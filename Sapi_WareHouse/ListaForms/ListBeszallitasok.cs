using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Sapi_WareHouse.models;

namespace Sapi_WareHouse.ListaForms
{
    public partial class ListBeszallitasok : Form
    {
        public static List<beszallitas> beszallitasok;
        public ListBeszallitasok()
        {
            InitializeComponent();
            Frissit(dataGridView1, textBox1.Text);
        }

        private void ListBeszallitasok_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frissit(dataGridView1, textBox1.Text);
        }

        public static void Frissit(DataGridView d, string text)
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    d.Rows.Clear();
                    beszallitasok = sql.Beszallitasok.ToList();
                    foreach (var item in beszallitasok)
                    {
                       
                        if(item.atvevo.ToString().Contains(text) || item.ID.ToString().Contains(text) || item.cikkszam.ToString().Contains(text)|| item.beszallito.ToString().Contains(text) || item.datum.ToString().Contains(text) || item.fizetve.ToString().Contains(text) || item.SzallitoLevel.ToString().Contains(text))
                        {
                            d.Rows.Add(item.ID, item.SzallitoLevel, beszallitas.GetDolgozo(item.atvevo).teljes_nev, item.cikkszam, item.mennyiseg, item.datum, item.fizetve, item.egysegar, item.penznem, item.afa, item.beszallito);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Frissit(dataGridView1, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewForms.newBeszallitas n = new NewForms.newBeszallitas();
            n.ShowDialog();
            Frissit(dataGridView1, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DialogResult d = MessageBox.Show("Biztosan szeretné átállítani a beszállítás állapotát?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        using (SQL sql = new SQL())
                        {
                            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                            beszallitas b = sql.Beszallitasok.Where(a => a.ID == id).Single();
                            b.fizetve = "igen";
                            sql.SaveChanges();
                            MessageBox.Show("Beszállítás megjelölve fizetettként!");
                            Frissit(dataGridView1, textBox1.Text);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("hiba történt");
                        throw;
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Title = "Mentés helye és file formátuma";
            d.FileName = "exported" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_"+DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;
            d.Filter = "Excel sheet (.xlsx)|*.xlsx|CSV file (.csv)|*.csv";
            DialogResult j = d.ShowDialog();
            if (j == DialogResult.OK)
            {
                FileInfo file = new FileInfo(d.FileName);
                WriteData(file);
            }
        }
        private void WriteData(FileInfo file)
        {
            if (file.Extension == ".csv")
            {
                using (StreamWriter sw = new StreamWriter(file.FullName))
                {
                    sw.WriteLine("ID;Szállítólevél;Átvevő;Cikkszám;Mennyiség;Mértékegység;Dátum;Kifizetve;Egységár;Pénznem;ÁFA;Beszállító");
                    foreach (beszallitas b in beszallitasok)
                    {
                        sw.WriteLine(b.ID + ";" + b.SzallitoLevel + ";" + b.atvevo + ";" + b.cikkszam + ";" + b.mennyiseg + ";"  +
                            b.mertekegyseg + ";" + b.datum + ";" + b.fizetve + ";" + b.penznem + ";" + b.afa + ";" + b.beszallito);
                    }
                }

                MessageBox.Show("A fájl sikeresen létrehozva");
            }
            else
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();
                var workSheet = excel.Workbook.Worksheets.Add("Beszállítások");

                workSheet.Cells[1, 1].Value = "ID";
                workSheet.Cells[1, 2].Value = "Szállítólevél";
                workSheet.Cells[1, 3].Value = "Átvevő";
                workSheet.Cells[1, 4].Value = "Cikkszám"; ;
                workSheet.Cells[1, 5].Value = "Mennyiség";
                workSheet.Cells[1, 6].Value = "Mértékegység";
                workSheet.Cells[1, 7].Value = "Dátum";
                workSheet.Cells[1, 8].Value = "Fizetve";
                workSheet.Cells[1, 9].Value = "Pénznem";
                workSheet.Cells[1, 10].Value = "ÁFA";
                workSheet.Cells[1, 11].Value = "Beszállító";

                for (var i = 2; i < beszallitasok.Count + 2; i++)
                {
                    workSheet.Cells[i, 1].Value = beszallitasok[i - 2].ID;
                    workSheet.Cells[i, 2].Value = beszallitasok[i - 2].SzallitoLevel;
                    workSheet.Cells[i, 3].Value = beszallitasok[i - 2].atvevo;
                    workSheet.Cells[i, 4].Value = beszallitasok[i - 2].cikkszam;
                    workSheet.Cells[i, 5].Value = beszallitasok[i - 2].mennyiseg;
                    workSheet.Cells[i, 6].Value = beszallitasok[i - 2].mertekegyseg;
                    workSheet.Cells[i, 7].Value = beszallitasok[i - 2].datum;
                    workSheet.Cells[i, 8].Value = beszallitasok[i - 2].fizetve;
                    workSheet.Cells[i, 9].Value = beszallitasok[i - 2].penznem;
                    workSheet.Cells[i, 10].Value = beszallitasok[i - 2].afa;
                    workSheet.Cells[i, 11].Value = beszallitasok[i - 2].beszallito;

                    workSheet.Cells["A1:E100"].AutoFitColumns();
                }
                if (File.Exists(file.FullName)) File.Delete(file.FullName);
                excel.SaveAs(file.FullName);
                MessageBox.Show("File kész");
            }
        }

        private void ListBeszallitasok_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
