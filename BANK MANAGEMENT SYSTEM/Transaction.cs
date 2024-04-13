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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BANK_DATABASE;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        int balance;
        private void Checkbal()
        {
            con.Open();
            String query = "select * from AccountTable where AcId=@an";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@an", chkbaltb.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ball.Text = "Rs." + dr["AcBal"].ToString();
                balance = Convert.ToInt32(dr["AcBal"].ToString());
            }
            con.Close();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            if (chkbaltb.Text == "")
            {
                MessageBox.Show("ENTER ACCOUNT NUMBER");
            }
            else
            {
                Checkbal();
            }
        }
        private void GetNewBalance()
        {
            con.Open();
            String query = "select * from AccountTable where AcId=@an";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@an", chkbaltb.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                // ball.Text = "Rs." + dr["AcBal"].ToString();
                balance = Convert.ToInt32(dr["AcBal"].ToString());
            }
            con.Close();
        }
        
        private void depositbtn_Click(object sender, EventArgs e)
        {
            if (danotb.Text == "" || damttb.Text == "")
            {
                MessageBox.Show("ENTER ALL DETAILS");
            }
            else
            {
             

                GetNewBalance();
                int NewBal = balance + Convert.ToInt32(damttb.Text);
                try
                {
                        con.Open();
                        String query = "update AccountTable set AcBal=@AB where AcId=@AI";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@AB", NewBal);
                        cmd.Parameters.AddWithValue("@AI", danotb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("MONEY DEPOSITED!");

                        con.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
            }
        }

        private void withdrawbtn_Click(object sender, EventArgs e)
        {

            if (wanotb.Text == "" || wamttb.Text == "")
            {
                MessageBox.Show("ENTER ALL DETAILS");
            }
            else
            {
                if (balance < Convert.ToInt32(wamttb.Text))
                {
                    MessageBox.Show("INSUFFICIENT BALANCE");
                }
                else
                {

                    GetNewBalance();
                    int NewBal = balance - Convert.ToInt32(wamttb.Text);
                    try
                    {
                        con.Open();
                        String query = "update AccountTable set AcBal=@AB where AcId=@AI";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@AB", NewBal);
                        cmd.Parameters.AddWithValue("@AI", wanotb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("MONEY WITHDRAWN!");

                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured: " + ex.Message);
                    }
                }
            }
        }

        private void transferbtn_Click(object sender, EventArgs e)
        {
            if (tfromtb.Text == "" || ttotb.Text == "")
            {
                MessageBox.Show("ENTER ALL DETAILS");
                return;
            }
            int transferFrom;
            if (!int.TryParse(tfromtb.Text, out transferFrom))
            {
                MessageBox.Show("Invalid 'From' account number. Please enter a valid numeric value.");
                return;
            }

            int transferTo;
            if (!int.TryParse(ttotb.Text, out transferTo))
            {
                MessageBox.Show("Invalid 'To' account number. Please enter a valid numeric value.");
                return;
            }

            int transferAmount;
            if (!int.TryParse(tamttb.Text, out transferAmount))
            {
                MessageBox.Show("Invalid transfer amount. Please enter a valid numeric value.");
                return;
            }

            try
            {
                con.Open();

                // Check if 'From' account has sufficient balance
                SqlCommand checkBalanceCmd = new SqlCommand("SELECT AcBal FROM AccountTable WHERE AcId = @FromId", con);
                checkBalanceCmd.Parameters.AddWithValue("@FromId", transferFrom);

                int fromBalance = (int)checkBalanceCmd.ExecuteScalar();

                if (fromBalance < transferAmount)
                {
                    MessageBox.Show("Insufficient balance in the 'From' account.");
                    return;
                }

                // Update 'From' account balance
                SqlCommand updateFromCmd = new SqlCommand("UPDATE AccountTable SET AcBal = AcBal - @TransferAmount WHERE AcId = @FromId", con);
                updateFromCmd.Parameters.AddWithValue("@TransferAmount", transferAmount);
                updateFromCmd.Parameters.AddWithValue("@FromId", transferFrom);
                updateFromCmd.ExecuteNonQuery();

                // Update 'To' account balance
                SqlCommand updateToCmd = new SqlCommand("UPDATE AccountTable SET AcBal = AcBal + @TransferAmount WHERE AcId = @ToId", con);
                updateToCmd.Parameters.AddWithValue("@TransferAmount", transferAmount);
                updateToCmd.Parameters.AddWithValue("@ToId", transferTo);
                updateToCmd.ExecuteNonQuery();

                MessageBox.Show("Transfer successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the transfer: {ex.Message}");
            }
            finally
            {
                con.Close();
                tfromtb.Text = "";
                ttotb.Text = "";
                tamttb.Text = "";
            }

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
