using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BANK_DATABASE;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usernametb.Text == "" || pwtb.Text == "")
            {
                MessageBox.Show("PLEASE ENTER ALL DETAILS");
            }
            else
            {
                con.Open();
                String query = "select count(*) from AdminTable where Adname=@un and Adpassword=@up";
              
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.Parameters.AddWithValue("@un", usernametb.Text);
                cmd.Parameters.AddWithValue("@up", pwtb.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                  
                    Userlogin ul = new Userlogin();
                    ul.Show();
                    con.Close();
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Invalid username or password");
                }
                con.Close();
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
