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
using System.IO;
using OGA.Helper.Message;
using OGA.Helper.Control;

namespace Packing_Control.FormAll.Master
{
    public partial class frmImportPartMaster : Packing_Control.FormAll.FormBase.frmBaseMaster
    {
        List<PartEntity> DisplayAllData = new List<PartEntity>();

        public frmImportPartMaster()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (lblpathformat.Text == "")
            {
                OGAMessage.ShowInformation("กรุณาเลือก Text file ที่ต้องการด้วย...!");
                return;
            }

            DisplayAllData.Clear();
            StreamReader re = File.OpenText(lblpathformat.Text);
            string input = null;
            //string inputs = null;
            string[] split;
            string split2;

            while ((input = re.ReadLine()) != null)
            {
                //Console.WriteLine(input);

                split2 = input.Replace(@"""", "");
                    split = split2.Split('|');
                    if(split.Length == 12) {
                        PartEntity rec = new PartEntity();
                        rec.Model = split[0].Trim();
                        rec.PartNo = split[1].Trim();
                        rec.PartName = split[2].Trim();
                        rec.Country = split[3].Trim();
            
                        rec.STDInnerLot = split[4].Trim().Equals("0") ? 0 : Convert.ToDecimal(split[4].Trim());
                        rec.STDMiddleLot = split[5].Trim().Equals("0") ? 0 : Convert.ToDecimal(split[5].Trim());
                        rec.STDOuterLot = split[6].Trim().Equals("0") ? 0 : Convert.ToDecimal(split[6].Trim());

                        rec.InnerLot = split[7].Trim();
                        rec.MiddleLot = split[8].Trim();
                        rec.OuterLot = split[9].Trim();
                        rec.PartNameTH = split[10].Trim();
                        rec.CountryTH = split[11].Trim();

                    rec.LastupdateBy = Authorization.UserAuthorization[0].UserID;

                        DisplayAllData.Add(rec);
                    }

                   
                

            }
            re.Close();

            dgvShow.AutoGenerateColumns = false;

            bs.DataSource = null;
            bs.DataSource = DisplayAllData;

            dgvShow.DataSource = bs;
            dgvShow.BringToFront();

            this.splitContainer1.Panel2.Enabled = true;
            
        }



        private string OpenDialog()
        {
            string ret = string.Empty;
            OpenFileDialog OPDialog = new OpenFileDialog();

            OPDialog.InitialDirectory = "C:\\";
            OPDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.CSV)|*.CSV|All files (*.*)|*.*";
            OPDialog.FilterIndex = 2;
            OPDialog.RestoreDirectory = true;

            if (OPDialog.ShowDialog() == DialogResult.OK)
            {
                ret = OPDialog.FileName;
            }

            OPDialog.Dispose();
            return ret;
        }

        private void frmImportPartMaster_Load(object sender, EventArgs e)
        {
            SetOfControlKeysEnabled.Add(btnPreview);
            SetOfControlKeysEnabled.Add(btnOpen); 

            lblpathformat.Text = string.Empty;
            EndEdit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            lblpathformat.Text = OpenDialog();
        }

#pragma warning disable CS0108 // 'frmImportPartMaster.btnCancel_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnCancel_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        private void btnCancel_Click(object sender, EventArgs e)
#pragma warning restore CS0108 // 'frmImportPartMaster.btnCancel_Click(object, EventArgs)' hides inherited member 'frmBaseMaster.btnCancel_Click(object, EventArgs)'. Use the new keyword if hiding was intended.
        {
            lblpathformat.Text = string.Empty;
            DisplayAllData.Clear();
            dgvShow.DataSource = null;
            dgvShow.DataSource = bs;
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            lblpathformat.Text = string.Empty;

        }

        private void dgvShow_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AppControl.PrintNumberInDataGridView(dgvShow, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (DisplayAllData.Count == 0)
                {
                    OGAMessage.ShowInformation("ไม่พบข้อมูลที่ต้องการบันทึก...!");
                    return;
                }

                if (OGAMessage.ShowConfirm("ต้องการบันทึกข้อมูล") == DialogResult.Yes)
                {

                    int ret = 0;
                    ret = DisplayAllData.InsertPart();
                    if (ret == 0) OGAMessage.ShowResultSaveComplete();
                    else OGAMessage.ShowResultSaveFailed();

                    DisplayAllData.Clear();
                    dgvShow.DataSource = null;
                    dgvShow.DataSource = bs;
                    //bs.DataSource = null;
                    //bs.DataSource = DisplayAllData;
                    //dgvShow.DataSource = bs;
                    EndEdit();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
