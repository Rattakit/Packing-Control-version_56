using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGA.Packing.Entity.Master
{
    public class UserEntity
    {
        //UserID, tbaUser.Password, tbaUser.FirstName, tbaUser.LastName, tbaUser.IsActive, tbaUser.CreateBy, Permission Group

        public UserEntity()
        { }

        public string UserGroupID { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public string LastUpdateBy { get; set; }
        public string Permission { get; set; }
        public string Group { get; set; }
    }
}
