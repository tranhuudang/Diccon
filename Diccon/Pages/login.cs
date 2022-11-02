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
            string encryptPass = new sha256Encrypt(tbPassword.Text.Trim()).Hash();
            string queryString = "Select * from dbo.DicconUser where Email='" + tbEmail.Text.Trim() + "' and Password='" + encryptPass + "'";
            SQLHandler sqlHandler = new SQLHandler();
            DataTable dataTable = sqlHandler.Select(queryString);
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
            btBack.BackColor = dicconProp.ColorA8;
            btCreateNow.BackColor = dicconProp.ColorA8;
            roundedPanel1.BackColor = dicconProp.ColorA9;
            roundedPanel2.BackColor = dicconProp.ColorA9;
            roundedPanel3.BackColor = dicconProp.ColorA9;
            roundedPanel4.BackColor = dicconProp.ColorA9;
            roundedPanel5.BackColor = dicconProp.ColorA9;
            roundedPanel6.BackColor = dicconProp.ColorA9;
            roundedPanel7.BackColor = dicconProp.ColorA9;
            roundedPanel8.BackColor = dicconProp.ColorA9;
            tbEmail.BackColor = dicconProp.ColorA9;
            tbPassword.BackColor = dicconProp.ColorA9;
            editEmail.BackColor = dicconProp.ColorA9;
            editPass_1.BackColor = dicconProp.ColorA9;
            editPass_2.BackColor = dicconProp.ColorA9;
            createEmail.BackColor = dicconProp.ColorA9;
            createPass_1.BackColor=dicconProp.ColorA9;
            createPass_2.BackColor = dicconProp.ColorA9;
           
            if (Properties.Settings.Default["userID"].ToString() != "none")
            {
                this.Text = manageAccountText.Text;
                panelLogin.Visible = false;
                panelCreateAccount.Visible = false;
                panelManage.Visible = true;
                panelManage.Dock = DockStyle.Fill;
                panelManage.BringToFront();
                editEmail.Text = Properties.Settings.Default["userEmail"].ToString();
            }
            else
            {
                this.Text = loginText.Text;
                panelManage.Visible = false;
                panelCreateAccount.Visible = false;
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

        private void btCreateAccount_Click(object sender, EventArgs e)
        {
            this.Text = createText.Text;
            panelManage.Visible = false;
            panelLogin.Visible = false;
            panelCreateAccount.Visible = true;
            panelCreateAccount.Dock = DockStyle.Fill;
            panelCreateAccount.BringToFront();
        }

        private void createEmail_TextChanged(object sender, EventArgs e)
        {
            if ((createEmail.Text.Contains("@") && createEmail.Text.Contains(".")) && (createPass_1.Text.Length >= 8 && createPass_1.Text == createPass_2.Text))
            {
                btCreateNow.Enabled = true;
            }
            else
            {
                btCreateNow.Enabled = false;
            }
        }

        private async void btCreateNow_Click(object sender, EventArgs e)
        {
            string encryptPass = new sha256Encrypt(createPass_1.Text.Trim()).Hash();
            string queryString = "Insert into dbo.DicconUser(Email, Password) values ('"+createEmail.Text+"','"+encryptPass+"')";
            SQLHandler sql = new SQLHandler();
            await sql.Insert(queryString);
            // Close create form and open login form
            this.Text = loginText.Text;
            panelManage.Visible = false;
            panelCreateAccount.Visible = false;
            panelLogin.Visible = true;
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.BringToFront();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Text = loginText.Text;
            panelManage.Visible = false;
            panelCreateAccount.Visible = false;
            panelLogin.Visible = true;
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.BringToFront();
        }

        private void btCreateAccount_MouseEnter(object sender, EventArgs e)
        {
            dicconProp.Control_MouseEnter(sender, e);
        }

        private void btCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            dicconProp.Control_MouseLeave(sender, e);
        }

        private void login_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btDeleteOnline_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to delete your online data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string updateQueryString = "UPDATE dbo.DicconUser  SET Resources = NULL, Timeline = NULL, QA = NULL, FreeAsk = NULL, PayAsk = NULL  Where Id=" + dicconProp.userID;
                SQLHandler sql = new SQLHandler();
                sql.Update(updateQueryString);
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                btLogin_Click(null, null);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLogin.Dock = DockStyle.Fill;
        }
    }
}
