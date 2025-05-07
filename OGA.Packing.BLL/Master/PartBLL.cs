using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OGA.Packing.Entity.Master;
using OGA.Packing.DAL.Master;

namespace OGA.Packing.BLL.Master
{
    public static class PartBLL
    {
        private static PartDAL dal = new PartDAL();
        public static List<PartEntity> GetPartAll(this List<PartEntity> record)
        {
            return dal.GetPartAll();
        }

        public static int CheckDuplicateData(this PartEntity record)
        {
            return dal.CheckDuplicateData(record);
        }

        public static int InsertPart(this PartEntity record)
        {
            return dal.InsertPart(record);
        }
        public static int InsertPart(this List<PartEntity> records)
        {
            return dal.InsertPart(records);
        }

        public static int UpdatePart(this PartEntity record)
        {
            return dal.UpdatePart(record);
        }

        public static string DeletePart(this PartEntity record)
        {
            return dal.DeletePart(record);
        }
    }
}
