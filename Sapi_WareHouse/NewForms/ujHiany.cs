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
    public partial class ujHiany : Form
    {
        public ujHiany()
        {
            
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    hiany h = new hiany();
                    int id = (int)comboBox1.SelectedValue;
                    h.datum = DateTime.Now;
                    h.cikkszam = sql.Termekek.Where(a => a.ID == id).Single().cikkszam;
                    h.dolgozo = Program.LoggedInUser.ID;
                    h.mennyiseg = (int)numericUpDown1.Value;
                    h.magyarazat = richTextBox1.Text;
                    h.termekID = id;
                    sql.Hianyok.Add(h);
                    if (sql.SaveChanges() == 1) MessageBox.Show("A hiány rögzítve lett");
                    else MessageBox.Show("Hiba történt a művelet során");
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void ujHiany_Load(object sender, EventArgs e)
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
        }
    }
}
