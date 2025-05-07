using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Master;
using OGA.Packing.DAL.Master;
using OGA.Packing.Entity.Transaction.GI;
using OGA.Packing.DAL.Transaction.GI;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace OGA.Packing.BLL.Transaction.GI
{
    public static class PrintLabelBLL
    {
        private static PrinlabelDAL dal = new PrinlabelDAL();

        public static List<PrintlabelEntity> GetPrintLabelAll(this List<PrintlabelEntity> record)
        {
            return dal.GetPrintLabelAll();
        }

        public static List<PrintlabelEntity> GetPrintLabelfromDatetime(DateTime begDatetime, DateTime EndDatetime)
        {
            return dal.GetPrintLabelFromDatetime(begDatetime, EndDatetime);
        }

        //Public Function GetPartCode(ByVal condition As String) As DataTable
        //    Dim dal As New PartCodeDAL
        //    Dim dt As Data.DataTable = dal.SelectPartCode(condition)
        //    dal.Dispose()
        //    Return dt
        //End Function

        public static DataTable GetPrintLabelfromDatetime2(DateTime begDatetime, DateTime EndDatetime)
        {
            return dal.GetPrintLabelFromDatetime2(begDatetime, EndDatetime);
        }

        public static int InsertPrintLabel(this List<PrintlabelEntity> record)
        {

            int ret = 0;
            try
            {
                if (dal.InsertPrintLabel(record) == 0)
                {
                    //PrintLabel(printbarcode);
                }
            }
            catch (Exception ex)
            {
                ret = 1;
                throw new Exception("Problems in using this function InsertPrintLabel BLL because." + ex.Message, ex);
            }
            return ret;
        }

        public static int UpdatePrintLabel(this PrintlabelEntity record, List<PrintBarcodeEntity> printbarcode, ref string errorMsg)
        {
            int ret = 0;
            try
            {
                if (dal.UpdatePrintLabel(record) == 0)
                {
                    ret = PrintLabel(printbarcode, ref errorMsg);
                }
            }
            catch (Exception ex)
            {
                ret = 1;
                throw new Exception("Problems in using this function UpdatePrintLabel BLL because." + ex.Message, ex);
            }
            return ret;
        }

        public static string GetLotNo(DateTime datetime, bool Repack)
        {
           // string PackingPlant = ConfigurationSettings.AppSettings["PackingPlant"].ToString();
            string D = string.Format("{0:00}", datetime.Day)+'/';
            string Y = datetime.Year.ToString();
            string M = string.Empty;

            switch (datetime.Month) {
                case 1:
                    M = "1/";
                    break;
                case 2:
                    M = "2/";
                    break;
                case 3:
                    M = "3/";
                    break;
                case 4:
                    M = "4/";
                    break;
                case 5:
                    M = "5/";
                    break;
                case 6:
                    M = "6/";
                    break;
                case 7:
                    M = "7/";
                    break;
                case 8:
                    M = "8/";
                    break;
                case 9:
                    M = "9/";
                    break;
                case 10:
                    M = "10/";
                    break;
                case 11:
                    M = "11/";
                    break;
                case 12:
                    M = "12/";
                    break;
            }

            return string.Format("{0}{1}{2}{3}", 
              //  PackingPlant,
                D, M, Y, Repack.Equals(true) ? "S" : string.Empty);
        }



        public static int PrintLabel(List<PrintBarcodeEntity> printbarcode, ref string errorMsg)
        {
            int ret = 0;
            string startPath = Environment.CurrentDirectory;//@"C:\Printkb";//
            string Pathfile = ConfigurationManager.AppSettings["CmdPrintBarcode"].ToString();
            //MessageBox.Show(Pathfile);
            try
            {
                PrinlabelDAL dal = new PrinlabelDAL();

                foreach (PrintBarcodeEntity d in printbarcode)
                {
                    d.PathBarcode = dal.GetPathLabelType(d.LabelType);

                    //string datalog = string.Format("d.PathBarcode");

                    string datalog = string.Format("{0}  {1}", System.DateTime.Now.ToString(), d.PathBarcode);
                    string directoryPath = @"C:\oga";

                    if (!Directory.Exists(directoryPath)) {
                        // Create the directory
                        Directory.CreateDirectory(directoryPath);
                    }

                    using (StreamWriter writer = new StreamWriter("C:\\oga\\printpath.log",true)) {
                        writer.WriteLine(datalog);

                    }

                    //string formatbarcode = @"/F=@format /PD /C=@copies /XS";
                    string formatbarcode = @"/F=@format /P /XS /C=@copies"; // print no show Dialog
                    dal.InsertBarTander(d.PartNo, d.PartName, d.STDPack, d.LotNo, d.Coutry, d.PartNameTH, d.CoutryTH);
                    formatbarcode = formatbarcode.Replace("@format", d.PathBarcode).Replace("@copies", d.Barcode.ToString());

                    //string formatbarcode = @"/F=@format /P /XS";
                    //dal.InsertBarTander(d.PartNo, d.PartName, d.STDPack, d.LotNo, d.Coutry, d.PartNameTH, d.CoutryTH,(int)d.Barcode);
                    //formatbarcode = formatbarcode.Replace("@format", d.PathBarcode);


                    //string filePath = "exampleWriter.txt";
                    //using (StreamWriter writer = new StreamWriter(filePath,true)) {
                    //    writer.WriteLine(formatbarcode);
                    
                    //}

                    if (File.Exists(d.PathBarcode)) {

                        ExecuteProcess(Pathfile, formatbarcode); // 22072024 พี่หนุ่ยสั่งเนื่องจากใช้ bartender integration
                        System.Threading.Thread.Sleep(500);
                    } else {
                        // write log path not found
                        ret = 1;
                        errorMsg = "Label Path Not Found";
                    }
                }

            }
            catch (Exception ex)
            {
                ret = 1;
                throw new Exception("Problems in using this function PrintLabel BLL because." + ex.Message, ex);
            }

            return ret;
        }

        public static decimal Calcu(decimal qty, decimal standardpack)
        {
            decimal ret = 0;
            string calcu = string.Format("{0}", qty / standardpack);
            int index = calcu.IndexOf(".");
            if (index != -1)
            {
                ret = Convert.ToDecimal(calcu.Substring(index + 1, calcu.Length - (index + 1)));
            }

            return ret;
        }


        public static int ExecuteProcess(string ProcessName, string param)
        {
            //Clear log.
            string Log = "";
            using (Process DOSProcess = new Process())
            {
                ProcessStartInfo StartInfo = new ProcessStartInfo();

                StartInfo.FileName = ProcessName;
                StartInfo.Arguments = param;

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
