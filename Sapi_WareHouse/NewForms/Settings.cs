using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapi_WareHouse.NewForms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = true;

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (Program.popup == true) checkBox1.Checked = true;
            else checkBox1.Checked = false;
            if (Program.LoggedInUser != null) button2.Visible = true;
            else button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Biztosan menti a beállításokat?","Megerősítés",MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if (Encrypt.EncryptString(textBox6.Text) == "UQIjehy7GL5RI6rw1+SFSWUhkoUolfdbc3oAlNO9Ahs=")
                {
                    SQL.ConnString = "server=" + textBox1.Text + ";port=" + textBox5.Text + ";user=" + textBox2.Text + ";password=" + textBox3.Text + ";database=" + textBox4.Text;
                    File.WriteAllText("popupconfig.txt", checkBox1.Checked.ToString());
                    MessageBox.Show("Beállítások mentve");
                    this.Close();
                }
                else 
                {
                    File.WriteAllText("popupconfig.txt", checkBox1.Checked.ToString());
                    MessageBox.Show("Beállítások mentve. Az érvénybe lépéshez újraindul a program");
                    this.Close();
                }
                Application.Restart();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (Encrypt.EncryptString(textBox6.Text) == "UQIjehy7GL5RI6rw1+SFSWUhkoUolfdbc3oAlNO9Ahs=")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = false;

                string[] c = SQL.ConnString.Split(";");
                textBox1.Text = c[0].Split("=")[1];
                textBox5.Text = c[1].Split("=")[1];
                textBox3.Text = c[3].Split("=")[1];
                textBox2.Text = c[2].Split("=")[1];
                textBox4.Text = c[4].Split("=")[1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Psw csere = new Psw();
            csere.ShowDialog();
        }
    }
}
