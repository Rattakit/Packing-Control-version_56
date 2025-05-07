using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OGA.Helper.Message;

namespace Packing_Control.FormAll.FormBase
{
 

    public partial class frmBase : Form
    {
        protected enum FormState
        {
            None=0,
            New,
            Edit,
            Cancel
        }

        public frmBase()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OGAMessage.ShowConfirmCloseForm() == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
