
namespace Sapi_WareHouse.NewForms
{
    partial class ujDolgozo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ujDolgozo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fnevbox = new System.Windows.Forms.TextBox();
            this.fullnamebox = new System.Windows.Forms.TextBox();
            this.pswbox = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.ComboBox();
            this.tiltva = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "teljes név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "jelszó";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "admin jog";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "felfüggesztve";
            // 
            // fnevbox
            // 
            this.fnevbox.Location = new System.Drawing.Point(112, 33);
            this.fnevbox.Name = "fnevbox";
            this.fnevbox.Size = new System.Drawing.Size(203, 25);
            this.fnevbox.TabIndex = 5;
            // 
            // fullnamebox
            // 
            this.fullnamebox.Location = new System.Drawing.Point(112, 65);
            this.fullnamebox.Name = "fullnamebox";
            this.fullnamebox.Size = new System.Drawing.Size(203, 25);
            this.fullnamebox.TabIndex = 6;
            // 
            // pswbox
            // 
            this.pswbox.Location = new System.Drawing.Point(112, 102);
            this.pswbox.Name = "pswbox";
            this.pswbox.PasswordChar = '●';
            this.pswbox.Size = new System.Drawing.Size(203, 25);
            this.pswbox.TabIndex = 7;
            // 
            // admin
            // 
            this.admin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.FormattingEnabled = true;
            this.admin.Items.AddRange(new object[] {
            "nem",
            "igen\t"});
            this.admin.Location = new System.Drawing.Point(112, 140);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(203, 25);
            this.admin.TabIndex = 8;
            // 
            // tiltva
            // 
            this.tiltva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tiltva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tiltva.FormattingEnabled = true;
            this.tiltva.Items.AddRange(new object[] {
            "nem",
            "igen"});
            this.tiltva.Location = new System.Drawing.Point(112, 176);
            this.tiltva.Name = "tiltva";
            this.tiltva.Size = new System.Drawing.Size(203, 25);
            this.tiltva.TabIndex = 9;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel.Location = new System.Drawing.Point(112, 265);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(92, 30);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Mégsem";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save.Location = new System.Drawing.Point(227, 265);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 29);
            this.save.TabIndex = 11;
            this.save.Text = "Mentés";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Születési dátum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 219);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 25);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2022, 1, 2, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ujDolgozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(345, 307);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.tiltva);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.pswbox);
            this.Controls.Add(this.fullnamebox);
            this.Controls.Add(this.fnevbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ujDolgozo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új dolgozó regisztrálása";
            this.Load += new System.EventHandler(this.ujDolgozo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fnevbox;
        private System.Windows.Forms.TextBox fullnamebox;
        private System.Windows.Forms.TextBox pswbox;
        private System.Windows.Forms.ComboBox admin;
        private System.Windows.Forms.ComboBox tiltva;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}