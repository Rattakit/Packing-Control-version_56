using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

using System.Globalization;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;

namespace OGA.Helper.Control
{
    public static class AppControl
    {
        static string pathshortcut = string.Empty;
        static string pathdesktop = string.Empty;

        //public static System.Windows.Forms.Control GetControlInForm

        //        Dim pathshortcut As String
        //Dim pathdesktop As String

        //''' <summary>
        //''' ดึง control ในฟอร์ม จากชื่อของ control ที่ระบุ
        //''' </summary>
        //''' <param name="controlName"></param>
        //''' <param name="Controls"></param>
        //''' <returns></returns>
        //''' <remarks></remarks>
        //Public Shared Function GetControlInForm(ByVal controlName As String, ByRef Controls As Windows.Forms.Control.ControlCollection) As Windows.Forms.Control
        //    For Each c As Windows.Forms.Control In Controls
        //        If c.Name = controlName Then
        //            Return c
        //            Exit For
        //        End If
        //        If c.Controls.Count > 0 Then
        //            GetControlInForm(controlName, c.Controls)
        //        End If
        //    Next
        //    Return Nothing
        //End Function

        public static void PrintNumberInDataGridView(DataGridView dataGridView, DataGridViewRowPostPaintEventArgs e)
        {//this method overrides the DataGridView's RowPostPaint event 
            //in order to automatically draw numbers on the row header cells
            //and to automatically adjust the width of the column containing
            //the row header cells so that it can accommodate the new row
            //numbers,

            //store a string representation of the row number in 'strRowNumber'
            string strRowNumber = (e.RowIndex + 1).ToString();

            //prepend leading zeros to the string if necessary to improve
            //appearance. For example, if there are ten rows in the grid,
            //row seven will be numbered as "07" instead of "7". Similarly, if 
            //there are 100 rows in the grid, row seven will be numbered as "007".
            while (strRowNumber.Length < dataGridView.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

            //determine the display size of the row number string using
            //the DataGridView's current font.
            SizeF size = e.Graphics.MeasureString(strRowNumber, dataGridView.Font);

            //adjust the width of the column that contains the row header cells 
            //if necessary
            if (dataGridView.RowHeadersWidth < (int)(size.Width + 20)) dataGridView.RowHeadersWidth = (int)(size.Width + 20);

            //this brush will be used to draw the row number string on the
            //row header cell using the system's current ControlText color
            Brush b = SystemBrushes.ControlText;

            //draw the row number string on the current row header cell using
            //the brush defined above and the DataGridView's default font
            e.Graphics.DrawString(strRowNumber, dataGridView.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));

            //call the base object's OnRowPostPaint method
            //base.OnRowPostPaint(e);

        }

        const int ERROR_FILE_NOT_FOUND = 2;
        const int ERROR_ACCESS_DENIED = 5;
        // Excel object references.
        private static Excel.Application m_objExcel = null;
        private static Excel.Workbooks m_objBooks = null;
        private static Excel._Workbook m_objBook = null;
        private static Excel.Sheets m_objSheets = null;
        private static Excel._Worksheet m_objSheet = null;

        // Frequenty-used variable for optional arguments.
        private static object m_objOpt = System.Reflection.Missing.Value;

        // Paths used by the sample code for accessing and storing data.
        private static object m_strSampleFolder = "C:\\ExcelData\\";


        public static void ExporttoExcel(DataGridView dv, string pathfilexls)//
        {
            System.Threading.Thread thisThread = System.Threading.Thread.CurrentThread;
            System.Globalization.CultureInfo originalCulture = thisThread.CurrentCulture;
            // Use an exception block to switch back in case of a run-time error.
            try
            {
                thisThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                // Start a new workbook in Excel.
                m_objExcel = new Excel.Application();
                m_objBooks = (Excel.Workbooks)m_objExcel.Workbooks;
                m_objBook = (Excel._Workbook)(m_objBooks.Add(m_objOpt));//(Excel._Workbook)(m_objBooks.Add(m_objOpt))
                m_objSheets = (Excel.Sheets)m_objBook.Worksheets;
                m_objSheet = (Excel._Worksheet)(m_objSheets.get_Item(1));


                int ColumnIndex = 0;
                // create Header Name
                int c_r = dv.Columns.Count;
                foreach (DataGridViewTextBoxColumn col in dv.Columns)
                {
                    ColumnIndex++;
                    m_objExcel.Cells[1, ColumnIndex] = col.HeaderText;

                }
                // End create Header Name

                int rowIndex = 0;
                // create data to columns
                foreach (DataGridViewRow row in dv.Rows)
                {
                    rowIndex++;
                    ColumnIndex = 0;
                    foreach (DataGridViewTextBoxColumn col in dv.Columns)
                    {
                        m_objExcel.Cells[rowIndex + 1, ColumnIndex + 1] = row.Cells[ColumnIndex].Value.ToString();
                        ColumnIndex++;
                    }

                }

                //// End create data to columns
                //m_objRange = m_objSheet.get_Range("A1", "E1");
                //m_objRange.EntireColumn.AutoFit();
                //m_objExcel.UserControl = false;
                //m_objExcel.Visible = true;
                // Save the Workbook and quit Excel.
                m_objBook.SaveAs(pathfilexls, m_objOpt, m_objOpt,
                    m_objOpt, m_objOpt, m_objOpt, Excel.XlSaveAsAccessMode.xlNoChange,
                    m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt);
                m_objBook.Close(false, m_objOpt, m_objOpt);
                //m_objExcel.Save();
                m_objExcel.Quit();

                //============ kill Process
                Process[] pProcess;
                pProcess = System.Diagnostics.Process.GetProcessesByName("Excel");
                pProcess[0].Kill();
                //============ kill Process 

                System.Diagnostics.Process.Start(pathfilexls);
            }
            catch (Exception ex)
            {
                if (File.Exists(pathfilexls)) File.Delete(pathfilexls);
                throw new Exception("Problems in using this function ExporttoExcel() because." + ex.Message, ex);
            }
            finally
            {
                // Restore the culture information for the thread after the
                // Excel calls have completed.
                thisThread.CurrentCulture = originalCulture;

            }
        }

        public static string OpenDialog(string filter)
        {
            string ret = string.Empty;
            OpenFileDialog OPDialog = new OpenFileDialog();

            OPDialog.InitialDirectory = "C:\\";
            OPDialog.Filter = filter; 
            OPDialog.FilterIndex = 2;
            OPDialog.RestoreDirectory = true;

            if (OPDialog.ShowDialog() == DialogResult.OK)
            {
                ret = OPDialog.FileName;
            }

            OPDialog.Dispose();
            return ret;
        }

        public static string SaveDialog(string filter)
        {
            string ret = string.Empty;
            SaveFileDialog SVDialog = new SaveFileDialog();

            SVDialog.InitialDirectory = "C:\\";
            SVDialog.Filter = filter;
            SVDialog.FilterIndex = 2;
            SVDialog.RestoreDirectory = true;

            if (SVDialog.ShowDialog() == DialogResult.OK)
            {
                ret = SVDialog.FileName;
            }

            SVDialog.Dispose();
            return ret;
        }

    }
}
