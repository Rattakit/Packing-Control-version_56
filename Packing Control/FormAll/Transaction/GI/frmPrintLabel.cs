using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OGA.Packing.Entity.Master;
using OGA.Packing.BLL.Master;
using OGA.Packing.Entity.Transaction.GI;
using OGA.Packing.BLL.Transaction.GI;
using OGA.Helper.Message;

namespace Packing_Control.FormAll.Transaction.GI
{
    public partial class frmPrintLabel : Packing_Control.FormAll.FormBase.frmBaseMaster
    {
        List<PartEntity> DisplayAllPart = new List<PartEntity>();
        List<PrintlabelEntity> DisplayAllData = new List<PrintlabelEntity>();
        List<PrintBarcodeEntity> RecordBarcode = new List<PrintBarcodeEntity>();
        public frmPrintLabel()
        {
            InitializeComponent();
        }

        private void frmPrintLabel_Load(object sender, EventArgs e)
        {
            AddControlKeysEnabled();
            GetDateAll();
            EndEdit();

            lblModel.ForeColor = Color.Blue;
            txtLotno.ForeColor = Color.Blue;

        }

        public void GetDateAll()
        {
            dgvShow.AutoGenerateColumns = false;
            DisplayAllData = DisplayAllData.GetPrintLabelAll();
            bs.DataSource = DisplayAllData;
            //bnd.DataBindings = bs;
            dgvShow.DataSource = bs;

            DisplayAllPart = DisplayAllPart.GetPartAll();
            bsPart.DataSource = DisplayAllPart;
            cbxpartNo.DataSource = bsPart;
            cbxpartNo.DisplayMember = "PartNo";
            cbxpartNo.ValueMember = "PartNo";
            cbxpartNo.SelectedIndex = -1;


            dgvShow.BringToFront();
            bnd.SendToBack();
        }

        private void AddControlKeysEnabled()
        {
            SetOfControlKeysEnabled.Add(cbxpartNo);
            SetOfControlKeysEnabled.Add(nuqTY);
            SetOfControlKeysEnabled.Add(dtpprintDatetime);
            SetOfControlKeysEnabled.Add(chkRepack);
            SetOfControlKeysEnabled.Add(btnCala);
        }

        private void AssignObjecttoEmtry()
        {

            cbxpartNo.SelectedIndex = -1;
            lblpartName.Text = string.Empty;
            lblModel.Text = string.Empty;
            lblcountry.Text = string.Empty;
            
            nuqTY.Value = 0;
            txtLotno.Text = string.Empty;
            txtLotno.Enabled = true;
            chkRepack.Checked = false;
            lblSTDInnerLot.Text = "0";
            lblSTDMiddleLot.Text = "0";
            lblSTDOuterLot.Text = "0";
            

            lbltypeInnerLot.Text = string.Empty;
            lbltypeMiddleLot.Text = string.Empty;
            lbltypeOuterLot.Text = string.Empty;

            lblcopieInner.Text = "0";
            lblcopieMiddle.Text = "0";
            lblcopieOuter.Text = "0";

            lblnotFullSTDInner.Text = "0";
            lblnotFulSTDMiddle.Text = "0";
            lblnotFulSTDOuter.Text = "0";
            lblpartNameTH.Text = string.Empty;
            lblcountryTH.Text = string.Empty;
           
        }

