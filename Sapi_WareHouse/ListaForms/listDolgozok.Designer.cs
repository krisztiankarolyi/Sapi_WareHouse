
namespace Sapi_WareHouse.ListaForms
{
    partial class listDolgozok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listDolgozok));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szuldat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiltva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.tilt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fnev,
            this.fullname,
            this.szuldat,
            this.admin,
            this.tiltva});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(582, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // fnev
            // 
            this.fnev.HeaderText = "felhasználónév";
            this.fnev.Name = "fnev";
            this.fnev.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "teljes név";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // szuldat
            // 
            this.szuldat.HeaderText = "születési dátum";
            this.szuldat.Name = "szuldat";
            this.szuldat.ReadOnly = true;
            // 
            // admin
            // 
            this.admin.HeaderText = "admin joga van";
            this.admin.Name = "admin";
            this.admin.ReadOnly = true;
            // 
            // tiltva
            // 
            this.tiltva.HeaderText = "Felfüggesztve";
            this.tiltva.Name = "tiltva";
            this.tiltva.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Szűrés (név, admin jog, stb...)";
            this.textBox1.Size = new System.Drawing.Size(184, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // edit
            // 
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Location = new System.Drawing.Point(312, 8);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(80, 30);
            this.edit.TabIndex = 2;
            this.edit.Text = "Módosítás";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // tilt
            // 
            this.tilt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tilt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tilt.Location = new System.Drawing.Point(414, 8);
            this.tilt.Name = "tilt";
            this.tilt.Size = new System.Drawing.Size(80, 30);
            this.tilt.TabIndex = 3;
            this.tilt.Text = "Új dolgozó";
            this.tilt.UseVisualStyleBackColor = true;
            this.tilt.Click += new System.EventHandler(this.tilt_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(514, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Exportálás";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh.Location = new System.Drawing.Point(217, 9);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(80, 30);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Frissít";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // listDolgozok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(606, 483);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tilt);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "listDolgozok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dolgozók listája";
            this.Load += new System.EventHandler(this.listDolgozok_Load);
            this.Click += new System.EventHandler(this.listDolgozok_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnev;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn szuldat;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiltva;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button tilt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button refresh;
    }
}