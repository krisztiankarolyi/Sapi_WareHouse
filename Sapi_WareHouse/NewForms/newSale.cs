using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapi_WareHouse.NewForms
{

    public partial class newSale : Form
    {
        public static Sapi_WareHouse.models.termek termek;
    public static bool kivon = false;
        public newSale()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newSale_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    comboBox1.DataSource = sql.Termekek.ToList();
                    comboBox1.DisplayMember = "cikkszam";
                    comboBox1.ValueMember = "ID";
                }
            }
            catch (Exception)
            {

                throw;
            }

            dateTimePicker1.MaxDate = DateTime.Now.AddDays(30);
            dateTimePicker1.MinDate = DateTime.Now.AddDays(-30);


            try
            {
                using (SQL sql = new SQL())
                {
                    comboBox1.DataSource = sql.Termekek.ToList();
                    comboBox1.DisplayMember = "cikkszam";
                    comboBox1.ValueMember = "ID";
                    comboBox1.SelectedIndex = 0;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) kivon = true;
            else kivon = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (SQL sql = new SQL())
                {
                    Sapi_WareHouse.models.Eladas el = new models.Eladas();
                    el.cikkszam = termek.cikkszam;
                    el.mennyiseg = (int) numericUpDown1.Value;
                    el.megnevezes = textBox2.Text;
                    el.szamlaszam = textBox1.Text;
                    el.datum = dateTimePicker1.Value;
                    el.ertek = (int)numericUpDown2.Value;
                    sql.Eladasok.Add(el);
                    if (kivon) sql.Termekek.Where(a => a.cikkszam == el.cikkszam).Single().jelenleg_keszlet -= el.mennyiseg;
                    sql.SaveChanges();
                    MessageBox.Show("Művelet sikeresen elvégezve!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Nem sikerült végrehajtani a műveletet!");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = termek.brutto_ertek * (int)numericUpDown1.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SQL sql = new SQL())
            {
                termek = (models.termek)comboBox1.SelectedItem;
                textBox2.Text = termek.megnevezes;
               
             //  termek = sql.Termekek.Where(a => a.ID == id).Single();
            }
              numericUpDown1.Maximum = termek.jelenleg_keszlet; 
        }
    }
}
