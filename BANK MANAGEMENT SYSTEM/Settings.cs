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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        
        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void resetl_Click(object sender, EventArgs e)
        {
            npwtb.Text = "";
           
        }
        private void Logout()
        {
          
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Perform the logout
                Logout();
            }
        }
        private void ChangePassword(string newPassword)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BANK_DATABASE;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
                {
                    con.Open();

                    string updateQuery = "UPDATE AdminTable SET Adpassword = @NewPassword WHERE AdId = @UserId";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@UserId", 1); 
                        cmd.Parameters.AddWithValue("@NewPassword", npwtb.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to change password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pwappbtn_Click(object sender, EventArgs e)
        {
            string newPassword = npwtb.Text;

            if (string.IsNullOrEmpty(newPassword))
            {  
                MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ChangePassword(newPassword);

          
            npwtb.Text = string.Empty;
        }
    
    }
}
