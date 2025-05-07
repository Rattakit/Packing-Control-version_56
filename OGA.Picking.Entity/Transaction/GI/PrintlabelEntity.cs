using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGA.Packing.Entity.Transaction.GI
{
    public class PrintlabelEntity
    {
        public PrintlabelEntity() { }

        //public decimal CopieInner { get; set; }
        //public decimal CopieMiddle { get; set; }
        //public decimal CopieOuter { get; set; }
        //public decimal NotFullSTDInner { get; set; }
        //public decimal NotFulSTDMiddle { get; set; }
        //public decimal NotFulSTDOuter { get; set; }
        //public string Delete { get; set; }
        //public string Printbarcode { get; set; }

        //public PrintlabelEntity(
        //               int id,
        //                string country,
        //               string model,
        //               string partno,
        //                string partname,
        //                decimal qty,
        //                 string Lotno,
        //               decimal stdinnerlot,
        //               decimal stdmiddlelot,
        //               decimal stdouterlot,
        //               string typeinnerlot,
        //               string typemiddlelot,
        //               string typeouterlot,
        //                DateTime printDatetime,
        //               string lastupdateby,
        //    decimal copieinner,
        //    decimal copiemiddle,
        //    decimal copieouter,
        //    decimal notfullstdinner,
        //    decimal notfullstdmiddle,
        //    decimal notfullstdouter,
        //    bool isprint
        //           )
        //{
        //    this.ID = id;
        //    this.Country = country;
        //    this.Model = model;
        //    this.PartNo = partno;
        //    this.PartName = partname;
        //    this.QTY = qty;
        //    this.LotNo = Lotno;
        //    this.STDInnerLot = stdinnerlot;
        //    this.STDMiddleLot = stdmiddlelot;
        //    this.STDOuterLot = stdouterlot;
        //    this.TypeInnerLot = typeinnerlot;
        //    this.TypeMiddleLot = typemiddlelot;
        //    this.TypeOuterLot = typeouterlot;
        //    this.PrintDatetime = printDatetime;
        //    this.LastupdateBy = lastupdateby;
        //    this.CopieInner = copieinner;
        //    this.CopieMiddle = copiemiddle;
        //    this.CopieOuter = copieouter;
        //    this.NotFullSTDInner = notfullstdinner;
        //    this.NotFulSTDMiddle = notfullstdmiddle;
        //    this.NotFulSTDOuter = notfullstdouter;
        //    this.IsPrint = isprint;
        //}

        //private int _ID = 0;
        //public int ID
        //{
        //    get { return _ID; }
        //    set { _ID = value; }
        //}

        //public string Country { get; set; }

        //private string _Model = string.Empty;
        //public string Model
        //{
        //    get { return _Model; }
        //    set { _Model = value; }
        //}

        //private string _PartNo = string.Empty;
        //public string PartNo
        //{
        //    get { return _PartNo; }
        //    set { _PartNo = value; }
        //}

        //public string PartName { get; set; }

        //public decimal QTY { get; set; }
        //public string LotNo { get; set; }

        //private decimal _STDInnerLot = 0;
        //public decimal STDInnerLot
        //{
        //    get { return _STDInnerLot; }
        //    set { _STDInnerLot = value; }
        //}

        //private decimal _STDMiddleLot = 0;
        //public decimal STDMiddleLot
        //{
        //    get { return _STDMiddleLot; }
        //    set { _STDMiddleLot = value; }
        //}

        //private decimal _STDOuterLot = 0;
        //public decimal STDOuterLot
        //{
        //    get { return _STDOuterLot; }
        //    set { _STDOuterLot = value; }
        //}

        //private string _TypeInnerLot = string.Empty;
        //public string TypeInnerLot
        //{
        //    get { return _TypeInnerLot; }
        //    set { _TypeInnerLot = value; }
        //}

        //private string _TypeMiddleLot = string.Empty;
        //public string TypeMiddleLot
        //{
        //    get { return _TypeMiddleLot; }
        //    set { _TypeMiddleLot = value; }
        //}

        //private string _TypeOuterLot = string.Empty;
        //public string TypeOuterLot
        //{
        //    get { return _TypeOuterLot; }
        //    set { _TypeOuterLot = value; }
        //}

        //public decimal CopieInner { get; set; }
        //public decimal CopieMiddle { get; set; }
        //public decimal CopieOuter { get; set; }
        //public decimal NotFullSTDInner { get; set; }
        //public decimal NotFulSTDMiddle { get; set; }
        //public decimal NotFulSTDOuter { get; set; }
        //public bool IsPrint { get; set; }

        //public DateTime PrintDatetime { get; set; }

        //private string _LastupdateBy = string.Empty;
        //public string LastupdateBy
        //{
        //    get { return _LastupdateBy; }
        //    set { _LastupdateBy = value; }
        //}

        public int ID { get; set; }
        public string Country { get; set; }
        public string Model { get; set; }
        public string PartNo { get; set; }
        public string PartName { get; set; }
        public decimal Qty { get; set; }
        public string LotNo { get; set; }
        public DateTime PrintDatetime { get; set; }
        public string TypeLabel { get; set; }
        public decimal STDLot { get; set; }
        public string TypeLot { get; set; }
        public decimal Copie { get; set; }
        public decimal NotFullSTD { get; set; }
        public bool IsPrint { get; set; }
        public string LastupdateBy { get; set; }
        public string PartNameTH { get; set; }
        public string CountryTH { get; set; }
    }
}
