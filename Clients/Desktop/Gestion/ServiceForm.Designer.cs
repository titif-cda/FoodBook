
namespace Desktop.Gestion
{
    partial class ServiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.serviceTlp = new System.Windows.Forms.TableLayoutPanel();
            this.addDeleteServiceTlp = new System.Windows.Forms.TableLayoutPanel();
            this.AddServiceBtn = new System.Windows.Forms.Button();
            this.btnTlp = new System.Windows.Forms.TableLayoutPanel();
            this.previousServiceBtn = new System.Windows.Forms.Button();
            this.RefreshServiceBtn = new System.Windows.Forms.Button();
            this.nextServiceBtn = new System.Windows.Forms.Button();
            this.CurrentPageServiceLbl = new System.Windows.Forms.Label();
            this.serviceDtGv = new System.Windows.Forms.DataGridView();
            this.detailServicePnl = new System.Windows.Forms.Panel();
            this.titreServiceLbl = new System.Windows.Forms.Label();
            this.platServiceLbl = new System.Windows.Forms.Label();
            this.entreeServiceLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dessertServiceLbl = new System.Windows.Forms.Label();
            this.dateServiceLbl = new System.Windows.Forms.Label();
            this.serviceLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isMidiLbl = new System.Windows.Forms.Label();
            this.serviceTlp.SuspendLayout();
            this.addDeleteServiceTlp.SuspendLayout();
            this.btnTlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDtGv)).BeginInit();
            this.detailServicePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceTlp
            // 
            this.serviceTlp.ColumnCount = 2;
            this.serviceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serviceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serviceTlp.Controls.Add(this.addDeleteServiceTlp, 0, 1);
            this.serviceTlp.Controls.Add(this.btnTlp, 1, 1);
            this.serviceTlp.Controls.Add(this.serviceDtGv, 0, 0);
            this.serviceTlp.Controls.Add(this.detailServicePnl, 1, 0);
            this.serviceTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceTlp.Location = new System.Drawing.Point(0, 0);
            this.serviceTlp.Margin = new System.Windows.Forms.Padding(0);
            this.serviceTlp.Name = "serviceTlp";
            this.serviceTlp.RowCount = 2;
            this.serviceTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.serviceTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.serviceTlp.Size = new System.Drawing.Size(784, 344);
            this.serviceTlp.TabIndex = 1;
            // 
            // addDeleteServiceTlp
            // 
            this.addDeleteServiceTlp.ColumnCount = 1;
            this.addDeleteServiceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addDeleteServiceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addDeleteServiceTlp.Controls.Add(this.AddServiceBtn, 0, 0);
            this.addDeleteServiceTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addDeleteServiceTlp.Location = new System.Drawing.Point(0, 309);
            this.addDeleteServiceTlp.Margin = new System.Windows.Forms.Padding(0);
            this.addDeleteServiceTlp.Name = "addDeleteServiceTlp";
            this.addDeleteServiceTlp.RowCount = 1;
            this.addDeleteServiceTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addDeleteServiceTlp.Size = new System.Drawing.Size(392, 35);
            this.addDeleteServiceTlp.TabIndex = 0;
            // 
            // AddServiceBtn
            // 
            this.AddServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.AddServiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddServiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddServiceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddServiceBtn.Location = new System.Drawing.Point(0, 0);
            this.AddServiceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddServiceBtn.Name = "AddServiceBtn";
            this.AddServiceBtn.Size = new System.Drawing.Size(392, 35);
            this.AddServiceBtn.TabIndex = 2;
            this.AddServiceBtn.Text = "Ajouter";
            this.AddServiceBtn.UseVisualStyleBackColor = false;
            this.AddServiceBtn.Click += new System.EventHandler(this.AddServiceBtn_Click);
            // 
            // btnTlp
            // 
            this.btnTlp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.btnTlp.ColumnCount = 4;
            this.btnTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.btnTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnTlp.Controls.Add(this.previousServiceBtn, 0, 0);
            this.btnTlp.Controls.Add(this.RefreshServiceBtn, 0, 0);
            this.btnTlp.Controls.Add(this.nextServiceBtn, 3, 0);
            this.btnTlp.Controls.Add(this.CurrentPageServiceLbl, 2, 0);
            this.btnTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTlp.Location = new System.Drawing.Point(395, 312);
            this.btnTlp.Name = "btnTlp";
            this.btnTlp.RowCount = 1;
            this.btnTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.btnTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.btnTlp.Size = new System.Drawing.Size(386, 29);
            this.btnTlp.TabIndex = 1;
            // 
            // previousServiceBtn
            // 
            this.previousServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.previousServiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousServiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.previousServiceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.previousServiceBtn.Location = new System.Drawing.Point(154, 0);
            this.previousServiceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.previousServiceBtn.Name = "previousServiceBtn";
            this.previousServiceBtn.Size = new System.Drawing.Size(77, 29);
            this.previousServiceBtn.TabIndex = 13;
            this.previousServiceBtn.Text = "<";
            this.previousServiceBtn.UseVisualStyleBackColor = false;
            // 
            // RefreshServiceBtn
            // 
            this.RefreshServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.RefreshServiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshServiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshServiceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshServiceBtn.Location = new System.Drawing.Point(0, 0);
            this.RefreshServiceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshServiceBtn.Name = "RefreshServiceBtn";
            this.RefreshServiceBtn.Size = new System.Drawing.Size(154, 29);
            this.RefreshServiceBtn.TabIndex = 8;
            this.RefreshServiceBtn.Text = "Rafraichir";
            this.RefreshServiceBtn.UseVisualStyleBackColor = false;
            // 
            // nextServiceBtn
            // 
            this.nextServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.nextServiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextServiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextServiceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.nextServiceBtn.Location = new System.Drawing.Point(308, 0);
            this.nextServiceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.nextServiceBtn.Name = "nextServiceBtn";
            this.nextServiceBtn.Size = new System.Drawing.Size(78, 29);
            this.nextServiceBtn.TabIndex = 12;
            this.nextServiceBtn.Text = ">";
            this.nextServiceBtn.UseVisualStyleBackColor = false;
            // 
            // CurrentPageServiceLbl
            // 
            this.CurrentPageServiceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentPageServiceLbl.AutoSize = true;
            this.CurrentPageServiceLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.CurrentPageServiceLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentPageServiceLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentPageServiceLbl.Location = new System.Drawing.Point(262, 7);
            this.CurrentPageServiceLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentPageServiceLbl.Name = "CurrentPageServiceLbl";
            this.CurrentPageServiceLbl.Size = new System.Drawing.Size(14, 15);
            this.CurrentPageServiceLbl.TabIndex = 9;
            this.CurrentPageServiceLbl.Text = "1";
            // 
            // serviceDtGv
            // 
            this.serviceDtGv.AllowUserToAddRows = false;
            this.serviceDtGv.AllowUserToDeleteRows = false;
            this.serviceDtGv.AllowUserToOrderColumns = true;
            this.serviceDtGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceDtGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.serviceDtGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceDtGv.DefaultCellStyle = dataGridViewCellStyle2;
            this.serviceDtGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceDtGv.Location = new System.Drawing.Point(0, 0);
            this.serviceDtGv.Margin = new System.Windows.Forms.Padding(0);
            this.serviceDtGv.Name = "serviceDtGv";
            this.serviceDtGv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceDtGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.serviceDtGv.RowHeadersVisible = false;
            this.serviceDtGv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.serviceDtGv.RowTemplate.Height = 25;
            this.serviceDtGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serviceDtGv.Size = new System.Drawing.Size(392, 309);
            this.serviceDtGv.TabIndex = 1;
            this.serviceDtGv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDtGv_CellDoubleClick);
            this.serviceDtGv.SelectionChanged += new System.EventHandler(this.serviceDtGv_SelectionChanged);
            // 
            // detailServicePnl
            // 
            this.detailServicePnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("detailServicePnl.BackgroundImage")));
            this.detailServicePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.detailServicePnl.Controls.Add(this.titreServiceLbl);
            this.detailServicePnl.Controls.Add(this.platServiceLbl);
            this.detailServicePnl.Controls.Add(this.entreeServiceLbl);
            this.detailServicePnl.Controls.Add(this.label5);
            this.detailServicePnl.Controls.Add(this.label4);
            this.detailServicePnl.Controls.Add(this.dessertServiceLbl);
            this.detailServicePnl.Controls.Add(this.dateServiceLbl);
            this.detailServicePnl.Controls.Add(this.serviceLbl);
            this.detailServicePnl.Controls.Add(this.label2);
            this.detailServicePnl.Controls.Add(this.label1);
            this.detailServicePnl.Controls.Add(this.isMidiLbl);
            this.detailServicePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailServicePnl.Location = new System.Drawing.Point(395, 3);
            this.detailServicePnl.Name = "detailServicePnl";
            this.detailServicePnl.Size = new System.Drawing.Size(386, 303);
            this.detailServicePnl.TabIndex = 2;
            // 
            // titreServiceLbl
            // 
            this.titreServiceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titreServiceLbl.AutoSize = true;
            this.titreServiceLbl.BackColor = System.Drawing.Color.Transparent;
            this.titreServiceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titreServiceLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titreServiceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.titreServiceLbl.Location = new System.Drawing.Point(12, 20);
            this.titreServiceLbl.Name = "titreServiceLbl";
            this.titreServiceLbl.Size = new System.Drawing.Size(72, 21);
            this.titreServiceLbl.TabIndex = 14;
            this.titreServiceLbl.Text = "Service";
            this.titreServiceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // platServiceLbl
            // 
            this.platServiceLbl.AutoSize = true;
            this.platServiceLbl.BackColor = System.Drawing.Color.Transparent;
            this.platServiceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.platServiceLbl.Location = new System.Drawing.Point(186, 229);
            this.platServiceLbl.Name = "platServiceLbl";
            this.platServiceLbl.Size = new System.Drawing.Size(27, 15);
            this.platServiceLbl.TabIndex = 13;
            this.platServiceLbl.Text = "Plat";
            // 
            // entreeServiceLbl
            // 
            this.entreeServiceLbl.AutoSize = true;
            this.entreeServiceLbl.BackColor = System.Drawing.Color.Transparent;
            this.entreeServiceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entreeServiceLbl.Location = new System.Drawing.Point(186, 191);
            this.entreeServiceLbl.Name = "entreeServiceLbl";
            this.entreeServiceLbl.Size = new System.Drawing.Size(40, 15);
            this.entreeServiceLbl.TabIndex = 12;
            this.entreeServiceLbl.Text = "Entree";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(125, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Plat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(107, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dessert :";
            // 
            // dessertServiceLbl
            // 
            this.dessertServiceLbl.AutoSize = true;
            this.dessertServiceLbl.BackColor = System.Drawing.Color.Transparent;
            this.dessertServiceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dessertServiceLbl.Location = new System.Drawing.Point(186, 266);
            this.dessertServiceLbl.Name = "dessertServiceLbl";
            this.dessertServiceLbl.Size = new System.Drawing.Size(45, 15);
            this.dessertServiceLbl.TabIndex = 9;
            this.dessertServiceLbl.Text = "Dessert";
            // 
            // dateServiceLbl
            // 
            this.dateServiceLbl.AutoSize = true;
            this.dateServiceLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateServiceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateServiceLbl.Location = new System.Drawing.Point(186, 140);
            this.dateServiceLbl.Name = "dateServiceLbl";
            this.dateServiceLbl.Size = new System.Drawing.Size(30, 15);
            this.dateServiceLbl.TabIndex = 7;
            this.dateServiceLbl.Text = "date";
            // 
            // serviceLbl
            // 
            this.serviceLbl.AutoSize = true;
            this.serviceLbl.BackColor = System.Drawing.Color.Transparent;
            this.serviceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceLbl.Location = new System.Drawing.Point(186, 93);
            this.serviceLbl.Name = "serviceLbl";
            this.serviceLbl.Size = new System.Drawing.Size(48, 15);
            this.serviceLbl.TabIndex = 6;
            this.serviceLbl.Text = "service?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(115, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Entrée :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(125, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date :";
            // 
            // isMidiLbl
            // 
            this.isMidiLbl.AutoSize = true;
            this.isMidiLbl.BackColor = System.Drawing.Color.Transparent;
            this.isMidiLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isMidiLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isMidiLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.isMidiLbl.Location = new System.Drawing.Point(111, 88);
            this.isMidiLbl.Name = "isMidiLbl";
            this.isMidiLbl.Size = new System.Drawing.Size(67, 20);
            this.isMidiLbl.TabIndex = 3;
            this.isMidiLbl.Text = "Service :";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 344);
            this.Controls.Add(this.serviceTlp);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.serviceTlp.ResumeLayout(false);
            this.addDeleteServiceTlp.ResumeLayout(false);
            this.btnTlp.ResumeLayout(false);
            this.btnTlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDtGv)).EndInit();
            this.detailServicePnl.ResumeLayout(false);
            this.detailServicePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel serviceTlp;
        private System.Windows.Forms.TableLayoutPanel addDeleteServiceTlp;
        private System.Windows.Forms.Button AddServiceBtn;
        private System.Windows.Forms.TableLayoutPanel btnTlp;
        private System.Windows.Forms.Button RefreshServiceBtn;
        private System.Windows.Forms.Label CurrentPageServiceLbl;
        private System.Windows.Forms.DataGridView serviceDtGv;
        private System.Windows.Forms.Button previousServiceBtn;
        private System.Windows.Forms.Button nextServiceBtn;
        private System.Windows.Forms.Panel detailServicePnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label isMidiLbl;
        private System.Windows.Forms.Label serviceLbl;
        private System.Windows.Forms.Label dateServiceLbl;
        private System.Windows.Forms.Label dessertServiceLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label entreeServiceLbl;
        private System.Windows.Forms.Label platServiceLbl;
        private System.Windows.Forms.Label titreServiceLbl;
    }
}