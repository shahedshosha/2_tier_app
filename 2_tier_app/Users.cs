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
    }
}
