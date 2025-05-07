using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Packing_Control.FormAll.FormBase;
using OGA.Packing.Entity.Master;
using OGA.Packing.BLL.Master;

namespace Packing_Control.FormAll.Master {
    public partial class frmGroup : frmBaseMaster {
#pragma warning disable CS0414 // The field 'frmGroup.Current_row' is assigned but its value is never used
        private int Current_row = 0;
#pragma warning restore CS0414 // The field 'frmGroup.Current_row' is assigned but its value is never used
        private List<UserGroupEntity> DisplayGroupUserList = new List<UserGroupEntity>();

        private UserGroupEntity recordUserGroupList = new UserGroupEntity();


        public frmGroup() {
            InitializeComponent();
        }

        private void AssignEmtrytoControl() {
            foreach (Control s in splitContainer1.Panel1.Controls) {
                if (s is TextBox) {
                    s.Text = string.Empty;
                }
            }

            txtUGID.Enabled = true;
            chkIsActive.Checked = true;
            recordUserGroupList = null;
        }

        private void AddControlKeysEnabled() {
            foreach (Control ctrl in this.splitContainer1.Panel1.Controls) {
                if (ctrl is Label || ctrl is Panel) continue;
                else {
                    SetOfControlKeysEnabled.Add(ctrl);
                }
            }
        }

        private void AssignUserGroupListtoControlText() {
            dgvShow.AutoGenerateColumns = false;

            UserGroupEntity record = DisplayGroupUserList.Find(delegate(UserGroupEntity _rec) {
                if (_rec.UserGroupID == dgvShow[0, dgvShow.CurrentRow.Index].Value.ToString()) {
                    return true;
                }

                return false;

            });

            //Current_row = DisplayGroupUserList.FindIndex(f => f.UserGroupID == dgvShow[0, dgvShow.CurrentRow.Index].Value.ToString());
            //if (Current_row != -1) {
                txtUGID.Text = record.UserGroupID;
                txtUGName.Text = record.UserGroupDescription;
                chkIsActive.Checked = record.IsActive;
            //}
        }

        private void AssignControltoUserGroupEntity() {
            recordUserGroupList.UserGroupID = txtUGID.Text;
            recordUserGroupList.UserGroupDescription = txtUGName.Text;
            recordUserGroupList.IsActive = chkIsActive.Checked.Equals(true) ? true : false;
            recordUserGroupList.LastUpdateBy = Authorization.UserAuthorization[0].UserID;
        }

        private void GetData() {
            dgvShow.AutoGenerateColumns = false;
            DisplayGroupUserList = DisplayGroupUserList.GetUserGroupListAll();
            bnd.BindingSource = bs;
            bs.DataSource = DisplayGroupUserList;
            dgvShow.DataSource = bs;

        }

        private void frmGroup_Load(object sender, EventArgs e) {
            AddControlKeysEnabled();
            AssignEmtrytoControl();
            GetData();
            EndEdit();
            dgvShow.BringToFront();
            
        }

#pragma warning disable CS0108 // 'frmGroup.btnNew_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnNew_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnNew_Click(object sender, EventArgs e) {
            BeginEdit();
            AssignEmtrytoControl();
            txtUGID.Focus();
            txtUGID.SelectAll();
        }
#pragma warning restore CS0108 // 'frmGroup.btnNew_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnNew_Click(object, EventArgs)'. Use the new keyword if hiding was intended.

#pragma warning disable CS0108 // 'frmGroup.btnEdit_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnEdit_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnEdit_Click(object sender, EventArgs e) {
            
            BeginEdit();
            //AssignUserGroupListtoControlText();
            SetOfControlKeys(true, Color.White);
            txtUGID.Enabled = false;
        }
#pragma warning restore CS0108 // 'frmGroup.btnEdit_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnEdit_Click(object, EventArgs)'. Use the new keyword if hiding was intended.

        private bool verifyData() {
            if (txtUGID.Text == string.Empty) {
                MessageBox.Show("กรุณาป้อนข้อมูลรหัสกลุ่มผู้ใช้งาน ...!", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtUGName.Text == string.Empty) {
                MessageBox.Show("กรุณาป้อนข้อมูลชื่อกลุ่มผู้ใช้งาน ...!", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (!verifyData()) return;
            if (MessageBox.Show("คุณต้องการบันทึกรายการ หรือไม่ [Y/N]", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Information,
                                                MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            recordUserGroupList = new UserGroupEntity();
            AssignControltoUserGroupEntity();
            int ret = 0;
            if (this.State == FormState.New) {
                if (recordUserGroupList.GetUserGroupListDuplicateBYUserGroupID(recordUserGroupList.UserGroupID) != 0) {
                    MessageBox.Show(string.Format("{0} : {1} นี มีอยู่แล้วในระบบ!", recordUserGroupList.UserGroupID, recordUserGroupList.UserGroupDescription), "คำเตือน",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    return;
                }
                ret = recordUserGroupList.InsertUserGroup();
            } else if (this.State == FormState.Edit) {
                ret = recordUserGroupList.UpdateUserGrouptList();
            }

            if (ret != 0) MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล", "คำเตือน",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            else MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            AssignEmtrytoControl();
            GetData();
            EndEdit();

        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtUGID_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                txtUGName.Focus();
                txtUGName.SelectAll();
            }
        }

        private void txtUGName_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                btnSave.Focus();
                btnSave_Click(null, null);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e) {
            AssignEmtrytoControl();
            EndEdit();
        }

        private void btnNew_Click_1(object sender, EventArgs e) {

        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e) {
            AssignUserGroupListtoControlText();
        }


    }
}
