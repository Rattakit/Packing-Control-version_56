using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OGA.Packing.Entity.Master;
using OGA.Packing.BLL.Master;
using System.Linq;

namespace Packing_Control.FormAll.Master
{
    public partial class frmPermission : Packing_Control.FormAll.FormBase.frmBaseMaster
    {
        List<PermissionEntity> DisplayPermission = new List<PermissionEntity>();
        List<UserGroupEntity> DisplayUserGroup = new List<UserGroupEntity>();

        public frmPermission()
        {
            InitializeComponent();
        }

        private void frmPermission_Load(object sender, EventArgs e)
        {
            GetDataPermission();
            btnNew_Click(null,null);
        }

        private void GetDataPermission()
        {
            DisplayUserGroup = DisplayUserGroup.GetUserGroupListBYIsActive();
            lsbGroup.DataSource = DisplayUserGroup;
            lsbGroup.DisplayMember = "UserGroupID";
            lsbGroup.ValueMember = "UserGroupID";

            DisplayPermission = DisplayPermission.GetPermissionListAll();

        }

        private void lsbGroup_MouseUp(object sender, MouseEventArgs e)
        {
            if (lsbGroup.SelectedIndex != -1) BindingDatatoControl();
        }

        private void BindingDatatoControl()
        {
            ///Production|Dummy|Testing|Part|Part List|User|Permission|user Group|RS232|Sound|DataBase|Report|
            ///

            var q = from d in DisplayPermission
                    where d.UserGroupID == lsbGroup.SelectedValue.ToString()
                    select d;

            if (q.Count() != 0)
            {
                this.State = FormState.Edit;
                string[] permission;
                foreach (var d in q)
                {
                    permission = d.Permission.Split('|');
                    chkPrintBarcode.Checked = permission[0].Equals("1") ? true : false;

                    chkPart.Checked = permission[1].Equals("1") ? true : false;
                    chkLabelType.Checked = permission[2].Equals("1") ? true : false;

                    chkUser.Checked = permission[3].Equals("1") ? true : false;
                    chkPermission.Checked = permission[4].Equals("1") ? true : false;
                    chkGroup.Checked = permission[5].Equals("1") ? true : false;

                    chkReportScanBarcode.Checked = permission[6].Equals("1") ? true : false;
                    chkImportPart.Checked = permission[7].Equals("1") ? true : false;
                }
            }
            else
            {
                this.State = FormState.New;

                chkPrintBarcode.Checked = false;

                chkPart.Checked = false;
                chkLabelType.Checked = false;

                chkUser.Checked = false;
                chkPermission.Checked = false;
                chkGroup.Checked = false;

                chkReportScanBarcode.Checked = false;

                chkImportPart.Checked = false;
            }

            chkAll.Checked = CheckSelectAll();
        }

        private bool CheckSelectAll()
        {
            bool ret = true;
            if (chkPrintBarcode.Checked.Equals(false))
            {
                ret = false;
                return ret;
            }

            if (chkPart.Checked.Equals(false))
            {
                ret = false;
                return ret;
            }

            if (chkLabelType.Checked.Equals(false))
            {
                ret = false;
                return ret;
            }

            if (chkUser.Checked.Equals(false))
            {
                ret = false;
                return ret;
            }

            if (chkPermission.Checked.Equals(false))
            {
                ret = false;
                return ret;
            }

            if (chkGroup.Checked.Equals(false))
            {
                ret = false;
                return ret;
            }

            if (chkReportScanBarcode.Checked.Equals(false))
            {
                ret = false;
                return ret;
            }
            return ret;
        }

        private string VeriifyPermission()
        {
            string ret = string.Empty;
            ret = chkPrintBarcode.Checked.Equals(true) ? "1|" : "0|";

            ret += chkPart.Checked.Equals(true) ? "1|" : "0|";
            ret += chkLabelType.Checked.Equals(true) ? "1|" : "0|";

            ret += chkUser.Checked.Equals(true) ? "1|" : "0|";
            ret += chkPermission.Checked.Equals(true) ? "1|" : "0|";
            ret += chkGroup.Checked.Equals(true) ? "1|" : "0|";

            ret += chkReportScanBarcode.Checked.Equals(true) ? "1|" : "0|";
            ret += chkImportPart.Checked.Equals(true) ? "1|" : "0|";

            return ret;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lsbGroup.SelectedIndex == -1)
            {
                MessageBox.Show("กรุณาเลือกกลุ่มผู้ใช้งานด้วย...!");
                return;
            }

            PermissionEntity rec = new PermissionEntity();
            rec.UserGroupID = lsbGroup.SelectedValue.ToString();
            rec.Permission = VeriifyPermission();
            rec.LastUpdateBy = Authorization.UserAuthorization[0].UserID;

            int ret = 0;
            if (this.State == FormState.New)
            {
                ret = rec.InsertPermission();
            }
            else if (this.State == FormState.Edit)
            {
                ret = rec.UpdatePermission();
            }

            if (ret != 0) MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล", "คำเตือน",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            else MessageBox.Show("ทำการบันทึกข้อมูลเรียบร้อยแล้ว", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            GetDataPermission();
            btnNew_Click(null, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkAll_MouseUp(object sender, MouseEventArgs e)
        {
            chkPrintBarcode.Checked = !chkPrintBarcode.Checked;

            chkPart.Checked = !chkPart.Checked;
            chkLabelType.Checked = !chkLabelType.Checked;

            chkUser.Checked = !chkUser.Checked;
            chkPermission.Checked = !chkPermission.Checked;
            chkGroup.Checked = !chkGroup.Checked;
            chkImportPart.Checked = !chkImportPart.Checked;

            chkReportScanBarcode.Checked = !chkReportScanBarcode.Checked;
       
        }

        private void lsbGroup_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                BindingDatatoControl();
            }
        }


        private void chkReportScanBarcode_Click(object sender, EventArgs e)
        {
            chkAll.Checked = CheckSelectAll();
        }

        private void chkPart_Click(object sender, EventArgs e)
        {
            chkAll.Checked = CheckSelectAll();
        }

        private void chkLabelType_Click(object sender, EventArgs e)
        {
            chkAll.Checked = CheckSelectAll();
        }

        private void chkUser_Click(object sender, EventArgs e)
        {
            chkAll.Checked = CheckSelectAll();
        }

        private void chkGroup_Click(object sender, EventArgs e)
        {
            chkAll.Checked = CheckSelectAll();
        }

        private void chkPermission_Click(object sender, EventArgs e)
        {
            chkAll.Checked = CheckSelectAll();
        }

        private void chkPrintBarcode_Click(object sender, EventArgs e)
        {
            chkAll.Checked = CheckSelectAll();
        }

        private void chkImportPart_Click(object sender, EventArgs e)
        {
            
                chkAll.Checked = CheckSelectAll();
        }

        private void btnNew_Click_1(object sender, EventArgs e) {

        }

    }
}
