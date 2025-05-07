namespace Packing_Control.FormAll.Master
{
    partial class frmPartMaster
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label partNoLabel;
            System.Windows.Forms.Label partNameLabel;
            System.Windows.Forms.Label InnerLotLabel;
            System.Windows.Forms.Label sTDMiddleLotLabel;
            System.Windows.Forms.Label sTDOuterLotLabel;
            System.Windows.Forms.Label innerLotLabel1;
            System.Windows.Forms.Label middleLotLabel;
            System.Windows.Forms.Label outerLotLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.partNameLabelTH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPartNo = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtPartNameTH = new System.Windows.Forms.TextBox();
            this.nuInnerLot = new System.Windows.Forms.NumericUpDown();
            this.nuMiddleLot = new System.Windows.Forms.NumericUpDown();
            this.nuOuterLot = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxTypeouter = new System.Windows.Forms.ComboBox();
            this.cbxTypemiddle = new System.Windows.Forms.ComboBox();
            this.cbxTypeinner = new System.Windows.Forms.ComboBox();
            this.bsInner = new System.Windows.Forms.BindingSource(this.components);
            this.bsMiddle = new System.Windows.Forms.BindingSource(this.components);
            this.bsOuter = new System.Windows.Forms.BindingSource(this.components);
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
            this.txtCoutry = new System.Windows.Forms.TextBox();
            this.txtCoutryTH = new System.Windows.Forms.TextBox();
            modelLabel = new System.Windows.Forms.Label();
            partNoLabel = new System.Windows.Forms.Label();
            partNameLabel = new System.Windows.Forms.Label();
            InnerLotLabel = new System.Windows.Forms.Label();
            sTDMiddleLotLabel = new System.Windows.Forms.Label();
            sTDOuterLotLabel = new System.Windows.Forms.Label();
            innerLotLabel1 = new System.Windows.Forms.Label();
            middleLotLabel = new System.Windows.Forms.Label();
            outerLotLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.pnlButton.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuInnerLot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMiddleLot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuOuterLot)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOuter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(372, 5);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(484, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = true;
            this.btnDelete.Location = new System.Drawing.Point(592, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 322);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(5);
            this.pnlButton.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlButton_Paint);
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtCoutry);
            this.splitContainer1.Panel1.Controls.Add(this.txtCoutryTH);
            this.splitContainer1.Panel1.Controls.Add(label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.txtModel);
            this.splitContainer1.Panel1.Controls.Add(partNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.partNameLabelTH);
            this.splitContainer1.Panel1.Controls.Add(this.txtPartName);
            this.splitContainer1.Panel1.Controls.Add(this.txtPartNameTH);
            this.splitContainer1.Panel1.Controls.Add(modelLabel);
            this.splitContainer1.Panel1.Controls.Add(partNoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.txtPartNo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvShow);
            this.splitContainer1.Size = new System.Drawing.Size(1344, 794);
            this.splitContainer1.SplitterDistance = 359;
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1344, 794);
            // 
            // lblTitle
            // 
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Size = new System.Drawing.Size(63, 29);
            this.lblTitle.Text = "Part";
            // 
            // picTitle
            // 
            this.picTitle.Image = global::Packing_Control.Properties.Resources.Hardware32x32;
            this.picTitle.Location = new System.Drawing.Point(16, 4);
            this.picTitle.Margin = new System.Windows.Forms.Padding(5);
            this.picTitle.Size = new System.Drawing.Size(71, 58);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(0, 859);
            // 
            // btnExit
            // 
            this.btnExit.Visible = true;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(284, 26);
            modelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(48, 16);
            modelLabel.TabIndex = 1;
            modelLabel.Text = "Model:";
            // 
            // partNoLabel
            // 
            partNoLabel.AutoSize = true;
            partNoLabel.Location = new System.Drawing.Point(277, 56);
            partNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            partNoLabel.Name = "partNoLabel";
            partNoLabel.Size = new System.Drawing.Size(55, 16);
            partNoLabel.TabIndex = 3;
            partNoLabel.Text = "Part No:";
            // 
            // partNameLabel
            // 
            partNameLabel.AutoSize = true;
            partNameLabel.Location = new System.Drawing.Point(258, 89);
            partNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            partNameLabel.Name = "partNameLabel";
            partNameLabel.Size = new System.Drawing.Size(74, 16);
            partNameLabel.TabIndex = 5;
            partNameLabel.Text = "Part Name:";
            // 
            // InnerLotLabel
            // 
            InnerLotLabel.AutoSize = true;
            InnerLotLabel.Location = new System.Drawing.Point(55, 27);
            InnerLotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            InnerLotLabel.Name = "InnerLotLabel";
            InnerLotLabel.Size = new System.Drawing.Size(60, 16);
            InnerLotLabel.TabIndex = 7;
            InnerLotLabel.Text = "Inner Lot:";
            // 
            // sTDMiddleLotLabel
            // 
            sTDMiddleLotLabel.AutoSize = true;
            sTDMiddleLotLabel.Location = new System.Drawing.Point(45, 55);
            sTDMiddleLotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sTDMiddleLotLabel.Name = "sTDMiddleLotLabel";
            sTDMiddleLotLabel.Size = new System.Drawing.Size(72, 16);
            sTDMiddleLotLabel.TabIndex = 9;
            sTDMiddleLotLabel.Text = "Middle Lot:";
            // 
            // sTDOuterLotLabel
            // 
            sTDOuterLotLabel.AutoSize = true;
            sTDOuterLotLabel.Location = new System.Drawing.Point(52, 86);
            sTDOuterLotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sTDOuterLotLabel.Name = "sTDOuterLotLabel";
            sTDOuterLotLabel.Size = new System.Drawing.Size(63, 16);
            sTDOuterLotLabel.TabIndex = 11;
            sTDOuterLotLabel.Text = "Outer Lot:";
            // 
            // innerLotLabel1
            // 
            innerLotLabel1.AutoSize = true;
            innerLotLabel1.Location = new System.Drawing.Point(292, 25);
            innerLotLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            innerLotLabel1.Name = "innerLotLabel1";
            innerLotLabel1.Size = new System.Drawing.Size(82, 16);
            innerLotLabel1.TabIndex = 12;
            innerLotLabel1.Text = "Label Type :";
            // 
            // middleLotLabel
            // 
            middleLotLabel.AutoSize = true;
            middleLotLabel.Location = new System.Drawing.Point(289, 55);
            middleLotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            middleLotLabel.Name = "middleLotLabel";
            middleLotLabel.Size = new System.Drawing.Size(82, 16);
            middleLotLabel.TabIndex = 13;
            middleLotLabel.Text = "Label Type :";
            middleLotLabel.Click += new System.EventHandler(this.middleLotLabel_Click);
            // 
            // outerLotLabel
            // 
            outerLotLabel.AutoSize = true;
            outerLotLabel.Location = new System.Drawing.Point(292, 86);
            outerLotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            outerLotLabel.Name = "outerLotLabel";
            outerLotLabel.Size = new System.Drawing.Size(82, 16);
            outerLotLabel.TabIndex = 14;
            outerLotLabel.Text = "Label Type :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(255, 150);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 16);
            label1.TabIndex = 14;
            label1.Text = "CountryEN :";
            // 
            // partNameLabelTH
            // 
            this.partNameLabelTH.AutoSize = true;
            this.partNameLabelTH.Location = new System.Drawing.Point(242, 119);
            this.partNameLabelTH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partNameLabelTH.Name = "partNameLabelTH";
            this.partNameLabelTH.Size = new System.Drawing.Size(93, 16);
            this.partNameLabelTH.TabIndex = 5;
            this.partNameLabelTH.Text = "Part NameTH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "CountryTH :";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(352, 20);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(216, 22);
            this.txtModel.TabIndex = 2;
            this.txtModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtModel_KeyPress);
            // 
            // txtPartNo
            // 
            this.txtPartNo.Location = new System.Drawing.Point(352, 50);
            this.txtPartNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartNo.Name = "txtPartNo";
            this.txtPartNo.Size = new System.Drawing.Size(216, 22);
            this.txtPartNo.TabIndex = 4;
            this.txtPartNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartNo_KeyPress);
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(352, 86);
            this.txtPartName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(216, 22);
            this.txtPartName.TabIndex = 6;
            this.txtPartName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartName_KeyPress);
            // 
            // txtPartNameTH
            // 
            this.txtPartNameTH.Location = new System.Drawing.Point(352, 114);
            this.txtPartNameTH.Margin = new System.Windows.Forms.Padding(4);
            this.txtPartNameTH.Name = "txtPartNameTH";
            this.txtPartNameTH.Size = new System.Drawing.Size(216, 22);
            this.txtPartNameTH.TabIndex = 6;
            this.txtPartNameTH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPartNameTH_KeyPress);
            // 
            // nuInnerLot
            // 
            this.nuInnerLot.Location = new System.Drawing.Point(132, 25);
            this.nuInnerLot.Margin = new System.Windows.Forms.Padding(4);
            this.nuInnerLot.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nuInnerLot.Name = "nuInnerLot";
            this.nuInnerLot.Size = new System.Drawing.Size(120, 22);
            this.nuInnerLot.TabIndex = 8;
            this.nuInnerLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuInnerLot.ValueChanged += new System.EventHandler(this.nuInnerLot_ValueChanged);
            // 
            // nuMiddleLot
            // 
            this.nuMiddleLot.Location = new System.Drawing.Point(132, 55);
            this.nuMiddleLot.Margin = new System.Windows.Forms.Padding(4);
            this.nuMiddleLot.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nuMiddleLot.Name = "nuMiddleLot";
            this.nuMiddleLot.Size = new System.Drawing.Size(120, 22);
            this.nuMiddleLot.TabIndex = 10;
            this.nuMiddleLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuMiddleLot.ValueChanged += new System.EventHandler(this.nuMiddleLot_ValueChanged);
            // 
            // nuOuterLot
            // 
            this.nuOuterLot.Location = new System.Drawing.Point(132, 84);
            this.nuOuterLot.Margin = new System.Windows.Forms.Padding(4);
            this.nuOuterLot.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nuOuterLot.Name = "nuOuterLot";
            this.nuOuterLot.Size = new System.Drawing.Size(120, 22);
            this.nuOuterLot.TabIndex = 12;
            this.nuOuterLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nuOuterLot.ValueChanged += new System.EventHandler(this.nuOuterLot_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(outerLotLabel);
            this.groupBox1.Controls.Add(this.cbxTypeouter);
            this.groupBox1.Controls.Add(middleLotLabel);
            this.groupBox1.Controls.Add(this.cbxTypemiddle);
            this.groupBox1.Controls.Add(innerLotLabel1);
            this.groupBox1.Controls.Add(this.cbxTypeinner);
            this.groupBox1.Controls.Add(this.nuOuterLot);
            this.groupBox1.Controls.Add(sTDOuterLotLabel);
            this.groupBox1.Controls.Add(this.nuInnerLot);
            this.groupBox1.Controls.Add(InnerLotLabel);
            this.groupBox1.Controls.Add(sTDMiddleLotLabel);
            this.groupBox1.Controls.Add(this.nuMiddleLot);
            this.groupBox1.Location = new System.Drawing.Point(220, 198);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(592, 120);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard Pack";
            // 
            // cbxTypeouter
            // 
            this.cbxTypeouter.FormattingEnabled = true;
            this.cbxTypeouter.Location = new System.Drawing.Point(384, 84);
            this.cbxTypeouter.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTypeouter.Name = "cbxTypeouter";
            this.cbxTypeouter.Size = new System.Drawing.Size(160, 24);
            this.cbxTypeouter.TabIndex = 15;
            // 
            // cbxTypemiddle
            // 
            this.cbxTypemiddle.FormattingEnabled = true;
            this.cbxTypemiddle.Location = new System.Drawing.Point(384, 55);
            this.cbxTypemiddle.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTypemiddle.Name = "cbxTypemiddle";
            this.cbxTypemiddle.Size = new System.Drawing.Size(160, 24);
            this.cbxTypemiddle.TabIndex = 14;
            // 
            // cbxTypeinner
            // 
            this.cbxTypeinner.FormattingEnabled = true;
            this.cbxTypeinner.Location = new System.Drawing.Point(384, 25);
            this.cbxTypeinner.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTypeinner.Name = "cbxTypeinner";
            this.cbxTypeinner.Size = new System.Drawing.Size(160, 24);
            this.cbxTypeinner.TabIndex = 13;
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
            this.dgvShow.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(1344, 430);
            this.dgvShow.TabIndex = 1;
            this.dgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellClick);
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            // 
            // PartNo
            // 
            this.PartNo.DataPropertyName = "PartNo";
            this.PartNo.HeaderText = "PartNo";
            this.PartNo.MinimumWidth = 6;
            this.PartNo.Name = "PartNo";
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "PartName";
            this.PartName.HeaderText = "PartName ";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            // 
            // PartNameTH
            // 
            this.PartNameTH.DataPropertyName = "PartNameTH";
            this.PartNameTH.HeaderText = "PartNameTH ";
            this.PartNameTH.MinimumWidth = 6;
            this.PartNameTH.Name = "PartNameTH";
            // 
            // CountryTH
            // 
            this.CountryTH.DataPropertyName = "CountryTH";
            this.CountryTH.HeaderText = "CountryTH";
            this.CountryTH.MinimumWidth = 6;
            this.CountryTH.Name = "CountryTH";
            // 
            // STDInnerLot
            // 
            this.STDInnerLot.DataPropertyName = "STDInnerLot";
            this.STDInnerLot.HeaderText = "STDInnerLot";
            this.STDInnerLot.MinimumWidth = 6;
            this.STDInnerLot.Name = "STDInnerLot";
            // 
            // STDMiddleLot
            // 
            this.STDMiddleLot.DataPropertyName = "STDMiddleLot";
            this.STDMiddleLot.HeaderText = "STDMiddleLot";
            this.STDMiddleLot.MinimumWidth = 6;
            this.STDMiddleLot.Name = "STDMiddleLot";
            // 
            // STDOuterLot
            // 
            this.STDOuterLot.DataPropertyName = "STDOuterLot";
            this.STDOuterLot.HeaderText = "STDOuterLot";
            this.STDOuterLot.MinimumWidth = 6;
            this.STDOuterLot.Name = "STDOuterLot";
            // 
            // InnerLot
            // 
            this.InnerLot.DataPropertyName = "InnerLot";
            this.InnerLot.HeaderText = "InnerLot";
            this.InnerLot.MinimumWidth = 6;
            this.InnerLot.Name = "InnerLot";
            // 
            // MiddleLot
            // 
            this.MiddleLot.DataPropertyName = "MiddleLot";
            this.MiddleLot.HeaderText = "MiddleLot";
            this.MiddleLot.MinimumWidth = 6;
            this.MiddleLot.Name = "MiddleLot";
            // 
            // OuterLot
            // 
            this.OuterLot.DataPropertyName = "OuterLot";
            this.OuterLot.HeaderText = "OuterLot";
            this.OuterLot.MinimumWidth = 6;
            this.OuterLot.Name = "OuterLot";
            // 
            // txtCoutry
            // 
            this.txtCoutry.Location = new System.Drawing.Point(352, 144);
            this.txtCoutry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoutry.Name = "txtCoutry";
            this.txtCoutry.Size = new System.Drawing.Size(216, 22);
            this.txtCoutry.TabIndex = 15;
            // 
            // txtCoutryTH
            // 
            this.txtCoutryTH.Location = new System.Drawing.Point(352, 174);
            this.txtCoutryTH.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoutryTH.Name = "txtCoutryTH";
            this.txtCoutryTH.Size = new System.Drawing.Size(216, 22);
            this.txtCoutryTH.TabIndex = 15;
            // 
            // frmPartMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 898);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmPartMaster";
            this.Text = "frmPartMaster";
            this.Load += new System.EventHandler(this.frmPartMaster_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.nuInnerLot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMiddleLot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuOuterLot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOuter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPartNo;
        private System.Windows.Forms.NumericUpDown nuOuterLot;
        private System.Windows.Forms.NumericUpDown nuMiddleLot;
        private System.Windows.Forms.NumericUpDown nuInnerLot;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtPartNameTH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxTypeinner;
        private System.Windows.Forms.ComboBox cbxTypeouter;
        private System.Windows.Forms.ComboBox cbxTypemiddle;
        private System.Windows.Forms.BindingSource bsInner;
        private System.Windows.Forms.BindingSource bsMiddle;
        private System.Windows.Forms.BindingSource bsOuter;
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
        private System.Windows.Forms.TextBox txtCoutry;
        private System.Windows.Forms.TextBox txtCoutryTH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label partNameLabelTH;
    }
}