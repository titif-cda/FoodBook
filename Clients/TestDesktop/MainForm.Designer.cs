
namespace DesktopClient
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.reloadBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ingredientsDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // reloadBtn
            // 
            this.reloadBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reloadBtn.Location = new System.Drawing.Point(676, 0);
            this.reloadBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(124, 32);
            this.reloadBtn.TabIndex = 0;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.previousBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.nextBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.currentPageLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(676, 410);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(124, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // previousBtn
            // 
            this.previousBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previousBtn.Location = new System.Drawing.Point(0, 0);
            this.previousBtn.Margin = new System.Windows.Forms.Padding(0);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(41, 40);
            this.previousBtn.TabIndex = 0;
            this.previousBtn.Text = "<";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextBtn.Location = new System.Drawing.Point(82, 0);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(0);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(42, 40);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Location = new System.Drawing.Point(55, 12);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(13, 15);
            this.currentPageLabel.TabIndex = 3;
            this.currentPageLabel.Text = "1";
            this.currentPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.AllowUserToAddRows = false;
            this.ingredientsDataGridView.AllowUserToDeleteRows = false;
            this.ingredientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.ingredientsDataGridView, 2);
            this.ingredientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsDataGridView.Location = new System.Drawing.Point(0, 32);
            this.ingredientsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.ReadOnly = true;
            this.ingredientsDataGridView.RowTemplate.Height = 25;
            this.ingredientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingredientsDataGridView.Size = new System.Drawing.Size(800, 378);
            this.ingredientsDataGridView.TabIndex = 2;
            this.ingredientsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingredientsDataGridView_CellDoubleClick);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(3, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label currentPageLabel;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private System.Windows.Forms.Button AddBtn;
    }
}

