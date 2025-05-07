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
using OGA.Helper.Control;
using OGA.Helper.Message;
#pragma warning disable CS0105 // The using directive for 'OGA.Helper.Control' appeared previously in this namespace
using OGA.Helper.Control;
#pragma warning restore CS0105 // The using directive for 'OGA.Helper.Control' appeared previously in this namespace

namespace Packing_Control.FormAll.Master
{
    public partial class frmPartMaster : frmBaseMaster
    {
        List<PartEntity> DisplayAllData = new List<PartEntity>();
        List<LabelTypeEntity> DisplayInner = new List<LabelTypeEntity>();
        List<LabelTypeEntity> DisplayMiddle = new List<LabelTypeEntity>();
        List<LabelTypeEntity> DisplayOuter = new List<LabelTypeEntity>();


        public frmPartMaster()
        {
            InitializeComponent();
            
        }

        private void pnlButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPartMaster_Load(object sender, EventArgs e)
        {
            AddControlKeysEnabled();
            GetDateAll();
            EndEdit();

            
            //cbxCountry.dis
            //cbxCountry
            nuInnerLot_ValueChanged(null, null);
            nuMiddleLot_ValueChanged (null, null);
            nuOuterLot_ValueChanged(null, null);
        }

        public void GetDateAll()
        {
            dgvShow.AutoGenerateColumns = false;
            DisplayAllData = DisplayAllData.GetPartAll();
            bs.DataSource = DisplayAllData;
            dgvShow.DataSource = bs;

            DisplayInner = DisplayInner.GetLabelTypeAll();
            bsInner.DataSource = DisplayInner;
            cbxTypeinner.DataSource = bsInner;
            cbxTypeinner.DisplayMember = "LabelType";
            cbxTypeinner.ValueMember = "LabelType";
            cbxTypeinner.SelectedIndex = -1;

            DisplayMiddle = new List<LabelTypeEntity>(from d in DisplayInner select d);
            bsMiddle.DataSource = DisplayMiddle;
            cbxTypemiddle.DataSource = bsMiddle;
            cbxTypemiddle.DisplayMember = "LabelType";
            cbxTypemiddle.ValueMember = "LabelType";
            cbxTypemiddle.SelectedIndex = -1;

            DisplayOuter = new List<LabelTypeEntity>(from d in DisplayInner select d);
            bsOuter.DataSource = DisplayOuter;
            cbxTypeouter.DataSource = bsOuter;
            cbxTypeouter.DisplayMember = "LabelType";
            cbxTypeouter.ValueMember = "LabelType";
            cbxTypeouter.SelectedIndex = -1;

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

            txtModel.Clear();
            txtPartNo.Clear();
            txtPartName.Clear();
            txtCoutry.Clear();
            txtPartNameTH.Clear();
            txtCoutryTH.Clear();

            nuInnerLot.Value = 0;
            nuMiddleLot.Value = 0;
            nuOuterLot.Value = 0;

            cbxTypeinner.SelectedIndex = -1;
            cbxTypemiddle.SelectedIndex = -1;
            cbxTypeouter.SelectedIndex = -1;

        }

        private void AssignDatatoObject()
        {
            ///ค้นหา row Index และทำการ Copy ข้อมูลที่ได้จากการค้นหม
            PartEntity record = DisplayAllData.Find(delegate(PartEntity _rec)
            {
                if (_rec.PartNo == dgvShow[1, dgvShow.CurrentRow.Index].Value.ToString())
                {
                    return true;
                }

                return false;

            });

            txtPartNo.Text = record.PartNo;
            txtPartName.Text = record.PartName;
            txtPartNameTH.Text = record.PartNameTH;
            txtModel.Text = record.Model;
            txtCoutry.Text = record.Country;
            txtCoutryTH.Text = record.CountryTH;
            nuInnerLot.Value = record.STDInnerLot;
            nuMiddleLot.Value = record.STDMiddleLot;
            nuOuterLot.Value = record.STDOuterLot;

            cbxTypeinner.SelectedIndex = DisplayInner.FindIndex(x => x.LabelType == record.InnerLot);
            cbxTypemiddle.SelectedIndex = DisplayMiddle.FindIndex(x => x.LabelType == record.MiddleLot);
            cbxTypeouter.SelectedIndex = DisplayOuter.FindIndex(x => x.LabelType == record.OuterLot);

           // cbxTypeinner.SelectedIndex = 

        }

#pragma warning disable CS0108 // 'frmPartMaster.btnNew_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnNew_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnNew_Click(object sender, EventArgs e)
#pragma warning restore CS0108 // 'frmPartMaster.btnNew_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnNew_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        {
            AssignObjecttoEmtry();
            txtPartNo.Enabled = true;
            txtPartNo.BackColor = Color.White;
        }

#pragma warning disable CS0108 // 'frmPartMaster.btnEdit_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnEdit_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnEdit_Click(object sender, EventArgs e)
#pragma warning restore CS0108 // 'frmPartMaster.btnEdit_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnEdit_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        {
            SetOfControlKeys(true, Color.White);
            txtPartNo.Enabled = false;
            txtPartNo.BackColor = Color.Silver;
        }

