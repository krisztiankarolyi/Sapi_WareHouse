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

namespace Sapi_WareHouse
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pw = Encrypt.EncryptString("server=localhost;port=3306;user=root;password=;database=warehouse");
            Clipboard.SetText(pw);
           string fnev = textBox1.Text;
           string psw = textBox2.Text;
           psw = Encrypt.EncryptString(psw);
            if (Auth(fnev, psw))
            {
                this.Close();
                Program.Belepett = true;
                
            }
            else MessageBox.Show("Hibás felhasználónév vagy jelszó");

        }

        public static bool Auth(string fnev, string psw)
        {
            try
            {
                using (SQL sql = new SQL())
                {
                    var u = sql.Dolgozok.First();
                    if (sql.Dolgozok.Any(u => u.fnev == fnev))
                    {
                        u = sql.Dolgozok.Where(a => a.fnev == fnev).FirstOrDefault();
                        Program.LoggedInUser = u;
                        if (u.jelszo == psw) return true;
                        else if (u.felfuggesztve == "igen") { MessageBox.Show("Ez a fiók fel lett függesztve"); return false; }
                        else return false;
                    }

                    else return false;                       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a kapcsolódás során!");
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult d = MessageBox.Show("Kérem csak akkor módosítsa a kapcsolati beállításokat, ha tudja mit csinál illetve van engedélye, különben működésképtelen lehet az alkalmazás!", "Figyelem", MessageBoxButtons.OKCancel);
            if (d == DialogResult.OK)
            {
                NewForms.Settings s = new NewForms.Settings();
                s.ShowDialog();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
