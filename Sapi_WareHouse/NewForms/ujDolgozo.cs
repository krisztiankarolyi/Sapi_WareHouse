using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sapi_WareHouse.models;

namespace Sapi_WareHouse.NewForms
{
    public partial class ujDolgozo : Form
    {
      public bool isedit { get; set; }
      public dolgozo? toedit { get; set; }
        public ujDolgozo(bool isedit, dolgozo toedit)
        {
            this.toedit = toedit; this.isedit = isedit;
         
        InitializeComponent();
            if (isedit)
            {
                tiltva.SelectedItem = toedit.felfuggesztve;
                admin.SelectedItem = toedit.admin;
                fnevbox.Text = toedit.fnev;
                fullnamebox.Text = toedit.teljes_nev;
                dateTimePicker1.Value = toedit.szuldat;
                tiltva.Enabled = true;
                pswbox.Text = Encrypt.DecryptString(toedit.jelszo);
                
            }
            else 
            {
                tiltva.SelectedIndex = 0;
                tiltva.Enabled = false;
                admin.SelectedIndex = 0;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isedit)
            {
                admin.SelectedIndex = 1;
                if (fnevbox.Text != "" && fullnamebox.Text != "" && pswbox.Text != "")
                {
                    try
                    {
                        using (SQL sql = new SQL())
                        {
                            if (Program.LoggedInUser.admin == "igen")
                            {
                                if (sql.Dolgozok.Count(a => a.fnev == fnevbox.Text) == 0)
                                {
                                    dolgozo d = new dolgozo();
                                    d.fnev = fnevbox.Text;
                                    d.teljes_nev = fullnamebox.Text;
                                    d.jelszo = Encrypt.EncryptString(pswbox.Text);
                                    d.admin = admin.SelectedItem.ToString();
                                    d.felfuggesztve = "nem";
                                    d.szuldat = dateTimePicker1.Value;
                                    sql.Dolgozok.Add(d);
                                    if (sql.SaveChanges() == 1) MessageBox.Show("Felhasználó sikeresen létrehozva!");
                                    else MessageBox.Show("Sikertelen művelet!");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Már létezik ilyen felhasználónév!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Csak admin joggal lehet végrehajtani a műveletet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (fnevbox.Text != "" && fullnamebox.Text != "" && pswbox.Text != "")
                {
                    try
                    {
                        using (SQL sql = new SQL())
                        {
                            if (Program.LoggedInUser.admin == "igen")
                            {
                                if (sql.Dolgozok.Count(a => a.fnev == fnevbox.Text) < 2)
                                {
                                    toedit.fnev = fnevbox.Text;
                                    toedit.teljes_nev = fullnamebox.Text;
                                    toedit.jelszo = Encrypt.EncryptString(pswbox.Text);
                                    toedit.admin = admin.SelectedItem.ToString();
                                    toedit.felfuggesztve = tiltva.SelectedItem.ToString();
                                    toedit.szuldat = dateTimePicker1.Value;
                                    sql.Dolgozok.Update(toedit);
                                    if (sql.SaveChanges() == 1) MessageBox.Show("Felhasználó adatai sikeresen módosítva!");
                                    else MessageBox.Show("Sikertelen művelet!");
                                    this.Close();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Már létezik ilyen felhasználónév!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Csak admin joggal lehet végrehajtani a műveletet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ujDolgozo_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
