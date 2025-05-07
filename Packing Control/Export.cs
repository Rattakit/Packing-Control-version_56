using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;

namespace ConSOH.IO {

    public class Export : IDisposable{
        public bool ExportExcel(DataTable dataTable) {
            return ExportExcel(dataTable, string.Empty);
        }
        public bool ExportExcel(DataTable dataTable, string fileName) {
            try {

                SaveFileDialog saveDialog = new SaveFileDialog();
                DataSet ds = new DataSet();

                if (dataTable == null || dataTable.Rows.Count == 0) {
                    MessageBox.Show("ไม่มีข้อมูลที่ในการเขียนเขียนไฟล์ Excel โปรดตรวจสอบและลองใหม่อีกครั้ง");
                    return false;
                }

                ds.Tables.Clear();
                ds.Tables.Add(dataTable.Copy());

                System.Web.UI.WebControls.DataGrid grid = new System.Web.UI.WebControls.DataGrid();
                grid.HeaderStyle.Font.Bold = true;
                grid.DataSource = ds;
                grid.DataMember = ds.Tables[0].TableName;
                grid.DataBind();
                saveDialog.Filter = "MS Excel 2003|*.xls";

                //ถ้าไม่มีการระบุชื่อไฟล์ dialog จะ default เป็น ชื่่อ table
                if (string.IsNullOrEmpty(fileName)) {
                    saveDialog.FileName = ds.Tables[0].TableName + ".xls";
                }
                else {
                    saveDialog.FileName = fileName;
                }

                if (saveDialog.ShowDialog() == DialogResult.OK) {
                    fileName = saveDialog.FileName;
                    if (fileName != string.Empty) {
                        //render the DataGrid control to a file
                        using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.UTF8)) {
                            using (HtmlTextWriter hw = new HtmlTextWriter(sw)) {
                                grid.RenderControl(hw);
                            }
                        }

                        //MessageBox.Show("ระบบได้บันทึกไฟล์ " + fileName + " เสร็จสมบูรณ์แล้ว");
                        System.Diagnostics.Process.Start(fileName);
                    }
                }
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
