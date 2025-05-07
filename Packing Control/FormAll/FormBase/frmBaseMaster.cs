using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Packing_Control.FormAll.FormBase
{

    public partial class frmBaseMaster : Packing_Control.FormAll.FormBase.frmBase
    {
        private string _userID = "22057";
        public string UserID { get { return _userID; } set { _userID = value;} }
        private int CurrentIndex = 0;
        protected Object CurrentItem;
        protected List<Control> SetOfControlEnabled = new List<Control>();
        protected List<Control> SetOfControlKeysEnabled = new List<Control>();
        protected FormState State { get; set; }
        protected List<BindSource> FindSource = new List<BindSource>();

        public frmBaseMaster()
        {
            InitializeComponent();
        }

        protected virtual void BindData()
        { }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void DisplayData()
        { }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void GetDataToControl()
        { }

        protected virtual void BeginEdit()
        {
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            splitContainer1.Panel2.Enabled = false;

            CurrentIndex = bs.Position;
            //if(CurrentIndex != -1) CurrentItem = bs.Current;
            //CurrentItem = bs.Current;
            bs.SuspendBinding();

            //'AcceptButton = btnSave
            //'CancelButton = btnCancel
            SetOfControl(true, Color.White);

            if (this.State == FormState.Edit)
            {
                GetDataToControl();
                SetOfControlKeys(false, System.Drawing.SystemColors.Control);
            }
            else
            {
                SetOfControlKeys(true, Color.White);
            }
        }

        protected virtual void EndEdit()
        {
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            splitContainer1.Panel2.Enabled = true;

            AcceptButton = null;
            CancelButton = null;

            bs.ResumeBinding();

            bs.Position = CurrentIndex;
            State = FormState.None;
            SetOfButton();
            SetOfControl(false, System.Drawing.SystemColors.Control);
            SetOfControlKeys(false, System.Drawing.SystemColors.Control);
        }

        protected virtual void SetOfButton()
        {
            btnEdit.Enabled = bs.Count > 0;
            btnDelete.Enabled = bs.Count > 0;
        }

        protected virtual void SetOfControl(bool state, Color bgColor)
        {
            foreach (Control c in SetOfControlEnabled)
            {
                c.BackColor = bgColor;
                c.Enabled = state;
            }

        }

        protected virtual void SetOfControlKeys(bool state, Color bgColor)
        {
            foreach (Control c in SetOfControlKeysEnabled)
            {
                c.BackColor = bgColor;
                c.Enabled = state;
            }
        }


        protected void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
           // If bs.DataSource Is Nothing Then Exit Sub
            if (bs.DataSource == null) return;

            //'// Don't search if the underlying IBindingList implementation
            //'// doesn't support searching
            if (bs.SupportsSorting) return;
            // '// Don’t search for a column isn’t specified to search in
            string key = txtFindDataGrid.Text;

            if (string.IsNullOrEmpty(key)) return;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                PropertyDescriptorCollection propertiesDC = bs.GetItemProperties(null);
                PropertyDescriptor prop_ = propertiesDC[key];
                string Condition = string.Empty;
                if (txtFindDataGrid.Text.Trim().Length == 0)
                {
                    bs.RemoveFilter();
                }
                else
                {
                    Condition = String.Format(" {0} Like %{1}%", prop_.DisplayName, txtFindDataGrid.Text);
                    bs.Filter = Condition;
                    int c = bs.Count;
                }

                txtFindDataGrid.Focus();
                txtFindDataGrid.SelectAll();
                    this.Refresh();

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }


        }

        protected void AddPropertiesColumn()
        {
            ///don't add if have existing properties in combobox
            if (cbxFindDataGrid.Items.Count > 0) return;

            //foreach (DataGridViewColumnCollection c in dgvShow.Columns)
            //{ 
            //    foreach (DataGridViewColumn d in c)
            //    {
            //        FindSource.Add(new BindSource(d.DataPropertyName, d.HeaderText));
            //    }
            //}
           // FindSource.Find
            
               // object[] itemFound = FindSource.Find(delegate(object[] item) { return item[cbxFindDataGrid.SelectedIndex].ToString() == txtFindDataGrid.Text; });
            //PropertyDescriptorCollection properties_ = bs.GetItemProperties(null);
            //foreach (PropertyDescriptor p in properties_)
            //{
                
            //    if (p.PropertyType == typeof(String)) cbxFindDataGrid.Items.Add(p.Name);
            //}

            /////Select first column name in list, if column names were added
            //if (toolStripComboBoxSearch.Items.Count > 0)
            //{
            //    toolStripComboBoxSearch.SelectedIndex = 0;
            //}

        }

        private void btnFindDataGrid_Click(object sender, EventArgs e)
        {
           

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            this.State = FormState.New;
            BeginEdit();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (bs.Current != null)
            {
                this.State = FormState.Edit;
                BeginEdit();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.State = FormState.Cancel;
            this.EndEdit();
        }

    }
}
