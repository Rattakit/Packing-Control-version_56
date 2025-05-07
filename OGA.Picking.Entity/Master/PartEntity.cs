using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGA.Packing.Entity.Master
{
    public class PartEntity
    {
        public PartEntity() { }

        public PartEntity(
                        string model,
                        string partno,
                        string partname,
                        string country,
                        Decimal stdinnerlot,
                        Decimal stdmiddlelot,
                        Decimal stdouterlot,
                        string innerLot,
                        string middleLot,
                        string outerLot,
                        string lastupdateby,
                        string pathinnerlot,
            string pathmiddlelot,
            string pathouterlot,
                        string partnameTH,
                        string countryTH
                    )
        {
            this.Model = model;
            this.PartNo = partno;
            this.PartName = partname;
            this.Country = country;
            this.STDInnerLot = stdinnerlot;
            this.STDMiddleLot = stdmiddlelot;
            this.STDOuterLot = stdouterlot;
            this.InnerLot = innerLot;
            this.MiddleLot = middleLot;
            this.OuterLot = outerLot;
            this.LastupdateBy = lastupdateby;
            this.PathInnerlot = pathinnerlot;
            this.PathMiddlelot = pathmiddlelot;
            this.PathOuterlot = pathouterlot;
            this.PartNameTH = partnameTH;
            this.CountryTH = countryTH;


        }

        public string PathInnerlot { get; set; }
        public string PathMiddlelot { get; set; }
        public string PathOuterlot { get; set; }

        private string _Model = string.Empty;
        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        private string _PartNo = string.Empty;
        public string PartNo
        {
            get { return _PartNo; }
            set { _PartNo = value; }
        }

        private string _PartName = string.Empty;
        public string PartName
        {
            get { return _PartName; }
            set { _PartName = value; }
        }

        public string Country { get; set; }

        private decimal _STDInnerLot = 0;
        public decimal STDInnerLot
        {
            get { return _STDInnerLot; }
            set { _STDInnerLot = value; }
        }

        private decimal _STDMiddleLot = 0;
        public decimal STDMiddleLot
        {
            get { return _STDMiddleLot; }
            set { _STDMiddleLot = value; }
        }

        private decimal _STDOuterLot = 0;
        public decimal STDOuterLot
        {
            get { return _STDOuterLot; }
            set { _STDOuterLot = value; }
        }


        public string InnerLot { get; set; }
        public string MiddleLot { get; set; }
        public string OuterLot { get; set; }


        private string _LastupdateBy = string.Empty;
        public string LastupdateBy
        {
            get { return _LastupdateBy; }
            set { _LastupdateBy = value; }
        }

        private string _PartNameTH = string.Empty;
        public string PartNameTH {
            get { return _PartNameTH; }
            set { _PartNameTH = value; }
        }

        public string CountryTH { get; set; }
    }
}
