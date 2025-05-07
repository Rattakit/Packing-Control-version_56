namespace Packing_Control.FormAll.Master
{
    partial class frmPermission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lsbGroup = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkReportScanBarcode = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkPermission = new System.Windows.Forms.CheckBox();
            this.chkUser = new System.Windows.Forms.CheckBox();
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkImportPart = new System.Windows.Forms.CheckBox();
            this.chkPart = new System.Windows.Forms.CheckBox();
            this.chkLabelType = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPrintBarcode = new System.Windows.Forms.CheckBox();
            this.pnlButton.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Visible = false;
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 540);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkAll);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 603);
            this.splitContainer1.SplitterDistance = 570;
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1008, 603);
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(115, 23);
            this.lblTitle.Text = "Permission";
            // 
            // picTitle
            // 
            this.picTitle.Image = global::Packing_Control.Properties.Resources.ADMIN;
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(0, 656);
            // 
            // btnExit
            // 
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(6, 496);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(139, 17);
            this.chkAll.TabIndex = 15;
            this.chkAll.Text = "Select All / UnSelect All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chkAll_MouseUp);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lsbGroup);
            this.groupBox6.Location = new System.Drawing.Point(3, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(184, 484);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Group";
            // 
            // lsbGroup
            // 
            this.lsbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbGroup.FormattingEnabled = true;
            this.lsbGroup.Location = new System.Drawing.Point(3, 16);
            this.lsbGroup.Name = "lsbGroup";
            this.lsbGroup.Size = new System.Drawing.Size(178, 459);
            this.lsbGroup.TabIndex = 0;
            this.lsbGroup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lsbGroup_MouseUp);
            this.lsbGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lsbGroup_KeyUp);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkReportScanBarcode);
            this.groupBox5.Location = new System.Drawing.Point(193, 217);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(236, 273);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Report";
            // 
            // chkReportScanBarcode
            // 
            this.chkReportScanBarcode.AutoSize = true;
            this.chkReportScanBarcode.Location = new System.Drawing.Point(27, 41);
            this.chkReportScanBarcode.Name = "chkReportScanBarcode";
            this.chkReportScanBarcode.Size = new System.Drawing.Size(129, 17);
            this.chkReportScanBarcode.TabIndex = 8;
            this.chkReportScanBarcode.Text = "Report Scan Barcode";
            this.chkReportScanBarcode.UseVisualStyleBackColor = true;
            this.chkReportScanBarcode.Click += new System.EventHandler(this.chkReportScanBarcode_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Location = new System.Drawing.Point(433, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 484);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Master Data";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkPermission);
            this.groupBox8.Controls.Add(this.chkUser);
            this.groupBox8.Controls.Add(this.chkGroup);
            this.groupBox8.Location = new System.Drawing.Point(15, 147);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(214, 131);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Authorization System";
            // 
            // chkPermission
            // 
            this.chkPermission.AutoSize = true;
            this.chkPermission.Location = new System.Drawing.Point(27, 87);
            this.chkPermission.Name = "chkPermission";
            this.chkPermission.Size = new System.Drawing.Size(76, 17);
            this.chkPermission.TabIndex = 9;
            this.chkPermission.Text = "Permission";
            this.chkPermission.UseVisualStyleBackColor = true;
            this.chkPermission.Click += new System.EventHandler(this.chkPermission_Click);
            // 
            // chkUser
            // 
            this.chkUser.AutoSize = true;
            this.chkUser.Location = new System.Drawing.Point(27, 41);
            this.chkUser.Name = "chkUser";
            this.chkUser.Size = new System.Drawing.Size(48, 17);
            this.chkUser.TabIndex = 8;
            this.chkUser.Text = "User";
            this.chkUser.UseVisualStyleBackColor = true;
            this.chkUser.Click += new System.EventHandler(this.chkUser_Click);
            // 
            // chkGroup
            // 
            this.chkGroup.AutoSize = true;
            this.chkGroup.Location = new System.Drawing.Point(27, 64);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(55, 17);
            this.chkGroup.TabIndex = 6;
            this.chkGroup.Text = "Group";
            this.chkGroup.UseVisualStyleBackColor = true;
            this.chkGroup.Click += new System.EventHandler(this.chkGroup_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkImportPart);
            this.groupBox7.Controls.Add(this.chkPart);
            this.groupBox7.Controls.Add(this.chkLabelType);
            this.groupBox7.Location = new System.Drawing.Point(15, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(214, 122);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Part Master";
            // 
            // chkImportPart
            // 
            this.chkImportPart.AutoSize = true;
            this.chkImportPart.Location = new System.Drawing.Point(27, 78);
            this.chkImportPart.Name = "chkImportPart";
            this.chkImportPart.Size = new System.Drawing.Size(77, 17);
            this.chkImportPart.TabIndex = 9;
            this.chkImportPart.Text = "Import Part";
            this.chkImportPart.UseVisualStyleBackColor = true;
            this.chkImportPart.Click += new System.EventHandler(this.chkImportPart_Click);
            // 
            // chkPart
            // 
            this.chkPart.AutoSize = true;
            this.chkPart.Location = new System.Drawing.Point(27, 32);
            this.chkPart.Name = "chkPart";
            this.chkPart.Size = new System.Drawing.Size(45, 17);
            this.chkPart.TabIndex = 8;
            this.chkPart.Text = "Part";
            this.chkPart.UseVisualStyleBackColor = true;
            this.chkPart.Click += new System.EventHandler(this.chkPart_Click);
            // 
            // chkLabelType
            // 
            this.chkLabelType.AutoSize = true;
            this.chkLabelType.Location = new System.Drawing.Point(27, 55);
            this.chkLabelType.Name = "chkLabelType";
            this.chkLabelType.Size = new System.Drawing.Size(79, 17);
            this.chkLabelType.TabIndex = 6;
            this.chkLabelType.Text = "Label Type";
            this.chkLabelType.UseVisualStyleBackColor = true;
            this.chkLabelType.Click += new System.EventHandler(this.chkLabelType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPrintBarcode);
            this.groupBox2.Location = new System.Drawing.Point(193, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 205);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print Barcode";
            // 
            // chkPrintBarcode
            // 
            this.chkPrintBarcode.AutoSize = true;
            this.chkPrintBarcode.Location = new System.Drawing.Point(24, 42);
            this.chkPrintBarcode.Name = "chkPrintBarcode";
            this.chkPrintBarcode.Size = new System.Drawing.Size(90, 17);
            this.chkPrintBarcode.TabIndex = 0;
            this.chkPrintBarcode.Text = "Print Barcode";
            this.chkPrintBarcode.UseVisualStyleBackColor = true;
            this.chkPrintBarcode.Click += new System.EventHandler(this.chkPrintBarcode_Click);
            // 
            // frmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 688);
            this.Name = "frmPermission";
            this.Text = "Permission";
            this.Load += new System.EventHandler(this.frmPermission_Load);
            this.pnlButton.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lsbGroup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkReportScanBarcode;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkPermission;
        private System.Windows.Forms.CheckBox chkUser;
        private System.Windows.Forms.CheckBox chkGroup;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkPart;
        private System.Windows.Forms.CheckBox chkLabelType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPrintBarcode;
        private System.Windows.Forms.CheckBox chkImportPart;
    }
}
