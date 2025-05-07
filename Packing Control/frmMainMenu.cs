using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Packing_Control.FormAll.Master;
using Packing_Control.FormAll.Transaction.GI;
using Packing_Control.FormAll.Report;
using OGA.Helper.Message;
using OGA.Helper.Control;

namespace Packing_Control
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void partToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPartMaster());
        }

        private void labelTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmLabelType());
        }

        private void printLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPrintLabel());
        }

        private void ShowForm(Form frm)
        {
           // frmPrintLabel frm = new frmPrintLabel();
            if (pnlDetail.Controls.Count > 0)
            {
                DialogResult dr = OGAMessage.ShowConfirmCloseForm();
                if (dr == DialogResult.No) return;
                else pnlDetail.Controls.RemoveAt(0);
            }

            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            pnlDetail.Dock = DockStyle.Fill;
            pnlDetail.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.WindowState = FormWindowState.Maximized;

            tssUserName.Text = Authorization.UserAuthorization[0].FirstName + " " + Authorization.UserAuthorization[0].LastName;
            tssGetLastVersion.Text = "Last Version : " + Authorization.GetVersion();

            BindingDatatoControl();
            this.Cursor = Cursors.Default;

            printLabelToolStripMenuItem_Click(null, null);
        }

        private void BindingDatatoControl()
        {
            ///Production|Dummy|Testing|Part|Part List|User|Permission|user Group|RS232|Sound|DataBase|Report|
            ///
            string[] permission = Authorization.UserAuthorization[0].Permission.Split('|');

            printLabelToolStripMenuItem.Enabled = permission[0].Equals("1") ? true : false;

            partToolStripMenuItem.Enabled = permission[1].Equals("1") ? true : false;
            labelTToolStripMenuItem.Enabled = permission[2].Equals("1") ? true : false;

            userToolStripMenuItem.Enabled = permission[3].Equals("1") ? true : false;
            permissionToolStripMenuItem.Enabled = permission[4].Equals("1") ? true : false;
            groupToolStripMenuItem.Enabled = permission[5].Equals("1") ? true : false;

            reportToolStripMenuItem.Enabled = permission[6].Equals("1") ? true : false;
            importPartToolStripMenuItem.Enabled = permission[7].Equals("1") ? true : false;

        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorzontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
            {
                mdiChildForm.Close();
            }
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(new frmUser());
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmGroup());
        }

        private void permissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPermission());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmImportPartMaster());
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new frmPrintllabelReport());
        }
    }
}
