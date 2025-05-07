using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OGA.Packing.Entity.Master;
using OGA.Packing.BLL.Master;
using OGA.Helper.Control;
using OGA.Helper.Message;

namespace Packing_Control.FormAll.Master
{
    public partial class frmLabelType : Packing_Control.FormAll.FormBase.frmBaseMaster
    {
        List<LabelTypeEntity> DisplayAllData = new List<LabelTypeEntity>();

        public frmLabelType()
        {
            InitializeComponent();
        }

        private string OpenDialog()
        {
            string ret = string.Empty;
            OpenFileDialog OPDialog = new OpenFileDialog();

            OPDialog.InitialDirectory = "c:\\";
            OPDialog.Filter = "btw files (*.btw)|*.btw|All files (*.*)|*.*";
            OPDialog.FilterIndex = 2;
            OPDialog.RestoreDirectory = true;

            if (OPDialog.ShowDialog() == DialogResult.OK)
            {
                ret = OPDialog.FileName;
            }

            return ret;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            lblpathformat.Text = OpenDialog();
            
        }

        private void frmLabelType_Load(object sender, EventArgs e)
        {
            AddControlKeysEnabled();
            GetDateAll();
            EndEdit();
        }

        public void GetDateAll()
        {
            dgvShow.AutoGenerateColumns = false;
            DisplayAllData = DisplayAllData.GetLabelTypeAll();
            bs.DataSource = DisplayAllData;
            dgvShow.DataSource = bs;

            dgvShow.BringToFront();
            bnd.SendToBack();
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

        private void AssignObjecttoEmtry()
        {
            txtlabelType.Clear();
            lblpathformat.Text = string.Empty;

        }

        private void AssignDatatoObject()
        {
            ///ค้นหา row Index และทำการ Copy ข้อมูลที่ได้จากการค้นหม
            LabelTypeEntity record = DisplayAllData.Find(delegate(LabelTypeEntity _rec)
            {
                if (_rec.LabelType == dgvShow[0, dgvShow.CurrentRow.Index].Value.ToString())
                {
                    return true;
                }

                return false;

            });

            txtlabelType.Text = record.LabelType;
            lblpathformat.Text = record.Pathformat;

        }

#pragma warning disable CS0108 // 'frmLabelType.btnNew_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnNew_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnNew_Click(object sender, EventArgs e)
#pragma warning restore CS0108 // 'frmLabelType.btnNew_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnNew_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        {
            AssignObjecttoEmtry();
            txtlabelType.Enabled = true;
            txtlabelType.BackColor = Color.White;
        }

#pragma warning disable CS0108 // 'frmLabelType.btnEdit_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnEdit_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnEdit_Click(object sender, EventArgs e)
#pragma warning restore CS0108 // 'frmLabelType.btnEdit_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnEdit_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        {
            SetOfControlKeys(true, Color.White);
            txtlabelType.Enabled = false;
            txtlabelType.BackColor = Color.Silver;
        }

#pragma warning disable CS0108 // 'frmLabelType.btnCancel_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnCancel_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnCancel_Click(object sender, EventArgs e)
#pragma warning restore CS0108 // 'frmLabelType.btnCancel_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnCancel_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        {
            AssignObjecttoEmtry();
        }

        private bool VerifyData()
        {
            if (txtlabelType.Text == string.Empty)
            {
                OGAMessage.ShowValidate("กรุณากรอกข้อมูล label Type...!");
                txtlabelType.Focus();
                return false;
            }

            if (txtlabelType.Text == string.Empty)
            {
                OGAMessage.ShowValidate("กรุณากรอกข้อมูล L...!");
                txtlabelType.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerifyData() == false) return;

                if (OGAMessage.ShowConfirm("ต้องการบันทึกข้อมูล") == DialogResult.Yes)
                {
                    LabelTypeEntity rec = new LabelTypeEntity(txtlabelType.Text.Trim(), lblpathformat.Text,  Authorization.UserAuthorization[0].UserID);

                    int ret = 0;
                    if (State == FormState.New)
                    {
                        /// ตรวจสอบว่ามีข้อมูลหรือยัง
                        if (rec.CheckDuplicateData() != 0)
                        {
                            OGAMessage.ShowErrorDuplicate(rec.LabelType);
                            return;
                        }
                        ret = rec.InsertPart();
                    }
                    else ret = rec.UpdatePart();


                    if (ret == 0) OGAMessage.ShowResultSaveComplete();
                    else OGAMessage.ShowResultSaveFailed();

                    EndEdit();
                    GetDataToControl();
                    AssignObjecttoEmtry();
                    GetDateAll();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShow.CurrentRow.Index == -1) return;
            
            AssignDatatoObject();
        }

        private void txtlabelType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnOpen.Focus();
                btnOpen_Click(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (VerifyData())
            {
                DialogResult dresult = OGAMessage.ShowConfirm("คุณต้องการลบข้อมูล Label Type : " + txtlabelType.Text + " \r\n นี้หรือไม่");
                if (dresult == DialogResult.Yes)
                {
                    string ret = string.Empty;
                    LabelTypeEntity rec = new LabelTypeEntity();
                    rec.LabelType = txtlabelType.Text;
                    rec.Pathformat = lblpathformat.Text;
                    rec.LastupdateBy = this.UserID;
                    ret = rec.DeleteLabelType();
                    OGAMessage.ShowResult(ret);
                    GetDateAll();
                }
            }
        }

    }
}
