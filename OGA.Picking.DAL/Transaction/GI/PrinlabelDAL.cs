using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Transaction.GI;
using System.Data;
using System.Data.SqlClient;

namespace OGA.Packing.DAL.Transaction.GI
{
    public partial class PrinlabelDAL : baseDAL
    {



        public PrinlabelDAL()
        {
            InitializeComponent();
        }

        public PrinlabelDAL(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region Get Data From Table Part
        protected PrintlabelEntity GetPrintLabelFromreader(IDataReader reader)
        {
            //ID, Model, PartNo, Qty, STDInnerLot, STDMiddleLot, STDOuterLot, TypeInnerLot, TypeMiddleLot, TypeOuterLot, PrintDatetime, CreateBy AS LastUpdateBy
            // CopieInner, CopieMiddle, CopieOuter, NotFullSTDInner, NotFulSTDMiddle, NotFulSTDOuter, IsPrint

            PrintlabelEntity rec = new PrintlabelEntity();
            rec.ID = (int)reader["ID"];
            rec.Model = reader["Model"].ToString();
            rec.Country = reader["CountryEN"].ToString();
            rec.CountryTH = reader["CountryTH"].ToString();
            rec.PartNo = reader["PartNo"].ToString();
            rec.PartName = reader["PartNameEN"].ToString();
            rec.PartNameTH = reader["PartNameTH"].ToString();
            rec.Qty = (decimal)reader["Qty"];
            rec.LotNo = reader["LotNo"].ToString();
            rec.PrintDatetime = (DateTime)reader["PrintDatetime"];
            rec.TypeLabel = reader["TypeLabel"].ToString();
            rec.STDLot = (decimal)reader["STDLot"];
            rec.TypeLot = reader["TypeLot"].ToString();
            rec.Copie = (decimal)reader["Copie"];
            rec.NotFullSTD = (decimal)reader["NotFullSTD"];
            rec.IsPrint = (bool)reader["IsPrint"];
            rec.LastupdateBy = reader["CreateBy"].ToString();
            
            
            //ID, Country, Model, PartNo, PartName, Qty, LotNo, PrintDatetime, TypeLabel, STDLot, TypeLot, Copie, NotFullSTD, IsPrint, CreateBy
            return rec;

        }

        protected List<PrintlabelEntity> GetPrintLabelCollectionfromreader(IDataReader reader)
        {
            List<PrintlabelEntity> record = new List<PrintlabelEntity>();
            try
            {
                while (reader.Read())
                {
                    record.Add(GetPrintLabelFromreader(reader));
                }
            }
            finally
            {
                if (reader.IsClosed == false) reader.Close();
            }
            return record;
        }



        public List<PrintlabelEntity> GetPrintLabelAll()
        {
            List<PrintlabelEntity> record = null;

            dbManager.Open();

            try
            {
                record = GetPrintLabelCollectionfromreader(dbManager.ExecuteReader(sqlcmd_GetPrintlabelAll));
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetPrintLabelAll() because." + ex.Message, ex);
            }
            return record;
        }
   
        

        public DataTable GetPrintLabelFromDatetime2(DateTime begDatetime, DateTime EndDatetime)
        {
          
            dbManager.Open();
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            try
            {
         
                //sqlcmd_GetReportprint1.CommandText = "WHERE (IsPrint = 1)";
                sqlcmd_GetReportprint.Parameters["@begdatetime"].Value = begDatetime;
                sqlcmd_GetReportprint.Parameters["@enddatetime"].Value = EndDatetime;
               SqlDataAdapter da = new SqlDataAdapter(sqlcmd_GetReportprint);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                  
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally 
            {
            }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used

        }



        public List<PrintlabelEntity> GetPrintLabelFromDatetime(DateTime begDatetime, DateTime EndDatetime)
        {
            List<PrintlabelEntity> record = null;

            dbManager.Open();
            try
            {
               
                
                
                sqlcmd_GetReportprint.Parameters["@begdatetime"].Value = begDatetime;
                sqlcmd_GetReportprint.Parameters["@enddatetime"].Value = EndDatetime;
                record = GetPrintLabelCollectionfromreader(dbManager.ExecuteReader(sqlcmd_GetReportprint));
          

            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetPrintLabelAll() because." + ex.Message, ex);
            }
            return record;
        }

        public string GetPathLabelType(string LabelType)
        {
            //@LabelType
            string ret = string.Empty;

            dbManager.Open();
            try
            {
                sqlcmd_GetLabelType.Parameters["@LabelType"].Value = LabelType;
                ret = (string)dbManager.ExecuteScalar(sqlcmd_GetLabelType);
            }
            catch (Exception ex)
            {
                throw new Exception("Problems in using this function GetPrintLabelAll() because." + ex.Message, ex);
            }
            return ret;
        }

        #endregion

        public int InsertPrintLabel(List<PrintlabelEntity> records)
        {
            int ret = 0;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();

                //sqlcmd_InsertPrintlabel.Parameters["@Model"].Value = record.Model;
                //sqlcmd_InsertPrintlabel.Parameters["@Country"].Value = record.Country;
                //sqlcmd_InsertPrintlabel.Parameters["@PartNo"].Value = record.PartNo;
                //sqlcmd_InsertPrintlabel.Parameters["@Qty"].Value = record.QTY;
                //sqlcmd_InsertPrintlabel.Parameters["@LotNo"].Value = record.LotNo;
                //sqlcmd_InsertPrintlabel.Parameters["@STDInnerLot"].Value = record.STDInnerLot;
                //sqlcmd_InsertPrintlabel.Parameters["@STDMiddleLot"].Value = record.STDMiddleLot;
                //sqlcmd_InsertPrintlabel.Parameters["@STDOuterLot"].Value = record.STDOuterLot;
                //sqlcmd_InsertPrintlabel.Parameters["@TypeInnerLot"].Value = record.TypeInnerLot;
                //sqlcmd_InsertPrintlabel.Parameters["@TypeMiddleLot"].Value = record.TypeMiddleLot;
                //sqlcmd_InsertPrintlabel.Parameters["@TypeOuterLot"].Value = record.TypeOuterLot;
                //sqlcmd_InsertPrintlabel.Parameters["@PrintDatetime"].Value = record.PrintDatetime;// string.Format("{0:yyyy-mm-dd}", record.PrintDatetime);
                //sqlcmd_InsertPrintlabel.Parameters["@LastUpdateBy"].Value = record.LastupdateBy;

                //sqlcmd_InsertPrintlabel.Parameters["@CopieInner"].Value = record.CopieInner;
                //sqlcmd_InsertPrintlabel.Parameters["@CopieMiddle"].Value = record.CopieMiddle;
                //sqlcmd_InsertPrintlabel.Parameters["@CopieOuter"].Value = record.CopieOuter;
                //sqlcmd_InsertPrintlabel.Parameters["@NotFullSTDInner"].Value = record.NotFullSTDInner;
                //sqlcmd_InsertPrintlabel.Parameters["@NotFulSTDMiddle"].Value = record.NotFulSTDMiddle;
                //sqlcmd_InsertPrintlabel.Parameters["@NotFulSTDOuter"].Value = record.NotFulSTDOuter;

                foreach (PrintlabelEntity record in records)
                {
                    sqlcmd_InsertPrintlabel.Parameters["@Country"].Value = record.Country;
                    sqlcmd_InsertPrintlabel.Parameters["@Model"].Value = record.Model;

                    sqlcmd_InsertPrintlabel.Parameters["@PartNo"].Value = record.PartNo;
                    sqlcmd_InsertPrintlabel.Parameters["@PartName"].Value = record.PartName;
                    sqlcmd_InsertPrintlabel.Parameters["@Qty"].Value = record.Qty;
                    sqlcmd_InsertPrintlabel.Parameters["@LotNo"].Value = record.LotNo;
                    sqlcmd_InsertPrintlabel.Parameters["@PrintDatetime"].Value = record.PrintDatetime;
                    sqlcmd_InsertPrintlabel.Parameters["@TypeLabel"].Value = record.TypeLabel;
                    sqlcmd_InsertPrintlabel.Parameters["@STDLot"].Value = record.STDLot;
                    sqlcmd_InsertPrintlabel.Parameters["@TypeLot"].Value = record.TypeLot;
                    sqlcmd_InsertPrintlabel.Parameters["@Copie"].Value = record.Copie;
                    sqlcmd_InsertPrintlabel.Parameters["@NotFullSTD"].Value = record.NotFullSTD;
                   // sqlcmd_InsertPrintlabel.Parameters["@IsPrint"].Value = record.IsPrint;
                    sqlcmd_InsertPrintlabel.Parameters["@CreateBy"].Value = record.LastupdateBy;
                    sqlcmd_InsertPrintlabel.Parameters["@PartNameTH"].Value = record.PartNameTH;
                    sqlcmd_InsertPrintlabel.Parameters["@CountryTH"].Value = record.CountryTH;
                    //@Country,@Model,@PartNo,@PartName,@Qty,@LotNo,@PrintDatetime,@TypeLabel,
                    //@STDLot,@TypeLot,@Copie,@NotFullSTD,@IsPrint,@CreateBy, GETDATE()
                    //sqlcmd_InsertPrintlabel.Parameters["@CreateDatetime"].Value = record.LastupdateBy;
                    dbManager.ExecuteNonQuery(sqlcmd_InsertPrintlabel);
                }
                //@IsPrint

                

                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function InsertPrintLabel because." + ex.Message, ex);
            }
            return ret;
        }

        public int InsertBarTander(string PartNo, string PartName, decimal stdpack, string lotno, string country,string PartNameTH, string countryTH)
        {
            int ret = 0;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();
                //Delete  Data all
                dbManager.ExecuteNonQuery(sqlcmd_deleteBarTander);

                sqlcmd_InsertBarTander.Parameters["@PartNo"].Value = PartNo;
                sqlcmd_InsertBarTander.Parameters["@PartName"].Value = PartName;
                sqlcmd_InsertBarTander.Parameters["@STDQTY"].Value = stdpack;
                sqlcmd_InsertBarTander.Parameters["@LotNo"].Value = lotno;
                sqlcmd_InsertBarTander.Parameters["@Coutry"].Value = "Made in " + country;
                sqlcmd_InsertBarTander.Parameters["@PartNameTH"].Value = PartNameTH;
                sqlcmd_InsertBarTander.Parameters["@CoutryTH"].Value = countryTH;
                dbManager.ExecuteNonQuery(sqlcmd_InsertBarTander);
                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function InsertPrintLabel because." + ex.Message, ex);
            }
            return ret;
        }


