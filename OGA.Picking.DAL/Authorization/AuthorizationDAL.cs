using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Master;
using System.Data.SqlClient;
using System.Data;


namespace OGA.Packing.DAL.Authorization
{
    public class AuthorizationDAL : baseDAL
    {
        string sqlstr_Authorization = "SELECT     dbo.tbaUser.UserID, dbo.tbaUser.[Password], dbo.tbaUser.FirstName, "
                            + "dbo.tbaUser.LastName, dbo.tbaUserGroup.UserGroupID, dbo.tbaUserGroup.UserGroupDescription, "
                            + " dbo.tbaPermission.Permission , dbo.tbaPermission.CreateBy"
                            + " FROM         dbo.tbaUser INNER JOIN "
                            + "  dbo.tbaUserGroup ON dbo.tbaUser.UserGroupID = dbo.tbaUserGroup.UserGroupID INNER JOIN "
                            + "  dbo.tbaPermission ON dbo.tbaUserGroup.UserGroupID = dbo.tbaPermission.UserGroup ";

        public List<AuthorizationEntity> GetLogInUserInSystem(string UserID, string Password)
        {
                List<AuthorizationEntity> record = null;
                dbManager.Open();
                try
                {
                    string sqlstr = sqlstr_Authorization + " where UserID = '" + UserID + "' order by UserID";
                    sqlcmd.CommandText = sqlstr;

                    record = GetAuthorizationListCollectionFromReader(dbManager.ExecuteReader(sqlcmd));
                }
                catch (Exception ex)
                {
                    throw new Exception("Problems in using this function GetPartAll() because." + ex.Message, ex);
                }
                return record;
        }

        /// <summary>
        /// Returns a new UserGroupEntity instance filled with the DataReader's current record data
        /// </summary>
        protected virtual AuthorizationEntity GetAuthorizationListFromReader(IDataReader reader)
        {
            AuthorizationEntity rec = new AuthorizationEntity();
            rec.UserGroupID = reader["UserGroupID"].ToString();
            rec.UserGroupDescription = reader["UserGroupDescription"].ToString();
            rec.UserID = reader["UserID"].ToString();
            rec.Password = reader["Password"].ToString();
            rec.FirstName = reader["FirstName"].ToString();
            rec.LastName = reader["LastName"].ToString();
            rec.Permission = reader["Permission"].ToString();
            rec.LastUpdateBy = reader["CreateBy"].ToString();

            return rec;
        }

        /// <summary>
        /// Returns a collection of UserGroupEntity objects with the data read from the input DataReader
        /// </summary>
        protected virtual List<AuthorizationEntity> GetAuthorizationListCollectionFromReader(IDataReader reader)
        {
            List<AuthorizationEntity> record = new List<AuthorizationEntity>();
            try
            {
                while (reader.Read())
                    record.Add(GetAuthorizationListFromReader(reader));
            }
            finally
            {
                reader.Close();
            }
            return record;
        }

    }
}
