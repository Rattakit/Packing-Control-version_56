using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OGA.Helper.Control;
using OGA.Helper.Message;
using OGA.Packing.Entity.Transaction.GI;
using OGA.Packing.BLL.Transaction.GI;
using ConSOH.IO;



namespace Packing_Control.FormAll.Report
{
    public partial class frmPrintllabelReport : Packing_Control.FormAll.FormBase.frmBase
    {
        List<PrintlabelEntity> DisplayAllData = new List<PrintlabelEntity>();
        public frmPrintllabelReport()
        {
            InitializeComponent();
        }

        private void dgvShow_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AppControl.PrintNumberInDataGridView(dgvShow, e);
        }

        private void frmPrintllabelReport_Load(object sender, EventArgs e)
        {
            dgvShow.BringToFront();
        }
        
        public void GetDateAll()
        {
            dgvShow.AutoGenerateColumns = false;
            DisplayAllData = PrintLabelBLL.GetPrintLabelfromDatetime(dtpbegDate.Value, dtpEndDatetime.Value);
            bs.DataSource = DisplayAllData;
            dgvShow.DataSource = bs;

            dgvShow.BringToFront();
            bnd.SendToBack();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                GetDateAll();
            }
            catch (Exception ex)
            {
                OGAMessage.ShowErrorTryCatch(ex.Message, ex);
            }
            this.Cursor = Cursors.Default;
        }

      

        private void btnExcel_Click(object sender, EventArgs e)
        {
         Export Ex = new Export() ;
         DataTable aa = new DataTable();
        //string fileExcel = AppControl.SaveDialog("Excel files (*.xls)|*.xls|All files (*.*)|*.*");
          
          //AppControl.ExporttoExcel(dgvShow, fileExcel);
        DisplayAllData = PrintLabelBLL.GetPrintLabelfromDatetime(dtpbegDate.Value, dtpEndDatetime.Value);

        aa = PrintLabelBLL.GetPrintLabelfromDatetime2(dtpbegDate.Value, dtpEndDatetime.Value);
            Ex.ExportExcel(aa,"");
         
        }

   

      

    }

    
}
