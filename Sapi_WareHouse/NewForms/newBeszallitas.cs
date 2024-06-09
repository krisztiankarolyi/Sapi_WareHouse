using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sapi_WareHouse.models;
using System.Windows.Forms;

namespace Sapi_WareHouse.NewForms
{
    public partial class newBeszallitas : Form
    {
        public newBeszallitas()
        {
            InitializeComponent();
        }

        private void newBeszallitas_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            fizetvebox.SelectedIndex = 0;
            checkBox1.Checked = true;
            mertbox.Text = "db";
            try
            {
                using (SQL sql = new SQL())
                {
                    atvevobox.DataSource = sql.Dolgozok.ToList();
                    atvevobox.DisplayMember = "teljes_nev";
                    atvevobox.ValueMember = "ID";
                    atvevobox.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cikkszambox.Text != "" && beszallitobox.Text != "" && mertbox.Text != "")
            {
                try
                {
                    using (SQL sql = new SQL())
                    {
                        beszallitas b = new beszallitas();
                        b.afa = (int)afabox.Value;
                        b.penznem = comboBox1.SelectedItem.ToString();
                        b.egysegar = (int)egysegarbox.Value;
                        b.atvevo = (int)atvevobox.SelectedValue;
                        b.SzallitoLevel = szlevelbox.Text;
                        b.mennyiseg = (int)mennyisegbox.Value;
                        b.mertekegyseg = mertbox.Text;
                        b.beszallito = beszallitobox.Text;
                        b.fizetve = (string)fizetvebox.SelectedItem;
                        b.cikkszam = int.Parse(cikkszambox.Text);
                        b.datum = dateTimePicker1.Value;
                        sql.Beszallitasok.Add(b);
                        if (sql.SaveChanges() == 1)
                        {
                            if (checkBox1.Checked == true)
                            {
                                int count = sql.Termekek.Count(a => a.cikkszam == b.cikkszam);
                                if (count > 0)
                                {
                                    termek t = sql.Termekek.Where(a => a.cikkszam == b.cikkszam).First();
                                    t.jelenleg_keszlet += b.mennyiseg;
                                    sql.SaveChanges();
                                }
                                else
                                {
                                    DialogResult d =  MessageBox.Show("A termék cikkszáma nem szerepel a nyilvántartásban. Ha szeretné rögzíteni, kérem töltse ki a termék további adatait.", "Új termék", MessageBoxButtons.YesNo);
                                    if (d == DialogResult.Yes)
                                    {
                                        UjTermek r = new UjTermek(false, null);
                                        r.cikkszam = b.cikkszam; r.mertekegyseg = b.mertekegyseg; r.beszerzesiar = b.egysegar;
                                        r.mennyiseg = b.mennyiseg;
                                        r.ShowDialog();                                      
                                    }
                                }
                                MessageBox.Show("A készletbe való beolvasztás sikeres volt");
                            }
                            MessageBox.Show("A beszállítás sikeresen felvéve");
                        }
                      

                    }
                }
                catch (FormatException ex )
                {
                    MessageBox.Show("A cikkszámnál csak számokat adjon meg!");
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Váratlan hiba történt! "+exp.Message,"Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