        public int InsertBarTander(string PartNo, string PartName, decimal stdpack, string lotno, string country, string PartNameTH, string countryTH,int Copies) {
            int ret = 0;
            try {
                dbManager.Open();
                dbManager.BeginTransaction();
                //Delete  Data all
                dbManager.ExecuteNonQuery(sqlcmd_deleteBarTander);

                
                sqlcmd_InsertBarTander.Parameters["@PartNo"].Value = PartNo;
                sqlcmd_InsertBarTander.Parameters["@PartName"].Value = PartName;
                sqlcmd_InsertBarTander.Parameters["@STDQTY"].Value = stdpack;
                sqlcmd_InsertBarTander.Parameters["@LotNo"].Value = lotno;
                sqlcmd_InsertBarTander.Parameters["@Coutry"].Value = "Made in " + country;
                sqlcmd_InsertBarTander.Parameters["@PartNameTH"].Value = PartNameTH;
                sqlcmd_InsertBarTander.Parameters["@CoutryTH"].Value = countryTH;

                for (int i = 0; i < Copies; i++) {
                    dbManager.ExecuteNonQuery(sqlcmd_InsertBarTander);
                }
               


                dbManager.CommitTransaction();
            } catch (Exception ex) {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function InsertPrintLabel because." + ex.Message, ex);
            }
            return ret;
        }

        //@ID
        public int UpdatePrintLabel(PrintlabelEntity record)
        {
            int ret = 0;
            try
            {
                dbManager.Open();
                dbManager.BeginTransaction();

                sqlcmd_updatePrintlabel.Parameters["@ID"].Value = record.ID;
                dbManager.ExecuteNonQuery(sqlcmd_updatePrintlabel);

                dbManager.CommitTransaction();
            }
            catch (Exception ex)
            {
                dbManager.RollbackTransaction();
                ret = 1;
                throw new Exception("Problems in using this function InsertPrintLabel because." + ex.Message, ex);
            }
            return ret;
        }
    }
}
