using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGA.Packing.Entity.Master
{
    public class PermissionEntity
    {
        public PermissionEntity()
        { }

        public string UserGroupID { get; set; }
        public string Permission { get; set; }
        public string LastUpdateBy { get; set; }

    }
}
