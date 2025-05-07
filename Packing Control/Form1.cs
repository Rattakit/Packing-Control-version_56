using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Packing_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProcessInfo pi = new ProcessInfo();
        STARTUPINFO si = new STARTUPINFO();
        //byte[] si = new byte[128];
        int exitCode = 0;
        int STILL_ACTIVE = 0x103;

        public class ProcessInfo
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public IntPtr ProcessID;
            public IntPtr ThreadID;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct STARTUPINFO
        {
            public Int32 cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public Int32 dwX;
            public Int32 dwY;
            public Int32 dwXSize;
            public Int32 dwYSize;
            public Int32 dwXCountChars;
            public Int32 dwYCountChars;
            public Int32 dwFillAttribute;
            public Int32 dwFlags;
            public Int16 wShowWindow;
            public Int16 cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }


        [DllImport("kernel32.DLL", SetLastError = true)]
        private static extern int CreateProcess(String imageName, String cmdLine,
            IntPtr lpProcessAttributes, IntPtr lpThreadAttributes,
            Int32 boolInheritHandles, Int32 dwCreationFlags, IntPtr lpEnvironment,
            IntPtr lpszCurrentDir, STARTUPINFO si, ProcessInfo pi);

        [DllImport("kernel32")]
        private static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32")]
        private static extern uint WaitForSingleObject
                    (IntPtr hHandle, uint dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int GetExitCodeProcess
                    (IntPtr hProcess, ref int lpExitCode);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);


        //private void LaunchApp(string strPath, string strParms)
        //{


        //    CreateProcess(strPath, strParms, IntPtr.Zero, IntPtr.Zero,
        //        0, 0, IntPtr.Zero, IntPtr.Zero, si, pi);
        //    // This line can be commented out if you do not want 
        //    // to wait for the process to exit
        //    WaitForSingleObject(pi.hProcess, 0xFFFFFFFF);

        //    //MessageBox.Show(strPath + " " + strParms);
        //    GetExitCodeProcess(pi.hProcess, ref exitCode);
        //    CloseHandle(pi.hProcess);
        //    CloseHandle(pi.hThread);

        //    return;
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();

            if (GetExitCodeProcess(pi.hProcess, ref exitCode) == 0)
            {
                if (exitCode != STILL_ACTIVE)
                {
                    timer1.Start();
                }
                else
                {
                    CloseHandle(pi.hProcess);
                    timer1.Stop();
                }
            }
            else
            {
                TerminateProcess(pi.hProcess, 0);
                CloseHandle(pi.hProcess);
                timer1.Stop();
            }
        }

        //Dim STILL_ACTIVE As Int32
        //Dim si(128) As Byte
        //Dim pi As New ProcessInfo
        //Dim iRetVal As Int32
        //Dim iRet2Val As Int32
        //iRetVal = 0
        //STILL_ACTIVE = &H103
        //iRetVal = CreateProcess("thirdparty.exe", "", IntPtr.Zero, IntPtr.Zero, 0,
        //0, IntPtr.Zero, IntPtr.Zero, si, pi)
        //If iRetVal <> 0 Then
        //WaitForSingleObject(pi.hProcess, 10000)
        //iRetVal = GetExitCodeProcess(pi.hProcess, iRet2Val)
        //If iRetVal = 0 Then MsgBox("Error calling GetExitCodeProcess")
        //Do While iRet2Val = STILL_ACTIVE
        //Sleep(1000)
        //GetExitCodeProcess(pi.hProcess, iRet2Val)
        //Loop
        //MsgBox("Errorlevel: " & iRet2Val)


        private void button1_Click(object sender, EventArgs e)
        {
            //Array.Clear(si, 0, si.Length);
            //si.cb =  STARTUPINFO;
            if (CreateProcess(textBox1.Text, textBox2.Text, IntPtr.Zero, IntPtr.Zero,
                                    0, 0, IntPtr.Zero, IntPtr.Zero, si, pi) != 0)
            {
                WaitForSingleObject(pi.hProcess, 0xFFFFFFFF);
                timer1.Start();
            }
            else
            {
                CloseHandle(pi.hProcess);
                MessageBox.Show("Couldn''t execute");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExecuteProcess();
        }

        public int ExecuteProcess()
        {
            //Clear log.
           string Log = "";
            using (Process DOSProcess = new Process())
            {
                ProcessStartInfo StartInfo = new ProcessStartInfo();

                StartInfo.FileName = textBox1.Text;
                StartInfo.Arguments = textBox2.Text;

                StartInfo.RedirectStandardError = false;
                StartInfo.RedirectStandardOutput = true;
                StartInfo.RedirectStandardInput = false;

                StartInfo.UseShellExecute = false;
                StartInfo.CreateNoWindow = true;

                DOSProcess.EnableRaisingEvents = true;
                DOSProcess.StartInfo = StartInfo;
                DOSProcess.Start();

                do
                {
                    Log += DOSProcess.StandardOutput.ReadToEnd();
                }
                while (!DOSProcess.HasExited);

                int ProcessExitCode = DOSProcess.ExitCode;

                return ProcessExitCode;
            }

        }
    }
}
