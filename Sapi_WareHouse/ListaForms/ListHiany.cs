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
    public partial class ListHiany : Form
    {
        public ListHiany()
        {
            InitializeComponent();
            Frissit(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frissit(dataGridView1);
        }
        public void Frissit(DataGridView d)
        {
            d.Rows.Clear();
            using (SQL sql = new SQL())
            {
                foreach (var item in sql.Hianyok.ToList())
                {
                    if (item.mennyiseg.ToString().Contains(textBox1.Text) || item.magyarazat.ToString().Contains(textBox1.Text) || item.dolgozo.ToString().Contains(textBox1.Text) || item.datum.ToString().Contains(textBox1.Text) || item.termekID.ToString().Contains(textBox1.Text) || item.cikkszam.ToString().Contains(textBox1.Text))
                    {
                        d.Rows.Add(item.ID, item.termekID, item.cikkszam, item.mennyiseg, item.magyarazat, sql.Dolgozok.Where(a=>a.ID== item.dolgozo).Single().fnev, item.datum) ;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewForms.ujHiany u = new NewForms.ujHiany(); u.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Frissit(dataGridView1);
        }

        private void ListHiany_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
