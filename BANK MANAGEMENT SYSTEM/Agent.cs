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
using System.Web.UI.WebControls;

namespace BANK_MANAGEMENT_SYSTEM
{
    public partial class Agent : Form
    {
        public Agent()
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
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            Adgview.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            Anametb.Text = "";
            Amobiletb.Text = "";
           Apwtb.Text = "";
           
            Aaddresstb.Text = "";
        }

       

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {

        }



        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }
        int key = 0;

    


private void Agent_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Agent_Load_1(object sender, EventArgs e)
        {

        }

        private void dgview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
