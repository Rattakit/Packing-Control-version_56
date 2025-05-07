using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Master;
using OGA.Packing.DAL.Master;

namespace OGA.Packing.BLL.Master
{
    public static class LabelTypeBLL
    {
        private static LabelTypeDAL dal = new LabelTypeDAL();
        public static List<LabelTypeEntity> GetLabelTypeAll(this List<LabelTypeEntity> record)
        {
            return dal.GetLabelTypeAll();
        }

        public static int CheckDuplicateData(this LabelTypeEntity record)
        {
            return dal.CheckDuplicateData(record);
        }

        public static int InsertPart(this LabelTypeEntity record)
        {
            return dal.InsertLabelType(record);
        }

        public static int UpdatePart(this LabelTypeEntity record)
        {
            return dal.UpdateLabelType(record);
        }

        public static  string DeleteLabelType(this LabelTypeEntity record)
        {
            return dal.DeleteLabelType(record);
        }

    }
}
