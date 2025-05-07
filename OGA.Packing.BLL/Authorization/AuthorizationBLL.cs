using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Master;
using OGA.Packing.DAL.Authorization;

namespace OGA.Packing.BLL.Authorization
{
    public static class AuthorizationBLL
    {
        static AuthorizationDAL dal = new AuthorizationDAL();
        public static List<AuthorizationEntity> GetLogInUserInSystem(this  List<AuthorizationEntity> record, string UserID, string Password)
        {
            return dal.GetLogInUserInSystem(UserID, Password);
        }
    }
}
