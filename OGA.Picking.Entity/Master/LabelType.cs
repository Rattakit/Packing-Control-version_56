using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGA.Packing.Entity.Master
{
    public class LabelTypeEntity
    {
        public LabelTypeEntity() { }

        public LabelTypeEntity(
                        string labeltype,
                        string pathformat,
                        string lastupdateby
                    )
        {
            this.LabelType = labeltype;
            this.Pathformat = pathformat;
            this.LastupdateBy = lastupdateby;
        }

        private string _LabelType = string.Empty;
        public string LabelType
        {
            get { return _LabelType; }
            set { _LabelType = value; }
        }

        private string _Pathformat = string.Empty;
        public string Pathformat
        {
            get { return _Pathformat; }
            set { _Pathformat = value; }
        }

        private string _LastupdateBy = string.Empty;
        public string LastupdateBy
        {
            get { return _LastupdateBy; }
            set { _LastupdateBy = value; }
        }
    }
}
