namespace OGA.Packing.DAL.Transaction.GI
{
    partial class PrinlabelDAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrinlabelDAL));
            this.sqlcmd_InsertPrintlabel = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_GetPrintlabelAll = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_InsertBarTander = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_deleteBarTander = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_updatePrintlabel = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_GetLabelType = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_GetReportprint = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_GetReportprint1 = new System.Data.SqlClient.SqlCommand();
            // 
            // sqlconn
            // 
            this.sqlconn.ConnectionString = "Data Source=PRGMKWANSIRI\\SQLEXPRESS;Initial Catalog=PackingHonda;Persist Security" +
                " Info=True;User ID=sa;Password=pass";
            // 
            // sqlcmd_InsertPrintlabel
            // 
            this.sqlcmd_InsertPrintlabel.CommandText = resources.GetString("sqlcmd_InsertPrintlabel.CommandText");
            this.sqlcmd_InsertPrintlabel.Connection = this.sqlconn;
            this.sqlcmd_InsertPrintlabel.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.VarChar, 100, "Country"),
            new System.Data.SqlClient.SqlParameter("@Model", System.Data.SqlDbType.VarChar, 20, "Model"),
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, "PartNo"),
            new System.Data.SqlClient.SqlParameter("@PartName", System.Data.SqlDbType.VarChar, 200, "PartName"),
            new System.Data.SqlClient.SqlParameter("@Qty", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Qty", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@LotNo", System.Data.SqlDbType.VarChar, 20, "LotNo"),
            new System.Data.SqlClient.SqlParameter("@PrintDatetime", System.Data.SqlDbType.DateTime, 8, "PrintDatetime"),
            new System.Data.SqlClient.SqlParameter("@TypeLabel", System.Data.SqlDbType.VarChar, 20, "TypeLabel"),
            new System.Data.SqlClient.SqlParameter("@STDLot", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "STDLot", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@TypeLot", System.Data.SqlDbType.VarChar, 20, "TypeLot"),
            new System.Data.SqlClient.SqlParameter("@Copie", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "Copie", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@NotFullSTD", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "NotFullSTD", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@CreateBy", System.Data.SqlDbType.VarChar, 50, "CreateBy"),
            new System.Data.SqlClient.SqlParameter("@PartNameTH", System.Data.SqlDbType.VarChar, 200, "PartNameTH"),
            new System.Data.SqlClient.SqlParameter("@CountryTH", System.Data.SqlDbType.VarChar, 100, "CountryTH")});
            // 
            // sqlcmd_GetPrintlabelAll
            // 
            this.sqlcmd_GetPrintlabelAll.CommandText = resources.GetString("sqlcmd_GetPrintlabelAll.CommandText");
            this.sqlcmd_GetPrintlabelAll.Connection = this.sqlconn;
            // 
            // sqlcmd_InsertBarTander
            // 
            this.sqlcmd_InsertBarTander.CommandText = "INSERT INTO tbt_Bartander\r\n                         (PartNo, PartName, STDQTY, Lo" +
                "tNo, Coutry,PartNameTH,CoutryTH)\r\nVALUES        (@PartNo,@PartName,@STDQTY,@LotNo,@Coutry,@PartNameTH,@CoutryTH)";
            this.sqlcmd_InsertBarTander.Connection = this.sqlconn;
            this.sqlcmd_InsertBarTander.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, "PartNo"),
            new System.Data.SqlClient.SqlParameter("@PartName", System.Data.SqlDbType.VarChar, 200, "PartName"),
            new System.Data.SqlClient.SqlParameter("@STDQTY", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "STDQTY", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@LotNo", System.Data.SqlDbType.VarChar, 20, "LotNo"),
            new System.Data.SqlClient.SqlParameter("@Coutry", System.Data.SqlDbType.VarChar, 50, "Coutry"),
            new System.Data.SqlClient.SqlParameter("@PartNameTH", System.Data.SqlDbType.VarChar, 200, "PartNameTH"),
            new System.Data.SqlClient.SqlParameter("@CoutryTH", System.Data.SqlDbType.VarChar, 50, "CoutryTH")
            });
            // 
            // sqlcmd_deleteBarTander
            // 
            this.sqlcmd_deleteBarTander.CommandText = "DELETE FROM tbt_Bartander";
            this.sqlcmd_deleteBarTander.Connection = this.sqlconn;
            // 
            // sqlcmd_updatePrintlabel
            // 
            this.sqlcmd_updatePrintlabel.CommandText = "UPDATE tbt_PrintLabel SET IsPrint = 1 WHERE (ID = @ID)";
            this.sqlcmd_updatePrintlabel.Connection = this.sqlconn;
            this.sqlcmd_updatePrintlabel.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlcmd_GetLabelType
            // 
            this.sqlcmd_GetLabelType.CommandText = "SELECT        Pathformat\r\nFROM            tbm_LabelType\r\nWHERE        (LabelType " +
                "= @LabelType)";
            this.sqlcmd_GetLabelType.Connection = this.sqlconn;
            this.sqlcmd_GetLabelType.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LabelType", System.Data.SqlDbType.VarChar, 20, "LabelType")});
            // 
            // sqlcmd_GetReportprint
            // 
            this.sqlcmd_GetReportprint.CommandText = resources.GetString("sqlcmd_GetReportprint.CommandText");
            this.sqlcmd_GetReportprint.Connection = this.sqlconn;
            this.sqlcmd_GetReportprint.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@begdatetime", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@enddatetime", System.Data.SqlDbType.DateTime)});
            // 
            // sqlcmd_GetReportprint1
            // 
            this.sqlcmd_GetReportprint1.CommandText = "SELECT     ID, Country, Model, PartNo, PartName, Qty, LotNo, PrintDatetime, TypeL" +
                "abel, STDLot, TypeLot, Copie, NotFullSTD, CreateBy, IsPrint,PartNameTH,CountryTH  \r\nFROM         tbt_Pr" +
                "intLabel";
            this.sqlcmd_GetReportprint1.Connection = this.sqlconn;

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlcmd_InsertPrintlabel;
        private System.Data.SqlClient.SqlCommand sqlcmd_GetPrintlabelAll;
        private System.Data.SqlClient.SqlCommand sqlcmd_InsertBarTander;
        private System.Data.SqlClient.SqlCommand sqlcmd_deleteBarTander;
        private System.Data.SqlClient.SqlCommand sqlcmd_updatePrintlabel;
        private System.Data.SqlClient.SqlCommand sqlcmd_GetLabelType;
        private System.Data.SqlClient.SqlCommand sqlcmd_GetReportprint;
        private System.Data.SqlClient.SqlCommand sqlcmd_GetReportprint1;
    }
}
