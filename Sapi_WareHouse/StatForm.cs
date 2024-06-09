using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sapi_WareHouse.NewForms;
using Sapi_WareHouse.ListaForms;
using System.IO;
using OfficeOpenXml;

namespace Sapi_WareHouse
{
    public partial class StatForm : Form
    {
        public static List<Sapi_WareHouse.models.termek> data;
        public static List<Sapi_WareHouse.models.Eladas> eladasok;
        public static DateTime datum = DateTime.Today;
        public static bool rand = false;
        public static bool randKeszlet = false; public static bool randAr = false;
        public StatForm()
        {
            InitializeComponent();
        }

        public static void Frissit()
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    data = sql.Termekek.ToList();
                    eladasok = sql.Eladasok.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void StatForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Frissit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            if (rand) datum = DateTime.Today.AddDays(r.Next(-365, 0));
            else datum = DateTime.Today;

            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Melyik excel fájlba írjam?";
            o.Filter = "Excel sheet (.xlsx)|*.xlsx";
            DialogResult d = o.ShowDialog();

            if (d == DialogResult.OK)
            {
                FileInfo file = new FileInfo(o.FileName);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:   
                        Kimutatas(file);
                        break;
                    case 1:
                        Termekenkent(file);
                        break;
                    case 2:
                        EladasKulon(file);
                        break;
                }
            }

        }
        public static void Kimutatas(FileInfo file )
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            using (FileStream stream = new FileStream(file.FullName, FileMode.Open))
            {
                excel.Load(stream); var workSheet = excel.Workbook.Worksheets[0];
                if (excel.Workbook.Worksheets.Count(a => a.Name == "Termekek") == 0) workSheet = excel.Workbook.Worksheets.Add("Termekek");
                else  workSheet = excel.Workbook.Worksheets.Where(a => a.Name == "Termekek").Single();
                workSheet.Cells[1, 1].Value = "Cikkszám";
                workSheet.Cells[1, 2].Value = "Megnevezés";
                workSheet.Cells[1, 3].Value = "Mennyiség";
                workSheet.Cells[1, 4].Value = "Mértékegység";
                workSheet.Cells[1, 5].Value = "Nettó Egységár";
                workSheet.Cells[1, 6].Value = "Dátum";
                workSheet.Cells[1, 7].Value = "ÁFA";
                int lastRow = 1;
                try
                {
                    lastRow = workSheet.Cells.Where(cell => !string.IsNullOrEmpty(cell.Value?.ToString() ?? string.Empty)).LastOrDefault().End.Row + 1;
                }
                catch (Exception)
                {

                    lastRow = 2;
                }

                Random r = new Random();
                for (var i = 0; i < data.Count; i++)
                {
                    workSheet.Cells[lastRow, 1].Value = data[i].cikkszam;
                    workSheet.Cells[lastRow, 2].Value = data[i].megnevezes;
                    if (randKeszlet) workSheet.Cells[lastRow, 3].Value = data[i].jelenleg_keszlet + r.Next(-1 * data[i].jelenleg_keszlet, data[i].jelenleg_keszlet);
                    else workSheet.Cells[lastRow, 3].Value = data[i].jelenleg_keszlet;
                    workSheet.Cells[lastRow, 4].Value = data[i].mertekegyseg;
                    if (randAr) workSheet.Cells[lastRow, 5].Value = data[i].netto_ertek + r.Next((int)(data[i].netto_ertek * -0.15), (int)(data[i].netto_ertek * 0.15));
                    else workSheet.Cells[lastRow, 5].Value = data[i].netto_ertek;
                    workSheet.Cells[lastRow, 6].Value = datum;  
                    workSheet.Cells[lastRow, 6].Style.Numberformat.Format = "yyyy-mm-dd";
                    workSheet.Cells[lastRow, 7].Value = data[i].afa_kulcs;
                    lastRow++;
                }
                workSheet.Cells["A1:E100"].AutoFitColumns();
                excel.Save();
            }
            Byte[] fajl = excel.GetAsByteArray();
            File.WriteAllBytes(file.FullName, fajl);
            MessageBox.Show("File kész");
        }

        public static void Termekenkent(FileInfo file)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            using (FileStream stream = new FileStream(file.FullName, FileMode.Open))
            {
                excel.Load(stream);
                Random r = new Random();
                foreach (var item in data)
                {
                    if (excel.Workbook.Worksheets.Count(a => a.Name == item.cikkszam.ToString()) == 0)
                    {
   
                        excel.Workbook.Worksheets.Add(item.cikkszam.ToString());
                        var workSheet = excel.Workbook.Worksheets.Where(a => a.Name == item.cikkszam.ToString()).Single();
                        workSheet.Cells[1, 1].Value = "Cikkszám";
                        workSheet.Cells[1, 2].Value = "Megnevezés";
                        workSheet.Cells[1, 3].Value = "Mennyiség";
                        workSheet.Cells[1, 4].Value = "Mértékegység";
                        workSheet.Cells[1, 5].Value = "Nettó Egységár";
                        workSheet.Cells[1, 6].Value = "Dátum";
                        workSheet.Cells[1, 7].Value = "ÁFA";

                        workSheet.Cells[2, 1].Value =  item.cikkszam;
                        workSheet.Cells[2, 2].Value = item.megnevezes;
                        if(randKeszlet)
                            workSheet.Cells[2, 3].Value = item.jelenleg_keszlet + r.Next(-1*item.jelenleg_keszlet, item.jelenleg_keszlet);
                        else
                        workSheet.Cells[2, 3].Value = item.jelenleg_keszlet;

                        workSheet.Cells[2, 4].Value = item.mertekegyseg;
                        if (randAr) workSheet.Cells[2, 5].Value = item.netto_ertek + r.Next((int)(item.netto_ertek * -0.15), (int)(item.netto_ertek * 0.15));
                        else  workSheet.Cells[2, 5].Value = item.netto_ertek;
                        workSheet.Cells[2, 6].Value = datum;
                        workSheet.Cells[2, 6].Style.Numberformat.Format = "yyyy-mm-dd";
                        workSheet.Cells[2, 7].Value = item.afa_kulcs;
                        workSheet.Cells["A1:E100"].AutoFitColumns();
                        excel.Save();
                    }
                    else 
                    {
                        var workSheet = excel.Workbook.Worksheets.Where(a => a.Name == item.cikkszam.ToString()).Single();
                        workSheet.Cells[1, 1].Value = "Cikkszám";
                        workSheet.Cells[1, 2].Value = "Megnevezés";
                        workSheet.Cells[1, 3].Value = "Mennyiség";
                        workSheet.Cells[1, 4].Value = "Mértékegység";
                        workSheet.Cells[1, 5].Value = "Nettó Egységár ";
                        workSheet.Cells[1, 6].Value = "Dátum";
                        workSheet.Cells[1, 7].Value = "ÁFA";

                        int lastRow = workSheet.Cells.Where(cell => !string.IsNullOrEmpty(cell.Value?.ToString() ?? string.Empty)).LastOrDefault().End.Row + 1;
                      
                        workSheet.Cells[lastRow, 1].Value = item.cikkszam;
                        workSheet.Cells[lastRow, 2].Value = item.megnevezes;
                        if (randKeszlet)
                            workSheet.Cells[lastRow, 3].Value = item.jelenleg_keszlet + r.Next(-1 * item.jelenleg_keszlet, item.jelenleg_keszlet);
                        else
                            workSheet.Cells[lastRow, 3].Value = item.jelenleg_keszlet;
                        workSheet.Cells[lastRow, 4].Value = item.mertekegyseg;
                        if (randAr) workSheet.Cells[lastRow, 5].Value = item.netto_ertek + r.Next((int)(item.netto_ertek * -0.15), (int)(item.netto_ertek * 0.15));
                        else workSheet.Cells[lastRow, 5].Value = item.netto_ertek;
                        workSheet.Cells[lastRow, 6].Value = datum;
                        workSheet.Cells[lastRow, 6].Style.Numberformat.Format = "yyyy-mm-dd";
                        workSheet.Cells[lastRow, 7].Value = item.afa_kulcs;
                        workSheet.Cells["A1:E100"].AutoFitColumns();
                        excel.Save();
                    }
                }
            }
            Byte[] fajl = excel.GetAsByteArray();
            File.WriteAllBytes(file.FullName, fajl);
            MessageBox.Show("File kész");

        }

        public static void EladasKulon(FileInfo file)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            using (FileStream stream = new FileStream(file.FullName, FileMode.Open))
            {
                excel.Load(stream);
                Random r = new Random();
                foreach (var item in eladasok)
                {
                    if (excel.Workbook.Worksheets.Count(a => a.Name == item.cikkszam.ToString() + "_eladas") == 0)
                    {

                        excel.Workbook.Worksheets.Add(item.cikkszam.ToString()+"_eladas");
                        var workSheet = excel.Workbook.Worksheets.Where(a => a.Name == item.cikkszam.ToString() + "_eladas").Single();
                        workSheet.Cells[1, 1].Value = "Cikkszám";
                        workSheet.Cells[1, 2].Value = "Megnevezés";
                        workSheet.Cells[1, 3].Value = "Mennyiség";
                        workSheet.Cells[1, 4].Value = "Bizonylat szama";
                        workSheet.Cells[1, 5].Value = "Érték";
                        workSheet.Cells[1, 6].Value = "Dátum";
                        workSheet.Cells[1, 7].Value = "Bruttó Egységár";


                        workSheet.Cells[2, 1].Value = item.cikkszam;
                        workSheet.Cells[2, 2].Value = item.megnevezes;
                        workSheet.Cells[2, 3].Value = item.mennyiseg;
                        workSheet.Cells[2, 4].Value = item.szamlaszam;
                        workSheet.Cells[2, 5].Value = item.ertek;
                        workSheet.Cells[2, 6].Value = item.datum;
                        workSheet.Cells[2, 6].Style.Numberformat.Format = "yyyy-mm-dd";
                        if (item.mennyiseg == 0) item.mennyiseg = 1;
                        workSheet.Cells[2, 7].Value = (int)(item.ertek / item.mennyiseg);
                        workSheet.Cells["A1:E100"].AutoFitColumns();
                        excel.Save();
                    }
                    else
                    {
                        var workSheet = excel.Workbook.Worksheets.Where(a => a.Name == item.cikkszam.ToString() + "_eladas").Single();
                        workSheet.Cells[1, 1].Value = "Cikkszám";
                        workSheet.Cells[1, 2].Value = "Megnevezés";
                        workSheet.Cells[1, 3].Value = "Mennyiség";
                        workSheet.Cells[1, 4].Value = "Bizonylat szama";
                        workSheet.Cells[1, 5].Value = "Érték";
                        workSheet.Cells[1, 6].Value = "Dátum";
                        workSheet.Cells[1, 6].Style.Numberformat.Format = "yyyy-mm-dd";
                        workSheet.Cells[1, 7].Value = "Bruttó Egységár";

                        int lastRow = workSheet.Cells.Where(cell => !string.IsNullOrEmpty(cell.Value?.ToString() ?? string.Empty)).LastOrDefault().End.Row + 1;

                        workSheet.Cells[lastRow, 1].Value = item.cikkszam;
                        workSheet.Cells[lastRow, 2].Value = item.megnevezes;
                        workSheet.Cells[lastRow, 3].Value = item.mennyiseg;
                        workSheet.Cells[lastRow, 4].Value = item.szamlaszam;
                        workSheet.Cells[lastRow, 5].Value = item.ertek;
                        workSheet.Cells[lastRow, 6].Value = item.datum;
                        workSheet.Cells[lastRow, 6].Style.Numberformat.Format = "yyyy-mm-dd";
                        if (item.mennyiseg == 0) item.mennyiseg = 1;
                        workSheet.Cells[lastRow, 7].Value = (int)(item.ertek / item.mennyiseg);
                        workSheet.Cells["A1:E100"].AutoFitColumns();
                        excel.Save();
                    }
                }
            }
            Byte[] fajl = excel.GetAsByteArray();
            File.WriteAllBytes(file.FullName, fajl);
            MessageBox.Show("A File kész");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) rand = true;
            else rand = false;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) randKeszlet = true;
            else rand = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) randAr = true;
            else rand = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                data.RemoveAll((a => a.szavatossag < DateTime.Now.Date));
            }
            else
            {
                Frissit();
            }
        }
    }

}
