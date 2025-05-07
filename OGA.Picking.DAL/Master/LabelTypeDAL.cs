using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Master;
using OGA.Database;
using System.Data;


namespace OGA.Packing.DAL.Master
{
    public partial class LabelTypeDAL : baseDAL
    {
        public LabelTypeDAL()
        {
            InitializeComponent();
        }

        public LabelTypeDAL(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region Get Data From Table Label Type 
        protected LabelTypeEntity GetLabelTypeFromreader(IDataReader reader)
        {
//@LabelType
//           ,@Pathformat
//           ,@LastUpdateBy
            return new LabelTypeEntity(reader["LabelType"].ToString(), reader["Pathformat"].ToString(), reader["LastUpdateBy"].ToString());
        }

        protected List<LabelTypeEntity> GetLabelTypeCollectionfromreader(IDataReader reader)
        {
            List<LabelTypeEntity> record = new List<LabelTypeEntity>();
            try
            {
                while (reader.Read())
                {
                    record.Add(GetLabelTypeFromreader(reader));
                }
            }
            finally
            {
                if (reader.IsClosed == false) reader.Close();
            }
            return record;
        }

        public List<LabelTypeEntity> GetLabelTypeAll()
        {
            List<LabelTypeEntity> record = null;
            dbManager.Open();
            try
            {
                record = GetLabelTypeCollectionfromreader(dbManager.ExecuteReader(sqlcmd_GetLabelTypeAll));
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetPartAll() because." + ex.Message, ex);
            }
            return record;
        }


        public int CheckDuplicateData(LabelTypeEntity record)
        {
            int ret = 0;
            dbManager.Open();
            try
            {
                sqlcmd_CheckDuplicate.Parameters["@LabelType"].Value = record.LabelType;
                ret = (int)dbManager.ExecuteScalar(sqlcmd_CheckDuplicate);
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetPartAll() because." + ex.Message, ex);
            }

            return ret;
        }
        #endregion

        public int InsertLabelType(LabelTypeEntity record)
        {
            int ret = 0;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();
                //@Truck_No,@Driver_Name,@Phone_No,@Type_3_License,@Type_4_License,@Truck_Type,@Description,@IsActive,@CreateBy
                sqlcmd_Insert.Parameters["@LabelType"].Value = record.LabelType;
                sqlcmd_Insert.Parameters["@Pathformat"].Value = record.Pathformat;
                sqlcmd_Insert.Parameters["@LastUpdateBy"].Value = record.LastupdateBy;
                dbManager.ExecuteNonQuery(sqlcmd_Insert);
                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function InsertPart() because." + ex.Message, ex);
            }
            return ret;
        }

        public int UpdateLabelType(LabelTypeEntity record)
        {
            int ret = 0;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();
                //@Truck_No,@Driver_Name,@Phone_No,@Type_3_License,@Type_4_License,@Truck_Type,@Description,@IsActive,@CreateBy
                sqlcmd_Update.Parameters["@LabelType"].Value = record.LabelType;
                sqlcmd_Update.Parameters["@Pathformat"].Value = record.Pathformat;
                sqlcmd_Update.Parameters["@LastUpdateBy"].Value = record.LastupdateBy;
                dbManager.ExecuteNonQuery(sqlcmd_Update);
                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function UpdatePart() because." + ex.Message, ex);

            }
            return ret;
        }

        //@Typelabel

        public string DeleteLabelType(LabelTypeEntity record)
        {
            string ret = string.Empty;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();
                 
                sqlcmd_GetTransaction.Parameters["@LabelType"].Value = record.LabelType;
                int c = (int)dbManager.ExecuteScalar(sqlcmd_GetTransaction);

                if (c == 0)
                {
                    sqlcmd_Delete.Parameters["@LabelType"].Value = record.LabelType;
                    dbManager.ExecuteNonQuery(sqlcmd_Delete);
                    ret = "Delete Successfully...";
                }
                else ret = "";

                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = "Problems in using this function UpdatePart() because." + ex.Message;

            }
            dbManager.Close();
            return ret;
        }

    }
}
