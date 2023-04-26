using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Diccon.Pages
{
    public partial class login : Form
    {
        private readonly SQLHandler _sqlHandler = new SQLHandler();

        public login()
        {
            InitializeComponent();
        }

        private async void btLogin_Click(object sender, EventArgs e)
        {
            string encryptPass = new Sha256Encrypt(tbPassword.Text.Trim()).Hash();
            string queryString = "Select * from dbo.DicconUser where Email='" + tbEmail.Text.Trim() + "' and Password='" + encryptPass + "'";
            DataTable dataTable = await _sqlHandler.SelectAsync(queryString);
            if (dataTable.Rows.Count >= 1)
            {
                //dataTable.Rows[0][0]-Id
                //dataTable.Rows[0][1]-Email
                //dataTable.Rows[0][2]-Password
                addUserInfo(dataTable.Rows[0][0].ToString(), dataTable.Rows[0][1].ToString());
                Application.Restart();
            }
            else
            {
                lbNotice.Visible = true;
            }

        }

        private void addUserInfo(string userId, string userEmail)
        {
            string content = userId.Trim() + "#" + userEmail.Trim();
            StreamWriter userInfo = new StreamWriter(DicconProp.UserInfoFileName, false);
            userInfo.Write(content);
            userInfo.Close();
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
            topPanel.BackColor = DicconProp.AccentColor;
            btLogin.BackColor = DicconProp.ColorA8;
            btLogOut.BackColor = DicconProp.ColorA8;
            btSave.BackColor = DicconProp.ColorA8;
            btBack.BackColor = DicconProp.ColorA8;
            btCreateNow.BackColor = DicconProp.ColorA8;
            roundedPanel1.BackColor = DicconProp.ColorA9;
            roundedPanel2.BackColor = DicconProp.ColorA9;
            roundedPanel3.BackColor = DicconProp.ColorA9;
            roundedPanel4.BackColor = DicconProp.ColorA9;
            roundedPanel5.BackColor = DicconProp.ColorA9;
            roundedPanel6.BackColor = DicconProp.ColorA9;
            roundedPanel7.BackColor = DicconProp.ColorA9;
            roundedPanel8.BackColor = DicconProp.ColorA9;
            tbEmail.BackColor = DicconProp.ColorA9;
            tbPassword.BackColor = DicconProp.ColorA9;
            editEmail.BackColor = DicconProp.ColorA9;
            editPass_1.BackColor = DicconProp.ColorA9;
            editPass_2.BackColor = DicconProp.ColorA9;
            createEmail.BackColor = DicconProp.ColorA9;
            createPass_1.BackColor = DicconProp.ColorA9;
            createPass_2.BackColor = DicconProp.ColorA9;

            if (DicconProp.UserID != "")
            {
                this.Text = manageAccountText.Text;
                panelLogin.Visible = false;
                panelCreateAccount.Visible = false;
                panelManage.Visible = true;
                panelManage.Dock = DockStyle.Fill;
                panelManage.BringToFront();
                editEmail.Text = DicconProp.UserEmail;
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
            try
            {
                if (File.Exists(DicconProp.UserInfoFileName))
                {
                    File.Delete(DicconProp.UserInfoFileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(DicconProp.LogOutError);
            }
            Application.Restart();
        }

        private void editEmail_TextChanged(object sender, EventArgs e)
        {
            if ((editEmail.Text.Contains("@") && editEmail.Text.Contains(".")) && (editPass_1.Text.Length >= 8 && editPass_1.Text == editPass_2.Text))
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
            DicconProp.RoundedLabel_MouseEnter(sender, e);
        }

        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.RoundedLabel_MouseLeave(sender, e);
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
            string encryptPass = new Sha256Encrypt(createPass_1.Text.Trim()).Hash();
            string queryString = "Insert into dbo.DicconUser(Email, Password) values ('" + createEmail.Text + "','" + encryptPass + "')";
            await _sqlHandler.InsertAsync(queryString);
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
            DicconProp.Control_MouseEnter(sender, e);
        }

        private void btCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            DicconProp.Control_MouseLeave(sender, e);
        }

        private void login_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private async void btDeleteOnline_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to delete your online data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string updateQueryString = "UPDATE dbo.DicconUser  SET Resources = NULL, Timeline = NULL, QA = NULL, FreeAsk = NULL, PayAsk = NULL  Where Id=" + DicconProp.UserID;
                await _sqlHandler.UpdateAsync(updateQueryString);
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelLogin.Dock = DockStyle.Fill;
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void logo_Click_1(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
