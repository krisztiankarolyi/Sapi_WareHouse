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
    public partial class ujLevel : Form
    {
        public Uzenet? toread { get; set; }
        public bool readerview { get; set; }
        public ujLevel(bool readerview, Uzenet toread)
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                using (SQL sql = new SQL())
                {
                    comboBox1.DataSource = sql.Dolgozok.ToList();
                    comboBox1.DisplayMember = "teljes_nev";
                    comboBox1.ValueMember = "fnev";
                    comboBox1.SelectedIndex = 0;
                    textBox2.Text = Program.LoggedInUser.fnev;
                }
            }
            catch (Exception)
            {
                throw;
            }
            if (readerview)
            {
                button1.Visible = false; button2.Visible = false; comboBox1.Enabled = false; textBox1.ReadOnly = true; richTextBox1.ReadOnly = true;
                richTextBox1.Text = toread.tartalom; textBox1.Text = toread.targy; comboBox1.SelectedValue = toread.cimzett; textBox2.Text = toread.felado;         
            }
            if (Program.LoggedInUser.fnev == textBox2.Text) textBox2.Text += " (Ön)";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty && textBox1.Text != string.Empty)
            {
                DialogResult d = MessageBox.Show("Biztosan el szeretné küldeni az üzenetet?", "Megerősítés", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    try
                    {
                        using (SQL sql = new SQL())
                        {
                            Uzenet u = new Uzenet();
                            u.cimzett = comboBox1.SelectedValue.ToString();
                            u.felado = Program.LoggedInUser.fnev;
                            u.targy = textBox1.Text;
                            u.tartalom = richTextBox1.Text;
                            u.datum = DateTime.Now;
                            sql.Uzenetek.Add(u);
                            if (sql.SaveChanges() == 1) MessageBox.Show("Üzenet sikeresen elküldve");
                            else MessageBox.Show("Sajnos nem sikerült elküldeni az üzenetet.", "Hiba");
                            this.Close();

                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            else MessageBox.Show("Minden mező kitöltése kötelező!", "Hiba");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ujLevel_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
