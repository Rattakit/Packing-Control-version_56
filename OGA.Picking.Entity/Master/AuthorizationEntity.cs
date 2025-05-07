using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGA.Packing.Entity.Master
{
    public class AuthorizationEntity
    {
        public AuthorizationEntity()
        { }

        public string UserGroupID { get; set; }
        public string UserGroupDescription { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Permission { get; set; }
        public string LastUpdateBy { get; set; }
    }
}
