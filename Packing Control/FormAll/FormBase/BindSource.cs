using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Packing_Control.FormAll.FormBase
{
    /// <summary>
    /// 
    /// </summary>
    public class BindSource
    {
        public BindSource()
        {        }

        public BindSource(object displaymember, object valuemenber)
        {
            this.DisplayMember = displaymember;
            this.ValueMember = valuemenber;
        }

        public object DisplayMember { get; set; }
        public object ValueMember { get; set; }
    }
}
