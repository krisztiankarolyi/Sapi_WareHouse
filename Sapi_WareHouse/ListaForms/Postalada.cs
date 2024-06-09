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
using Sapi_WareHouse.NewForms;

namespace Sapi_WareHouse.ListaForms
{
    public partial class Postalada : Form
    {
        public static List<Sapi_WareHouse.models.Uzenet> uzenetek = new List<models.Uzenet>();
        public static List<Sapi_WareHouse.models.Uzenet> filtered = new List<models.Uzenet>();
        public Postalada()
        {
            InitializeComponent();
            if (Program.LoggedInUser.admin != "igen") button1.Enabled = false;
            Frissit(dataGridView1);
            comboBox1.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frissit(dataGridView1);
        }

        public static void Frissit(DataGridView d)
        {
            d.Rows.Clear();
            uzenetek = new List<models.Uzenet>();
            try
            {
                using (SQL sql = new SQL())
                {
                    foreach (var u in sql.Uzenetek.Where(a=>a.cimzett==Program.LoggedInUser.fnev || a.felado == Program.LoggedInUser.fnev).ToList())
                    {
                        d.Rows.Add(u.datum, u.felado, u.cimzett, u.targy, u.tartalom, u.id);
                        uzenetek.Add(u);

                    }
 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            filtered.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                foreach (var u in uzenetek)
                {
                    if (u.cimzett == Program.LoggedInUser.fnev)
                    {
                        dataGridView1.Rows.Add(u.datum, u.felado, u.cimzett, u.targy, u.tartalom[0..6] + "...", u.id);
                        filtered.Add(u);
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                foreach (var u in uzenetek)
                {
                    if (u.felado == Program.LoggedInUser.fnev)
                    {
                        dataGridView1.Rows.Add(u.datum, u.felado, u.cimzett, u.targy, u.tartalom[0..6] + "...", u.id);
                        filtered.Add(u);
                    }
                }
            }
            else
            {
                Frissit(dataGridView1);
                foreach (var i in uzenetek) 
                {
                    filtered.Add(i);
                }
            }  
                       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            {
                foreach (var u in filtered.ToList())
                {
                    if(u.targy.ToLower().Contains(textBox1.Text.ToLower()) || u.felado.ToLower().Contains(textBox1.Text.ToLower()) || u.cimzett.ToLower().Contains(textBox1.Text.ToLower()) || u.tartalom.ToLower().Contains(textBox1.Text.ToLower()))
                    dataGridView1.Rows.Add(u.datum, u.felado, u.cimzett, u.targy, u.tartalom, u.id);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.LoggedInUser.admin == "igen")
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DialogResult d = MessageBox.Show("Biztosan törölni szeretné az üzenetet?","Megerősítés", MessageBoxButtons.YesNo);
                        
                    if (d == DialogResult.Yes)
                    {
                        int id = (int)dataGridView1.SelectedRows[0].Cells[5].Value;
                        try
                        {
                            using (SQL sql = new SQL())
                            {
                                sql.Uzenetek.Remove(sql.Uzenetek.Where(a => a.id == id).SingleOrDefault());
                                if (sql.SaveChanges() == 1) MessageBox.Show("Üzenet sikeresen törölve");
                                else MessageBox.Show("Nem sikerült az üzenetet törölni!");
                                Frissit(dataGridView1);
                            }
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }                 
                }
            }
        }

        private void Postalada_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
        }

        private void Megnyitás_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[5].Value;
                    try
                    {
                        using (SQL sql = new SQL())
                        {
                            ujLevel u = new ujLevel(true, sql.Uzenetek.Where(a => a.id == id).Single());
                            u.Text = "Levél olvasása";
                            u.Show();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ujLevel l = new ujLevel(false, null);
           
            l.ShowDialog();  
        }

        private void Postalada_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
