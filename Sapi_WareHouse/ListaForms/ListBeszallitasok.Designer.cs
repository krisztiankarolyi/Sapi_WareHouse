
namespace Sapi_WareHouse.ListaForms
{
    partial class ListBeszallitasok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBeszallitasok));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SzallitoLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atvevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mennyiseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kifizetve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penznem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beszallito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Szűrés ";
            this.textBox1.Size = new System.Drawing.Size(200, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(233, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Frissítés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(346, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exportálás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SzallitoLevel,
            this.atvevo,
            this.cikkszam,
            this.Mennyiseg,
            this.datun,
            this.Kifizetve,
            this.egysegar,
            this.penznem,
            this.AFA,
            this.Beszallito});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(955, 375);
            this.dataGridView1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // SzallitoLevel
            // 
            this.SzallitoLevel.HeaderText = "Szállítólevél";
            this.SzallitoLevel.Name = "SzallitoLevel";
            this.SzallitoLevel.ReadOnly = true;
            // 
            // atvevo
            // 
            this.atvevo.HeaderText = "Átvevő";
            this.atvevo.Name = "atvevo";
            this.atvevo.ReadOnly = true;
            // 
            // cikkszam
            // 
            this.cikkszam.HeaderText = "Cikkszám";
            this.cikkszam.Name = "cikkszam";
            this.cikkszam.ReadOnly = true;
            // 
            // Mennyiseg
            // 
            this.Mennyiseg.HeaderText = "Mennyiség";
            this.Mennyiseg.Name = "Mennyiseg";
            this.Mennyiseg.ReadOnly = true;
            // 
            // datun
            // 
            this.datun.HeaderText = "Dátum";
            this.datun.Name = "datun";
            this.datun.ReadOnly = true;
            // 
            // Kifizetve
            // 
            this.Kifizetve.HeaderText = "Kifizetve";
            this.Kifizetve.Name = "Kifizetve";
            this.Kifizetve.ReadOnly = true;
            // 
            // egysegar
            // 
            this.egysegar.HeaderText = "Egységár";
            this.egysegar.Name = "egysegar";
            this.egysegar.ReadOnly = true;
            // 
            // penznem
            // 
            this.penznem.HeaderText = "Pénznem";
            this.penznem.Name = "penznem";
            this.penznem.ReadOnly = true;
            // 
            // AFA
            // 
            this.AFA.HeaderText = "ÁFA";
            this.AFA.Name = "AFA";
            this.AFA.ReadOnly = true;
            // 
            // Beszallito
            // 
            this.Beszallito.HeaderText = "Beszállító";
            this.Beszallito.Name = "Beszallito";
            this.Beszallito.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(456, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kifizetve";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(574, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "Új rögzítése";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ListBeszallitasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListBeszallitasok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beszállítások listája";
            this.Load += new System.EventHandler(this.ListBeszallitasok_Load);
            this.Click += new System.EventHandler(this.ListBeszallitasok_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SzallitoLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn atvevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mennyiseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn datun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kifizetve;
        private System.Windows.Forms.DataGridViewTextBoxColumn egysegar;
        private System.Windows.Forms.DataGridViewTextBoxColumn penznem;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beszallito;
    }
}