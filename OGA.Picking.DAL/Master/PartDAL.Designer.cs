namespace OGA.Packing.DAL.Master
{
    partial class PartDAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartDAL));
            this.sqlcmd_InsertPart = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_UpdatePart = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_GetPartAll = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_CheckDuplicatePart = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_InsertPartlabel = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_UpdatePartLabel = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_Delete = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_Delete_tbt_PartLabel = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_GetTransaction = new System.Data.SqlClient.SqlCommand();
            // 
            // sqlcmd_InsertPart
            // 
            this.sqlcmd_InsertPart.CommandText = resources.GetString("sqlcmd_InsertPart.CommandText");
            this.sqlcmd_InsertPart.Connection = this.sqlconn;
            this.sqlcmd_InsertPart.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Model", System.Data.SqlDbType.VarChar, 20, "Model"),
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, "PartNo"),
            new System.Data.SqlClient.SqlParameter("@PartName", System.Data.SqlDbType.VarChar, 200, "PartName"),
            new System.Data.SqlClient.SqlParameter("@STDInnerLot", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "STDInnerLot", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@STDMiddleLot", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "STDMiddleLot", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@STDOuterLot", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "STDOuterLot", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@LastUpdateBy", System.Data.SqlDbType.NVarChar, 50, "CreateBy"),
            new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.VarChar, 50, "Country"),
            new System.Data.SqlClient.SqlParameter("@PartNameTH", System.Data.SqlDbType.VarChar, 200, "PartNameTH"),
            new System.Data.SqlClient.SqlParameter("@CountryTH", System.Data.SqlDbType.VarChar, 50, "CountryTH")


            });
            // 
            // sqlcmd_UpdatePart
            // 
            this.sqlcmd_UpdatePart.CommandText = resources.GetString("sqlcmd_UpdatePart.CommandText");
            this.sqlcmd_UpdatePart.Connection = this.sqlconn;
            this.sqlcmd_UpdatePart.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Model", System.Data.SqlDbType.VarChar, 20, "Model"),
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, "PartNo"),
            new System.Data.SqlClient.SqlParameter("@PartName", System.Data.SqlDbType.VarChar, 200, "PartName"),
            new System.Data.SqlClient.SqlParameter("@STDInnerLot", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "STDInnerLot", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@STDMiddleLot", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "STDMiddleLot", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@STDOuterLot", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((byte)(18)), ((byte)(0)), "STDOuterLot", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@LastUpdateBy", System.Data.SqlDbType.VarChar, 20, "UpdateBy"),
            new System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.VarChar, 50, "Country"),
            new System.Data.SqlClient.SqlParameter("@PartNameTH", System.Data.SqlDbType.VarChar, 200, "PartNameTH"),
            new System.Data.SqlClient.SqlParameter("@CountryTH", System.Data.SqlDbType.VarChar, 50, "CountryTH"),
            });
            // 
            // sqlcmd_GetPartAll
            // 
            this.sqlcmd_GetPartAll.CommandText = resources.GetString("sqlcmd_GetPartAll.CommandText");
            this.sqlcmd_GetPartAll.Connection = this.sqlconn;
            // 
            // sqlcmd_CheckDuplicatePart
            // 
            this.sqlcmd_CheckDuplicatePart.CommandText = "SELECT        COUNT(Model) AS Expr1\r\nFROM            tbm_Part\r\nWHERE        (Part" +
                "No = @PartNo)";
            this.sqlcmd_CheckDuplicatePart.Connection = this.sqlconn;
            this.sqlcmd_CheckDuplicatePart.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, "PartNo")});
            // 
            // sqlcmd_InsertPartlabel
            // 
            this.sqlcmd_InsertPartlabel.CommandText = "INSERT INTO tbm_PartLabel\r\n                         (PartNo, InnerLot, MiddleLot," +
                " OuterLot, CreateBy, CreateDatetime)\r\nVALUES        (@PartNo,@InnerLot,@MiddleLo" +
                "t,@OuterLot,@LastUpdateBy, GETDATE())";
            this.sqlcmd_InsertPartlabel.Connection = this.sqlconn;
            this.sqlcmd_InsertPartlabel.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, "PartNo"),
            new System.Data.SqlClient.SqlParameter("@InnerLot", System.Data.SqlDbType.VarChar, 20, "InnerLot"),
            new System.Data.SqlClient.SqlParameter("@MiddleLot", System.Data.SqlDbType.VarChar, 20, "MiddleLot"),
            new System.Data.SqlClient.SqlParameter("@OuterLot", System.Data.SqlDbType.VarChar, 20, "OuterLot"),
            new System.Data.SqlClient.SqlParameter("@LastUpdateBy", System.Data.SqlDbType.NChar, 20, "CreateBy")});
            // 
            // sqlcmd_UpdatePartLabel
            // 
            this.sqlcmd_UpdatePartLabel.CommandText = resources.GetString("sqlcmd_UpdatePartLabel.CommandText");
            this.sqlcmd_UpdatePartLabel.Connection = this.sqlconn;
            this.sqlcmd_UpdatePartLabel.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, "PartNo"),
            new System.Data.SqlClient.SqlParameter("@InnerLot", System.Data.SqlDbType.VarChar, 20, "InnerLot"),
            new System.Data.SqlClient.SqlParameter("@MiddleLot", System.Data.SqlDbType.VarChar, 20, "MiddleLot"),
            new System.Data.SqlClient.SqlParameter("@OuterLot", System.Data.SqlDbType.VarChar, 20, "OuterLot"),
            new System.Data.SqlClient.SqlParameter("@LastUpdateBy", System.Data.SqlDbType.VarChar, 20, "UpdateBy")});
            // 
            // sqlcmd_Delete
            // 
            this.sqlcmd_Delete.CommandText = "DELETE FROM tbm_Part\r\nWHERE        (PartNo = @PartNo)";
            this.sqlcmd_Delete.Connection = this.sqlconn;
            this.sqlcmd_Delete.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PartNo", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlcmd_Delete_tbt_PartLabel
            // 
            this.sqlcmd_Delete_tbt_PartLabel.CommandText = "DELETE FROM tbm_PartLabel\r\nWHERE        (PartNo = @PartNo)";
            this.sqlcmd_Delete_tbt_PartLabel.Connection = this.sqlconn;
            this.sqlcmd_Delete_tbt_PartLabel.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PartNo", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlcmd_GetTransaction
            // 
            this.sqlcmd_GetTransaction.CommandText = "SELECT        COUNT(ID) AS r_count\r\nFROM            tbt_PrintLabel\r\nWHERE        " +
                "(PartNo = @PartNo)";
            this.sqlcmd_GetTransaction.Connection = this.sqlconn;
            this.sqlcmd_GetTransaction.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PartNo", System.Data.SqlDbType.VarChar, 20, "PartNo")});

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlcmd_InsertPart;
        private System.Data.SqlClient.SqlCommand sqlcmd_UpdatePart;
        private System.Data.SqlClient.SqlCommand sqlcmd_GetPartAll;
        private System.Data.SqlClient.SqlCommand sqlcmd_CheckDuplicatePart;
        private System.Data.SqlClient.SqlCommand sqlcmd_InsertPartlabel;
        private System.Data.SqlClient.SqlCommand sqlcmd_UpdatePartLabel;
        private System.Data.SqlClient.SqlCommand sqlcmd_Delete;
        private System.Data.SqlClient.SqlCommand sqlcmd_Delete_tbt_PartLabel;
        private System.Data.SqlClient.SqlCommand sqlcmd_GetTransaction;
    }
}
