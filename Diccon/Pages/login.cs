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

namespace Diccon.Pages
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ZeroClubOne;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string queryString= "Select * from dbo.DicconLogin where Email='"+tbEmail.Text.Trim()+"' and Password='"+tbPassword.Text.Trim()+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if(dataTable.Rows.Count >=1)
            {
                //dataTable.Rows[0][0]-Id
                //dataTable.Rows[0][1]-Email
                //dataTable.Rows[0][2]-Password
                Properties.Settings.Default["userID"] = dataTable.Rows[0][0].ToString();
                Properties.Settings.Default["userName"] = dataTable.Rows[0][1].ToString();
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            else
            {
                lbNotice.Visible = true;
            }
        
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            lbNotice.Visible = false;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            lbNotice.Visible = false;
        }
    }
}
