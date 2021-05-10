namespace mcmp2
{
    partial class frmActivites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivites));
            this.tblListeAct = new System.Windows.Forms.TableLayoutPanel();
            this.gbListeAct = new System.Windows.Forms.GroupBox();
            this.dgvAct = new System.Windows.Forms.DataGridView();
            this.iDACTIVITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDADHERENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNTITULEACTIVITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDEBUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIFADHERENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIFINVITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLIMITEINSCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBLIMITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNTITULETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listActTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda28_bd3DataSet = new mcmp2.cda28_bd3DataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbAct = new System.Windows.Forms.GroupBox();
            this.tblDescAct = new System.Windows.Forms.TableLayoutPanel();
            this.textId = new System.Windows.Forms.TextBox();
            this.textType = new System.Windows.Forms.TextBox();
            this.textLimite = new System.Windows.Forms.TextBox();
            this.textTarifInv = new System.Windows.Forms.TextBox();
            this.textTarifAdh = new System.Windows.Forms.TextBox();
            this.lblTarifAdh = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblidAct = new System.Windows.Forms.Label();
            this.textIntitule = new System.Windows.Forms.TextBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblintitul = new System.Windows.Forms.Label();
            this.lblDdebut = new System.Windows.Forms.Label();
            this.dtpDatedebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblTarifInv = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblDateLimite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSuivi = new System.Windows.Forms.Button();
            this.listActTypeTableAdapter = new mcmp2.cda28_bd3DataSetTableAdapters.listActTypeTableAdapter();
            this.tblListeAct.SuspendLayout();
            this.gbListeAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listActTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda28_bd3DataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbAct.SuspendLayout();
            this.tblDescAct.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblListeAct
            // 
            this.tblListeAct.ColumnCount = 2;
            this.tblListeAct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tblListeAct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tblListeAct.Controls.Add(this.gbListeAct, 0, 0);
            this.tblListeAct.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tblListeAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblListeAct.Location = new System.Drawing.Point(0, 0);
            this.tblListeAct.Name = "tblListeAct";
            this.tblListeAct.RowCount = 1;
            this.tblListeAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.09677F));
            this.tblListeAct.Size = new System.Drawing.Size(731, 434);
            this.tblListeAct.TabIndex = 2;
            // 
            // gbListeAct
            // 
            this.gbListeAct.Controls.Add(this.dgvAct);
            this.gbListeAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbListeAct.Location = new System.Drawing.Point(3, 3);
            this.gbListeAct.Name = "gbListeAct";
            this.gbListeAct.Size = new System.Drawing.Size(423, 428);
            this.gbListeAct.TabIndex = 0;
            this.gbListeAct.TabStop = false;
            this.gbListeAct.Text = "Liste des activités";
            // 
            // dgvAct
            // 
            this.dgvAct.AllowUserToAddRows = false;
            this.dgvAct.AllowUserToDeleteRows = false;
            this.dgvAct.AutoGenerateColumns = false;
            this.dgvAct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.dgvAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDACTIVITEDataGridViewTextBoxColumn,
            this.iDADHERENTDataGridViewTextBoxColumn,
            this.iDTYPEDataGridViewTextBoxColumn,
            this.iNTITULEACTIVITEDataGridViewTextBoxColumn,
            this.dDEBUTDataGridViewTextBoxColumn,
            this.dFINDataGridViewTextBoxColumn,
            this.dESCRIPTIONDataGridViewTextBoxColumn,
            this.tARIFADHERENTDataGridViewTextBoxColumn,
            this.tARIFINVITEDataGridViewTextBoxColumn,
            this.dLIMITEINSCRIPTIONDataGridViewTextBoxColumn,
            this.nBLIMITEDataGridViewTextBoxColumn,
            this.iNTITULETYPEDataGridViewTextBoxColumn});
            this.dgvAct.DataSource = this.listActTypeBindingSource;
            this.dgvAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAct.Location = new System.Drawing.Point(3, 16);
            this.dgvAct.Name = "dgvAct";
            this.dgvAct.ReadOnly = true;
            this.dgvAct.RowHeadersVisible = false;
            this.dgvAct.Size = new System.Drawing.Size(417, 409);
            this.dgvAct.TabIndex = 15;
            // 
            // iDACTIVITEDataGridViewTextBoxColumn
            // 
            this.iDACTIVITEDataGridViewTextBoxColumn.DataPropertyName = "IDACTIVITE";
            this.iDACTIVITEDataGridViewTextBoxColumn.HeaderText = "IDACTIVITE";
            this.iDACTIVITEDataGridViewTextBoxColumn.Name = "iDACTIVITEDataGridViewTextBoxColumn";
            this.iDACTIVITEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDACTIVITEDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDADHERENTDataGridViewTextBoxColumn
            // 
            this.iDADHERENTDataGridViewTextBoxColumn.DataPropertyName = "IDADHERENT";
            this.iDADHERENTDataGridViewTextBoxColumn.HeaderText = "IDADHERENT";
            this.iDADHERENTDataGridViewTextBoxColumn.Name = "iDADHERENTDataGridViewTextBoxColumn";
            this.iDADHERENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDADHERENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDTYPEDataGridViewTextBoxColumn
            // 
            this.iDTYPEDataGridViewTextBoxColumn.DataPropertyName = "IDTYPE";
            this.iDTYPEDataGridViewTextBoxColumn.HeaderText = "IDTYPE";
            this.iDTYPEDataGridViewTextBoxColumn.Name = "iDTYPEDataGridViewTextBoxColumn";
            this.iDTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNTITULEACTIVITEDataGridViewTextBoxColumn
            // 
            this.iNTITULEACTIVITEDataGridViewTextBoxColumn.DataPropertyName = "INTITULEACTIVITE";
            this.iNTITULEACTIVITEDataGridViewTextBoxColumn.HeaderText = "Intitulé";
            this.iNTITULEACTIVITEDataGridViewTextBoxColumn.Name = "iNTITULEACTIVITEDataGridViewTextBoxColumn";
            this.iNTITULEACTIVITEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDEBUTDataGridViewTextBoxColumn
            // 
            this.dDEBUTDataGridViewTextBoxColumn.DataPropertyName = "DDEBUT";
            this.dDEBUTDataGridViewTextBoxColumn.HeaderText = "Date début";
            this.dDEBUTDataGridViewTextBoxColumn.Name = "dDEBUTDataGridViewTextBoxColumn";
            this.dDEBUTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dFINDataGridViewTextBoxColumn
            // 
            this.dFINDataGridViewTextBoxColumn.DataPropertyName = "DFIN";
            this.dFINDataGridViewTextBoxColumn.HeaderText = "Date fin";
            this.dFINDataGridViewTextBoxColumn.Name = "dFINDataGridViewTextBoxColumn";
            this.dFINDataGridViewTextBoxColumn.ReadOnly = true;
            this.dFINDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPTION";
            this.dESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Description";
            this.dESCRIPTIONDataGridViewTextBoxColumn.Name = "dESCRIPTIONDataGridViewTextBoxColumn";
            this.dESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESCRIPTIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // tARIFADHERENTDataGridViewTextBoxColumn
            // 
            this.tARIFADHERENTDataGridViewTextBoxColumn.DataPropertyName = "TARIFADHERENT";
            this.tARIFADHERENTDataGridViewTextBoxColumn.HeaderText = "TARIFADHERENT";
            this.tARIFADHERENTDataGridViewTextBoxColumn.Name = "tARIFADHERENTDataGridViewTextBoxColumn";
            this.tARIFADHERENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tARIFADHERENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // tARIFINVITEDataGridViewTextBoxColumn
            // 
            this.tARIFINVITEDataGridViewTextBoxColumn.DataPropertyName = "TARIFINVITE";
            this.tARIFINVITEDataGridViewTextBoxColumn.HeaderText = "TARIFINVITE";
            this.tARIFINVITEDataGridViewTextBoxColumn.Name = "tARIFINVITEDataGridViewTextBoxColumn";
            this.tARIFINVITEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tARIFINVITEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dLIMITEINSCRIPTIONDataGridViewTextBoxColumn
            // 
            this.dLIMITEINSCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "DLIMITEINSCRIPTION";
            this.dLIMITEINSCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Date limite d\'inscription";
            this.dLIMITEINSCRIPTIONDataGridViewTextBoxColumn.Name = "dLIMITEINSCRIPTIONDataGridViewTextBoxColumn";
            this.dLIMITEINSCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nBLIMITEDataGridViewTextBoxColumn
            // 
            this.nBLIMITEDataGridViewTextBoxColumn.DataPropertyName = "NBLIMITE";
            this.nBLIMITEDataGridViewTextBoxColumn.HeaderText = "NBLIMITE";
            this.nBLIMITEDataGridViewTextBoxColumn.Name = "nBLIMITEDataGridViewTextBoxColumn";
            this.nBLIMITEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nBLIMITEDataGridViewTextBoxColumn.Visible = false;
            // 
            // iNTITULETYPEDataGridViewTextBoxColumn
            // 
            this.iNTITULETYPEDataGridViewTextBoxColumn.DataPropertyName = "INTITULETYPE";
            this.iNTITULETYPEDataGridViewTextBoxColumn.HeaderText = "Type";
            this.iNTITULETYPEDataGridViewTextBoxColumn.Name = "iNTITULETYPEDataGridViewTextBoxColumn";
            this.iNTITULETYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listActTypeBindingSource
            // 
            this.listActTypeBindingSource.DataMember = "listActType";
            this.listActTypeBindingSource.DataSource = this.cda28_bd3DataSet;
            // 
            // cda28_bd3DataSet
            // 
            this.cda28_bd3DataSet.DataSetName = "cda28_bd3DataSet";
            this.cda28_bd3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbAct, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSuivi, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(432, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.34579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.65421F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 428);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbAct
            // 
            this.gbAct.Controls.Add(this.tblDescAct);
            this.gbAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAct.Location = new System.Drawing.Point(3, 3);
            this.gbAct.Name = "gbAct";
            this.gbAct.Size = new System.Drawing.Size(290, 354);
            this.gbAct.TabIndex = 2;
            this.gbAct.TabStop = false;
            this.gbAct.Text = "Fiche activité";
            // 
            // tblDescAct
            // 
            this.tblDescAct.ColumnCount = 2;
            this.tblDescAct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.83832F));
            this.tblDescAct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.16168F));
            this.tblDescAct.Controls.Add(this.textId, 1, 0);
            this.tblDescAct.Controls.Add(this.textType, 1, 1);
            this.tblDescAct.Controls.Add(this.textLimite, 1, 9);
            this.tblDescAct.Controls.Add(this.textTarifInv, 1, 7);
            this.tblDescAct.Controls.Add(this.textTarifAdh, 1, 6);
            this.tblDescAct.Controls.Add(this.lblTarifAdh, 0, 6);
            this.tblDescAct.Controls.Add(this.lblDesc, 0, 5);
            this.tblDescAct.Controls.Add(this.label1, 0, 4);
            this.tblDescAct.Controls.Add(this.lblidAct, 0, 0);
            this.tblDescAct.Controls.Add(this.textIntitule, 1, 2);
            this.tblDescAct.Controls.Add(this.lbltype, 0, 1);
            this.tblDescAct.Controls.Add(this.lblintitul, 0, 2);
            this.tblDescAct.Controls.Add(this.lblDdebut, 0, 3);
            this.tblDescAct.Controls.Add(this.dtpDatedebut, 1, 3);
            this.tblDescAct.Controls.Add(this.dateTimePicker1, 1, 4);
            this.tblDescAct.Controls.Add(this.richTextBox1, 1, 5);
            this.tblDescAct.Controls.Add(this.lblTarifInv, 0, 7);
            this.tblDescAct.Controls.Add(this.dateTimePicker2, 1, 8);
            this.tblDescAct.Controls.Add(this.lblDateLimite, 0, 8);
            this.tblDescAct.Controls.Add(this.label2, 0, 9);
            this.tblDescAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDescAct.Location = new System.Drawing.Point(3, 16);
            this.tblDescAct.Name = "tblDescAct";
            this.tblDescAct.RowCount = 10;
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tblDescAct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tblDescAct.Size = new System.Drawing.Size(284, 335);
            this.tblDescAct.TabIndex = 7;
            // 
            // textId
            // 
            this.textId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textId.BackColor = System.Drawing.SystemColors.Control;
            this.textId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listActTypeBindingSource, "IDACTIVITE", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(90, 5);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(137, 13);
            this.textId.TabIndex = 22;
            // 
            // textType
            // 
            this.textType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textType.BackColor = System.Drawing.SystemColors.Control;
            this.textType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listActTypeBindingSource, "INTITULETYPE", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textType.Enabled = false;
            this.textType.Location = new System.Drawing.Point(90, 28);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(137, 13);
            this.textType.TabIndex = 21;
            // 
            // textLimite
            // 
            this.textLimite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textLimite.BackColor = System.Drawing.SystemColors.Control;
            this.textLimite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLimite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listActTypeBindingSource, "NBLIMITE", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textLimite.Enabled = false;
            this.textLimite.Location = new System.Drawing.Point(90, 312);
            this.textLimite.Name = "textLimite";
            this.textLimite.Size = new System.Drawing.Size(137, 13);
            this.textLimite.TabIndex = 20;
            // 
            // textTarifInv
            // 
            this.textTarifInv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textTarifInv.BackColor = System.Drawing.SystemColors.Control;
            this.textTarifInv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTarifInv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listActTypeBindingSource, "TARIFINVITE", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "C2"));
            this.textTarifInv.Enabled = false;
            this.textTarifInv.Location = new System.Drawing.Point(90, 262);
            this.textTarifInv.Name = "textTarifInv";
            this.textTarifInv.Size = new System.Drawing.Size(137, 13);
            this.textTarifInv.TabIndex = 19;
            // 
            // textTarifAdh
            // 
            this.textTarifAdh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textTarifAdh.BackColor = System.Drawing.SystemColors.Control;
            this.textTarifAdh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTarifAdh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listActTypeBindingSource, "TARIFADHERENT", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "C2"));
            this.textTarifAdh.Enabled = false;
            this.textTarifAdh.Location = new System.Drawing.Point(90, 239);
            this.textTarifAdh.Name = "textTarifAdh";
            this.textTarifAdh.Size = new System.Drawing.Size(137, 13);
            this.textTarifAdh.TabIndex = 18;
            // 
            // lblTarifAdh
            // 
            this.lblTarifAdh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTarifAdh.AutoSize = true;
            this.lblTarifAdh.Location = new System.Drawing.Point(3, 239);
            this.lblTarifAdh.Name = "lblTarifAdh";
            this.lblTarifAdh.Size = new System.Drawing.Size(73, 13);
            this.lblTarifAdh.TabIndex = 13;
            this.lblTarifAdh.Text = "Tarif adhérent";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 168);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(51, 13);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "Descriptif";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date de fin";
            // 
            // lblidAct
            // 
            this.lblidAct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblidAct.AutoSize = true;
            this.lblidAct.Location = new System.Drawing.Point(3, 5);
            this.lblidAct.Name = "lblidAct";
            this.lblidAct.Size = new System.Drawing.Size(56, 13);
            this.lblidAct.TabIndex = 1;
            this.lblidAct.Text = "ID Activité";
            // 
            // textIntitule
            // 
            this.textIntitule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textIntitule.BackColor = System.Drawing.SystemColors.Control;
            this.textIntitule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIntitule.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listActTypeBindingSource, "INTITULEACTIVITE", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textIntitule.Enabled = false;
            this.textIntitule.Location = new System.Drawing.Point(90, 51);
            this.textIntitule.Name = "textIntitule";
            this.textIntitule.Size = new System.Drawing.Size(137, 13);
            this.textIntitule.TabIndex = 5;
            // 
            // lbltype
            // 
            this.lbltype.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(3, 28);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 2;
            this.lbltype.Text = "Type";
            // 
            // lblintitul
            // 
            this.lblintitul.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblintitul.AutoSize = true;
            this.lblintitul.Location = new System.Drawing.Point(3, 51);
            this.lblintitul.Name = "lblintitul";
            this.lblintitul.Size = new System.Drawing.Size(38, 13);
            this.lblintitul.TabIndex = 7;
            this.lblintitul.Text = "Intitulé";
            // 
            // lblDdebut
            // 
            this.lblDdebut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDdebut.AutoSize = true;
            this.lblDdebut.Location = new System.Drawing.Point(3, 74);
            this.lblDdebut.Name = "lblDdebut";
            this.lblDdebut.Size = new System.Drawing.Size(75, 13);
            this.lblDdebut.TabIndex = 6;
            this.lblDdebut.Text = "Date de début";
            // 
            // dtpDatedebut
            // 
            this.dtpDatedebut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDatedebut.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dtpDatedebut.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listActTypeBindingSource, "DDEBUT", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "d"));
            this.dtpDatedebut.Enabled = false;
            this.dtpDatedebut.Location = new System.Drawing.Point(90, 72);
            this.dtpDatedebut.Name = "dtpDatedebut";
            this.dtpDatedebut.Size = new System.Drawing.Size(187, 20);
            this.dtpDatedebut.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listActTypeBindingSource, "DFIN", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "d"));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listActTypeBindingSource, "DESCRIPTION", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(90, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(191, 113);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // lblTarifInv
            // 
            this.lblTarifInv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTarifInv.AutoSize = true;
            this.lblTarifInv.Location = new System.Drawing.Point(3, 262);
            this.lblTarifInv.Name = "lblTarifInv";
            this.lblTarifInv.Size = new System.Drawing.Size(56, 13);
            this.lblTarifInv.TabIndex = 14;
            this.lblTarifInv.Text = "Tarif invité";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listActTypeBindingSource, "DLIMITEINSCRIPTION", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "d"));
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(90, 283);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // lblDateLimite
            // 
            this.lblDateLimite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateLimite.AutoSize = true;
            this.lblDateLimite.Location = new System.Drawing.Point(3, 280);
            this.lblDateLimite.Name = "lblDateLimite";
            this.lblDateLimite.Size = new System.Drawing.Size(59, 23);
            this.lblDateLimite.TabIndex = 16;
            this.lblDateLimite.Text = "Date limite Inscription";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Limite participants";
            // 
            // btSuivi
            // 
            this.btSuivi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btSuivi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btSuivi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSuivi.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btSuivi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSuivi.Image = ((System.Drawing.Image)(resources.GetObject("btSuivi.Image")));
            this.btSuivi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuivi.Location = new System.Drawing.Point(3, 363);
            this.btSuivi.Name = "btSuivi";
            this.btSuivi.Size = new System.Drawing.Size(290, 62);
            this.btSuivi.TabIndex = 5;
            this.btSuivi.Text = "&Inscriptions liées aux activités";
            this.btSuivi.UseVisualStyleBackColor = false;
            this.btSuivi.Click += new System.EventHandler(this.btSuivi_Click);
            // 
            // listActTypeTableAdapter
            // 
            this.listActTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frmActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(731, 434);
            this.Controls.Add(this.tblListeAct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActivites";
            this.Text = "frmActivites";
            this.Load += new System.EventHandler(this.frmActivites_Load);
            this.tblListeAct.ResumeLayout(false);
            this.gbListeAct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listActTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda28_bd3DataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbAct.ResumeLayout(false);
            this.tblDescAct.ResumeLayout(false);
            this.tblDescAct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblListeAct;
        private System.Windows.Forms.GroupBox gbListeAct;
        private System.Windows.Forms.DataGridView dgvAct;
        private cda28_bd3DataSet cda28_bd3DataSet;
        private System.Windows.Forms.BindingSource listActTypeBindingSource;
        private cda28_bd3DataSetTableAdapters.listActTypeTableAdapter listActTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDACTIVITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDADHERENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTITULEACTIVITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDEBUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIFADHERENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIFINVITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLIMITEINSCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nBLIMITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTITULETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbAct;
        private System.Windows.Forms.TableLayoutPanel tblDescAct;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textLimite;
        private System.Windows.Forms.TextBox textTarifInv;
        private System.Windows.Forms.TextBox textTarifAdh;
        private System.Windows.Forms.Label lblTarifAdh;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblidAct;
        private System.Windows.Forms.TextBox textIntitule;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblintitul;
        private System.Windows.Forms.Label lblDdebut;
        private System.Windows.Forms.DateTimePicker dtpDatedebut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblTarifInv;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblDateLimite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSuivi;
    }
}