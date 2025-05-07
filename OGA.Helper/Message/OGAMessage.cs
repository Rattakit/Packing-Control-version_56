using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OGA.Helper.Message
{
    public static class OGAMessage
    {
        //    Public Shared Sub ShowAsterisk(ByVal msg As String)
        //    MessageBox.Show(msg, "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        //End Sub
        public static void ShowAsterisk(String msg)
        {
            MessageBox.Show(msg, "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //Public Shared Sub ShowResult(ByVal msg As String)
        //    MessageBox.Show(msg, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        //End Sub
        public static void ShowResult(String msg)
        {
            MessageBox.Show(msg, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Public Shared Sub ShowValidate(ByVal msg As String)
        //    MessageBox.Show(msg, "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        //End Sub
        public static void ShowValidate(String msg)
        {
            MessageBox.Show(msg, "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Public Shared Sub ShowInformation(ByVal msg As String)
        //    MessageBox.Show(msg, "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        //End Sub
        public static void ShowInformation(String msg)
        {
            MessageBox.Show(msg, "ผลการตรวจสอบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Public Shared Sub ShowErrorTryCatch(ByVal msg As String, ByVal ex As Exception)
        //    MessageBox.Show(msg & vbCrLf & "ข้อผิดพลาดจากระบบ : " & ex.ToString.Replace("System.Exception:", ""), "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        //End Sub
        public static void ShowErrorTryCatch(String msg, Exception ex)
        {
            MessageBox.Show(msg + Environment.NewLine + "ข้อผิดพลาดจากระบบ : " + ex.Message.Replace("System.Exception:", ""), "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //Public Shared Sub ShowError(ByVal msg As String, ByVal ex As Exception)
        //    MessageBox.Show(msg & vbCrLf & "ข้อผิดพลาดจากระบบ : " & ex.ToString, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        //End Sub
        public static void ShowError(String msg, Exception ex)
        {
            MessageBox.Show(msg + Environment.NewLine + "ข้อผิดพลาดจากระบบ : " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //Public Shared Sub ShowError(ByVal msg As String)
        //    MessageBox.Show(msg, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        //End Sub
        public static void ShowError(String msg)
        {
            MessageBox.Show(msg, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //Public Shared Sub ShowErrorDuplicate(ByVal msg As String)
        //    MessageBox.Show("ข้อมูล " & msg & " นี้มีอยู่ในระบบอยู่แล้ว!", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        //End Sub
        public static void ShowErrorDuplicate(String msg)
        {
            MessageBox.Show("ข้อมูล " + msg + " นี้มีอยู่แล้วในระบบ...!!", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        //Public Shared Sub ShowErrorConnectWebService(ByVal ex As System.Net.WebException)
        //    MessageBox.Show("ไม่สามารถติดต่อ Server ได้ !" & vbCrLf & "ข้อผิดพลาดจากระบบ : " & ex.Message, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        //End Sub
        public static void ShowErrorConnectWebService(System.Net.WebException ex)
        {
            MessageBox.Show("ไม่สามารถติดต่อ Server ได้ !" + Environment.NewLine + "ข้อผิดพลาดจากระบบ : " + ex.Message, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// "กรุณายืนยัน",
        /// MessageBoxButtons.YesNo,
        /// MessageBoxIcon.Question
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static DialogResult ShowConfirm(string msg)
        {
            return MessageBox.Show(msg, "กรุณายืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// "กรุณายืนยัน",
        /// MessageBoxButtons.YesNo,
        /// MessageBoxIcon.Question
        /// <param name="msg"></param>
        /// <returns></returns>
        public static DialogResult ShowConfirmCloseForm()
        {
            return MessageBox.Show("คุณต้องการออกจากหน้าจอที่กำลังทำงานอยู่ ใช่ หรือ ไม่ ?", "กรุณายืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        //Public Shared Sub ShowResultSaveComplete()
        //    MessageBox.Show(My.Resources.resSystemMessage.ResultSaveComplete, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        //End Sub
        public static void ShowResultSaveComplete()
        {

            MessageBox.Show(resSystemMessage.ResultSaveComplete, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Public Shared Sub ShowResultDeleteComplete()
        //    MessageBox.Show(My.Resources.resSystemMessage.ResultDeleteComplete, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        //End Sub
        public static void ShowResultDeleteComplete()
        {
            MessageBox.Show(resSystemMessage.ResultDeleteComplete, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Public Shared Sub ShowResultCancelComplete()
        //    MessageBox.Show(My.Resources.resSystemMessage.ResultCancelComplete, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)
        //End Sub
        public static void ShowResultCancelComplete()
        {
            MessageBox.Show(resSystemMessage.ResultCancelComplete, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //ResultSaveFailed

        public static void ShowResultSaveFailed()
        {
            MessageBox.Show(resSystemMessage.ResultSaveFailed, "ผลการทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Public Shared Function ShowConfirmResetScreen() As Windows.Forms.DialogResult
        //    Return MessageBox.Show(My.Resources.resSystemMessage.ConfirmReset, "กรุณายืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        //End Function
        public static DialogResult ShowConfirmResetScreen()
        {
            return MessageBox.Show(resSystemMessage.ConfirmReset, "กรุณายืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
