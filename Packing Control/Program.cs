using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Packing_Control.FormAll.Master;
using Packing_Control.FormAll.Transaction.GI;
using Packing_Control.FormAll.Authenticate;
using Packing_Control.FormAll;

namespace Packing_Control
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Authorization.UserAuthorization = Authorization.UserAuthorization.GetUserListBYUserID("22057", "r0oNwrgikt");
            frmlogin frm = new frmlogin();
            frm.State = frmlogin.StateProcess.Login;
            frm.ShowDialog();
            frm.Dispose();
            //Application.Run(new frmMenu());
            if (Authorization.UserAuthorization.Count != 0)
            {
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMainMenu());
            }

            //Application.Run(new frmMenu());
        }
    }
}
