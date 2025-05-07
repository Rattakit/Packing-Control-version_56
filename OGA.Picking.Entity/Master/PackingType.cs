using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGA.Packing.Entity.Master
{
    public class PartLabelEntity
    {
        public PartLabelEntity() { }

        public PartLabelEntity(
                        string partno,
                        string innerlot,
                        string middlelot,
                        string outerlot,
                        string lastupdateby
                    )
        {
            this.PartNo = partno;
            this.InnerLot = innerlot;
            this.MiddleLot = middlelot;
            this.OuterLot = outerlot;
            this.LastupdateBy = lastupdateby;
        }

        private string _PartNo = string.Empty;
        public string PartNo
        {
            get { return _PartNo; }
            set { _PartNo = value; }
        }

        private string _InnerLot = string.Empty;
        public string InnerLot
        {
            get { return _InnerLot; }
            set { _InnerLot = value; }
        }

        private string _MiddleLot = string.Empty;
        public string MiddleLot
        {
            get { return _MiddleLot; }
            set { _MiddleLot = value; }
        }

        private string _OuterLot = string.Empty;
        public string OuterLot
        {
            get { return _OuterLot; }
            set { _OuterLot = value; }
        }

        private string _CreateBy = string.Empty;
        public string CreateBy
        {
            get { return _CreateBy; }
            set { _CreateBy = value; }
        }

        private string _LastupdateBy = string.Empty;
        public string LastupdateBy
        {
            get { return _LastupdateBy; }
            set { _LastupdateBy = value; }
        }

    }
}
