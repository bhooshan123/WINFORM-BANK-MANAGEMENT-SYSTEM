namespace BANK_MANAGEMENT_SYSTEM
{
    partial class Settings
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetl = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.pwappbtn = new System.Windows.Forms.Button();
            this.npwtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.resetl);
            this.panel1.Controls.Add(this.logoutbtn);
            this.panel1.Controls.Add(this.pwappbtn);
            this.panel1.Controls.Add(this.npwtb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 334);
            this.panel1.TabIndex = 0;
            // 
            // resetl
            // 
            this.resetl.AutoSize = true;
            this.resetl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetl.ForeColor = System.Drawing.Color.IndianRed;
            this.resetl.Location = new System.Drawing.Point(380, 103);
            this.resetl.Name = "resetl";
            this.resetl.Size = new System.Drawing.Size(76, 22);
            this.resetl.TabIndex = 6;
            this.resetl.Text = "RESET";
            this.resetl.Click += new System.EventHandler(this.resetl_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(236, 189);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(137, 45);
            this.logoutbtn.TabIndex = 5;
            this.logoutbtn.Text = "LOG OUT";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // pwappbtn
            // 
            this.pwappbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwappbtn.Location = new System.Drawing.Point(198, 91);
            this.pwappbtn.Name = "pwappbtn";
            this.pwappbtn.Size = new System.Drawing.Size(137, 45);
            this.pwappbtn.TabIndex = 2;
            this.pwappbtn.Text = "APPLY";
            this.pwappbtn.UseVisualStyleBackColor = true;
            this.pwappbtn.Click += new System.EventHandler(this.pwappbtn_Click);
            // 
            // npwtb
            // 
            this.npwtb.Location = new System.Drawing.Point(296, 24);
            this.npwtb.Multiline = true;
            this.npwtb.Name = "npwtb";
            this.npwtb.Size = new System.Drawing.Size(208, 46);
            this.npwtb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHANGE PASSWORD";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox npwtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pwappbtn;
        private System.Windows.Forms.Label resetl;
        private System.Windows.Forms.Button logoutbtn;
    }
}