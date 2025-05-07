using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGA.Packing.Entity.Master
{
    public class UserGroupEntity
    {
        //UserGroupID, UserGroupDescription, IsActive, CreateBy
        public UserGroupEntity()
        { }

        public UserGroupEntity(string usergroup, string usergroupdescription, bool isactive, string lastupdateby)
        {
            this.UserGroupID = usergroup;
            this.UserGroupDescription = usergroupdescription;
            this.IsActive = isactive;
            this.LastUpdateBy = lastupdateby;
        }

        public string UserGroupID { get; set; }
        public string UserGroupDescription { get; set; }
        public bool IsActive { get; set; }
        public string LastUpdateBy { get; set; }

    }
}
