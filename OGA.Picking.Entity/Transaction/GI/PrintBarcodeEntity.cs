using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGA.Packing.Entity.Transaction.GI
{
    public class PrintBarcodeEntity
    {
        public PrintBarcodeEntity() { }

        private string _PartNo = string.Empty;
        public string PartNo
        {
            get { return _PartNo; }
            set { _PartNo = value; }
        }

        public string PartName { get; set; }

        public decimal QTY { get; set; }
        public string LotNo { get; set; }

        private decimal _STDPack = 0;
        public decimal STDPack {
            get { return _STDPack; }
            set { _STDPack = value; }
        }

        public string PathBarcode { get; set; }
        public decimal Barcode { get; set; }

        public string Coutry { get; set; }
        public string LabelType { get; set; }

        public string PartNameTH { get; set; }
        public string CoutryTH { get; set; }


    }
}
