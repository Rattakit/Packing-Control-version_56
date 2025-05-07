using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using OGA.Database;
using System.Configuration;

namespace OGA.Packing.DAL
{
    public partial class baseDAL : Component
    {
        string Connectionstring = string.Empty;
        public DBManager dbManager = null;

        public string GetConnectionString()
        {
            //string _connectionStringsName = ConfigurationSettings. //ConfigurationSettings.AppSettings["Packing_Control.Properties.Settings.Setting"].ToString();
            string _connectionStringsName = "Packing_Control.Properties.Settings.ConnectionString";
            ConnectionStringSettingsCollection config = ConfigurationManager.ConnectionStrings;
            if (config[_connectionStringsName] != null)
                return config[_connectionStringsName].ToString();
            else
                return string.Empty;
        }

        public baseDAL()
        {
            InitializeComponent();
            dbManager = new DBManager(DataProvider.SqlServer, GetConnectionString());
        }

        public baseDAL(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


    }
}
