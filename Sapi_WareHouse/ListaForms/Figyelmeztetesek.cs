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
    public partial class Figyelmeztetesek : Form
    {
        public Figyelmeztetesek()
        {
            InitializeComponent();
        }

        private void Figyelmeztetesek_Load(object sender, EventArgs e)
        {
            Frissit(dataGridView1);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = SystemColors.ControlDarkDark;
        }
        

        public static void Frissit(DataGridView d)
        {
            d.Rows.Clear();
            try
            {
                using (SQL sql = new SQL())
                {
                    foreach (var item in sql.Figyelmeztetesek)
                    {
                        d.Rows.Add(item.ID, item.cikkszam, item.megjegyzes, item.datum);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Biztosan szeretné törölni a figylmeztetéseket?", "Megerősítés", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                try
                {
                    using (SQL sql = new SQL())
                    {
                        sql.Figyelmeztetesek.RemoveRange(sql.Figyelmeztetesek.ToList());
                        sql.SaveChanges();
                        MessageBox.Show("A lista sikeresen ürítve.");
                        Frissit(dataGridView1);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Valami hiba történt a művelet elvégzése során!");
                }
            }
        }
    }
}
