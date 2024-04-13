namespace BANK_MANAGEMENT_SYSTEM
{
    partial class AddAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Namel = new System.Windows.Forms.Label();
            this.addressl = new System.Windows.Forms.Label();
            this.mobilel = new System.Windows.Forms.Label();
            this.incl = new System.Windows.Forms.Label();
            this.qualil = new System.Windows.Forms.Label();
            this.occul = new System.Windows.Forms.Label();
            this.genderl = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.mobiletb = new System.Windows.Forms.TextBox();
            this.inctb = new System.Windows.Forms.TextBox();
            this.occutb = new System.Windows.Forms.TextBox();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.gendercb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.qualitb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.dgview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 790);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "NEW ACCOUNT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namel.Location = new System.Drawing.Point(261, 94);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(68, 25);
            this.Namel.TabIndex = 2;
            this.Namel.Text = "Name";
            // 
            // addressl
            // 
            this.addressl.AutoSize = true;
            this.addressl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressl.Location = new System.Drawing.Point(1133, 33);
            this.addressl.Name = "addressl";
            this.addressl.Size = new System.Drawing.Size(92, 25);
            this.addressl.TabIndex = 3;
            this.addressl.Text = "Address";
            this.addressl.Click += new System.EventHandler(this.label3_Click);
            // 
            // mobilel
            // 
            this.mobilel.AutoSize = true;
            this.mobilel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilel.Location = new System.Drawing.Point(172, 234);
            this.mobilel.Name = "mobilel";
            this.mobilel.Size = new System.Drawing.Size(157, 25);
            this.mobilel.TabIndex = 4;
            this.mobilel.Text = "Mobile Number";
            // 
            // incl
            // 
            this.incl.AutoSize = true;
            this.incl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incl.Location = new System.Drawing.Point(617, 94);
            this.incl.Name = "incl";
            this.incl.Size = new System.Drawing.Size(164, 25);
            this.incl.TabIndex = 5;
            this.incl.Text = "Monthly Income";
            // 
            // qualil
            // 
            this.qualil.AutoSize = true;
            this.qualil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualil.Location = new System.Drawing.Point(649, 234);
            this.qualil.Name = "qualil";
            this.qualil.Size = new System.Drawing.Size(132, 25);
            this.qualil.TabIndex = 6;
            this.qualil.Text = "Qualification";
            // 
            // occul
            // 
            this.occul.AutoSize = true;
            this.occul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occul.Location = new System.Drawing.Point(659, 163);
            this.occul.Name = "occul";
            this.occul.Size = new System.Drawing.Size(122, 25);
            this.occul.TabIndex = 7;
            this.occul.Text = "Occupation";
            this.occul.Click += new System.EventHandler(this.occul_Click);
            // 
            // genderl
            // 
            this.genderl.AutoSize = true;
            this.genderl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderl.Location = new System.Drawing.Point(246, 163);
            this.genderl.Name = "genderl";
            this.genderl.Size = new System.Drawing.Size(83, 25);
            this.genderl.TabIndex = 8;
            this.genderl.Text = "Gender";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(346, 72);
            this.nametb.Multiline = true;
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(217, 47);
            this.nametb.TabIndex = 9;
            // 
            // mobiletb
            // 
            this.mobiletb.Location = new System.Drawing.Point(346, 212);
            this.mobiletb.Multiline = true;
            this.mobiletb.Name = "mobiletb";
            this.mobiletb.Size = new System.Drawing.Size(217, 47);
            this.mobiletb.TabIndex = 10;
            // 
            // inctb
            // 
            this.inctb.Location = new System.Drawing.Point(804, 72);
            this.inctb.Multiline = true;
            this.inctb.Name = "inctb";
            this.inctb.Size = new System.Drawing.Size(217, 47);
            this.inctb.TabIndex = 12;
            // 
            // occutb
            // 
            this.occutb.Location = new System.Drawing.Point(804, 141);
            this.occutb.Multiline = true;
            this.occutb.Name = "occutb";
            this.occutb.Size = new System.Drawing.Size(217, 47);
            this.occutb.TabIndex = 13;
            // 
            // addresstb
            // 
            this.addresstb.Location = new System.Drawing.Point(1054, 72);
            this.addresstb.Multiline = true;
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(246, 187);
            this.addresstb.TabIndex = 15;
            // 
            // gendercb
            // 
            this.gendercb.BackColor = System.Drawing.Color.Transparent;
            this.gendercb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gendercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gendercb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gendercb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gendercb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gendercb.ItemHeight = 30;
            this.gendercb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.gendercb.Location = new System.Drawing.Point(346, 152);
            this.gendercb.Name = "gendercb";
            this.gendercb.Size = new System.Drawing.Size(192, 36);
            this.gendercb.TabIndex = 17;
            // 
            // qualitb
            // 
            this.qualitb.BackColor = System.Drawing.Color.Transparent;
            this.qualitb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.qualitb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualitb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qualitb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qualitb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.qualitb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.qualitb.ItemHeight = 30;
            this.qualitb.Items.AddRange(new object[] {
            "Matriculation",
            "High School",
            "UG",
            "PG",
            "Doctorate",
            "Diploma",
            "None"});
            this.qualitb.Location = new System.Drawing.Point(804, 223);
            this.qualitb.Name = "qualitb";
            this.qualitb.Size = new System.Drawing.Size(192, 36);
            this.qualitb.TabIndex = 18;
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(497, 298);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(164, 58);
            this.submitbtn.TabIndex = 19;
            this.submitbtn.Text = "SUBMIT";
            this.submitbtn.UseVisualStyleBackColor = false;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(804, 298);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(164, 58);
            this.cancelbtn.TabIndex = 21;
            this.cancelbtn.Text = "CANCEL";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // dgview
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgview.ColumnHeadersHeight = 4;
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgview.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgview.Location = new System.Drawing.Point(155, 382);
            this.dgview.Name = "dgview";
            this.dgview.RowHeadersVisible = false;
            this.dgview.RowHeadersWidth = 51;
            this.dgview.RowTemplate.Height = 24;
            this.dgview.Size = new System.Drawing.Size(1172, 396);
            this.dgview.TabIndex = 22;
            this.dgview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgview.ThemeStyle.HeaderStyle.Height = 4;
            this.dgview.ThemeStyle.ReadOnly = false;
            this.dgview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgview.ThemeStyle.RowsStyle.Height = 24;
            this.dgview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellContentClick);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::BANK_MANAGEMENT_SYSTEM.Properties.Resources.exit;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1280, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(47, 45);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 24;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // AddAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1339, 790);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.qualitb);
            this.Controls.Add(this.gendercb);
            this.Controls.Add(this.addresstb);
            this.Controls.Add(this.occutb);
            this.Controls.Add(this.inctb);
            this.Controls.Add(this.mobiletb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.genderl);
            this.Controls.Add(this.occul);
            this.Controls.Add(this.qualil);
            this.Controls.Add(this.incl);
            this.Controls.Add(this.mobilel);
            this.Controls.Add(this.addressl);
            this.Controls.Add(this.Namel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AddAccounts";
            this.Text = "AddAccounts";
            this.Load += new System.EventHandler(this.AddAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Namel;
        private System.Windows.Forms.Label addressl;
        private System.Windows.Forms.Label mobilel;
        private System.Windows.Forms.Label incl;
        private System.Windows.Forms.Label qualil;
        private System.Windows.Forms.Label occul;
        private System.Windows.Forms.Label genderl;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox mobiletb;
        private System.Windows.Forms.TextBox inctb;
        private System.Windows.Forms.TextBox occutb;
        private System.Windows.Forms.TextBox addresstb;
        private Guna.UI2.WinForms.Guna2ComboBox gendercb;
        private Guna.UI2.WinForms.Guna2ComboBox qualitb;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button cancelbtn;
        private Guna.UI2.WinForms.Guna2DataGridView dgview;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}