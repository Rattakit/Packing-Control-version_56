using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Globalization;
using System.Net;
using System.Collections;
using Microsoft.Win32;
using System.Diagnostics;

namespace OGA.Helper.Control
{
    public static class AppService
    {
        public static string GetPasswordMD5(string pwd)
        {
            string epassword = string.Empty;
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(pwd);
            bs = x.ComputeHash(bs);
            StringBuilder s = new StringBuilder();

            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToUpper());
            }
            epassword = s.ToString();
            return epassword;
        }

        //Code snippet
        /// <summary>
        /// method for generating a country list, say for populating
        /// a ComboBox, with country options. We return the
        /// values in a Generic List<T>
        /// </summary>
        /// <returns></returns>
        public static List<string> GetCountryList()
        {
            //create a new Generic list to hold the country names returned
            List<string> cultureList = new List<string>();

            //create an array of CultureInfo to hold all the cultures found, these include the users local cluture, and all the
            //cultures installed with the .Net Framework
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);

            //loop through all the cultures found
            foreach (CultureInfo culture in cultures)
            {
                //pass the current culture's Locale ID (http://msdn.microsoft.com/en-us/library/0h88fahh.aspx)
                //to the RegionInfo contructor to gain access to the information for that culture
                RegionInfo region = new RegionInfo(culture.LCID);

                //make sure out generic list doesnt already
                //contain this country
                if (!(cultureList.Contains(region.EnglishName)))
                    //not there so add the EnglishName (http://msdn.microsoft.com/en-us/library/system.globalization.regioninfo.englishname.aspx)
                    //value to our generic list
                    cultureList.Add(region.EnglishName);
            }
            return cultureList;
        }

        public static string GetVersion()
        {

            // get the version object for this assembly
            Version v = System.Reflection.Assembly.GetExecutingAssembly().
             GetName().Version;
            // write out the whole version number
            //Console.WriteLine(v.ToString());
            //// or do it in pieces
            //Console.WriteLine(v.Major + "." + v.Minor + "." + v.Build +
            // "." + v.Revision);

            //this._info = new AssemblyInformationalVersionAttribute();
            //this._info.Name = asm.GetName().Name;
            //this._info.Version = asm.GetName().Version.ToString();
            //this._info.FullName = asm.GetName().ToString();

            return v.ToString();
        }

        public static string GetIPAddr()
        {
            string Result = "";
            String strHostName = "";
            strHostName = Dns.GetHostName();

            IPHostEntry ipEntry = Dns.GetHostByName(strHostName);
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                Result = addr[i].ToString();
            }

            return Result;
        }

        public static IEnumerable GetPortName()
        {
            RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DEVICEMAP\SERIALCOMM");
            //ArrayList myAL = new ArrayList();
            //try
            //{
            foreach (string valueName in rk.GetValueNames())
            {
                // listBox1.Items.Add(rk.GetValue(valueName).ToString());
                //myAL.Add(rk.GetValue(valueName).ToString());
                yield return rk.GetValue(valueName).ToString();
            }
            //}
            //catch { }

            // return myAL;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProcessName"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int ExecuteProgram(string ProcessName, string param)
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
