
namespace Desktop.Ingredients
{
    partial class ListIngredientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListIngredientsForm));
            this.IngredientPicturePnl = new System.Windows.Forms.Panel();
            this.RefreshIngredientBtn = new System.Windows.Forms.Button();
            this.AddIngredientBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviousIngredientBtn = new System.Windows.Forms.Button();
            this.NextIngredientBtn = new System.Windows.Forms.Button();
            this.CurentPageIngredientLbl = new System.Windows.Forms.Label();
            this.listIngredientPnl = new System.Windows.Forms.Panel();
            this.IngredientDtGv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.listIngredientPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientDtGv)).BeginInit();
            this.SuspendLayout();
            // 
            // IngredientPicturePnl
            // 
            this.IngredientPicturePnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IngredientPicturePnl.BackgroundImage")));
            this.IngredientPicturePnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.IngredientPicturePnl, 2);
            this.IngredientPicturePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IngredientPicturePnl.Location = new System.Drawing.Point(305, 3);
            this.IngredientPicturePnl.Name = "IngredientPicturePnl";
            this.IngredientPicturePnl.Size = new System.Drawing.Size(492, 405);
            this.IngredientPicturePnl.TabIndex = 5;
            // 
            // RefreshIngredientBtn
            // 
            this.RefreshIngredientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.RefreshIngredientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshIngredientBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RefreshIngredientBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.RefreshIngredientBtn.Location = new System.Drawing.Point(302, 411);
            this.RefreshIngredientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshIngredientBtn.Name = "RefreshIngredientBtn";
            this.RefreshIngredientBtn.Size = new System.Drawing.Size(230, 39);
            this.RefreshIngredientBtn.TabIndex = 2;
            this.RefreshIngredientBtn.Text = "Rafraichir";
            this.RefreshIngredientBtn.UseVisualStyleBackColor = false;
            this.RefreshIngredientBtn.Click += new System.EventHandler(this.RefreshIngredientBtn_Click);
            // 
            // AddIngredientBtn
            // 
            this.AddIngredientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.AddIngredientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddIngredientBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddIngredientBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddIngredientBtn.Location = new System.Drawing.Point(0, 411);
            this.AddIngredientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddIngredientBtn.Name = "AddIngredientBtn";
            this.AddIngredientBtn.Size = new System.Drawing.Size(302, 39);
            this.AddIngredientBtn.TabIndex = 1;
            this.AddIngredientBtn.Text = "Ajouter";
            this.AddIngredientBtn.UseVisualStyleBackColor = false;
            this.AddIngredientBtn.Click += new System.EventHandler(this.AddIngredientBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.AddIngredientBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RefreshIngredientBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.IngredientPicturePnl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listIngredientPnl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.48936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510639F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.PreviousIngredientBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NextIngredientBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.CurentPageIngredientLbl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(535, 414);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 33);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // PreviousIngredientBtn
            // 
            this.PreviousIngredientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviousIngredientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousIngredientBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PreviousIngredientBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PreviousIngredientBtn.Location = new System.Drawing.Point(3, 3);
            this.PreviousIngredientBtn.Name = "PreviousIngredientBtn";
            this.PreviousIngredientBtn.Size = new System.Drawing.Size(81, 27);
            this.PreviousIngredientBtn.TabIndex = 0;
            this.PreviousIngredientBtn.Text = "<";
            this.PreviousIngredientBtn.UseVisualStyleBackColor = true;
            this.PreviousIngredientBtn.Click += new System.EventHandler(this.PreviousIngredientBtn_Click);
            // 
            // NextIngredientBtn
            // 
            this.NextIngredientBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextIngredientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextIngredientBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NextIngredientBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.NextIngredientBtn.Location = new System.Drawing.Point(177, 3);
            this.NextIngredientBtn.Name = "NextIngredientBtn";
            this.NextIngredientBtn.Size = new System.Drawing.Size(82, 27);
            this.NextIngredientBtn.TabIndex = 1;
            this.NextIngredientBtn.Text = ">";
            this.NextIngredientBtn.UseVisualStyleBackColor = true;
            this.NextIngredientBtn.Click += new System.EventHandler(this.NextIngredientBtn_Click);
            // 
            // CurentPageIngredientLbl
            // 
            this.CurentPageIngredientLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurentPageIngredientLbl.AutoSize = true;
            this.CurentPageIngredientLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.CurentPageIngredientLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurentPageIngredientLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CurentPageIngredientLbl.Location = new System.Drawing.Point(123, 9);
            this.CurentPageIngredientLbl.Margin = new System.Windows.Forms.Padding(0);
            this.CurentPageIngredientLbl.Name = "CurentPageIngredientLbl";
            this.CurentPageIngredientLbl.Size = new System.Drawing.Size(14, 15);
            this.CurentPageIngredientLbl.TabIndex = 2;
            this.CurentPageIngredientLbl.Text = "1";
            // 
            // listIngredientPnl
            // 
            this.listIngredientPnl.Controls.Add(this.IngredientDtGv);
            this.listIngredientPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listIngredientPnl.Location = new System.Drawing.Point(3, 3);
            this.listIngredientPnl.Name = "listIngredientPnl";
            this.listIngredientPnl.Size = new System.Drawing.Size(296, 405);
            this.listIngredientPnl.TabIndex = 6;
            // 
            // IngredientDtGv
            // 
            this.IngredientDtGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IngredientDtGv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.IngredientDtGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IngredientDtGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientDtGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IngredientDtGv.GridColor = System.Drawing.SystemColors.Control;
            this.IngredientDtGv.Location = new System.Drawing.Point(0, 0);
            this.IngredientDtGv.Name = "IngredientDtGv";
            this.IngredientDtGv.RowHeadersVisible = false;
            this.IngredientDtGv.RowTemplate.Height = 25;
            this.IngredientDtGv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IngredientDtGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IngredientDtGv.Size = new System.Drawing.Size(296, 405);
            this.IngredientDtGv.TabIndex = 5;
            // 
            // ListIngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ListIngredientsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.listIngredientPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IngredientDtGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel IngredientPicturePnl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddIngredientBtn;
        private System.Windows.Forms.Button RefreshIngredientBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button PreviousIngredientBtn;
        private System.Windows.Forms.Button NextIngredientBtn;
        private System.Windows.Forms.Label CurentPageIngredientLbl;
        private System.Windows.Forms.Panel listIngredientPnl;
        private System.Windows.Forms.TextBox searchTbox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.DataGridView IngredientDtGv;
    }
}