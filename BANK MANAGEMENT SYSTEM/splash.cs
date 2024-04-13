using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
    
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP++;
            pbar.Value=startP;
            if (pbar.Value == 100)
            {
                timer1.Stop();
                pbar.Value = 0;
                Login l = new Login();
                l.FormClosed += (s, args) => { this.Show(); };
                l.Show();
                this.Hide();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            timer1.Stop();
            timer1.Dispose();
        }
    }
}
