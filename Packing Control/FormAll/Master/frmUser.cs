using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Packing_Control.FormAll.FormBase;

using OGA.Packing.BLL.Master;
using OGA.Packing.Entity.Master;

namespace Packing_Control.FormAll.Master
{
    public partial class frmUser : frmBaseMaster
    {
#pragma warning disable CS0414 // The field 'frmUser.Current_row' is assigned but its value is never used
        private int Current_row = 0;
#pragma warning restore CS0414 // The field 'frmUser.Current_row' is assigned but its value is never used
        private List<UserGroupEntity> DisplayGroupUserList = new List<UserGroupEntity>();
        private List<UserEntity> DisplayUserList = new List<UserEntity>();

        private UserEntity recordUserList = new UserEntity();


        public frmUser()
        {
            InitializeComponent();
        }

        private void AssignEmtrytoControl()
        {
            foreach (Control s in splitContainer1.Panel1.Controls)
            {
                if (s is TextBox)
                {
                    s.Text = string.Empty;
                }
            }
            chkIsActive.Checked = true;
        }

        private void AddControlKeysEnabled()
        {
            foreach (Control ctrl in this.splitContainer1.Panel1.Controls)
            {
                if (ctrl is Label || ctrl is Panel) continue;
                else
                {
                    SetOfControlKeysEnabled.Add(ctrl);
                }
            }
        }

        private void AssignUserListtoControl()
        {
            UserEntity record = DisplayUserList.Find(delegate(UserEntity _rec) {
                if (_rec.UserID == dgvShow[1, dgvShow.CurrentRow.Index].Value.ToString()) {
                    return true;
                }

                return false;

            });

            cbxGroup.SelectedIndex = DisplayGroupUserList.FindIndex(x => x.UserGroupID == record.UserGroupID);
            txtId.Text = record.UserID;
            txtPassword.Text = record.Password;
            txtConfirmPassword.Text = record.Password;
            txtName.Text = record.FirstName;
            txtSurname.Text = record.LastName;
            chkIsActive.Checked = record.IsActive;
        }

        private void AssignControltoUserEntity()
        {
            recordUserList.UserGroupID = cbxGroup.SelectedValue.ToString();
            recordUserList.UserID = txtId.Text;
            recordUserList.Password = txtPassword.Text;
            // recordUserList.Password = txtConfirmPassword.Text;
            recordUserList.FirstName = txtName.Text;
            recordUserList.LastName = txtSurname.Text;
            recordUserList.IsActive = chkIsActive.Checked.Equals(true) ? true : false;
            recordUserList.LastUpdateBy = Authorization.UserAuthorization[0].UserID;
        }

        private void GetData()
        {
            DisplayGroupUserList = DisplayGroupUserList.GetUserGroupListAll();
            cbxGroup.DataSource = DisplayGroupUserList;
            cbxGroup.DisplayMember = "UserGroupDescription ";
            cbxGroup.ValueMember = "UserGroupID";
            cbxGroup.SelectedIndex = -1;

            dgvShow.AutoGenerateColumns = false;
            DisplayUserList = DisplayUserList.GetUserListAll();
            bs.DataSource = DisplayUserList;
            dgvShow.DataSource = bs;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            AssignEmtrytoControl();
            GetData();
            AddControlKeysEnabled();
            EndEdit();
            dgvShow.BringToFront();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            BeginEdit();
            AssignEmtrytoControl();

            cbxGroup.Focus();
            txtId.Enabled = true;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
           // if (dgvShow.CurrentRow.Index == -1) return;

            txtId.Enabled = false;
            BeginEdit();
           // AssignUserListtoControl();
            SetOfControlKeys(true, Color.White);
        }

        private bool verifyData()
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("กรุณาป้อนข้อมูลรหัสผู้ใช้งาน ...!", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbxGroup.Text == string.Empty && cbxGroup.SelectedIndex == -1)
            {
                MessageBox.Show("กรุณาป้อนข้อมูลชื่อกลุ่มผู้ใช้งาน ...!", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("กรุณาป้อนข้อมูลรหัสผ่าน ...!", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtConfirmPassword.Text == string.Empty)
            {
                MessageBox.Show("กรุณาป้อนข้อมูลยืนยันรหัสผ่าน ...!", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("กรุณาป้อนข้อมูลยืนยันรหัสผ่านไม่ถูกต้อง ...!", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!verifyData()) return;
            if (MessageBox.Show("คุณต้องการบันทึกรายการ หรือไม่ [Y/N]", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            recordUserList = new UserEntity();
            AssignControltoUserEntity();
            int ret = 0;
            if (this.State ==  FormState.New)
            {
                if (recordUserList.GetUserListDuplicateBYUserID(recordUserList.UserID) != 0)
                {
                    MessageBox.Show(string.Format("{0} : {1} นี มีอยู่แล้วในระบบ!", recordUserList.UserID, recordUserList.FirstName), "คำเตือน",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    return;
                }
                ret = recordUserList.InsertUserList();
            }
            else if (this.State == FormState.Edit)
            {
                ret = recordUserList.UpdateUsertList();
            }

            if (ret != 0) MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล", "คำเตือน",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            else MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            AssignEmtrytoControl();
            GetData();
            EndEdit();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดหน้าหรือไม[Y/N]", "คำเตือน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxGroup_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
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
                txtConfirmPassword.Focus();
                txtConfirmPassword.SelectAll();
            }
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtName.Focus();
                txtName.SelectAll();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtSurname.Focus();
                txtSurname.SelectAll();
            }
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                chkIsActive.Focus();
                // chkIsActive.SelectAll();
            }
        }

        private void dgvShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit_Click(sender, e);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            EndEdit();
            AssignEmtrytoControl();
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e) {
            AssignUserListtoControl();
        }

    }
}
