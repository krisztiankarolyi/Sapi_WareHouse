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
using Sapi_WareHouse.models;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Sapi_WareHouse.NewForms;

namespace Sapi_WareHouse.ListaForms
{
    public partial class listDolgozok : Form
    {
        public static List<dolgozo> data = new List<dolgozo>();
        public listDolgozok()
        {
            InitializeComponent();
            if (Program.LoggedInUser.admin == "nem")
            {
                tilt.Enabled = false;
                edit.Enabled = false;

            }
            Frissit(dataGridView1);
        }

        private void listDolgozok_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
        }

        public static void Frissit(DataGridView d)
        {
            d.Rows.Clear();
            try
            {
                using (SQL sql = new SQL())
                {
                    data = sql.Dolgozok.ToList();

                    foreach (var munkas in data)
                    {
                        d.Rows.Add(munkas.fnev, munkas.teljes_nev, munkas.szuldat, munkas.admin, munkas.felfuggesztve );

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Frissit(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Title = "Mentés helye és file formátuma";
            d.FileName = "exported_" + DateTime.Now.Year + "_" + DateTime.Now.Month + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;
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
                    sw.WriteLine("fnev;teljesnev;szuldat;admin,letiltva");
                    foreach (var munkas in data)
                    {
                        sw.WriteLine(munkas.fnev + ";" + munkas.teljes_nev + ";" + munkas.szuldat + ";" + munkas.admin + ";" + munkas.felfuggesztve);
                    }
                }

                MessageBox.Show("A fájl sikeresen létrehozva");
            }
            else
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();
                var workSheet = excel.Workbook.Worksheets.Add("Dolgozok");

                workSheet.Cells[1, 1].Value = "Felhasználónév";
                workSheet.Cells[1, 2].Value = "Teljes név";
                workSheet.Cells[1, 3].Value = "Születési dátum";
                workSheet.Cells[1, 4].Value = "Admin jog"; ;
                workSheet.Cells[1, 5].Value = "Felfüggesztve";


                for (var i = 2; i < data.Count+2; i++)
                {
                    workSheet.Cells[i, 1].Value = data[i-2].fnev;
                    workSheet.Cells[i, 2].Value = data[i-2].teljes_nev;
                    workSheet.Cells[i, 3].Value = data[i-2].szuldat;
                    workSheet.Cells[i,3].Style.Numberformat.Format = "yyyy-mm-dd";
                    workSheet.Cells[i, 4].Value = data[i-2].admin;
                    workSheet.Cells[i, 5].Value = data[i-2].felfuggesztve;
                    workSheet.Cells["A1:E100"].AutoFitColumns();
                }
                if (File.Exists(file.FullName)) File.Delete(file.FullName);
                excel.SaveAs(file.FullName);
                MessageBox.Show("File kész");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter(dataGridView1, textBox1.Text);
        }

        public static void Filter(DataGridView d, string text)
        {
            d.Rows.Clear();
            foreach (var munkas in data)
            {
                if (munkas.fnev.Contains(text) || munkas.teljes_nev.Contains(text) || munkas.felfuggesztve == text || munkas.admin == text)
                {
                    d.Rows.Add(munkas.fnev, munkas.teljes_nev, munkas.szuldat, munkas.admin, munkas.felfuggesztve);

                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
               using (SQL sql = new SQL())
                {
                    ujDolgozo d = new ujDolgozo(true, sql.Dolgozok.Where(a => a.fnev == dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).FirstOrDefault());
                    d.Text = d.toedit.teljes_nev + " adatainak szerkesztése";
                    d.Show();
                    Frissit(dataGridView1);
                }

            }
            else MessageBox.Show("Pontosan 1 sort jelöljön ki!");
        }

        private void tilt_Click(object sender, EventArgs e)
        {
            ujDolgozo u = new ujDolgozo(false, null) ;
            u.ShowDialog();
            Frissit(dataGridView1);
        }

        private void listDolgozok_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
