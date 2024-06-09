using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapi_WareHouse.ListaForms
{
    public partial class ListSales : Form
    {
        public ListSales()
        {
            InitializeComponent();
            Refresh(dataGridView1, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewForms.newSale n = new NewForms.newSale();
            n.ShowDialog();
            Refresh(dataGridView1, "");
        }

        public static void Refresh(DataGridView d, string text)
        {
            d.Rows.Clear();
            try
            {
                using (SQL sql = new SQL())
                {
                    foreach (var i in sql.Eladasok)
                    {
                        if (i.megnevezes.ToLower().Contains(text.ToLower()) || i.szamlaszam.ToLower().Contains(text.ToLower()) || i.cikkszam.ToString().Contains(text) || i.datum.ToString().Contains(text) || i.mennyiseg.ToString().Contains(text))
                        {
                            d.Rows.Add(i.ID, i.cikkszam, i.megnevezes, i.mennyiseg, i.szamlaszam, i.datum);
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
            Refresh(dataGridView1, textBox1.Text);
        }
    }
}
