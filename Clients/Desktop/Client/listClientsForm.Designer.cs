
namespace Desktop
{
    partial class ListClientsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clientTlp = new System.Windows.Forms.FlowLayoutPanel();
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.RefreshClientBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.CurentPageLbl = new System.Windows.Forms.Label();
            this.NbPagesCombo = new System.Windows.Forms.ComboBox();
            this.SearchFlp = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.SearchtBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SearchFlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.clientTlp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddClientBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.RefreshClientBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.SearchFlp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.48936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510639F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(858, 423);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // clientTlp
            // 
            this.clientTlp.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.clientTlp, 3);
            this.clientTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientTlp.Location = new System.Drawing.Point(3, 35);
            this.clientTlp.Name = "clientTlp";
            this.clientTlp.Size = new System.Drawing.Size(852, 351);
            this.clientTlp.TabIndex = 0;
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.AddClientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddClientBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddClientBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddClientBtn.Location = new System.Drawing.Point(0, 389);
            this.AddClientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(285, 34);
            this.AddClientBtn.TabIndex = 1;
            this.AddClientBtn.Text = "Ajouter";
            this.AddClientBtn.UseVisualStyleBackColor = false;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // RefreshClientBtn
            // 
            this.RefreshClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.RefreshClientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshClientBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshClientBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshClientBtn.Location = new System.Drawing.Point(285, 389);
            this.RefreshClientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshClientBtn.Name = "RefreshClientBtn";
            this.RefreshClientBtn.Size = new System.Drawing.Size(286, 34);
            this.RefreshClientBtn.TabIndex = 2;
            this.RefreshClientBtn.Text = "Rafraichir";
            this.RefreshClientBtn.UseVisualStyleBackColor = false;
            this.RefreshClientBtn.Click += new System.EventHandler(this.RefreshClientBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.PreviousBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NextBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CurentPageLbl, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.NbPagesCombo, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(574, 392);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 28);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PreviousBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PreviousBtn.Location = new System.Drawing.Point(115, 3);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(50, 22);
            this.PreviousBtn.TabIndex = 0;
            this.PreviousBtn.Text = "<";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.NextBtn.Location = new System.Drawing.Point(227, 3);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(51, 22);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = ">";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // CurentPageLbl
            // 
            this.CurentPageLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurentPageLbl.AutoSize = true;
            this.CurentPageLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.CurentPageLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurentPageLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CurentPageLbl.Location = new System.Drawing.Point(189, 6);
            this.CurentPageLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CurentPageLbl.Name = "CurentPageLbl";
            this.CurentPageLbl.Size = new System.Drawing.Size(14, 15);
            this.CurentPageLbl.TabIndex = 2;
            this.CurentPageLbl.Text = "1";
            // 
            // NbPagesCombo
            // 
            this.NbPagesCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NbPagesCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.NbPagesCombo.FormattingEnabled = true;
            this.NbPagesCombo.Location = new System.Drawing.Point(3, 3);
            this.NbPagesCombo.Name = "NbPagesCombo";
            this.NbPagesCombo.Size = new System.Drawing.Size(106, 23);
            this.NbPagesCombo.TabIndex = 3;
            // 
            // SearchFlp
            // 
            this.SearchFlp.Controls.Add(this.SearchLbl);
            this.SearchFlp.Controls.Add(this.SearchtBox);
            this.SearchFlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchFlp.Location = new System.Drawing.Point(3, 3);
            this.SearchFlp.Name = "SearchFlp";
            this.SearchFlp.Size = new System.Drawing.Size(279, 26);
            this.SearchFlp.TabIndex = 4;
            // 
            // SearchLbl
            // 
            this.SearchLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(3, 7);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(68, 15);
            this.SearchLbl.TabIndex = 0;
            this.SearchLbl.Text = "Recherche :";
            // 
            // SearchtBox
            // 
            this.SearchtBox.Location = new System.Drawing.Point(77, 3);
            this.SearchtBox.Name = "SearchtBox";
            this.SearchtBox.Size = new System.Drawing.Size(130, 23);
            this.SearchtBox.TabIndex = 1;
            this.SearchtBox.TextChanged += new System.EventHandler(this.SearchtBox_TextChanged);
            // 
            // ListClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 423);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListClientsForm";
            this.Text = "listClients";
            this.SizeChanged += new System.EventHandler(this.listClientsForm_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.SearchFlp.ResumeLayout(false);
            this.SearchFlp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel clientTlp;
        private ClientsControl clientsControl1;
        private System.Windows.Forms.Button AddClientBtn;
        private System.Windows.Forms.Button RefreshClientBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Label CurentPageLbl;
        public System.Windows.Forms.ComboBox NbPagesCombo;
        private System.Windows.Forms.FlowLayoutPanel SearchFlp;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TextBox SearchtBox;
    }
}