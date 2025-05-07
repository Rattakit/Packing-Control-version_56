using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Data;
using OGA.Packing.Entity.Master;

namespace OGA.Packing.DAL.Master
{
    public partial class PartDAL : baseDAL
    {
        public PartDAL()
        {
            InitializeComponent();
        }

        public PartDAL(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region Get Data From Table Part
       protected PartEntity GetPartFromreader(IDataReader reader)
        {
            //InnerLot.Pathformat AS PathInnerlot, MiddleLot.Pathformat AS PathMiddle, 
//                         OuterLot.Pathformat AS PathOuter

            return new PartEntity(reader["Model"].ToString(), reader["PartNo"].ToString(), reader["PartName"].ToString(),  reader["Country"].ToString(),  (decimal)reader["STDInnerLot"]
                                                , (decimal)reader["STDMiddleLot"], (decimal)reader["STDOuterLot"],
                                                reader["InnerLot"].ToString(), reader["MiddleLot"].ToString(), reader["OuterLot"].ToString()
                                                , reader["LastUpdateBy"].ToString(), reader["PathInnerlot"].ToString()
                                                , reader["PathMiddle"].ToString(), reader["PathOuter"].ToString()
                                                , reader["PartNameTH"].ToString(), reader["CountryTH"].ToString()); 
        }

        protected List<PartEntity> GetPartCollectionfromreader(IDataReader reader)
        {
            List<PartEntity> record = new List<PartEntity>();
            try
            {
                while (reader.Read())
                {
                    record.Add(GetPartFromreader(reader));
                }
            }
            finally
            {
                if (reader.IsClosed == false) reader.Close();
            }
            return record;
        }

        public List<PartEntity> GetPartAll()
        {
            List<PartEntity> record = null;

            dbManager.Open();

            try
            {
                record = GetPartCollectionfromreader(dbManager.ExecuteReader(sqlcmd_GetPartAll));
            }
            catch(Exception ex)
            {
                throw new Exception("Problems in using this function GetPartAll() because." + ex.Message, ex);
            }
            return record;
        }


        public int CheckDuplicateData(PartEntity record)
        {
            int ret = 0;
            dbManager.Open();
            try
            {
                //sqlcmd_CheckDuplicatePart.Parameters["@Model"].Value = record.Model;
                sqlcmd_CheckDuplicatePart.Parameters["@PartNo"].Value = record.PartNo;
                //sqlcmd_CheckDuplicatePart.Parameters["@STDInnerLot"].Value = record.STDInnerLot;
                //sqlcmd_CheckDuplicatePart.Parameters["@STDMiddleLot"].Value = record.STDMiddleLot;
                //sqlcmd_CheckDuplicatePart.Parameters["@STDOuterLot"].Value = record.STDOuterLot;
                ret = (int)dbManager.ExecuteScalar(sqlcmd_CheckDuplicatePart);
            }
            catch (Exception ex)
            {
                ret = 1;
                throw new Exception("Problems in using this function CheckDuplicateData() because." + ex.Message, ex);
            }

            return ret;
        }
        #endregion

        public int InsertPart(PartEntity record)
        {
            int ret = 0;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();
                //@Truck_No,@Driver_Name,@Phone_No,@Type_3_License,@Type_4_License,@Truck_Type,@Description,@IsActive,@CreateBy
                sqlcmd_InsertPart.Parameters["@Model"].Value = record.Model;
                sqlcmd_InsertPart.Parameters["@PartNo"].Value = record.PartNo;
                sqlcmd_InsertPart.Parameters["@PartName"].Value = record.PartName;
        
                sqlcmd_InsertPart.Parameters["@STDInnerLot"].Value = record.STDInnerLot;
                sqlcmd_InsertPart.Parameters["@STDMiddleLot"].Value = record.STDMiddleLot;
                sqlcmd_InsertPart.Parameters["@STDOuterLot"].Value = record.STDOuterLot;
                sqlcmd_InsertPart.Parameters["@LastUpdateBy"].Value = record.LastupdateBy;
                sqlcmd_InsertPart.Parameters["@Country"].Value = record.Country;

                sqlcmd_InsertPart.Parameters["@PartNameTH"].Value = record.PartNameTH;
                sqlcmd_InsertPart.Parameters["@CountryTH"].Value = record.CountryTH;

                dbManager.ExecuteNonQuery(sqlcmd_InsertPart);

                sqlcmd_InsertPartlabel.Parameters["@PartNo"].Value = record.PartNo;
                sqlcmd_InsertPartlabel.Parameters["@InnerLot"].Value = record.InnerLot;
                sqlcmd_InsertPartlabel.Parameters["@MiddleLot"].Value = record.MiddleLot;
                sqlcmd_InsertPartlabel.Parameters["@OuterLot"].Value = record.OuterLot;
                sqlcmd_InsertPartlabel.Parameters["@LastUpdateBy"].Value = record.LastupdateBy;


                dbManager.ExecuteNonQuery(sqlcmd_InsertPartlabel);
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

        public int InsertPart(List<PartEntity> records)
        {
            int ret = 0;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();
                //int check_part = 0;
                //@Truck_No,@Driver_Name,@Phone_No,@Type_3_License,@Type_4_License,@Truck_Type,@Description,@IsActive,@CreateBy
                int i = 0;
                foreach (PartEntity record in records)
                {
                    //check_part = CheckDuplicateData(record);
                    //if(record.PartNo == ) {

                    //}
                    //if (check_part == 0)
                    //{
                        sqlcmd_InsertPart.Parameters["@Model"].Value = record.Model;
                        sqlcmd_InsertPart.Parameters["@PartNo"].Value = record.PartNo;
                        sqlcmd_InsertPart.Parameters["@PartName"].Value = record.PartName;
                 
                        sqlcmd_InsertPart.Parameters["@STDInnerLot"].Value = record.STDInnerLot;
                        sqlcmd_InsertPart.Parameters["@STDMiddleLot"].Value = record.STDMiddleLot;
                        sqlcmd_InsertPart.Parameters["@STDOuterLot"].Value = record.STDOuterLot;
                        sqlcmd_InsertPart.Parameters["@LastUpdateBy"].Value = record.LastupdateBy;
                        sqlcmd_InsertPart.Parameters["@Country"].Value = record.Country;

                        sqlcmd_InsertPart.Parameters["@PartNameTH"].Value = record.PartNameTH;
                        sqlcmd_InsertPart.Parameters["@CountryTH"].Value = record.CountryTH;

                    dbManager.ExecuteNonQuery(sqlcmd_InsertPart);

                        sqlcmd_InsertPartlabel.Parameters["@PartNo"].Value = record.PartNo;
                        sqlcmd_InsertPartlabel.Parameters["@InnerLot"].Value = record.InnerLot;
                        sqlcmd_InsertPartlabel.Parameters["@MiddleLot"].Value = record.MiddleLot;
                        sqlcmd_InsertPartlabel.Parameters["@OuterLot"].Value = record.OuterLot;
                        sqlcmd_InsertPartlabel.Parameters["@LastUpdateBy"].Value = record.LastupdateBy;


                    i++;
                        if (i==50)
                        {
                            string dd = i.ToString();
                        }
                        dbManager.ExecuteNonQuery(sqlcmd_InsertPartlabel);
                    //}
                    //else {
                    //    dbManager.RollbackTransaction();
                    //    ret = 1;
                    //    throw new 
                    //   // throw new Exception("ไม่สามารถบันทึกรายการ");
                    //}
                }
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

        public int UpdatePart(PartEntity record)
        {
            int ret = 0;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();
                //@Truck_No,@Driver_Name,@Phone_No,@Type_3_License,@Type_4_License,@Truck_Type,@Description,@IsActive,@CreateBy
                sqlcmd_UpdatePart.Parameters["@Model"].Value = record.Model;
                sqlcmd_UpdatePart.Parameters["@PartNo"].Value = record.PartNo;
                sqlcmd_UpdatePart.Parameters["@PartName"].Value = record.PartName;
         
                sqlcmd_UpdatePart.Parameters["@STDInnerLot"].Value = record.STDInnerLot;
                sqlcmd_UpdatePart.Parameters["@STDMiddleLot"].Value = record.STDMiddleLot;
                sqlcmd_UpdatePart.Parameters["@STDOuterLot"].Value = record.STDOuterLot;
                sqlcmd_UpdatePart.Parameters["@LastUpdateBy"].Value = record.LastupdateBy;
                sqlcmd_UpdatePart.Parameters["@Country"].Value = record.Country;

                sqlcmd_UpdatePart.Parameters["@PartNameTH"].Value = record.PartNameTH;
                sqlcmd_UpdatePart.Parameters["@CountryTH"].Value = record.CountryTH;

                dbManager.ExecuteNonQuery(sqlcmd_UpdatePart);

                sqlcmd_UpdatePartLabel.Parameters["@PartNo"].Value = record.PartNo;
                sqlcmd_UpdatePartLabel.Parameters["@InnerLot"].Value = record.InnerLot;
                sqlcmd_UpdatePartLabel.Parameters["@MiddleLot"].Value = record.MiddleLot;
                sqlcmd_UpdatePartLabel.Parameters["@OuterLot"].Value = record.OuterLot;
                sqlcmd_UpdatePartLabel.Parameters["@LastUpdateBy"].Value = record.LastupdateBy;
                dbManager.ExecuteNonQuery(sqlcmd_UpdatePartLabel);

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

        public string DeletePart(PartEntity record)
        {
            string ret = string.Empty;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();

                sqlcmd_GetTransaction.Parameters["@PartNo"].Value = record.PartNo;
                int c = (int)dbManager.ExecuteScalar(sqlcmd_GetTransaction);

                if (c == 0)
                {
                    sqlcmd_Delete.Parameters["@PartNo"].Value = record.PartNo;
                    dbManager.ExecuteNonQuery(sqlcmd_Delete);

                    sqlcmd_Delete_tbt_PartLabel.Parameters["@PartNo"].Value = record.PartNo;
                    dbManager.ExecuteNonQuery(sqlcmd_Delete_tbt_PartLabel);

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
