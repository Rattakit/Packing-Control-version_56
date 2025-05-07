using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Master;

namespace Packing_Control
{
    public static class Authorization
    {
        public static string UserID { get; set; }
        public static List<AuthorizationEntity> UserAuthorization { get; set; }
        public static PermissionEntity PermissionGroupAuthorization { get; set; }
        public static UserGroupEntity UserGroupAuthorization { get; set; }

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
    }
}
