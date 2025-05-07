namespace OGA.Packing.DAL
{
    partial class baseDAL
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
            this.sqlconn = new System.Data.SqlClient.SqlConnection();
            this.sqlcmd = new System.Data.SqlClient.SqlCommand();
            // 
            // sqlconn
            // 
            this.sqlconn.ConnectionString = "Data Source=PRGWICHAI-PC\\SQLEXPRESS;Initial Catalog=PackingHonda;Persist Security" +
                " Info=True;User ID=sa;Password=r0oNwrgikt";
            this.sqlconn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlcmd
            // 
            this.sqlcmd.Connection = this.sqlconn;

        }

        #endregion

        protected System.Data.SqlClient.SqlConnection sqlconn;
        protected System.Data.SqlClient.SqlCommand sqlcmd;

    }
}
