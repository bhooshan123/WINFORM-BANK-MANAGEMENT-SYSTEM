using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class AddAccounts : Form
    {
        public AddAccounts()
        {
            InitializeComponent();
            DisplayAccounts();
            Reset();

        }
        
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BANK_DATABASE;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void DisplayAccounts()
        {
            con.Open();
            string query = "Select * from AccountTable";
            SqlDataAdapter sda =new SqlDataAdapter( query, con );
            var ds = new DataSet();
            sda.Fill( ds );
            dgview.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            nametb.Text = "";
            gendercb.SelectedIndex = -1;
            mobiletb.Text = "";
            inctb.Text = "";
            occutb.Text = "";
            qualitb.SelectedIndex = -1; 
            addresstb.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddAccounts_Load(object sender, EventArgs e)
        {

        }

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nametb.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
           addresstb.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
            gendercb.SelectedItem = dgview.SelectedRows[0].Cells[3].Value.ToString();
           qualitb.SelectedItem = dgview.SelectedRows[0].Cells[4].Value.ToString();
            occutb.Text = dgview.SelectedRows[0].Cells[5].Value.ToString();
            inctb.Text = dgview.SelectedRows[0].Cells[6].Value.ToString();
            mobiletb.Text = dgview.SelectedRows[0].Cells[7].Value.ToString();
            if (nametb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgview.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (nametb.Text == "" || gendercb.SelectedIndex == -1 || mobiletb.Text == "" || inctb.Text == "" || occutb.Text == "" || qualitb.SelectedIndex == -1 || addresstb.Text =="")
            {
                MessageBox.Show("PLEASE ENTER ALL DETAILS");
            }
            else
            {
                try
                { 
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into dbo.AccountTable(AcName,AcAddress,Acgender,AcEdu,AcOccu,AcInc,AcBal,AcPhone) values (@AN,@AA,@AG,@AE,@AO,@AI,@AB,@AP)", con);
                     
                    cmd.Parameters.AddWithValue("@AN", nametb.Text);
                    cmd.Parameters.AddWithValue("@AA", addresstb.Text);
                    cmd.Parameters.AddWithValue("@AG", gendercb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AE", qualitb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", occutb.Text);
                    cmd.Parameters.AddWithValue("@AI", inctb.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.Parameters.AddWithValue("@AP", mobiletb.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account Created Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data into the database.");
                    }
                    con.Close();
                    Reset();
                    DisplayAccounts();
                } 
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("PLEASE SELECT AN ACCOUNT");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AccountTable where AcId=@AcKey", con);

                    cmd.Parameters.AddWithValue("@AcKey", key);
                   
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert data into the database.");
                    }
                    con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;

        private void occul_Click(object sender, EventArgs e)
        {

        }
    }
}

