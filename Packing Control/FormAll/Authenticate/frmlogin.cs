using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OGA.Packing.Entity.Master;
using OGA.Packing.BLL.Authorization;
using OGA.Helper.Control;
using System.Configuration;
using OGA.Helper.Message;

namespace Packing_Control.FormAll.Authenticate
{
    public partial class frmlogin : Form
    {
        public enum StateProcess
        {
            Login,
            ErrorMsg
        }
        public StateProcess State { get; set; }

        public frmlogin()
        {
            InitializeComponent();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            CheckStateProcess();
            Authorization.UserAuthorization = new List<AuthorizationEntity>();

            lblVersion.Text = "Last version : " + Authorization.GetVersion();
        }

        private void CheckStateProcess()
        {
            switch (this.State)
            {
                case StateProcess.Login:
                    btnClose.Enabled = true;
                    this.ControlBox = true;
                    break;
                case StateProcess.ErrorMsg:
                    btnClose.Enabled = false;
                    this.ControlBox = false;
                    break;
            }
        }

        private bool LogIn()
        {
            bool ret = true;
            Authorization.UserAuthorization = Authorization.UserAuthorization.GetLogInUserInSystem(txtUserID.Text, txtPassword.Text);
            if (Authorization.UserAuthorization.Count == 0)
            {
                MessageBox.Show("ไม่พบ User ID  กรุณาตรวจสอบใหม่อีกครั้ง...!",
                                                    "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtUserID.Focus();
                txtUserID.SelectAll();
                return false;
            }
            else
            {
                if (txtPassword.Text != Authorization.UserAuthorization[0].Password)
                {
                    MessageBox.Show("Password ของคุณผิดกรุณาตรวจสอบใหม่อีกครั้ง...!",
                                        "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    return false;
                }
                else ret = true;
            }


            return ret;
        }


        /// <summary>
        ///  returns true = administrator
        ///  returns false = not administrator
        /// </summary>
        /// <returns></returns>
        private bool CheckAuthenticateAdmin()
        {
            bool ret = false;
            Authorization.UserAuthorization = Authorization.UserAuthorization.GetLogInUserInSystem(txtUserID.Text, txtPassword.Text);
            string userGroup = ConfigurationManager.AppSettings["UserGroup"].ToString();
            if (Authorization.UserAuthorization[0].UserGroupID.ToLower() == userGroup) ret = true;
            else
            {
                MessageBox.Show("คุณไม่ได้รับสิทธิในการปลดล็อคกรุณาตรวจสอบใหม่อีกครั้ง...!",
                                                    "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtUserID.Focus();
                txtUserID.SelectAll();
                return false;
            }

            if (Authorization.UserAuthorization.Count == 0)
            {
                MessageBox.Show("ไม่พบ User ID  กรุณาตรวจสอบใหม่อีกครั้ง...!",
                                                    "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtUserID.Focus();
                txtUserID.SelectAll();
                return false;
            }
            else
            {
                if (txtPassword.Text != Authorization.UserAuthorization[0].Password)
                {
                    MessageBox.Show("Password ของคุณผิดกรุณาตรวจสอบใหม่อีกครั้ง...!",
                                        "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    return false;
                }
                else ret = true;
            }

            return ret;
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogIn.Focus();
                btnLogIn_Click(null, null);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                bool ret = true;

                ret = this.State.Equals(StateProcess.Login) ? LogIn() : CheckAuthenticateAdmin();

                if (ret == true)
                {
                    this.Close();
                }
                else Authorization.UserAuthorization.Clear();
            }
            catch (Exception ex)
            {
                OGAMessage.ShowErrorTryCatch(ex.Message, ex);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
