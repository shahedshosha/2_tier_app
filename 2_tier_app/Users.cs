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

namespace _2_tier_app
{
    public partial class frmUsers : Form
    {
        string connectionString = "sarver=localhost; databace=SoftweraArchitectureCourse; Integrated security=true ";
        SqlConnection connection;
        public frmUsers()
        {
            InitializeComponent();
           connection = new SqlConnection(connectionString);
        }
        private void Form1_load(object sender, EventArgs e)
        {
            string command = "slect * from Users";
            SqlCommand sqlcommand  = new SqlCommand(command, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void bntsave_click(object sender, EventArgs e)
        {
            string userFullname = txtFullName.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            string command = $"Insert into Users values('{userFullname}',  '{username}', {password} ";
            SqlCommand sqlcommand = new SqlCommand(command , connection);

           
            if(connection.State != ConnectionState.Open )
            connection.Open();
            MessageBox.Show(connection.State.ToString());
            sqlCommand.ExecuteNonQuery();
            connection.Close();

           }

        }
    }
}
