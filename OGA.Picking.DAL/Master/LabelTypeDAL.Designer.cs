namespace OGA.Packing.DAL.Master
{
    partial class LabelTypeDAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelTypeDAL));
            this.sqlcmd_CheckDuplicate = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_Insert = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_Update = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_GetLabelTypeAll = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_Delete = new System.Data.SqlClient.SqlCommand();
            this.sqlcmd_GetTransaction = new System.Data.SqlClient.SqlCommand();
            // 
            // sqlcmd_CheckDuplicate
            // 
            this.sqlcmd_CheckDuplicate.CommandText = "SELECT        COUNT(LabelType) AS Expr1\r\nFROM            tbm_LabelType\r\nWHERE    " +
                "    (LabelType = @LabelType)";
            this.sqlcmd_CheckDuplicate.Connection = this.sqlconn;
            this.sqlcmd_CheckDuplicate.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LabelType", System.Data.SqlDbType.VarChar, 20, "LabelType")});
            // 
            // sqlcmd_Insert
            // 
            this.sqlcmd_Insert.CommandText = "INSERT INTO tbm_LabelType\r\n                         (LabelType, Pathformat, Creat" +
                "eBy, CreateDatetime)\r\nVALUES        (@LabelType,@Pathformat,@LastUpdateBy, GETDA" +
                "TE())";
            this.sqlcmd_Insert.Connection = this.sqlconn;
            this.sqlcmd_Insert.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LabelType", System.Data.SqlDbType.VarChar, 20, "LabelType"),
            new System.Data.SqlClient.SqlParameter("@Pathformat", System.Data.SqlDbType.VarChar, 200, "Pathformat"),
            new System.Data.SqlClient.SqlParameter("@LastUpdateBy", System.Data.SqlDbType.NVarChar, 50, "CreateBy")});
            // 
            // sqlcmd_Update
            // 
            this.sqlcmd_Update.CommandText = "UPDATE       tbm_LabelType\r\nSET                LabelType = @LabelType, Pathformat" +
                " = @Pathformat, UpdateBy = @LastUpdateBy, UpdateDatetime = GETDATE()\r\nWHERE     " +
                "   (LabelType = @LabelType)";
            this.sqlcmd_Update.Connection = this.sqlconn;
            this.sqlcmd_Update.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LabelType", System.Data.SqlDbType.VarChar, 20, "LabelType"),
            new System.Data.SqlClient.SqlParameter("@Pathformat", System.Data.SqlDbType.VarChar, 200, "Pathformat"),
            new System.Data.SqlClient.SqlParameter("@LastUpdateBy", System.Data.SqlDbType.VarChar, 20, "UpdateBy")});
            // 
            // sqlcmd_GetLabelTypeAll
            // 
            this.sqlcmd_GetLabelTypeAll.CommandText = "SELECT        LabelType, Pathformat, CreateBy AS LastUpdateBy\r\nFROM            tb" +
                "m_LabelType";
            this.sqlcmd_GetLabelTypeAll.Connection = this.sqlconn;
            // 
            // sqlcmd_Delete
            // 
            this.sqlcmd_Delete.CommandText = "DELETE FROM tbm_LabelType\r\nWHERE        (LabelType = @LabelType)";
            this.sqlcmd_Delete.Connection = this.sqlconn;
            this.sqlcmd_Delete.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LabelType", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LabelType", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlcmd_GetTransaction
            // 
            this.sqlcmd_GetTransaction.CommandText = resources.GetString("sqlcmd_GetTransaction.CommandText");
            this.sqlcmd_GetTransaction.Connection = this.sqlconn;
            this.sqlcmd_GetTransaction.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LabelType", System.Data.SqlDbType.VarChar, 20, "TypeInnerLot")});

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlcmd_CheckDuplicate;
        private System.Data.SqlClient.SqlCommand sqlcmd_Insert;
        private System.Data.SqlClient.SqlCommand sqlcmd_Update;
        private System.Data.SqlClient.SqlCommand sqlcmd_GetLabelTypeAll;
        private System.Data.SqlClient.SqlCommand sqlcmd_Delete;
        private System.Data.SqlClient.SqlCommand sqlcmd_GetTransaction;
    }
}
