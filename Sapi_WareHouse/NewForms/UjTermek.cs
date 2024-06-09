using System;
using System.Windows.Forms;
using System.Linq;
using Sapi_WareHouse.models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;

namespace Sapi_WareHouse.NewForms
{
    public partial class UjTermek : Form
    {
        public bool isedit { get; set; }
        public termek? toedit { get; set; }
        public int cikkszam { get; set; } public string mertekegyseg { get; set; } public int beszerzesiar { get; set; } public int mennyiseg { get; set; }
        public UjTermek(bool isedit, termek toedit)


        {
            InitializeComponent();
            if (isedit)
            {
                this.Text += "id: "+toedit.ID;
                br_ertek_box.Value = (int)toedit.brutto_ertek;
                cikkszambox.Text = toedit.cikkszam.ToString();
                afabox.Value = (int)toedit.afa_kulcs;
                netttoertekbox.Value = (int)toedit.netto_ertek;
                kategoriabox.Text = toedit.kategoria;
                mertekegysegbox.Text = toedit.mertekegyseg;
                megnevzesbox.Text = toedit.megnevezes;
                elozohavibox.Value = (int)toedit.elozo_ho_keszlet;
                jelenlegikeszletbox.Value = (int)toedit.jelenleg_keszlet;
                beszerzesibox.Value = toedit.br_beszerzesi_ertek;
                leltarivbox.Text = toedit.leltariv;
                comboBox1.SelectedItem = toedit.penznem;
                dateTimePicker1.Value = toedit.szavatossag;
               
            }
            else 
            {
                br_ertek_box.Value = 0;
                cikkszambox.Text = "";
                afabox.Value = 0;
                netttoertekbox.Value = 0;
                kategoriabox.Text = "";
                mertekegysegbox.Text = "";
                megnevzesbox.Text = "";
                elozohavibox.Value = 0;
                jelenlegikeszletbox.Value = 0;
                beszerzesibox.Value = 0;
                leltarivbox.Text = "";
                dateTimePicker1.Value = DateTime.Now;


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (!isedit)
            {
                if (cikkszambox.Text != string.Empty && megnevzesbox.Text != string.Empty)
                {
                    try
                    {
                        termek Termek = new termek();
                        Termek.afa_kulcs = (int)afabox.Value;
                        Termek.penznem = comboBox1.SelectedItem.ToString();
                        Termek.brutto_ertek = (int)br_ertek_box.Value;
                        Termek.br_beszerzesi_ertek = (int)beszerzesibox.Value;
                        Termek.cikkszam = int.Parse(cikkszambox.Text);
                        Termek.megnevezes = megnevzesbox.Text;
                        Termek.netto_ertek = (int)netttoertekbox.Value;
                        Termek.mertekegyseg = mertekegysegbox.Text;
                        Termek.jelenleg_keszlet = (int)jelenlegikeszletbox.Value;
                        Termek.elozo_ho_keszlet = (int)elozohavibox.Value;
                        Termek.leltariv = leltarivbox.Text;
                        Termek.kategoria = kategoriabox.Text;
                        Termek.szavatossag = dateTimePicker1.Value.Date;

                        using (SQL sql = new SQL())
                        {
                            if (sql.Termekek.Count(a => a.cikkszam == Termek.cikkszam) == 0)
                            {
                                sql.Termekek.Add(Termek);
                                sql.SaveChanges();
                                MessageBox.Show("Termék sikeresen felvéve");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Már van ilyen cikkszámú termék.", "Hiba");

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        this.Close();
                        // MessageBox.Show(ex.Message+"\n"+ex.InnerException,"Hiba történt");
                        throw;
                    }
                }
            }
            else //update
            {
                toedit.afa_kulcs = (int)afabox.Value;
                toedit.brutto_ertek = (int)br_ertek_box.Value;
                toedit.br_beszerzesi_ertek = (int)beszerzesibox.Value;
                toedit.cikkszam = int.Parse(cikkszambox.Text);
                toedit.megnevezes = megnevzesbox.Text;
                toedit.netto_ertek = (int)netttoertekbox.Value;
                toedit.mertekegyseg = mertekegysegbox.Text;
                toedit.jelenleg_keszlet = (int)jelenlegikeszletbox.Value;
                toedit.elozo_ho_keszlet = (int)elozohavibox.Value;
                toedit.leltariv = leltarivbox.Text;
                toedit.kategoria = kategoriabox.Text;
                toedit.szavatossag = dateTimePicker1.Value.Date;
                try
                {
                    using (SQL sql = new SQL())
                    {
                        if (sql.Termekek.Count(a => a.cikkszam == toedit.cikkszam) < 2)
                        {
                            sql.Termekek.Update(toedit);
                            sql.SaveChanges();
                            MessageBox.Show("Termék sikeresen módosítva!");
                            this.Close();

                        }
                        else 
                        {
                            MessageBox.Show("Van már ilyen cikkszám!");
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            isedit = false;
        }

        private void UjTermek_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(20);
            comboBox1.SelectedIndex = 0;
            if (beszerzesiar != 0) beszerzesibox.Value = beszerzesiar; if (cikkszam != 0) cikkszambox.Text = cikkszam.ToString();
            if (mertekegyseg != null) mertekegysegbox.Text = mertekegyseg; if (mennyiseg != 0) jelenlegikeszletbox.Value = mennyiseg;
        }

        private void netttoertekbox_ValueChanged(object sender, EventArgs e)
        {
            br_ertek_box.Value = netttoertekbox.Value + netttoertekbox.Value * afabox.Value/100;
        }

        private void br_ertek_box_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
