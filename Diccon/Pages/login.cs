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
            SqlConnection sqlConnection = new SqlConnection(dicconProp.connectionString);
            string queryString= "Select * from dbo.DicconLogin where Email='"+tbEmail.Text.Trim()+"' and Password='"+tbPassword.Text.Trim()+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            if (dataTable.Rows.Count >=1)
            {
                //dataTable.Rows[0][0]-Id
                //dataTable.Rows[0][1]-Email
                //dataTable.Rows[0][2]-Password
                Properties.Settings.Default["userID"] = dataTable.Rows[0][0].ToString();
                Properties.Settings.Default["userEmail"] = dataTable.Rows[0][1].ToString();
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

        private void login_Load(object sender, EventArgs e)
        {
            // load theme
            btLogin.BackColor = dicconProp.ColorA8;
            btLogOut.BackColor = dicconProp.ColorA8;
            btSave.BackColor = dicconProp.ColorA8;
            btDeleteLocal.BackColor = dicconProp.ColorA8;
            btDeleteOnline.BackColor = dicconProp.ColorA8;
            roundedPanel1.BackColor = dicconProp.ColorA9;
            roundedPanel2.BackColor = dicconProp.ColorA9;
            roundedPanel3.BackColor = dicconProp.ColorA9;
            roundedPanel4.BackColor = dicconProp.ColorA9;
            roundedPanel5.BackColor = dicconProp.ColorA9;
            tbEmail.BackColor = dicconProp.ColorA9;
            tbPassword.BackColor = dicconProp.ColorA9;
            editEmail.BackColor = dicconProp.ColorA9;
            editPass_1.BackColor = dicconProp.ColorA9;
            editPass_2.BackColor = dicconProp.ColorA9;
           
            if (Properties.Settings.Default["userID"].ToString() != "none")
            {
                this.Text = manageAccountText.Text;
                panelLogin.Visible = false;
                panelManage.Visible = true;
                panelManage.Dock = DockStyle.Fill;
                panelManage.BringToFront();
                editEmail.Text = Properties.Settings.Default["userEmail"].ToString();
            }
            else
            {
                this.Text = loginText.Text;
                panelManage.Visible = false;
                panelLogin.Visible = true;
                panelLogin.Dock = DockStyle.Fill;
                panelLogin.BringToFront();
            }
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["userID"] = "none";
            Properties.Settings.Default["userEmail"] = "none";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void editEmail_TextChanged(object sender, EventArgs e)
        {
            if ((editEmail.Text.Contains("@") && editEmail.Text.Contains("."))&& ( editPass_1.Text.Length >= 8 && editPass_1.Text == editPass_2.Text))
            {
                btSave.Enabled = true;
            }
            else
            {
                btSave.Enabled = false;
            }
        }

        private void btLogin_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseEnter(sender, e);
        }

        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.RoundedLabel_MouseLeave(sender, e);
        }
    }
}
