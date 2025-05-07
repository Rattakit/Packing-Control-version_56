using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Master;
using System.Data;

namespace OGA.Packing.DAL.Master
{
    public partial class UserDAL : baseDAL
    {
        private string SQLStr_User = "SELECT tbaUser.UserID, tbaUser.UserGroupID, tbaUserGroup.UserGroupDescription, "
                     + " tbaUser.Password, tbaUser.FirstName, tbaUser.LastName, tbaUser.IsActive, tbaUser.CreateBy AS LastUpdateBy "
                     + " FROM tbaUser INNER JOIN tbaUserGroup ON tbaUser.UserGroupID = tbaUserGroup.UserGroupID";

        private string SQLStr_UserGroup = "SELECT UserGroupID, UserGroupDescription, IsActive, CreateBy AS LastUpdateBy FROM tbaUserGroup";



        public UserDAL()
        {
            InitializeComponent();
        }

        public UserDAL(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        #region Process tabel User
        public int InsertUserList(UserEntity record)
        {
            int ret = 0;
            try
            {

                dbManager.Open();
                dbManager.BeginTransaction();

                string sqlstr = "INSERT INTO tbaUser ( UserID, UserGroupID, [Password], FirstName, LastName, IsActive, CreateBy, CreateDate ) values "
                                    + "( '" + record.UserID + "', '" + record.UserGroupID + "', '" + record.Password + "', '" + record.FirstName + "', '"
                                    + record.LastName + "', " + (record.IsActive.Equals(true) ? 1 : 0).ToString() + " , '" + record.LastUpdateBy + "', Getdate()) ";

                sqlcmd.CommandText = sqlstr;
                sqlcmd.CommandType = CommandType.Text;
                dbManager.ExecuteNonQuery(sqlcmd);
                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function InsertUserList() because." + ex.Message, ex);
            }
            return ret;
        }

        public int UpdateUsertList(UserEntity record)
        {
            int ret = 0;
            try
            {

                dbManager.Open();
                dbManager.BeginTransaction();

                string sqlstr = "UPDATE tbaUser SET tbaUser.UserID = '" + record.UserID + "', tbaUser.UserGroupID = '"
                                + record.UserGroupID + "', tbaUser.[Password] = '" + record.Password + "', tbaUser.FirstName = '"
                                + record.FirstName + "', tbaUser.LastName = '" + record.LastName + "', tbaUser.IsActive = "
                                + (record.IsActive.Equals(true) ? 1 : 0).ToString() + ", tbaUser.UpdateBy = '" + record.LastUpdateBy + "', tbaUser.UpdateDate = GetDate()"
                                + " WHERE tbaUser.UserID = '" + record.UserID + "'";

                sqlcmd.CommandText = sqlstr;
                sqlcmd.CommandType = CommandType.Text;
                dbManager.ExecuteNonQuery(sqlcmd);
                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function UpdateUsertList() because." + ex.Message, ex);
            }
            return ret;
        }

        public List<UserEntity> GetUserListAll()
        {
            List<UserEntity> record = null;
            dbManager.Open();
            try
            {
                string sqlstr = SQLStr_User + " Order by UserID";
                sqlcmd.CommandText = sqlstr;

                record = GetUserListCollectionFromReader(dbManager.ExecuteReader(sqlcmd));
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetUserListAll() because." + ex.Message, ex);
            }
            return record;

        }

        public UserEntity GetUserListBYUserID(string UserID)
        {
            UserEntity record = null;
            dbManager.Open();
            try
            {
                string sqlstr = SQLStr_User + " where UserID = '" + UserID + "' order by UserID";
                sqlcmd.CommandText = sqlstr;

                record = GetUserListFromReader(dbManager.ExecuteReader(sqlcmd));
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetUserListBYUserID() because." + ex.Message, ex);
            }
            return record;

        }

        public int GetUserListDuplicateBYUserID(string UserID)
        {
            int ret = 0;
            dbManager.Open();
            try
            {
                string sqlstr = " SELECT Count([UserID]) FROM tbaUser where UserID = '" + UserID + "'";
                sqlcmd.CommandText = sqlstr;
                sqlcmd.CommandType = CommandType.Text;

                ret = (int)dbManager.ExecuteScalar(sqlcmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetUserListBYUserID() because." + ex.Message, ex);
            }
            return ret;

        }

        public List<PermissionEntity> GetPermissionListAll()
        {
            List<PermissionEntity> record = null;
            dbManager.Open();
            try
            {
                string sqlstr = " SELECT     UserGroup, [Permission] as UserPermission, CreateBy FROM dbo.tbaPermission "
                                    + " ORDER BY UserGroup";
                sqlcmd.CommandText = sqlstr;

                record = GetPermissionCollectionFromReader(dbManager.ExecuteReader(sqlcmd));
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetUserListAll() because." + ex.Message, ex);
            }
            return record;

        }

 /// <summary>
        /// Returns a new UserEntity instance filled with the DataReader's current record data
        /// </summary>
        protected UserEntity GetUserListFromReader(IDataReader reader)
        {
            //UserID, Password, FirstName, LastName, IsActive, CreateBy UserGroupID
            UserEntity rec = new UserEntity();
            rec.UserGroupID = reader["UserGroupID"].ToString();
            rec.UserID = reader["UserID"].ToString();
            rec.Password = reader["Password"].ToString();
            rec.FirstName = reader["FirstName"].ToString();
            rec.LastName = reader["LastName"].ToString();
            rec.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
            rec.LastUpdateBy = reader["LastUpdateBy"].ToString();

            return rec;
        }

        /// <summary>
        /// Returns a collection of UserEntity objects with the data read from the input DataReader
        /// </summary>
        protected List<UserEntity> GetUserListCollectionFromReader(IDataReader reader)
        {
            List<UserEntity> record = new List<UserEntity>();
            try {
                while (reader.Read())
                    record.Add(GetUserListFromReader(reader));
            }  finally { reader.Close(); }
            return record;
        }
        #endregion


        #region Process table UserGroup

        protected UserGroupEntity GetUserGroupListFromReader(IDataReader reader)
        {
            //UserGroupID, UserGroupDescription, IsActive, CreateBy AS LastUpdateBy
            UserGroupEntity rec = new UserGroupEntity();
            rec.UserGroupID = reader["UserGroupID"].ToString();
            rec.UserGroupDescription = reader["UserGroupDescription"].ToString();
            rec.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
            rec.LastUpdateBy = reader["LastUpdateBy"].ToString();

            return rec;
        }

        /// <summary>
        /// Returns a collection of UserGroupEntity objects with the data read from the input DataReader
        /// </summary>
        protected List<UserGroupEntity> GetUserGroupListCollectionFromReader(IDataReader reader)
        {
            List<UserGroupEntity> record = new List<UserGroupEntity>();
            try
            {
                while (reader.Read())
                    record.Add(GetUserGroupListFromReader(reader));
            }
            finally
            {
                reader.Close();
            }
            return record;
        }

        public int InsertUserGroupList(UserGroupEntity record)
        {
            int ret = 0;
            try
            {

                dbManager.Open();
                dbManager.BeginTransaction();

                string sqlstr = "INSERT INTO tbaUserGroup ( UserGroupID, UserGroupDescription, IsActive, CreateBy, CreateDate )"
                                    + "values ( '" + record.UserGroupID + "', '" + record.UserGroupDescription + "', "
                                    + (record.IsActive.Equals(true) ? 1 : 0).ToString() + "  ,'" + record.LastUpdateBy + "', GetDate())";
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = sqlstr;

                dbManager.ExecuteNonQuery(sqlcmd);
                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function InsertUserGroupList() because." + ex.Message, ex);
            }
            return ret;
        }

        public int UpdateUserGrouptList(UserGroupEntity record)
        {
            int ret = 0;
            try
            {

                dbManager.Open();
                dbManager.BeginTransaction();
                // myComm.CommandType = CommandType.Text;
                string sqlstr = "UPDATE tbaUserGroup SET UserGroupID = '" + record.UserGroupID + "', UserGroupDescription = '" + record.UserGroupDescription
                                    + "', IsActive = " + (record.IsActive.Equals(true) ? 1 : 0).ToString() + ", UpdateBy = '" + record.LastUpdateBy + "', UpdateDate = GetDate()"
                                    + " WHERE UserGroupID='" + record.UserGroupID + "';";
                sqlcmd.CommandText = sqlstr;
                sqlcmd.CommandType = CommandType.Text;

                dbManager.ExecuteNonQuery(sqlcmd);
                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function UpdateUserGrouptList() because." + ex.Message, ex);
            }
            return ret;
        }

        public List<UserGroupEntity> GetUserGroupListAll()
        {

            List<UserGroupEntity> record = null;
            dbManager.Open();
            try
            {
                string sqlstr = SQLStr_UserGroup + " Order by UserGroupID";
                sqlcmd.CommandText = sqlstr;

                record = GetUserGroupListCollectionFromReader(dbManager.ExecuteReader(sqlcmd));
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetUserGroupListAll() because." + ex.Message, ex);
            }
            return record;

        }

        public List<UserGroupEntity> GetUserGroupListBYUserGroupID(string UserGroupID)
        {
            List<UserGroupEntity> record = null;
            dbManager.Open();
            try
            {
                string sqlstr = SQLStr_UserGroup + " where UserGroupID = '" + UserGroupID + "' order by UserGroupID";
                sqlcmd.CommandText = sqlstr;

                record = GetUserGroupListCollectionFromReader(dbManager.ExecuteReader(sqlcmd));
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetUserGroupListAll() because." + ex.Message, ex);
            }
            return record;

        }

        public List<UserGroupEntity> GetUserGroupListBYIsActive()
        {
            List<UserGroupEntity> record = null;
            dbManager.Open();
            try
            {
                string sqlstr = SQLStr_UserGroup + " where IsActive = 1 order by UserGroupID";
                sqlcmd.CommandText = sqlstr;

                record = GetUserGroupListCollectionFromReader(dbManager.ExecuteReader(sqlcmd));
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetUserGroupListAll() because." + ex.Message, ex);
            }
            return record;

        }

        public int GetUserGroupListDuplicateBYUserGroupID(string UserGroupID)
        {
            int ret = 0;
            dbManager.Open();
            try
            {
                string sqlstr = " SELECT count(UserGroupID) FROM tbaUserGroup where UserGroupID = '" + UserGroupID + "'";
                sqlcmd.CommandText = sqlstr;

                ret = (int)dbManager.ExecuteScalar(sqlcmd);
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetUserGroupListAll() because." + ex.Message, ex);
            }
            return ret;
        }
        #endregion




        

        #region Process table Permission
        /// <summary>
        /// Returns a new UserGroupEntity instance filled with the DataReader's current record data
        /// </summary>
        protected virtual PermissionEntity GetPermissionListFromReader(IDataReader reader)
        {
            PermissionEntity rec = new PermissionEntity();
            rec.UserGroupID = reader["UserGroup"].ToString();
            rec.Permission = reader["UserPermission"].ToString();
            rec.LastUpdateBy = reader["CreateBy"].ToString();

            return rec;
        }

        /// <summary>
        /// Returns a collection of UserGroupEntity objects with the data read from the input DataReader
        /// </summary>
        protected virtual List<PermissionEntity> GetPermissionCollectionFromReader(IDataReader reader)
        {
            List<PermissionEntity> record = new List<PermissionEntity>();
            try
            {
                while (reader.Read())
                    record.Add(GetPermissionListFromReader(reader));
            }
            finally
            {
                reader.Close();
            }
            return record;
        }

        public int InsertPermission(PermissionEntity record)
        {
            int ret = 0;
            try
            {

                dbManager.Open();
                dbManager.BeginTransaction();
                string sqlstr = " INSERT INTO [tbaPermission] "
                                    + " ([UserGroup], [Permission], [CreateBy], [CreateDate]) "
                                    + " VALUES "
                                    + " (@UserGroup, @Permission, @CreateBy, GetDate()) ";

                sqlcmd.Parameters.Add("@UserGroup", SqlDbType.VarChar, 50).Value = record.UserGroupID;
                sqlcmd.Parameters.Add("@Permission", SqlDbType.VarChar, 50).Value = record.Permission;
                sqlcmd.Parameters.Add("@CreateBy", SqlDbType.VarChar, 50).Value = record.LastUpdateBy;

                sqlcmd.CommandText = sqlstr;
                sqlcmd.CommandType = CommandType.Text;
                dbManager.ExecuteNonQuery(sqlcmd);
                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function InsertUserGroupList() because." + ex.Message, ex);
            }
            return ret;
        }

        public int UpdatePermission(PermissionEntity record)
        {
            int ret = 0;
            try
            {

                dbManager.Open();
                dbManager.BeginTransaction();

                string sqlstr = " UPDATE [tbaPermission] "
                                    + " SET [UserGroup] = @UserGroup "
                                    + "  ,[Permission] = @Permission "
                                    + "  ,[UpdateBy] = @UpdateBy "
                                    + "  ,[UpdateDate] = GetDate() "
                                    + " WHERE [UserGroup] = @UserGroup ";

                sqlcmd.Parameters.Add("@UserGroup", SqlDbType.VarChar, 50).Value = record.UserGroupID;
                sqlcmd.Parameters.Add("@Permission", SqlDbType.VarChar, 50).Value = record.Permission;
                sqlcmd.Parameters.Add("@UpdateBy", SqlDbType.VarChar, 50).Value = record.LastUpdateBy;

                sqlcmd.CommandText = sqlstr;
                sqlcmd.CommandType = CommandType.Text;
                dbManager.ExecuteNonQuery(sqlcmd);
                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function InsertUserGroupList() because." + ex.Message, ex);
            }
            return ret;
        }


        #endregion

    }
}
