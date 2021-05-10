namespace mcmp2
{
    partial class frmAdherents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdherents));
            this.tblListeAdh = new System.Windows.Forms.TableLayoutPanel();
            this.gbListeAdherent = new System.Windows.Forms.GroupBox();
            this.tlplistAd = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAdh = new System.Windows.Forms.DataGridView();
            this.iDADHERENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNAISSANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSE1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDPOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vILLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dADHESIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRGANISATEURDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listAdherentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda28_bd3DataSet = new mcmp2.cda28_bd3DataSet();
            this.gBTotal = new System.Windows.Forms.GroupBox();
            this.lblTotalAd = new System.Windows.Forms.Label();
            this.gbMembre = new System.Windows.Forms.GroupBox();
            this.tblMembre = new System.Windows.Forms.TableLayoutPanel();
            this.btAjouter = new System.Windows.Forms.Button();
            this.textNom = new System.Windows.Forms.TextBox();
            this.btModifier = new System.Windows.Forms.Button();
            this.dtpAdh = new System.Windows.Forms.DateTimePicker();
            this.lblorg = new System.Windows.Forms.Label();
            this.textTel = new System.Windows.Forms.TextBox();
            this.lblDadh = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.textVille = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textCP = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.textAd2 = new System.Windows.Forms.TextBox();
            this.lblCp = new System.Windows.Forms.Label();
            this.textAd1 = new System.Windows.Forms.TextBox();
            this.lblAdr2 = new System.Windows.Forms.Label();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.dtpDNaiss = new System.Windows.Forms.DateTimePicker();
            this.lblAdr1 = new System.Windows.Forms.Label();
            this.lblDtNaiss = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.ckbxOrg = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btAd = new System.Windows.Forms.Button();
            this.btMaj = new System.Windows.Forms.Button();
            this.btActualiser = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btSuivi = new System.Windows.Forms.Button();
            this.listAdherentTableAdapter = new mcmp2.cda28_bd3DataSetTableAdapters.listAdherentTableAdapter();
            this.adherentTableAdapter = new mcmp2.cda28_bd3DataSetTableAdapters.adherentTableAdapter();
            this.listeInscriptionsAvecActetAdhTableAdapter = new mcmp2.cda28_bd3DataSetTableAdapters.listeInscriptionsAvecActetAdhTableAdapter();
            this.tblListeAdh.SuspendLayout();
            this.gbListeAdherent.SuspendLayout();
            this.tlplistAd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAdherentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda28_bd3DataSet)).BeginInit();
            this.gBTotal.SuspendLayout();
            this.gbMembre.SuspendLayout();
            this.tblMembre.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblListeAdh
            // 
            this.tblListeAdh.ColumnCount = 2;
            this.tblListeAdh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.82353F));
            this.tblListeAdh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17647F));
            this.tblListeAdh.Controls.Add(this.gbListeAdherent, 0, 0);
            this.tblListeAdh.Controls.Add(this.gbMembre, 1, 0);
            this.tblListeAdh.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblListeAdh.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tblListeAdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblListeAdh.Location = new System.Drawing.Point(0, 0);
            this.tblListeAdh.Name = "tblListeAdh";
            this.tblListeAdh.RowCount = 2;
            this.tblListeAdh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.94931F));
            this.tblListeAdh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.05069F));
            this.tblListeAdh.Size = new System.Drawing.Size(731, 434);
            this.tblListeAdh.TabIndex = 1;
            // 
            // gbListeAdherent
            // 
            this.gbListeAdherent.Controls.Add(this.tlplistAd);
            this.gbListeAdherent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbListeAdherent.Location = new System.Drawing.Point(3, 3);
            this.gbListeAdherent.Name = "gbListeAdherent";
            this.gbListeAdherent.Size = new System.Drawing.Size(423, 354);
            this.gbListeAdherent.TabIndex = 0;
            this.gbListeAdherent.TabStop = false;
            this.gbListeAdherent.Text = "Liste des adhérents";
            // 
            // tlplistAd
            // 
            this.tlplistAd.ColumnCount = 1;
            this.tlplistAd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlplistAd.Controls.Add(this.dgvAdh, 0, 1);
            this.tlplistAd.Controls.Add(this.gBTotal, 0, 0);
            this.tlplistAd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlplistAd.Location = new System.Drawing.Point(3, 16);
            this.tlplistAd.Name = "tlplistAd";
            this.tlplistAd.RowCount = 2;
            this.tlplistAd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.954545F));
            this.tlplistAd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.04546F));
            this.tlplistAd.Size = new System.Drawing.Size(417, 335);
            this.tlplistAd.TabIndex = 0;
            // 
            // dgvAdh
            // 
            this.dgvAdh.AllowUserToAddRows = false;
            this.dgvAdh.AllowUserToDeleteRows = false;
            this.dgvAdh.AutoGenerateColumns = false;
            this.dgvAdh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.dgvAdh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDADHERENTDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENOMDataGridViewTextBoxColumn,
            this.dNAISSANCEDataGridViewTextBoxColumn,
            this.aDRESSE1DataGridViewTextBoxColumn,
            this.aDRESSE2DataGridViewTextBoxColumn,
            this.cDPOSTDataGridViewTextBoxColumn,
            this.vILLEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.tELEPHONEDataGridViewTextBoxColumn,
            this.dADHESIONDataGridViewTextBoxColumn,
            this.oRGANISATEURDataGridViewTextBoxColumn});
            this.dgvAdh.DataSource = this.listAdherentBindingSource;
            this.dgvAdh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdh.Location = new System.Drawing.Point(3, 29);
            this.dgvAdh.Name = "dgvAdh";
            this.dgvAdh.ReadOnly = true;
            this.dgvAdh.RowHeadersVisible = false;
            this.dgvAdh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdh.Size = new System.Drawing.Size(411, 303);
            this.dgvAdh.StandardTab = true;
            this.dgvAdh.TabIndex = 16;
            // 
            // iDADHERENTDataGridViewTextBoxColumn
            // 
            this.iDADHERENTDataGridViewTextBoxColumn.DataPropertyName = "IDADHERENT";
            this.iDADHERENTDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.iDADHERENTDataGridViewTextBoxColumn.Name = "iDADHERENTDataGridViewTextBoxColumn";
            this.iDADHERENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDADHERENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRENOMDataGridViewTextBoxColumn
            // 
            this.pRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRENOM";
            this.pRENOMDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.pRENOMDataGridViewTextBoxColumn.Name = "pRENOMDataGridViewTextBoxColumn";
            this.pRENOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNAISSANCEDataGridViewTextBoxColumn
            // 
            this.dNAISSANCEDataGridViewTextBoxColumn.DataPropertyName = "DNAISSANCE";
            this.dNAISSANCEDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
            this.dNAISSANCEDataGridViewTextBoxColumn.Name = "dNAISSANCEDataGridViewTextBoxColumn";
            this.dNAISSANCEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDRESSE1DataGridViewTextBoxColumn
            // 
            this.aDRESSE1DataGridViewTextBoxColumn.DataPropertyName = "ADRESSE1";
            this.aDRESSE1DataGridViewTextBoxColumn.HeaderText = "ADRESSE1";
            this.aDRESSE1DataGridViewTextBoxColumn.Name = "aDRESSE1DataGridViewTextBoxColumn";
            this.aDRESSE1DataGridViewTextBoxColumn.ReadOnly = true;
            this.aDRESSE1DataGridViewTextBoxColumn.Visible = false;
            // 
            // aDRESSE2DataGridViewTextBoxColumn
            // 
            this.aDRESSE2DataGridViewTextBoxColumn.DataPropertyName = "ADRESSE2";
            this.aDRESSE2DataGridViewTextBoxColumn.HeaderText = "ADRESSE2";
            this.aDRESSE2DataGridViewTextBoxColumn.Name = "aDRESSE2DataGridViewTextBoxColumn";
            this.aDRESSE2DataGridViewTextBoxColumn.ReadOnly = true;
            this.aDRESSE2DataGridViewTextBoxColumn.Visible = false;
            // 
            // cDPOSTDataGridViewTextBoxColumn
            // 
            this.cDPOSTDataGridViewTextBoxColumn.DataPropertyName = "CDPOST";
            this.cDPOSTDataGridViewTextBoxColumn.HeaderText = "CDPOST";
            this.cDPOSTDataGridViewTextBoxColumn.Name = "cDPOSTDataGridViewTextBoxColumn";
            this.cDPOSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDPOSTDataGridViewTextBoxColumn.Visible = false;
            // 
            // vILLEDataGridViewTextBoxColumn
            // 
            this.vILLEDataGridViewTextBoxColumn.DataPropertyName = "VILLE";
            this.vILLEDataGridViewTextBoxColumn.HeaderText = "VILLE";
            this.vILLEDataGridViewTextBoxColumn.Name = "vILLEDataGridViewTextBoxColumn";
            this.vILLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.vILLEDataGridViewTextBoxColumn.Visible = false;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEPHONEDataGridViewTextBoxColumn
            // 
            this.tELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONE";
            this.tELEPHONEDataGridViewTextBoxColumn.HeaderText = "TELEPHONE";
            this.tELEPHONEDataGridViewTextBoxColumn.Name = "tELEPHONEDataGridViewTextBoxColumn";
            this.tELEPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tELEPHONEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dADHESIONDataGridViewTextBoxColumn
            // 
            this.dADHESIONDataGridViewTextBoxColumn.DataPropertyName = "DADHESION";
            this.dADHESIONDataGridViewTextBoxColumn.HeaderText = "DADHESION";
            this.dADHESIONDataGridViewTextBoxColumn.Name = "dADHESIONDataGridViewTextBoxColumn";
            this.dADHESIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dADHESIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRGANISATEURDataGridViewTextBoxColumn
            // 
            this.oRGANISATEURDataGridViewTextBoxColumn.DataPropertyName = "ORGANISATEUR";
            this.oRGANISATEURDataGridViewTextBoxColumn.HeaderText = "ORGANISATEUR";
            this.oRGANISATEURDataGridViewTextBoxColumn.Name = "oRGANISATEURDataGridViewTextBoxColumn";
            this.oRGANISATEURDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRGANISATEURDataGridViewTextBoxColumn.Visible = false;
            // 
            // listAdherentBindingSource
            // 
            this.listAdherentBindingSource.DataMember = "listAdherent";
            this.listAdherentBindingSource.DataSource = this.cda28_bd3DataSet;
            this.listAdherentBindingSource.CurrentChanged += new System.EventHandler(this.listAdherentBindingSource_CurrentChanged);
            // 
            // cda28_bd3DataSet
            // 
            this.cda28_bd3DataSet.DataSetName = "cda28_bd3DataSet";
            this.cda28_bd3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gBTotal
            // 
            this.gBTotal.Controls.Add(this.lblTotalAd);
            this.gBTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBTotal.Location = new System.Drawing.Point(3, 3);
            this.gBTotal.Name = "gBTotal";
            this.gBTotal.Size = new System.Drawing.Size(411, 20);
            this.gBTotal.TabIndex = 17;
            this.gBTotal.TabStop = false;
            this.gBTotal.Text = "Nombre d\'adhérents";
            // 
            // lblTotalAd
            // 
            this.lblTotalAd.AutoSize = true;
            this.lblTotalAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAd.Location = new System.Drawing.Point(139, 0);
            this.lblTotalAd.Name = "lblTotalAd";
            this.lblTotalAd.Size = new System.Drawing.Size(32, 13);
            this.lblTotalAd.TabIndex = 0;
            this.lblTotalAd.Text = "total";
            // 
            // gbMembre
            // 
            this.gbMembre.Controls.Add(this.tblMembre);
            this.gbMembre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMembre.Location = new System.Drawing.Point(432, 3);
            this.gbMembre.Name = "gbMembre";
            this.gbMembre.Size = new System.Drawing.Size(296, 354);
            this.gbMembre.TabIndex = 1;
            this.gbMembre.TabStop = false;
            this.gbMembre.Text = "Fiche adhérent";
            // 
            // tblMembre
            // 
            this.tblMembre.ColumnCount = 2;
            this.tblMembre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMembre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMembre.Controls.Add(this.btAjouter, 1, 11);
            this.tblMembre.Controls.Add(this.textNom, 1, 0);
            this.tblMembre.Controls.Add(this.btModifier, 0, 11);
            this.tblMembre.Controls.Add(this.dtpAdh, 1, 9);
            this.tblMembre.Controls.Add(this.lblorg, 0, 10);
            this.tblMembre.Controls.Add(this.textTel, 1, 8);
            this.tblMembre.Controls.Add(this.lblDadh, 0, 9);
            this.tblMembre.Controls.Add(this.textEmail, 1, 7);
            this.tblMembre.Controls.Add(this.lblTel, 0, 8);
            this.tblMembre.Controls.Add(this.textVille, 1, 6);
            this.tblMembre.Controls.Add(this.lblEmail, 0, 7);
            this.tblMembre.Controls.Add(this.textCP, 1, 5);
            this.tblMembre.Controls.Add(this.lblVille, 0, 6);
            this.tblMembre.Controls.Add(this.textAd2, 1, 4);
            this.tblMembre.Controls.Add(this.lblCp, 0, 5);
            this.tblMembre.Controls.Add(this.textAd1, 1, 3);
            this.tblMembre.Controls.Add(this.lblAdr2, 0, 4);
            this.tblMembre.Controls.Add(this.textPrenom, 1, 1);
            this.tblMembre.Controls.Add(this.dtpDNaiss, 1, 2);
            this.tblMembre.Controls.Add(this.lblAdr1, 0, 3);
            this.tblMembre.Controls.Add(this.lblDtNaiss, 0, 2);
            this.tblMembre.Controls.Add(this.lblPrenom, 0, 1);
            this.tblMembre.Controls.Add(this.lblNom, 0, 0);
            this.tblMembre.Controls.Add(this.ckbxOrg, 1, 10);
            this.tblMembre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMembre.Location = new System.Drawing.Point(3, 16);
            this.tblMembre.Name = "tblMembre";
            this.tblMembre.RowCount = 12;
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblMembre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMembre.Size = new System.Drawing.Size(290, 335);
            this.tblMembre.TabIndex = 6;
            // 
            // btAjouter
            // 
            this.btAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAjouter.Enabled = false;
            this.btAjouter.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btAjouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjouter.Location = new System.Drawing.Point(148, 300);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(139, 32);
            this.btAjouter.TabIndex = 19;
            this.btAjouter.Text = "&Ajouter";
            this.btAjouter.UseVisualStyleBackColor = false;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // textNom
            // 
            this.textNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listAdherentBindingSource, "NOM", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textNom.Enabled = false;
            this.textNom.Location = new System.Drawing.Point(148, 3);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(139, 20);
            this.textNom.TabIndex = 0;
            // 
            // btModifier
            // 
            this.btModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModifier.Enabled = false;
            this.btModifier.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModifier.Location = new System.Drawing.Point(3, 300);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(139, 32);
            this.btModifier.TabIndex = 18;
            this.btModifier.Text = "&Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // dtpAdh
            // 
            this.dtpAdh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAdh.Enabled = false;
            this.dtpAdh.Location = new System.Drawing.Point(148, 246);
            this.dtpAdh.Name = "dtpAdh";
            this.dtpAdh.Size = new System.Drawing.Size(139, 20);
            this.dtpAdh.TabIndex = 9;
            // 
            // lblorg
            // 
            this.lblorg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblorg.AutoSize = true;
            this.lblorg.Location = new System.Drawing.Point(75, 277);
            this.lblorg.Name = "lblorg";
            this.lblorg.Size = new System.Drawing.Size(67, 13);
            this.lblorg.TabIndex = 10;
            this.lblorg.Text = "Organisateur";
            // 
            // textTel
            // 
            this.textTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listAdherentBindingSource, "TELEPHONE", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textTel.Enabled = false;
            this.textTel.Location = new System.Drawing.Point(148, 219);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(139, 20);
            this.textTel.TabIndex = 8;
            // 
            // lblDadh
            // 
            this.lblDadh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDadh.AutoSize = true;
            this.lblDadh.Location = new System.Drawing.Point(56, 250);
            this.lblDadh.Name = "lblDadh";
            this.lblDadh.Size = new System.Drawing.Size(86, 13);
            this.lblDadh.TabIndex = 9;
            this.lblDadh.Text = "Date D\'adhésion";
            // 
            // textEmail
            // 
            this.textEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listAdherentBindingSource, "EMAIL", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textEmail.Enabled = false;
            this.textEmail.Location = new System.Drawing.Point(148, 192);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(139, 20);
            this.textEmail.TabIndex = 7;
            // 
            // lblTel
            // 
            this.lblTel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(84, 223);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(58, 13);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "Téléphone";
            // 
            // textVille
            // 
            this.textVille.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listAdherentBindingSource, "VILLE", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textVille.Enabled = false;
            this.textVille.Location = new System.Drawing.Point(148, 165);
            this.textVille.Name = "textVille";
            this.textVille.Size = new System.Drawing.Size(139, 20);
            this.textVille.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(110, 196);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // textCP
            // 
            this.textCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listAdherentBindingSource, "CDPOST", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textCP.Enabled = false;
            this.textCP.Location = new System.Drawing.Point(148, 138);
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(139, 20);
            this.textCP.TabIndex = 5;
            // 
            // lblVille
            // 
            this.lblVille.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(116, 169);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 6;
            this.lblVille.Text = "Ville";
            // 
            // textAd2
            // 
            this.textAd2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textAd2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listAdherentBindingSource, "ADRESSE2", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textAd2.Enabled = false;
            this.textAd2.Location = new System.Drawing.Point(148, 111);
            this.textAd2.Name = "textAd2";
            this.textAd2.Size = new System.Drawing.Size(139, 20);
            this.textAd2.TabIndex = 4;
            // 
            // lblCp
            // 
            this.lblCp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(78, 142);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(64, 13);
            this.lblCp.TabIndex = 5;
            this.lblCp.Text = "Code Postal";
            // 
            // textAd1
            // 
            this.textAd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textAd1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listAdherentBindingSource, "ADRESSE1", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textAd1.Enabled = false;
            this.textAd1.Location = new System.Drawing.Point(148, 84);
            this.textAd1.Name = "textAd1";
            this.textAd1.Size = new System.Drawing.Size(139, 20);
            this.textAd1.TabIndex = 3;
            // 
            // lblAdr2
            // 
            this.lblAdr2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAdr2.AutoSize = true;
            this.lblAdr2.Location = new System.Drawing.Point(88, 115);
            this.lblAdr2.Name = "lblAdr2";
            this.lblAdr2.Size = new System.Drawing.Size(54, 13);
            this.lblAdr2.TabIndex = 4;
            this.lblAdr2.Text = "Adresse 2";
            // 
            // textPrenom
            // 
            this.textPrenom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listAdherentBindingSource, "PRENOM", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.textPrenom.Enabled = false;
            this.textPrenom.Location = new System.Drawing.Point(148, 30);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(139, 20);
            this.textPrenom.TabIndex = 1;
            // 
            // dtpDNaiss
            // 
            this.dtpDNaiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDNaiss.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listAdherentBindingSource, "DNAISSANCE", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dtpDNaiss.Enabled = false;
            this.dtpDNaiss.Location = new System.Drawing.Point(148, 57);
            this.dtpDNaiss.MaxDate = new System.DateTime(2999, 12, 3, 0, 0, 0, 0);
            this.dtpDNaiss.Name = "dtpDNaiss";
            this.dtpDNaiss.Size = new System.Drawing.Size(139, 20);
            this.dtpDNaiss.TabIndex = 2;
            this.dtpDNaiss.Value = new System.DateTime(2020, 12, 3, 0, 0, 0, 0);
            // 
            // lblAdr1
            // 
            this.lblAdr1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAdr1.AutoSize = true;
            this.lblAdr1.Location = new System.Drawing.Point(88, 88);
            this.lblAdr1.Name = "lblAdr1";
            this.lblAdr1.Size = new System.Drawing.Size(54, 13);
            this.lblAdr1.TabIndex = 3;
            this.lblAdr1.Text = "Adresse 1";
            // 
            // lblDtNaiss
            // 
            this.lblDtNaiss.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDtNaiss.AutoSize = true;
            this.lblDtNaiss.Location = new System.Drawing.Point(44, 61);
            this.lblDtNaiss.Name = "lblDtNaiss";
            this.lblDtNaiss.Size = new System.Drawing.Size(98, 13);
            this.lblDtNaiss.TabIndex = 2;
            this.lblDtNaiss.Text = "Date de Naissance";
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(99, 34);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(113, 7);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // ckbxOrg
            // 
            this.ckbxOrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbxOrg.AutoSize = true;
            this.ckbxOrg.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listAdherentBindingSource, "ORGANISATEUR", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.ckbxOrg.Enabled = false;
            this.ckbxOrg.Location = new System.Drawing.Point(210, 276);
            this.ckbxOrg.Name = "ckbxOrg";
            this.ckbxOrg.Size = new System.Drawing.Size(15, 14);
            this.ckbxOrg.TabIndex = 12;
            this.ckbxOrg.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btAd, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btMaj, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btActualiser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btSupprimer, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(423, 68);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btAd
            // 
            this.btAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAd.BackColor = System.Drawing.Color.Maroon;
            this.btAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAd.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btAd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAd.Location = new System.Drawing.Point(318, 3);
            this.btAd.Name = "btAd";
            this.btAd.Size = new System.Drawing.Size(102, 62);
            this.btAd.TabIndex = 17;
            this.btAd.Text = "&Ajouter un adhérent";
            this.btAd.UseVisualStyleBackColor = false;
            this.btAd.Click += new System.EventHandler(this.btAd_Click);
            // 
            // btMaj
            // 
            this.btMaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaj.BackColor = System.Drawing.Color.Maroon;
            this.btMaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaj.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btMaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btMaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMaj.Location = new System.Drawing.Point(213, 3);
            this.btMaj.Name = "btMaj";
            this.btMaj.Size = new System.Drawing.Size(99, 62);
            this.btMaj.TabIndex = 16;
            this.btMaj.Text = "&Modifier l\'adhérent";
            this.btMaj.UseVisualStyleBackColor = false;
            this.btMaj.Click += new System.EventHandler(this.btMaj_Click);
            // 
            // btActualiser
            // 
            this.btActualiser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btActualiser.BackColor = System.Drawing.Color.Maroon;
            this.btActualiser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btActualiser.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualiser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btActualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btActualiser.Location = new System.Drawing.Point(3, 3);
            this.btActualiser.Name = "btActualiser";
            this.btActualiser.Size = new System.Drawing.Size(99, 62);
            this.btActualiser.TabIndex = 1;
            this.btActualiser.Text = "&Actualiser";
            this.btActualiser.UseVisualStyleBackColor = false;
            this.btActualiser.Click += new System.EventHandler(this.btActualiser_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSupprimer.BackColor = System.Drawing.Color.Maroon;
            this.btSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSupprimer.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btSupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSupprimer.Location = new System.Drawing.Point(108, 3);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(99, 62);
            this.btSupprimer.TabIndex = 4;
            this.btSupprimer.Text = "&Supprimer";
            this.btSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSupprimer.UseVisualStyleBackColor = false;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btSuivi, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(432, 363);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 68);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btSuivi
            // 
            this.btSuivi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btSuivi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSuivi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSuivi.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.btSuivi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSuivi.Image = ((System.Drawing.Image)(resources.GetObject("btSuivi.Image")));
            this.btSuivi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuivi.Location = new System.Drawing.Point(3, 3);
            this.btSuivi.Name = "btSuivi";
            this.btSuivi.Size = new System.Drawing.Size(290, 62);
            this.btSuivi.TabIndex = 5;
            this.btSuivi.Text = "&Inscriptions liées aux adhérents";
            this.btSuivi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuivi.UseVisualStyleBackColor = false;
            this.btSuivi.Click += new System.EventHandler(this.btSuivi_Click);
            // 
            // listAdherentTableAdapter
            // 
            this.listAdherentTableAdapter.ClearBeforeFill = true;
            // 
            // adherentTableAdapter
            // 
            this.adherentTableAdapter.ClearBeforeFill = true;
            // 
            // listeInscriptionsAvecActetAdhTableAdapter
            // 
            this.listeInscriptionsAvecActetAdhTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(731, 434);
            this.Controls.Add(this.tblListeAdh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdherents";
            this.Text = "frmAdherent";
            this.Load += new System.EventHandler(this.frmAdherents_Load);
            this.tblListeAdh.ResumeLayout(false);
            this.gbListeAdherent.ResumeLayout(false);
            this.tlplistAd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listAdherentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda28_bd3DataSet)).EndInit();
            this.gBTotal.ResumeLayout(false);
            this.gBTotal.PerformLayout();
            this.gbMembre.ResumeLayout(false);
            this.tblMembre.ResumeLayout(false);
            this.tblMembre.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblListeAdh;
        private System.Windows.Forms.GroupBox gbMembre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btActualiser;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbListeAdherent;
        private System.Windows.Forms.Button btAd;
        private System.Windows.Forms.Button btMaj;
        private cda28_bd3DataSet cda28_bd3DataSet;
        private System.Windows.Forms.BindingSource listAdherentBindingSource;
        private cda28_bd3DataSetTableAdapters.listAdherentTableAdapter listAdherentTableAdapter;
        private cda28_bd3DataSetTableAdapters.adherentTableAdapter adherentTableAdapter;
        internal cda28_bd3DataSetTableAdapters.listeInscriptionsAvecActetAdhTableAdapter listeInscriptionsAvecActetAdhTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tlplistAd;
        private System.Windows.Forms.DataGridView dgvAdh;
        private System.Windows.Forms.GroupBox gBTotal;
        private System.Windows.Forms.Label lblTotalAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDADHERENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNAISSANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDPOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vILLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dADHESIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRGANISATEURDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btSuivi;
        private System.Windows.Forms.TableLayoutPanel tblMembre;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.DateTimePicker dtpAdh;
        private System.Windows.Forms.Label lblorg;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.Label lblDadh;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox textVille;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox textAd2;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.TextBox textAd1;
        private System.Windows.Forms.Label lblAdr2;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.DateTimePicker dtpDNaiss;
        private System.Windows.Forms.Label lblAdr1;
        private System.Windows.Forms.Label lblDtNaiss;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.CheckBox ckbxOrg;
    }
}