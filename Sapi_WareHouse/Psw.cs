using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapi_WareHouse
{
    public partial class Psw : Form
    {
        public Psw()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                textBox3.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
            }
            else
            {
                textBox3.BackColor = Color.White;
                textBox2.BackColor = Color.White;
             
        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.LoggedInUser.jelszo != Encrypt.EncryptString(textBox1.Text))
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("Hibás jelenlegi jelszó lett megadva!");
            }
            else
            {
                textBox1.BackColor = Color.White;
                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Nem egyezik az új jelszó és a megerősítés!");
                }
                else
                {
                    try
                    {
                        using (SQL sql = new SQL())
                        {
                            Program.LoggedInUser.jelszo = Encrypt.EncryptString(textBox2.Text);
                            sql.Dolgozok.Update(Program.LoggedInUser);
                            sql.SaveChanges();
                            MessageBox.Show("Jelszó sikeresen módosítva!");
                            this.Close();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nem sikerült a művelet, próbálja később!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Psw_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
