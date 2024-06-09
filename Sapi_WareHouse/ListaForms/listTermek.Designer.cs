
namespace Sapi_WareHouse.ListaForms
{
    partial class listTermek
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listTermek));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.szurobox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megnevezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelenkeszlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elozokeszlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leltariv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penznem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettoertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruttoertek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_beszerzeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szavatossag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "d";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cikkszam,
            this.megnevezes,
            this.kategoria,
            this.jelenkeszlet,
            this.elozokeszlet,
            this.mertek,
            this.leltariv,
            this.penznem,
            this.nettoertek,
            this.bruttoertek,
            this.br_beszerzeso,
            this.afa,
            this.szavatossag});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(22, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(956, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // szurobox
            // 
            this.szurobox.Location = new System.Drawing.Point(13, 13);
            this.szurobox.Name = "szurobox";
            this.szurobox.Size = new System.Drawing.Size(244, 25);
            this.szurobox.TabIndex = 1;
            this.szurobox.TextChanged += new System.EventHandler(this.szurobox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "szűrés (kategória/cikkszám/megnevezés)";
            // 
            // editbtn
            // 
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editbtn.Location = new System.Drawing.Point(371, 9);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(80, 30);
            this.editbtn.TabIndex = 3;
            this.editbtn.Text = "Módosítás";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delbtn.Location = new System.Drawing.Point(564, 9);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(80, 30);
            this.delbtn.TabIndex = 4;
            this.delbtn.Text = "Törlés";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // refresh
            // 
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.refresh.Location = new System.Drawing.Point(468, 9);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(80, 30);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Frissítés";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // exp
            // 
            this.exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exp.Location = new System.Drawing.Point(659, 9);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(80, 30);
            this.exp.TabIndex = 6;
            this.exp.Text = "Exportálás";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(272, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Új termék";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(755, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Random feltöltés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(891, 13);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 25);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(564, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Összes";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 7;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // cikkszam
            // 
            this.cikkszam.HeaderText = "Cikkszám";
            this.cikkszam.MinimumWidth = 6;
            this.cikkszam.Name = "cikkszam";
            this.cikkszam.ReadOnly = true;
            this.cikkszam.Width = 125;
            // 
            // megnevezes
            // 
            this.megnevezes.HeaderText = "Megnevezés";
            this.megnevezes.MinimumWidth = 6;
            this.megnevezes.Name = "megnevezes";
            this.megnevezes.ReadOnly = true;
            this.megnevezes.Width = 125;
            // 
            // kategoria
            // 
            this.kategoria.HeaderText = "Kategória";
            this.kategoria.MinimumWidth = 6;
            this.kategoria.Name = "kategoria";
            this.kategoria.ReadOnly = true;
            this.kategoria.Width = 125;
            // 
            // jelenkeszlet
            // 
            this.jelenkeszlet.HeaderText = "Jelenlegi Készlet";
            this.jelenkeszlet.MinimumWidth = 6;
            this.jelenkeszlet.Name = "jelenkeszlet";
            this.jelenkeszlet.ReadOnly = true;
            this.jelenkeszlet.Width = 125;
            // 
            // elozokeszlet
            // 
            this.elozokeszlet.HeaderText = "Előző leltári készlet";
            this.elozokeszlet.MinimumWidth = 6;
            this.elozokeszlet.Name = "elozokeszlet";
            this.elozokeszlet.ReadOnly = true;
            this.elozokeszlet.Width = 125;
            // 
            // mertek
            // 
            this.mertek.HeaderText = "Mértékegység";
            this.mertek.Name = "mertek";
            this.mertek.ReadOnly = true;
            // 
            // leltariv
            // 
            this.leltariv.HeaderText = "Leltárív száma";
            this.leltariv.MinimumWidth = 6;
            this.leltariv.Name = "leltariv";
            this.leltariv.ReadOnly = true;
            this.leltariv.Width = 125;
            // 
            // penznem
            // 
            this.penznem.HeaderText = "Pénznem";
            this.penznem.Name = "penznem";
            this.penznem.ReadOnly = true;
            // 
            // nettoertek
            // 
            this.nettoertek.HeaderText = "Nettó egységár";
            this.nettoertek.MinimumWidth = 6;
            this.nettoertek.Name = "nettoertek";
            this.nettoertek.ReadOnly = true;
            this.nettoertek.Width = 125;
            // 
            // bruttoertek
            // 
            this.bruttoertek.HeaderText = "Bruttó egységár";
            this.bruttoertek.MinimumWidth = 6;
            this.bruttoertek.Name = "bruttoertek";
            this.bruttoertek.ReadOnly = true;
            this.bruttoertek.Width = 125;
            // 
            // br_beszerzeso
            // 
            this.br_beszerzeso.HeaderText = "Beszerzési költség";
            this.br_beszerzeso.MinimumWidth = 6;
            this.br_beszerzeso.Name = "br_beszerzeso";
            this.br_beszerzeso.ReadOnly = true;
            this.br_beszerzeso.Width = 125;
            // 
            // afa
            // 
            this.afa.HeaderText = "ÁFA kulcs (%)";
            this.afa.MinimumWidth = 6;
            this.afa.Name = "afa";
            this.afa.ReadOnly = true;
            this.afa.Width = 125;
            // 
            // szavatossag
            // 
            this.szavatossag.HeaderText = "Szavatosság";
            this.szavatossag.Name = "szavatossag";
            this.szavatossag.ReadOnly = true;
            // 
            // listTermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(980, 457);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szurobox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "listTermek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termékek listája";
            this.Load += new System.EventHandler(this.listTermek_Load);
            this.Click += new System.EventHandler(this.listTermek_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private  System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox szurobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn megnevezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenkeszlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn elozokeszlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn mertek;
        private System.Windows.Forms.DataGridViewTextBoxColumn leltariv;
        private System.Windows.Forms.DataGridViewTextBoxColumn penznem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettoertek;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruttoertek;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_beszerzeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn afa;
        private System.Windows.Forms.DataGridViewTextBoxColumn szavatossag;
    }
}