#pragma warning disable CS0108 // 'frmPartMaster.btnCancel_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnCancel_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnCancel_Click(object sender, EventArgs e)
#pragma warning restore CS0108 // 'frmPartMaster.btnCancel_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnCancel_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        {
            AssignObjecttoEmtry();
        }

        private bool VerifyData()
        {
            if (txtPartNo.Text == string.Empty)
            {
                OGAMessage.ShowValidate("กรุณากรอกข้อมูล ประเภทรถ...!");
                txtPartNo.Focus();
                return false;
            }

            //if (txtModel.Text == string.Empty)
            //{
            //    OGAMessage.ShowValidate("กรุณากรอกข้อมูล Model...!");
            //    txtModel.Focus();
            //    return false;
            //}

            if (nuInnerLot.Value == 0 && nuMiddleLot.Value == 0 && nuOuterLot.Value == 0)
            {
                OGAMessage.ShowValidate("กรุณากรอกข้อมูล Inner Lot หรือ Middle Lot หรือ Outer Lot ...!");
                nuInnerLot.Focus();
                return false;
            }

            if (cbxTypeinner.Text == string.Empty && cbxTypemiddle.Text == string.Empty && cbxTypeouter.Text == string.Empty)
            {
                OGAMessage.ShowValidate("กรุณากรอกข้อมูล Type Inner หรือ Type Middel หรือ Type Outer...!");
                nuMiddleLot.Focus();
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
                    PartEntity rec = new PartEntity();
                    rec.Model = txtModel.Text;
                    rec.PartNo = txtPartNo.Text;
                    rec.Country = txtCoutry.Text;
                    rec.PartName = txtPartName.Text;
                    rec.STDInnerLot = nuInnerLot.Value;
                    rec.STDMiddleLot = nuMiddleLot.Value;
                    rec.STDOuterLot = nuOuterLot.Value;
                    rec.CountryTH = txtCoutryTH.Text;
                    rec.PartNameTH = txtPartNameTH.Text;

                    rec.InnerLot = (cbxTypeinner.SelectedIndex.Equals(-1)) ? string.Empty : cbxTypeinner.SelectedValue.ToString();
                    rec.MiddleLot = (cbxTypemiddle.SelectedIndex.Equals(-1)) ? string.Empty : cbxTypemiddle.SelectedValue.ToString();
                    rec.OuterLot = (cbxTypeouter.SelectedIndex.Equals(-1))?string.Empty : cbxTypeouter.SelectedValue.ToString();
                    rec.LastupdateBy = Authorization.UserAuthorization[0].UserID;

                    int ret = 0;
                    if (State == FormState.New)
                    {
                        /// ตรวจสอบว่ามีข้อมูลหรือยัง
                        if (rec.CheckDuplicateData() != 0)
                        {
                            OGAMessage.ShowErrorDuplicate(rec.PartNo);
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

        private void nuInnerLot_ValueChanged(object sender, EventArgs e)
        {
            if (nuInnerLot.Value > 0)
            {
                cbxTypeinner.Enabled = true;
                cbxTypeinner.BackColor = Color.White;
            }
            else
            {
                cbxTypeinner.Enabled = false;
                cbxTypeinner.BackColor = Color.Silver;
                cbxTypeinner.SelectedIndex = -1;
            }
        }

        private void nuMiddleLot_ValueChanged(object sender, EventArgs e)
        {
            if (nuMiddleLot.Value > 0)
            {
                cbxTypemiddle.Enabled = true;
                cbxTypemiddle.BackColor = Color.White;
            }
            else
            {
                cbxTypemiddle.Enabled = false;
                cbxTypemiddle.BackColor = Color.Silver;
                cbxTypemiddle.SelectedIndex = -1;
            }
        }
        
        private void nuOuterLot_ValueChanged(object sender, EventArgs e)
        {
            if (nuOuterLot.Value > 0)
            {
                cbxTypeouter.Enabled = true;
                cbxTypeouter.BackColor = Color.White;
            }
            else
            {
                cbxTypeouter.Enabled = false;
                cbxTypeouter.BackColor = Color.Silver;
                cbxTypeouter.SelectedIndex = -1;
            }
        }

        private void txtModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPartNo.Focus();
                txtPartNo.SelectAll();
            }
        }

        private void txtPartNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtPartName.Focus();
                txtPartName.SelectAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (VerifyData())
            {
                DialogResult dresult = OGAMessage.ShowConfirm("คุณต้องการลบข้อมูล Part No : " + txtPartNo.Text + " \r\n นี้หรือไม่");
                if (dresult == DialogResult.Yes)
                {
                    string ret = string.Empty;
                    PartEntity rec = new PartEntity();
                    rec.Model = txtModel.Text;
                    rec.PartNo = txtPartNo.Text;
                    ret = rec.DeletePart();

                    OGAMessage.ShowResult(ret);
                    
                    GetDateAll();
                }
            }
        }

        private void txtPartName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtCoutry.Focus();
                txtCoutry.SelectAll();
            }
        }

        private void txtPartNameTH_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                txtCoutryTH.Focus();
                txtCoutryTH.SelectAll();
            }
        }

        private void middleLotLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
