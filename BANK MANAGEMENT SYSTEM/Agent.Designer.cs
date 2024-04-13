namespace BANK_MANAGEMENT_SYSTEM
{
    partial class Agent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.submitbtn = new System.Windows.Forms.Button();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.inctb = new System.Windows.Forms.TextBox();
            this.mobiletb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.incl = new System.Windows.Forms.Label();
            this.mobilel = new System.Windows.Forms.Label();
            this.addressl = new System.Windows.Forms.Label();
            this.Namel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgview.ColumnHeadersHeight = 4;
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgview.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgview.Location = new System.Drawing.Point(183, 373);
            this.dgview.Name = "dgview";
            this.dgview.RowHeadersVisible = false;
            this.dgview.RowHeadersWidth = 51;
            this.dgview.RowTemplate.Height = 24;
            this.dgview.Size = new System.Drawing.Size(1172, 396);
            this.dgview.TabIndex = 39;
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
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellContentClick_1);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(769, 309);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(164, 58);
            this.cancelbtn.TabIndex = 38;
            this.cancelbtn.Text = "CANCEL";
            this.cancelbtn.UseVisualStyleBackColor = false;
            // 
            // submitbtn
            // 
            this.submitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(462, 309);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(164, 58);
            this.submitbtn.TabIndex = 37;
            this.submitbtn.Text = "SUBMIT";
            this.submitbtn.UseVisualStyleBackColor = false;
            // 
            // addresstb
            // 
            this.addresstb.Location = new System.Drawing.Point(1043, 149);
            this.addresstb.Multiline = true;
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(318, 121);
            this.addresstb.TabIndex = 34;
            // 
            // inctb
            // 
            this.inctb.Location = new System.Drawing.Point(1043, 83);
            this.inctb.Multiline = true;
            this.inctb.Name = "inctb";
            this.inctb.Size = new System.Drawing.Size(217, 47);
            this.inctb.TabIndex = 32;
            // 
            // mobiletb
            // 
            this.mobiletb.Location = new System.Drawing.Point(444, 223);
            this.mobiletb.Multiline = true;
            this.mobiletb.Name = "mobiletb";
            this.mobiletb.Size = new System.Drawing.Size(217, 47);
            this.mobiletb.TabIndex = 31;
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(444, 83);
            this.nametb.Multiline = true;
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(217, 47);
            this.nametb.TabIndex = 30;
            // 
            // incl
            // 
            this.incl.AutoSize = true;
            this.incl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incl.Location = new System.Drawing.Point(854, 105);
            this.incl.Name = "incl";
            this.incl.Size = new System.Drawing.Size(106, 25);
            this.incl.TabIndex = 26;
            this.incl.Text = "Password";
            // 
            // mobilel
            // 
            this.mobilel.AutoSize = true;
            this.mobilel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilel.Location = new System.Drawing.Point(226, 245);
            this.mobilel.Name = "mobilel";
            this.mobilel.Size = new System.Drawing.Size(157, 25);
            this.mobilel.TabIndex = 25;
            this.mobilel.Text = "Mobile Number";
            // 
            // addressl
            // 
            this.addressl.AutoSize = true;
            this.addressl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressl.Location = new System.Drawing.Point(878, 223);
            this.addressl.Name = "addressl";
            this.addressl.Size = new System.Drawing.Size(92, 25);
            this.addressl.TabIndex = 24;
            this.addressl.Text = "Address";
            // 
            // Namel
            // 
            this.Namel.AutoSize = true;
            this.Namel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namel.Location = new System.Drawing.Point(315, 105);
            this.Namel.Name = "Namel";
            this.Namel.Size = new System.Drawing.Size(68, 25);
            this.Namel.TabIndex = 23;
            this.Namel.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 832);
            this.panel1.TabIndex = 40;
            // 
            // Agent
            // 
            this.ClientSize = new System.Drawing.Size(1412, 832);
            this.Controls.Add(this.addresstb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.inctb);
            this.Controls.Add(this.mobiletb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.incl);
            this.Controls.Add(this.mobilel);
            this.Controls.Add(this.addressl);
            this.Controls.Add(this.Namel);
            this.Name = "Agent";
            this.Load += new System.EventHandler(this.Agent_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView Adgview;
        private System.Windows.Forms.Button Acancelbtn;
        private System.Windows.Forms.Button Asubmitbtn;
        private System.Windows.Forms.TextBox Aaddresstb;
        private System.Windows.Forms.TextBox Apwtb;
        private System.Windows.Forms.TextBox Amobiletb;
        private System.Windows.Forms.TextBox Anametb;
        private System.Windows.Forms.Label Apwl;
        private System.Windows.Forms.Label Amobilel;
        private System.Windows.Forms.Label Aaddressl;
        private System.Windows.Forms.Label Anamel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgview;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.TextBox inctb;
        private System.Windows.Forms.TextBox mobiletb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label incl;
        private System.Windows.Forms.Label mobilel;
        private System.Windows.Forms.Label addressl;
        private System.Windows.Forms.Label Namel;
        private System.Windows.Forms.Panel panel1;
    }
}