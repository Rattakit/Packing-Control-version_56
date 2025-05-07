namespace Packing_Control.FormAll.Master
{
    partial class frmImportPartMaster
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
            System.Windows.Forms.Label pathformatLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblpathformat = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNameTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STDInnerLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STDMiddleLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STDOuterLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InnerLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OuterLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pathformatLabel1 = new System.Windows.Forms.Label();
            this.pnlButton.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 129);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnPreview);
            this.splitContainer1.Panel1.Controls.Add(pathformatLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.lblpathformat);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvShow);
            this.splitContainer1.SplitterDistance = 159;
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(193, 23);
            this.lblTitle.Text = "Import Part Master";
            // 
            // picTitle
            // 
            this.picTitle.Image = global::Packing_Control.Properties.Resources.BrownFolder;
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // btnExit
            // 
            this.btnExit.Visible = true;
            // 
            // pathformatLabel1
            // 
            pathformatLabel1.AutoSize = true;
            pathformatLabel1.Location = new System.Drawing.Point(139, 49);
            pathformatLabel1.Name = "pathformatLabel1";
            pathformatLabel1.Size = new System.Drawing.Size(53, 13);
            pathformatLabel1.TabIndex = 8;
            pathformatLabel1.Text = "Text file : ";
            // 
            // lblpathformat
            // 
            this.lblpathformat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblpathformat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpathformat.ForeColor = System.Drawing.Color.Blue;
            this.lblpathformat.Location = new System.Drawing.Point(251, 45);
            this.lblpathformat.Name = "lblpathformat";
            this.lblpathformat.Size = new System.Drawing.Size(471, 23);
            this.lblpathformat.TabIndex = 9;
            this.lblpathformat.Text = "\r\n";
            this.lblpathformat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::Packing_Control.Properties.Resources.Openfile_jpeg24;
            this.btnOpen.Location = new System.Drawing.Point(214, 45);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(31, 31);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(251, 71);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(80, 34);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvShow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.PartNo,
            this.PartName,
            this.Country,
            this.PartNameTH,
            this.CountryTH,
            this.STDInnerLot,
            this.STDMiddleLot,
            this.STDOuterLot,
            this.InnerLot,
            this.MiddleLot,
            this.OuterLot});
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvShow.Location = new System.Drawing.Point(0, 0);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1008, 482);
            this.dgvShow.TabIndex = 2;
            this.dgvShow.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvShow_RowPostPaint);
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // PartNo
            // 
            this.PartNo.DataPropertyName = "PartNo";
            this.PartNo.HeaderText = "PartNo";
            this.PartNo.Name = "PartNo";
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "PartName";
            this.PartName.HeaderText = "PartName ";
            this.PartName.Name = "PartName";
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            // 
            // PartNameTH
            // 
            this.PartNameTH.DataPropertyName = "PartNameTH";
            this.PartNameTH.HeaderText = "PartNameTH ";
            this.PartNameTH.Name = "PartNameTH";
            // 
            // CountryTH
            // 
            this.CountryTH.DataPropertyName = "CountryTH";
            this.CountryTH.HeaderText = "CountryTH";
            this.CountryTH.Name = "CountryTH";
       

            // 
            // STDInnerLot
            // 
            this.STDInnerLot.DataPropertyName = "STDInnerLot";
            this.STDInnerLot.HeaderText = "STDInnerLot";
            this.STDInnerLot.Name = "STDInnerLot";
            // 
            // STDMiddleLot
            // 
            this.STDMiddleLot.DataPropertyName = "STDMiddleLot";
            this.STDMiddleLot.HeaderText = "STDMiddleLot";
            this.STDMiddleLot.Name = "STDMiddleLot";
            // 
            // STDOuterLot
            // 
            this.STDOuterLot.DataPropertyName = "STDOuterLot";
            this.STDOuterLot.HeaderText = "STDOuterLot";
            this.STDOuterLot.Name = "STDOuterLot";
            // 
            // InnerLot
            // 
            this.InnerLot.DataPropertyName = "InnerLot";
            this.InnerLot.HeaderText = "InnerLot";
            this.InnerLot.Name = "InnerLot";
            // 
            // MiddleLot
            // 
            this.MiddleLot.DataPropertyName = "MiddleLot";
            this.MiddleLot.HeaderText = "MiddleLot";
            this.MiddleLot.Name = "MiddleLot";
            // 
            // OuterLot
            // 
            this.OuterLot.DataPropertyName = "OuterLot";
            this.OuterLot.HeaderText = "OuterLot";
            this.OuterLot.Name = "OuterLot";
            // 
            // frmImportPartMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Name = "frmImportPartMaster";
            this.Text = "frmImportPartMaster";
            this.Load += new System.EventHandler(this.frmImportPartMaster_Load);
            this.pnlButton.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblpathformat;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNameTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn STDInnerLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn STDMiddleLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn STDOuterLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn InnerLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn OuterLot;
    }
}