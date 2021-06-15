
namespace Desktop.Mets
{
    partial class ListMetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMetForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddMetBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviousMetBtn = new System.Windows.Forms.Button();
            this.NextMetBtn = new System.Windows.Forms.Button();
            this.CurentPageMetLbl = new System.Windows.Forms.Label();
            this.metDtGv = new System.Windows.Forms.DataGridView();
            this.metPicturePnl = new System.Windows.Forms.Panel();
            this.DescRepasPnl = new System.Windows.Forms.Panel();
            this.typeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentIngredientsLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.CurrentDescLabel = new System.Windows.Forms.Label();
            this.Nomlbl = new System.Windows.Forms.Label();
            this.CurrentMetLbl = new System.Windows.Forms.Label();
            this.refreshDeleteTLP = new System.Windows.Forms.TableLayoutPanel();
            this.RefreshMetBtn = new System.Windows.Forms.Button();
            this.DeleteMetBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metDtGv)).BeginInit();
            this.metPicturePnl.SuspendLayout();
            this.DescRepasPnl.SuspendLayout();
            this.refreshDeleteTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.AddMetBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.metDtGv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metPicturePnl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.refreshDeleteTLP, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.48936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510639F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AddMetBtn
            // 
            this.AddMetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.AddMetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddMetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddMetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddMetBtn.Location = new System.Drawing.Point(0, 411);
            this.AddMetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddMetBtn.Name = "AddMetBtn";
            this.AddMetBtn.Size = new System.Drawing.Size(302, 39);
            this.AddMetBtn.TabIndex = 1;
            this.AddMetBtn.Text = "Ajouter";
            this.AddMetBtn.UseVisualStyleBackColor = false;
            this.AddMetBtn.Click += new System.EventHandler(this.AddMetBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.PreviousMetBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NextMetBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.CurentPageMetLbl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(535, 414);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 33);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // PreviousMetBtn
            // 
            this.PreviousMetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviousMetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousMetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PreviousMetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PreviousMetBtn.Location = new System.Drawing.Point(3, 3);
            this.PreviousMetBtn.Name = "PreviousMetBtn";
            this.PreviousMetBtn.Size = new System.Drawing.Size(81, 27);
            this.PreviousMetBtn.TabIndex = 0;
            this.PreviousMetBtn.Text = "<";
            this.PreviousMetBtn.UseVisualStyleBackColor = true;
            this.PreviousMetBtn.Click += new System.EventHandler(this.PreviousMetBtn_Click);
            // 
            // NextMetBtn
            // 
            this.NextMetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextMetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextMetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextMetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.NextMetBtn.Location = new System.Drawing.Point(177, 3);
            this.NextMetBtn.Name = "NextMetBtn";
            this.NextMetBtn.Size = new System.Drawing.Size(82, 27);
            this.NextMetBtn.TabIndex = 1;
            this.NextMetBtn.Text = ">";
            this.NextMetBtn.UseVisualStyleBackColor = true;
            this.NextMetBtn.Click += new System.EventHandler(this.NextMetBtn_Click);
            // 
            // CurentPageMetLbl
            // 
            this.CurentPageMetLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurentPageMetLbl.AutoSize = true;
            this.CurentPageMetLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.CurentPageMetLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurentPageMetLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CurentPageMetLbl.Location = new System.Drawing.Point(123, 9);
            this.CurentPageMetLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CurentPageMetLbl.Name = "CurentPageMetLbl";
            this.CurentPageMetLbl.Size = new System.Drawing.Size(14, 15);
            this.CurentPageMetLbl.TabIndex = 2;
            this.CurentPageMetLbl.Text = "1";
            // 
            // metDtGv
            // 
            this.metDtGv.AllowUserToAddRows = false;
            this.metDtGv.AllowUserToDeleteRows = false;
            this.metDtGv.AllowUserToResizeRows = false;
            this.metDtGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metDtGv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.metDtGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metDtGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.metDtGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metDtGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metDtGv.GridColor = System.Drawing.SystemColors.Control;
            this.metDtGv.Location = new System.Drawing.Point(3, 3);
            this.metDtGv.MultiSelect = false;
            this.metDtGv.Name = "metDtGv";
            this.metDtGv.ReadOnly = true;
            this.metDtGv.RowHeadersVisible = false;
            this.metDtGv.RowTemplate.Height = 25;
            this.metDtGv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metDtGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metDtGv.Size = new System.Drawing.Size(296, 405);
            this.metDtGv.TabIndex = 4;
            this.metDtGv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metDtGv_CellDoubleClick);
            this.metDtGv.SelectionChanged += new System.EventHandler(this.metDtGv_SelectionChanged);
            // 
            // metPicturePnl
            // 
            this.metPicturePnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metPicturePnl.BackgroundImage")));
            this.metPicturePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.metPicturePnl, 2);
            this.metPicturePnl.Controls.Add(this.DescRepasPnl);
            this.metPicturePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metPicturePnl.Location = new System.Drawing.Point(305, 3);
            this.metPicturePnl.Name = "metPicturePnl";
            this.metPicturePnl.Size = new System.Drawing.Size(492, 405);
            this.metPicturePnl.TabIndex = 5;
            // 
            // DescRepasPnl
            // 
            this.DescRepasPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DescRepasPnl.BackColor = System.Drawing.Color.Transparent;
            this.DescRepasPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DescRepasPnl.BackgroundImage")));
            this.DescRepasPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DescRepasPnl.Controls.Add(this.typeLbl);
            this.DescRepasPnl.Controls.Add(this.label1);
            this.DescRepasPnl.Controls.Add(this.CurrentIngredientsLbl);
            this.DescRepasPnl.Controls.Add(this.descLbl);
            this.DescRepasPnl.Controls.Add(this.CurrentDescLabel);
            this.DescRepasPnl.Controls.Add(this.Nomlbl);
            this.DescRepasPnl.Controls.Add(this.CurrentMetLbl);
            this.DescRepasPnl.Location = new System.Drawing.Point(93, 3);
            this.DescRepasPnl.Name = "DescRepasPnl";
            this.DescRepasPnl.Size = new System.Drawing.Size(312, 405);
            this.DescRepasPnl.TabIndex = 1;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.typeLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.typeLbl.Location = new System.Drawing.Point(198, 51);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(45, 17);
            this.typeLbl.TabIndex = 6;
            this.typeLbl.Text = "Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(70, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingredients :";
            // 
            // CurrentIngredientsLbl
            // 
            this.CurrentIngredientsLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentIngredientsLbl.Location = new System.Drawing.Point(33, 207);
            this.CurrentIngredientsLbl.Name = "CurrentIngredientsLbl";
            this.CurrentIngredientsLbl.Size = new System.Drawing.Size(242, 94);
            this.CurrentIngredientsLbl.TabIndex = 4;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.descLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.descLbl.Location = new System.Drawing.Point(70, 129);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(87, 17);
            this.descLbl.TabIndex = 3;
            this.descLbl.Text = "Description :";
            // 
            // CurrentDescLabel
            // 
            this.CurrentDescLabel.AutoSize = true;
            this.CurrentDescLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentDescLabel.Location = new System.Drawing.Point(98, 154);
            this.CurrentDescLabel.Name = "CurrentDescLabel";
            this.CurrentDescLabel.Size = new System.Drawing.Size(0, 15);
            this.CurrentDescLabel.TabIndex = 2;
            // 
            // Nomlbl
            // 
            this.Nomlbl.AutoSize = true;
            this.Nomlbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nomlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Nomlbl.Location = new System.Drawing.Point(70, 74);
            this.Nomlbl.Name = "Nomlbl";
            this.Nomlbl.Size = new System.Drawing.Size(40, 17);
            this.Nomlbl.TabIndex = 1;
            this.Nomlbl.Text = "Plat :";
            // 
            // CurrentMetLbl
            // 
            this.CurrentMetLbl.AutoSize = true;
            this.CurrentMetLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CurrentMetLbl.Location = new System.Drawing.Point(98, 99);
            this.CurrentMetLbl.Name = "CurrentMetLbl";
            this.CurrentMetLbl.Size = new System.Drawing.Size(0, 15);
            this.CurrentMetLbl.TabIndex = 0;
            // 
            // refreshDeleteTLP
            // 
            this.refreshDeleteTLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshDeleteTLP.ColumnCount = 2;
            this.refreshDeleteTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.refreshDeleteTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.refreshDeleteTLP.Controls.Add(this.RefreshMetBtn, 1, 0);
            this.refreshDeleteTLP.Controls.Add(this.DeleteMetBtn, 0, 0);
            this.refreshDeleteTLP.Location = new System.Drawing.Point(302, 411);
            this.refreshDeleteTLP.Margin = new System.Windows.Forms.Padding(0);
            this.refreshDeleteTLP.Name = "refreshDeleteTLP";
            this.refreshDeleteTLP.RowCount = 1;
            this.refreshDeleteTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.refreshDeleteTLP.Size = new System.Drawing.Size(230, 39);
            this.refreshDeleteTLP.TabIndex = 8;
            // 
            // RefreshMetBtn
            // 
            this.RefreshMetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.RefreshMetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshMetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshMetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshMetBtn.Location = new System.Drawing.Point(115, 0);
            this.RefreshMetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshMetBtn.Name = "RefreshMetBtn";
            this.RefreshMetBtn.Size = new System.Drawing.Size(115, 39);
            this.RefreshMetBtn.TabIndex = 7;
            this.RefreshMetBtn.Text = "Rafraichir";
            this.RefreshMetBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteMetBtn
            // 
            this.DeleteMetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteMetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteMetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteMetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteMetBtn.Location = new System.Drawing.Point(0, 0);
            this.DeleteMetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteMetBtn.Name = "DeleteMetBtn";
            this.DeleteMetBtn.Size = new System.Drawing.Size(115, 39);
            this.DeleteMetBtn.TabIndex = 6;
            this.DeleteMetBtn.Text = "Supprimer";
            this.DeleteMetBtn.UseVisualStyleBackColor = false;
            this.DeleteMetBtn.Click += new System.EventHandler(this.DeleteMetBtn_Click);
            // 
            // ListMetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListMetForm";
            this.Text = "ListMetForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metDtGv)).EndInit();
            this.metPicturePnl.ResumeLayout(false);
            this.DescRepasPnl.ResumeLayout(false);
            this.DescRepasPnl.PerformLayout();
            this.refreshDeleteTLP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddMetBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button PreviousMetBtn;
        private System.Windows.Forms.Button NextMetBtn;
        private System.Windows.Forms.Label CurentPageMetLbl;
        private System.Windows.Forms.DataGridView metDtGv;
        private System.Windows.Forms.Panel metPicturePnl;
        private System.Windows.Forms.Panel DescRepasPnl;
        private System.Windows.Forms.Label CurrentMetLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label CurrentDescLabel;
        private System.Windows.Forms.Label Nomlbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentIngredientsLbl;
        private System.Windows.Forms.TableLayoutPanel refreshDeleteTLP;
        private System.Windows.Forms.Button RefreshMetBtn;
        private System.Windows.Forms.Button DeleteMetBtn;
    }
}