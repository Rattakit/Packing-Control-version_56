using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Master;
using OGA.Packing.DAL.Master;

namespace OGA.Packing.BLL.Master
{
    public static class UserBLL//UserExtensions
    {
        static UserDAL dal = new UserDAL();
        //static UserProvider 
        #region UserGroup
        public static int FindRowIndexfromUserID(this List<UserEntity> record, string value)
        {
            int rowIndex = -1;
            //string valuestmp = string.Empty;
            for (int i = 0; i <= record.Count - 1; i++)
            {
                // valuestmp = record[i].UserGroupCode;
                if (record[i].UserID == value)
                {
                    return i;
                }
            }

            return rowIndex;
        }

        public static int InsertUserGroup(this UserGroupEntity record)
        {
            return dal.InsertUserGroupList(record);
        }

        public static int UpdateUserGrouptList(this UserGroupEntity record)
        {
            return dal.UpdateUserGrouptList(record);
        }

        public static List<UserGroupEntity> GetUserGroupListAll(this List<UserGroupEntity> record)
        {
            return dal.GetUserGroupListAll();
        }

        public static List<UserGroupEntity> GetUserGroupListBYUserGroupID(this List<UserGroupEntity> record, string UserID)
        {
            return dal.GetUserGroupListBYUserGroupID(UserID);
        }

        public static int GetUserGroupListDuplicateBYUserGroupID(this UserGroupEntity record, string UserID)
        {
            return dal.GetUserGroupListDuplicateBYUserGroupID(UserID);
        }

        public static List<UserGroupEntity> GetUserGroupListBYIsActive(this List<UserGroupEntity> record)
        {
            return dal.GetUserGroupListBYIsActive();
        }

        #endregion

        #region User entity
        public static int InsertUserList(this UserEntity record)
        {
            return dal.InsertUserList(record);
        }

        public static int UpdateUsertList(this UserEntity record)
        {
            return dal.UpdateUsertList(record);
        }

        public static UserEntity GetUserListBYUserID(this UserEntity record, string UserID)
        {
            return dal.GetUserListBYUserID(UserID);
        }

        public static List<UserEntity> GetUserListAll(this List<UserEntity> record)
        {
            return dal.GetUserListAll();
        }



        public static int GetUserListDuplicateBYUserID(this UserEntity rec, string UserID)
        {
            return dal.GetUserListDuplicateBYUserID(UserID);
        }
        #endregion

        #region Permission
        public static List<PermissionEntity> GetPermissionListAll(this List<PermissionEntity> rec)
        {
            return dal.GetPermissionListAll();
        }

        public static int InsertPermission(this PermissionEntity rec)
        {
            return dal.InsertPermission(rec);
        }

        public static int UpdatePermission(this PermissionEntity rec)
        {
            return dal.UpdatePermission(rec);
        }
        #endregion

    }
}
