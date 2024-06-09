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
using Sapi_WareHouse.models;
using System.IO;
using OfficeOpenXml;

namespace Sapi_WareHouse.ListaForms
{
    public partial class listTermek : Form
    {
        public static List<termek> data = new List<termek>();
        public static bool all = false;
        public listTermek()
        {
            InitializeComponent();
            Frissit(dataGridView1);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Frissit(dataGridView1);
        }

        public static void Frissit(DataGridView d)
        {
            d.Rows.Clear();
            d.DefaultCellStyle.ForeColor = Color.Black;
            d.DefaultCellStyle.BackColor = Color.White;
            try
            {
                using (SQL sql = new SQL())
                {
                    data = sql.Termekek.ToList();

                    foreach (var termek in data)
                    {
                        d.Rows.Add(
                          termek.ID, termek.cikkszam, termek.megnevezes, termek.kategoria, termek.jelenleg_keszlet, termek.elozo_ho_keszlet, termek.mertekegyseg, termek.leltariv, termek.penznem, termek.netto_ertek, termek.brutto_ertek, termek.br_beszerzesi_ertek, termek.afa_kulcs, termek.szavatossag
                         );
                        if (d.Rows.Count > 0)
                        {
                            if (termek.jelenleg_keszlet <= 0)
                            {
                                for (int i = 0; i < d.Rows[d.Rows.Count - 1].Cells.Count; i++)
                                {
                                    d.Rows[d.Rows.Count - 1].Cells[i].Style.BackColor = Color.Red;
                                    d.Rows[d.Rows.Count - 1].Cells[i].Style.ForeColor = Color.White;
                                }

                                if (Program.popup) MessageBox.Show("A(z) " + termek.megnevezes + " teljesen elfogyott!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                figyelmeztetes f = new figyelmeztetes();
                                f.cikkszam = termek.cikkszam; f.megjegyzes = "A(z) " + termek.megnevezes + " teljesen elfogyott!"; f.datum = DateTime.Now;
                                sql.Figyelmeztetesek.Add(f); sql.SaveChanges();
                            }
                            else if (termek.szavatossag.AddDays(-7) <= DateTime.Today && termek.szavatossag > DateTime.Today)
                            {
                                for (int i = 0; i < d.Rows[d.Rows.Count - 1].Cells.Count; i++)
                                {
                                    d.Rows[d.Rows.Count - 1].Cells[i].Style.BackColor = Color.Yellow;
                                    d.Rows[d.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Black;
                                }
                                if (Program.popup) MessageBox.Show("A(z) " + termek.megnevezes + " Hamarosan lejár!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                figyelmeztetes f = new figyelmeztetes();
                                f.cikkszam = termek.cikkszam; f.megjegyzes = "A(z) " + termek.megnevezes + " Hamarosan lejár!"; f.datum = DateTime.Now;
                                sql.Figyelmeztetesek.Add(f); sql.SaveChanges();
                            }
                            else if (termek.szavatossag <= DateTime.Today)
                            {
                                for (int i = 0; i < d.Rows[d.Rows.Count - 1].Cells.Count; i++)
                                {
                                    d.Rows[d.Rows.Count - 1].Cells[i].Style.BackColor = Color.Orange;
                                    d.Rows[d.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Black;
                                }
                                if (Program.popup) MessageBox.Show("A(z) " + termek.megnevezes + "  LEJÁRT!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                figyelmeztetes f = new figyelmeztetes();
                                f.cikkszam = termek.cikkszam; f.megjegyzes = "A(z) " + termek.megnevezes + " LEJÁRT!"; f.datum = DateTime.Now;
                                sql.Figyelmeztetesek.Add(f); sql.SaveChanges();
                            }

                            else
                            {
                                for (int i = 0; i < d.Rows[d.Rows.Count - 1].Cells.Count; i++)
                                {
                                    d.Rows[d.Rows.Count - 1].Cells[i].Style.BackColor = Color.White;
                                    d.Rows[d.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Black;

                                }
                            }

                        }

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void szurobox_TextChanged(object sender, EventArgs e)
        {

            Filter(dataGridView1, szurobox.Text);
        }

        public static void Filter(DataGridView d, string text)
        {

            d.Rows.Clear();
            foreach (var termek in data)
            {
                if (termek.cikkszam.ToString().Contains(text) || termek.szavatossag.ToString().Contains(text) || termek.megnevezes.ToString().Contains(text) || termek.kategoria.ToString().Contains(text))
                {
                    d.Rows.Add(
                 termek.ID, termek.cikkszam, termek.megnevezes, termek.kategoria, termek.jelenleg_keszlet,
                 termek.elozo_ho_keszlet, termek.mertekegyseg, termek.leltariv, termek.penznem, termek.netto_ertek,
                 termek.brutto_ertek, termek.br_beszerzesi_ertek, termek.afa_kulcs, termek.szavatossag);

                    if (d.Rows.Count > 0)
                    {
                        if (termek.jelenleg_keszlet <= 0)
                        {
                            for (int i = 0; i < d.Rows[d.Rows.Count - 1].Cells.Count; i++)
                            {
                                d.Rows[d.Rows.Count - 1].Cells[i].Style.BackColor = Color.Red;
                                d.Rows[d.Rows.Count - 1].Cells[i].Style.ForeColor = Color.White;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < d.Rows[d.Rows.Count - 1].Cells.Count; i++)
                            {
                                d.Rows[d.Rows.Count - 1].Cells[i].Style.BackColor = Color.White;
                                d.Rows[d.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Black;

                            }
                        }

                    }

                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                try
                {
                    using (SQL sql = new SQL())
                    {
                        UjTermek u = new UjTermek(true, sql.Termekek.Where(a => a.ID == id).Single());
                        u.Text = "Termék szerkesztése";
                        u.isedit = true;
                        u.toedit = sql.Termekek.Where(a => a.ID == id).Single();
                        u.ShowDialog();
                        Frissit(dataGridView1);
                    }
                }
                catch (Exception ex)
                {

                }

            }
            else MessageBox.Show("Kérem, jelöljön ki pontosan 1db sort (rekordot)!");
        }

        private void listTermek_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            if (Program.LoggedInUser.admin != "igen") checkBox1.Enabled = false;
            else checkBox1.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delbtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                try
                {
                    using (SQL sql = new SQL())
                    {
                        DialogResult d = MessageBox.Show("Biztosan törli?", "Törlés megerősítése", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            termek todelete = sql.Termekek.Where(a => a.ID == id).Single();
                            sql.Termekek.Remove(todelete);
                            sql.SaveChanges();
                            MessageBox.Show("Termék törölve!");
                            Frissit(dataGridView1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if(all)
            {
                using (SQL sql = new SQL())
                {
                    DialogResult d = MessageBox.Show("Biztosan törli az összeset?", "Törlés megerősítése", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        sql.Termekek.RemoveRange(sql.Termekek);
                        sql.SaveChanges();
                        MessageBox.Show("Termékek törölve!");
                        Frissit(dataGridView1);
                    }
                }
            }
            else MessageBox.Show("Kérem, jelöljön ki pontosan 1db sort (rekordot)!");
        }
        private void exp_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog();
            d.Title = "Mentés helye és file formátuma";
            d.FileName = "exported" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;
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
                    sw.WriteLine("cikkszám;megnevezés;kategória;jelenlegi készlet;elöző havi készlet;mértékegység;" +
                        "leltárív száma;pénznem;nettó érték;bruttó érték;beszerzési érték;ÁFA kulcs;Szavatosság");
                    foreach (termek termek in data)
                    {
                        sw.WriteLine(termek.cikkszam + ";" + termek.megnevezes + ";" + termek.kategoria + ";" + termek.jelenleg_keszlet + ";" + termek.elozo_ho_keszlet + ";" + termek.mertekegyseg + ";" + termek.leltariv + ";" + termek.penznem + ";" + termek.netto_ertek + ";" + termek.brutto_ertek + ";" + termek.br_beszerzesi_ertek + ";" + termek.afa_kulcs + ";" + termek.szavatossag);
                    }
                }

                MessageBox.Show("A fájl sikeresen létrehozva");
            }
            else
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                ExcelPackage excel = new ExcelPackage();
                var workSheet = excel.Workbook.Worksheets.Add("Termékek");

                workSheet.Cells[1, 1].Value = "Cikkszám";
                workSheet.Cells[1, 2].Value = "Megnevezés";
                workSheet.Cells[1, 3].Value = "Kategória";
                workSheet.Cells[1, 4].Value = "Jelenlegi Készlet"; ;
                workSheet.Cells[1, 5].Value = "Előző havi készlet";
                workSheet.Cells[1, 6].Value = "Mértékegység";
                workSheet.Cells[1, 7].Value = "Leltárív száma";
                workSheet.Cells[1, 8].Value = "Pénznem";
                workSheet.Cells[1, 9].Value = "Nettó érték";
                workSheet.Cells[1, 10].Value = "Bruttó érték";
                workSheet.Cells[1, 11].Value = "Beszerzési érték";
                workSheet.Cells[1, 12].Value = "ÁFA kulcs";
                workSheet.Cells[1, 13].Value = "Szavatosság";

                for (var i = 2; i < data.Count + 2; i++)
                {
                    workSheet.Cells[i, 1].Value = data[i - 2].cikkszam;
                    workSheet.Cells[i, 2].Value = data[i - 2].megnevezes;
                    workSheet.Cells[i, 3].Value = data[i - 2].kategoria;
                    workSheet.Cells[i, 4].Value = data[i - 2].jelenleg_keszlet;
                    workSheet.Cells[i, 5].Value = data[i - 2].elozo_ho_keszlet;
                    workSheet.Cells[i, 6].Value = data[i - 2].mertekegyseg;
                    workSheet.Cells[i, 7].Value = data[i - 2].leltariv;
                    workSheet.Cells[i, 8].Value = data[i - 2].penznem;
                    workSheet.Cells[i, 9].Value = data[i - 2].netto_ertek;
                    workSheet.Cells[i, 10].Value = data[i - 2].brutto_ertek;
                    workSheet.Cells[i, 11].Value = data[i - 2].br_beszerzesi_ertek;
                    workSheet.Cells[i, 12].Value = data[i - 2].afa_kulcs;
                    workSheet.Cells[i, 13].Value = data[i - 2].szavatossag;
                }
                workSheet.Cells["A1:E100"].AutoFitColumns();
                if (File.Exists(file.FullName)) File.Delete(file.FullName);
                excel.SaveAs(file.FullName);
                MessageBox.Show("File kész");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UjTermek u = new UjTermek(false, null);
            u.isedit = false;
            u.ShowDialog();
        }

        private void listTermek_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int db = (int)numericUpDown1.Value;
            string[] megnevezesek = { "Vodka", "Sör", "Pálinka",  "Bor", "Banán", "Alma", "Kifli", "Barack", "Yoghurt", "Tej", "Kefír"
            , "Csoki",  "Szalonna","Babkonzerv", "Szalámi", "Kenyér", "Uborka", "Majonéz", "Ketchup", "Szatyor"};
            using (SQL sql = new SQL())
            {
                for (int i = 0; i < db; i++)
                {
                    termek t = new termek();
                    t.megnevezes = megnevezesek[r.Next(0, megnevezesek.Length - 1)];
                    t.kategoria = "random adat";
                    t.jelenleg_keszlet = r.Next(0, 200);
                    t.leltariv = "-";
                    t.penznem = "HUF";
                    t.mertekegyseg = "db";
                    t.netto_ertek = r.Next(30, 3000);
                    t.szavatossag = DateTime.Today.AddDays(r.Next(1, 730));
                    t.afa_kulcs = 27;
                    t.brutto_ertek = t.netto_ertek +(int)( t.netto_ertek * 0.27);
                    t.elozo_ho_keszlet = 0;
                    t.br_beszerzesi_ertek = 0;
                    t.cikkszam = r.Next(100000, 999999);
                    if (sql.Termekek.Count(a => a.cikkszam == t.cikkszam) == 0)
                    {
                        sql.Termekek.Add(t);
                        sql.SaveChanges();
                    }
                    else i--;
                }
                MessageBox.Show("Random termékek létrehozva!");
                Frissit(dataGridView1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) all = true;
            else all = false;
        }
    }
}