        private PrintlabelEntity AssignDatatoObject()
        {
            ///ค้นหา row Index และทำการ Copy ข้อมูลที่ได้จากการค้นหม
            return DisplayAllData.Find(delegate(PrintlabelEntity _rec)
            {
                if (_rec.PartNo == dgvShow[0, dgvShow.CurrentRow.Index].Value.ToString())
                {
                    return true;
                }

                return false;

            });

        }

#pragma warning disable CS0108 // 'frmPrintLabel.btnNew_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnNew_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnNew_Click(object sender, EventArgs e)
#pragma warning restore CS0108 // 'frmPrintLabel.btnNew_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnNew_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        {
            AssignObjecttoEmtry();
            btnCala.Enabled = false;
            btnSave.Enabled = false;
    
        }

#pragma warning disable CS0108 // 'frmPrintLabel.btnCancel_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnCancel_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnCancel_Click(object sender, EventArgs e)
#pragma warning restore CS0108 // 'frmPrintLabel.btnCancel_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnCancel_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        {
            AssignObjecttoEmtry();
            txtLotno.Enabled = false;
        }

        private bool VerifyData()
        {
            if (cbxpartNo.Text == string.Empty)
            {
                OGAMessage.ShowValidate("กรุณากรอกข้อมูล Part...!");
                cbxpartNo.Focus();
                return false;
            }

            if (nuqTY.Value == 0)
            {
                OGAMessage.ShowValidate("กรุณากรอกข้อมูล Qty...!");
                nuqTY.Focus();
                return false;
            }
            if (txtLotno.Text == "") {
                OGAMessage.ShowValidate("กรุณากรอกข้อมูลให้ถูกต้อง ...!");
                nuqTY.Focus();
                return false;
            }




            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {
                decimal qty = nuqTY.Value;
                decimal stdInnerLot = decimal.Parse(lblSTDInnerLot.Text.ToString());
                decimal stdMiddleLot = decimal.Parse(lblSTDMiddleLot.Text.ToString());
                decimal stdOuterLot = decimal.Parse(lblSTDOuterLot.Text.ToString());

                ///วิธีการคำนวน Copies & not full std
                //decimal intCoiesInner = Math.Floor(qty / stdInnerLot);
                //decimal intCoiesMiddle = Math.Floor(qty / stdMiddleLot);
                //decimal intCoiesOuter = Math.Floor(qty / stdOuterLot);

                //decimal intNotStdInner = qty % stdInnerLot;
                //decimal intNotStdMiddle = qty % stdMiddleLot;
                //decimal intNotStdOuter = qty % stdOuterLot;

                //string strMessage = string.Format("intCoiesInner: {0}\tintNotStdInner: {1}\nintCoiesMiddle: {2}\tintNotStdMiddle: {3}\nintCoiesOuter: {4}\tintNotStdOuter: {5}",
                //    intCoiesInner, intNotStdInner, intCoiesMiddle, intNotStdMiddle, intCoiesOuter, intNotStdOuter);

                //MessageBox.Show(strMessage);

                CalaLotno(sender, e);

                if (VerifyData() == false) return;

                if (OGAMessage.ShowConfirm("ต้องการบันทึกข้อมูล") == DialogResult.Yes)
                {
                    List<PrintlabelEntity> record = new List<PrintlabelEntity>();


                    if (lblSTDInnerLot.Text != "0" && lbltypeInnerLot.Text != string.Empty)
                    {
                        PrintlabelEntity rec = new PrintlabelEntity();
                        rec.Model = lblModel.Text;
                        rec.PartNo = cbxpartNo.Text;
                        rec.PartName = lblpartName.Text;
                        rec.Country = lblcountry.Text;
                        rec.Qty = nuqTY.Value;
                        rec.LotNo = txtLotno.Text;
                        rec.PrintDatetime = dtpprintDatetime.Value;
                        rec.TypeLabel = "InnerLot";
                        rec.STDLot =  (lblSTDInnerLot.Text.Equals("0")) ? 0 : Convert.ToDecimal(lblSTDInnerLot.Text);
                        rec.TypeLot = lbltypeInnerLot.Text;
                        rec.Copie = Math.Floor(qty / stdInnerLot);
                        rec.NotFullSTD = (qty % stdInnerLot);
                        rec.LastupdateBy = Authorization.UserAuthorization[0].UserID;
                        rec.PartNameTH = lblpartNameTH.Text;
                        rec.CountryTH = lblcountryTH.Text;
                        record.Add(rec);
                    }

                    if (lblSTDMiddleLot.Text != "0" && lbltypeMiddleLot.Text != string.Empty)
                    {
                        PrintlabelEntity rec = new PrintlabelEntity();
                        rec.Model = lblModel.Text;
                        rec.PartNo = cbxpartNo.Text;
                        rec.PartName = lblpartName.Text;
                        rec.Country = lblcountry.Text;
                        rec.Qty = nuqTY.Value;
                        rec.LotNo = txtLotno.Text;
                        rec.PrintDatetime = dtpprintDatetime.Value;
                        rec.TypeLabel = "MiddleLot";
                        rec.STDLot = (lblSTDMiddleLot.Text.Equals("0")) ? 0 : Convert.ToDecimal(lblSTDMiddleLot.Text);
                        rec.TypeLot = lbltypeMiddleLot.Text;
                        rec.Copie = Math.Floor(qty / stdMiddleLot);
                        rec.NotFullSTD = (qty % stdMiddleLot);
                        rec.LastupdateBy = Authorization.UserAuthorization[0].UserID;
                        rec.PartNameTH = lblpartNameTH.Text;
                        rec.CountryTH = lblcountryTH.Text;
                        record.Add(rec);
                    }

                    if (lblSTDOuterLot.Text != "0" && lbltypeOuterLot.Text != string.Empty)
                    {
                        PrintlabelEntity rec = new PrintlabelEntity();
                        rec.Model = lblModel.Text;
                        rec.PartNo = cbxpartNo.Text;
                        rec.PartName = lblpartName.Text;
                        rec.Country = lblcountry.Text;
                        rec.Qty = nuqTY.Value;
                        rec.LotNo = txtLotno.Text;
                        rec.PrintDatetime = dtpprintDatetime.Value;
                        rec.TypeLabel = "OuterLot";
                        rec.STDLot = (lblSTDOuterLot.Text.Equals("0")) ? 0 : Convert.ToDecimal(lblSTDOuterLot.Text);
                        rec.TypeLot = lbltypeOuterLot.Text;
                        rec.Copie = Math.Floor(qty / stdOuterLot);
                        rec.NotFullSTD = (qty % stdOuterLot);
                        rec.LastupdateBy = Authorization.UserAuthorization[0].UserID;
                        rec.PartNameTH = lblpartNameTH.Text;
                        rec.CountryTH = lblcountryTH.Text;
                        record.Add(rec);
                    }
                
                    //RecordBarcode

                    int ret = 0;
                    if (State == FormState.New)
                    {
                        ret = record.InsertPrintLabel();
                    }
                    //else ret = AssignDatatoObject().RePrintLabel(RecordBarcode);


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
                OGAMessage.ShowErrorTryCatch(ex.Message, ex);
            }
        }

        private PrintBarcodeEntity addprintbarcode(string PartNo, string PartName, string LotNo
                                                                    , decimal stdpack, decimal numerbarcode, string pathbarcode, string coutry, string LabelType, string PartNameTH, string coutryTH)
        {
            PrintBarcodeEntity recbarcode = new PrintBarcodeEntity();
            recbarcode.PartNo = PartNo;
            recbarcode.PartName = PartName;
            recbarcode.STDPack = stdpack;
            recbarcode.LotNo = LotNo;
            recbarcode.Barcode = numerbarcode;
            recbarcode.PathBarcode = pathbarcode;
            recbarcode.Coutry = coutry;
            recbarcode.LabelType = LabelType;
            recbarcode.PartNameTH = PartNameTH;
            recbarcode.CoutryTH = coutryTH;
            return recbarcode;
        }

        private void cbxpartNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ///ค้นหา row Index และทำการ Copy ข้อมูลที่ได้จากการค้นหม
            PartEntity record = DisplayAllPart.Find(delegate(PartEntity _rec)
            {
                if (_rec.PartNo == cbxpartNo.SelectedValue.ToString())
                {
                    return true;
                }

                return false;

            });

            lblModel.Text = record.Model;
            lblpartName.Text = record.PartName;
            lblcountry.Text = record.Country;
            lblSTDInnerLot.Text = record.STDInnerLot.ToString();
            lblSTDMiddleLot.Text = record.STDMiddleLot.ToString();
            lblSTDOuterLot.Text = record.STDOuterLot.ToString();

            lbltypeInnerLot.Text = record.InnerLot.ToString();
            lbltypeMiddleLot.Text = record.MiddleLot.ToString();
            lbltypeOuterLot.Text = record.OuterLot.ToString();
            lblpartNameTH.Text = record.PartNameTH;
            lblcountryTH.Text = record.CountryTH;
            nuqTY.Focus();
            nuqTY.Select();
            //btnCala.Enabled = true;
            btnSave.Enabled = true;

        }

        private void nuqTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dtpprintDatetime.Focus();
            }
        }

        private void btnCala_Click(object sender, EventArgs e) {
            try {
                if (nuqTY.Value == 0) {
                    OGAMessage.ShowInformation("กรุณาป้อน Qty ด้วย...");
                    return;
                }
                decimal stdinner = Convert.ToDecimal(lblSTDInnerLot.Text);
                decimal stdmiddle = Convert.ToDecimal(lblSTDMiddleLot.Text);
                decimal stdouter = Convert.ToDecimal(lblSTDOuterLot.Text);

                decimal copieinner = 0;
                decimal copiemiddle = 0;
                decimal copieouter = 0;

                txtLotno.Text = PrintLabelBLL.GetLotNo(dtpprintDatetime.Value, chkRepack.Checked);
                if (stdinner != 0) {
                    copieinner = nuqTY.Value / stdinner;
                    lblcopieInner.Text = copieinner.ToString();

                    lblnotFullSTDInner.Text = PrintLabelBLL.Calcu(nuqTY.Value, stdinner).ToString();
                    lblcopieInner.Text = Math.Floor(copieinner).ToString();

                }

                if (stdmiddle != 0) {
                    copiemiddle = nuqTY.Value / stdmiddle;
                    lblcopieMiddle.Text = copiemiddle.ToString();


                    lblnotFulSTDMiddle.Text = PrintLabelBLL.Calcu(nuqTY.Value, stdmiddle).ToString();
                    lblcopieMiddle.Text = Math.Floor(copiemiddle).ToString();
                }

                if (stdouter != 0) {
                    copieouter = Math.Floor(nuqTY.Value / stdouter);
                    lblcopieOuter.Text = copieouter.ToString();

                    if (copieouter == 0) {
                        if ((nuqTY.Value / stdouter) < stdouter) {
                            lblnotFulSTDOuter.Text = nuqTY.Value.ToString();
                        } else lblnotFulSTDOuter.Text = (PrintLabelBLL.Calcu(nuqTY.Value, stdouter)).ToString();
                    } else lblnotFulSTDOuter.Text = (nuqTY.Value - (copieouter * Math.Floor(stdouter))).ToString();


                    lblcopieOuter.Text = Math.Floor(copieouter).ToString();
                }

                btnSave.Enabled = true;
            } catch (Exception ex) {
                OGAMessage.ShowErrorTryCatch(ex.Message, ex);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShow.RowCount == 0) return;

            try
            {
                PrintlabelEntity rec = null;
                //print Bacode Inner
                if (e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                    ///ค้นหา row Index และทำการ Copy ข้อมูลที่ได้จากการค้นหม
                    rec = DisplayAllData.Find(delegate(PrintlabelEntity _rec)
                    {
                        if (_rec.ID == (int)dgvShow["ID", e.RowIndex].Value)
                        {
                            return true;
                        }

                        return false;

                    });

                    string errorMsg = String.Empty;

                    if (rec.Copie != 0)
                    {
                        RecordBarcode.Clear();
                        RecordBarcode.Add(addprintbarcode(rec.PartNo, rec.PartName, rec.LotNo, rec.STDLot
                                                                , rec.Copie, "", rec.Country, rec.TypeLot, rec.PartNameTH, rec.CountryTH));
                        
                        int ret = rec.UpdatePrintLabel(RecordBarcode, ref errorMsg);
                        if (ret != 0) MessageBox.Show(errorMsg);
                    }

                    if (rec.NotFullSTD != 0)
                    {
                        RecordBarcode.Clear();
                         RecordBarcode.Add(addprintbarcode(rec.PartNo, rec.PartName, rec.LotNo, rec.NotFullSTD
                                                                , 1, "", rec.Country, rec.TypeLot, rec.PartNameTH , rec.CountryTH));
                        
                        int ret = rec.UpdatePrintLabel(RecordBarcode, ref errorMsg);
                        if (ret != 0) MessageBox.Show(errorMsg);
                    }

                    GetDateAll();
                    RecordBarcode.Clear();

                }
            }
            catch (Exception ex)
            {
                OGAMessage.ShowErrorTryCatch(ex.Message, ex);
            }

        }



        private void CheckLotno() {
            try {
                if (txtLotno.Text.Length == 6) {
                    string e = txtLotno.Text.Substring(0, 2).ToString();
                    string f = txtLotno.Text.Substring(2, 4).ToString();
                    if (int.Parse(e) > 12) {
                        //OGAMessage.ShowInformation("กรอกเดือนไม่ถูกต้อง ...");
                        txtLotno.Text = "";
                    } else {
                        string ef = e + "/" + f;
                        txtLotno.Text = ef;
                    }


                } else if (txtLotno.Text.Length == 8) {
                    // txtLotno.Text = txtLotno.Text.Split(txtLotno.Text[2]) + "/" + txtLotno.Text.Split(txtLotno.Text[6]);
                    string a = txtLotno.Text.Substring(0,2).ToString();
                    string b = txtLotno.Text.Substring(2, 2).ToString();
                    string c = txtLotno.Text.Substring(4, 4).ToString();

                    if(int.Parse(a) > 31 || int.Parse(b) > 12) {
                        txtLotno.Text = "";
                    } else {
                        string abc = a + "/" + b + "/" + c;
                        txtLotno.Text = abc;
                    }

                } else {
                    txtLotno.Text = "";
                    // OGAMessage.ShowInformation("กรุณากรอกข้อมูลให้ครบ ด้วย...");
                }

            } catch (Exception ex) {
                OGAMessage.ShowErrorTryCatch(ex.Message, ex);
            }

        }



        private void CalaLotno(object sender, EventArgs e) {
            try {

                decimal stdinner = Convert.ToDecimal(lblSTDInnerLot.Text);
                decimal stdmiddle = Convert.ToDecimal(lblSTDMiddleLot.Text);
                decimal stdouter = Convert.ToDecimal(lblSTDOuterLot.Text);

                decimal copieinner = 0;
                decimal copiemiddle = 0;
                decimal copieouter = 0;

                //       txtLotno.Text = PrintLabelBLL.GetLotNo(dtpprintDatetime.Value, chkRepack.Checked);
                CheckLotno();

                if (stdinner != 0) {
                    copieinner = nuqTY.Value / stdinner;
                    lblcopieInner.Text = copieinner.ToString();

                    lblnotFullSTDInner.Text = PrintLabelBLL.Calcu(nuqTY.Value, stdinner).ToString();
                    lblcopieInner.Text = Math.Floor(copieinner).ToString();

                }

                if (stdmiddle != 0) {
                    copiemiddle = nuqTY.Value / stdmiddle;
                    lblcopieMiddle.Text = copiemiddle.ToString();


                    lblnotFulSTDMiddle.Text = PrintLabelBLL.Calcu(nuqTY.Value, stdmiddle).ToString();
                    lblcopieMiddle.Text = Math.Floor(copiemiddle).ToString();
                }

                if (stdouter != 0) {
                    copieouter = Math.Floor(nuqTY.Value / stdouter);
                    lblcopieOuter.Text = copieouter.ToString();

                    if (copieouter == 0) {
                        if ((nuqTY.Value / stdouter) < stdouter) {
                            lblnotFulSTDOuter.Text = nuqTY.Value.ToString();
                        } else lblnotFulSTDOuter.Text = (PrintLabelBLL.Calcu(nuqTY.Value, stdouter)).ToString();
                    } else lblnotFulSTDOuter.Text = (nuqTY.Value - (copieouter * Math.Floor(stdouter))).ToString();


                    lblcopieOuter.Text = Math.Floor(copieouter).ToString();
                }

   
            } catch (Exception ex) {
                OGAMessage.ShowErrorTryCatch(ex.Message, ex);
            }

        }

        private void txtLotno_KeyPress(object sender, KeyPressEventArgs e) {

 

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) ) {
                e.Handled = true;
            }

        }

    }
}
