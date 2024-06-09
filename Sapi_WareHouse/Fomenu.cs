using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sapi_WareHouse.ListaForms;
using Sapi_WareHouse.NewForms;

namespace Sapi_WareHouse
{
    public partial class Fomenu : Form
    {
        public Fomenu()
        {
            InitializeComponent();
        }

        private void termékFelvételeAKészletbeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void készletcsökkenésekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListHiany l = new ListHiany(); l.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoggedInUser = null;
            Program.Belepett = false;
            Program.l.Close();
        }

        private void termékFelvételeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForms.UjTermek u = new NewForms.UjTermek(false, null);
            u.ShowDialog();
        }

        private void termékekKészletekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listTermek l = new listTermek();
            l.Show();
        }

        private void dolgozóRegisztrálásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.LoggedInUser.admin == "igen")
            {
                ujDolgozo u = new ujDolgozo(false, null);
                u.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs jogosultsága ehhez!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dolgozókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listDolgozok l = new listDolgozok();
            l.Show();
        }

        private void készletcsökkenésNaplózásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ujHiany d = new ujHiany(); d.ShowDialog();
        }

        private void postaládaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void postaládaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Postalada p = new Postalada(); p.Show();
        }

        private void levélÍrásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ujLevel u = new ujLevel(false, null);
            u.ShowDialog();
        }

        private void Fomenu_Load(object sender, EventArgs e)
        {
            label1.Text = "Üdvözöljük, " + Program.LoggedInUser.teljes_nev+"!";
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Postalada l = new Postalada(); l.Show();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.White);
            label2.Visible = true;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = true;
            button1.BackColor = Color.Transparent;
            label2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listTermek u = new listTermek();
            u.ShowDialog();
        }

        private void beszállításokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListHiany l = new ListHiany(); l.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listDolgozok l = new listDolgozok();
            l.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Biztosan ki szeretne jelentkezni?", "Megerősítés", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes) Application.Restart();

        }

        private void button2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            
        }

        private void button3_Enter(object sender, EventArgs e)
        {
           
        }

        private void button3_Leave(object sender, EventArgs e)
        {
           
        }

        private void button4_Enter(object sender, EventArgs e)
        {
           
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
     
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListBeszallitasok j = new ListBeszallitasok();
            j.Show();
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            label7.Visible = true;
 
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.Show();
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Sapi_WareHouse.StatForm s = new StatForm(); s.Show();
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Figyelmeztetesek f = new Figyelmeztetesek(); f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ListSales s = new ListSales();
            s.ShowDialog();
        }
    }
}