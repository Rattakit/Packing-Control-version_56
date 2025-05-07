namespace Packing_Control.FormAll.Master
{
    partial class frmLabelType
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
            System.Windows.Forms.Label labelTypeLabel;
            System.Windows.Forms.Label pathformatLabel1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtlabelType = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.LabelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pathformat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblpathformat = new System.Windows.Forms.Label();
            labelTypeLabel = new System.Windows.Forms.Label();
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
            this.btnNew.Location = new System.Drawing.Point(263, 5);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(347, 5);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = true;
            this.btnDelete.Location = new System.Drawing.Point(428, 4);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 110);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(labelTypeLabel);
            this.splitContainer1.Panel1.Controls.Add(pathformatLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.txtlabelType);
            this.splitContainer1.Panel1.Controls.Add(this.lblpathformat);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvShow);
            this.splitContainer1.SplitterDistance = 140;
            // 
            // lblTitle
            // 
            this.lblTitle.Size = new System.Drawing.Size(113, 23);
            this.lblTitle.Text = "Label Type";
            // 
            // picTitle
            // 
            this.picTitle.Image = global::Packing_Control.Properties.Resources.QRCode135;
            this.picTitle.Location = new System.Drawing.Point(11, 3);
            this.picTitle.Size = new System.Drawing.Size(50, 48);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btnExit
            // 
            this.btnExit.Visible = true;
            // 
            // labelTypeLabel
            // 
            labelTypeLabel.AutoSize = true;
            labelTypeLabel.Location = new System.Drawing.Point(272, 36);
            labelTypeLabel.Name = "labelTypeLabel";
            labelTypeLabel.Size = new System.Drawing.Size(69, 13);
            labelTypeLabel.TabIndex = 1;
            labelTypeLabel.Text = "Label Type : ";
            // 
            // pathformatLabel1
            // 
            pathformatLabel1.AutoSize = true;
            pathformatLabel1.Location = new System.Drawing.Point(258, 65);
            pathformatLabel1.Name = "pathformatLabel1";
            pathformatLabel1.Size = new System.Drawing.Size(78, 13);
            pathformatLabel1.TabIndex = 5;
            pathformatLabel1.Text = "Path Lay Out : ";
            // 
            // txtlabelType
            // 
            this.txtlabelType.Location = new System.Drawing.Point(347, 33);
            this.txtlabelType.Name = "txtlabelType";
            this.txtlabelType.Size = new System.Drawing.Size(135, 20);
            this.txtlabelType.TabIndex = 2;
            this.txtlabelType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlabelType_KeyPress);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::Packing_Control.Properties.Resources.Openfile_jpeg24;
            this.btnOpen.Location = new System.Drawing.Point(342, 65);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(31, 31);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.LabelType,
            this.Pathformat});
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvShow.Location = new System.Drawing.Point(0, 0);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1008, 501);
            this.dgvShow.TabIndex = 1;
            this.dgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellClick);
            // 
            // LabelType
            // 
            this.LabelType.DataPropertyName = "LabelType";
            this.LabelType.HeaderText = "LabelType";
            this.LabelType.Name = "LabelType";
            // 
            // Pathformat
            // 
            this.Pathformat.DataPropertyName = "Pathformat";
            this.Pathformat.HeaderText = "Pathformat";
            this.Pathformat.Name = "Pathformat";
            // 
            // lblpathformat
            // 
            this.lblpathformat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblpathformat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblpathformat.ForeColor = System.Drawing.Color.Blue;
            this.lblpathformat.Location = new System.Drawing.Point(379, 65);
            this.lblpathformat.Name = "lblpathformat";
            this.lblpathformat.Size = new System.Drawing.Size(459, 23);
            this.lblpathformat.TabIndex = 6;
            this.lblpathformat.Text = "\r\n";
            this.lblpathformat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLabelType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Name = "frmLabelType";
            this.Load += new System.EventHandler(this.frmLabelType_Load);
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

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtlabelType;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pathformat;
        private System.Windows.Forms.Label lblpathformat;

    }
}
