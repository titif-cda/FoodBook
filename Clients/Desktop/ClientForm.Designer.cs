
namespace Desktop
{
    partial class ClientForm
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
            this.FormClientTlp = new System.Windows.Forms.TableLayoutPanel();
            this.ClientdataGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.currentPageLabel = new System.Windows.Forms.Label();
            this.FormClientTlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormClientTlp
            // 
            this.FormClientTlp.ColumnCount = 2;
            this.FormClientTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.76815F));
            this.FormClientTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.23185F));
            this.FormClientTlp.Controls.Add(this.ClientdataGridView, 0, 1);
            this.FormClientTlp.Controls.Add(this.addBtn, 0, 0);
            this.FormClientTlp.Controls.Add(this.RefreshBtn, 1, 0);
            this.FormClientTlp.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.FormClientTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormClientTlp.Location = new System.Drawing.Point(0, 0);
            this.FormClientTlp.Name = "FormClientTlp";
            this.FormClientTlp.RowCount = 3;
            this.FormClientTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.24468F));
            this.FormClientTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.75532F));
            this.FormClientTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.FormClientTlp.Size = new System.Drawing.Size(854, 411);
            this.FormClientTlp.TabIndex = 0;
            // 
            // ClientdataGridView
            // 
            this.ClientdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormClientTlp.SetColumnSpan(this.ClientdataGridView, 2);
            this.ClientdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientdataGridView.Location = new System.Drawing.Point(3, 34);
            this.ClientdataGridView.Name = "ClientdataGridView";
            this.ClientdataGridView.RowTemplate.Height = 25;
            this.ClientdataGridView.Size = new System.Drawing.Size(848, 339);
            this.ClientdataGridView.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Ajouter";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshBtn.Location = new System.Drawing.Point(744, 3);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(107, 25);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.Text = "Rafraichir";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(3, 3);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(24, 23);
            this.previousBtn.TabIndex = 3;
            this.previousBtn.Text = "<";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.16901F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.02817F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.previousBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentPageLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(744, 379);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(107, 29);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(73, 3);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(31, 23);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // currentPageLabel
            // 
            this.currentPageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentPageLabel.AutoSize = true;
            this.currentPageLabel.Location = new System.Drawing.Point(43, 7);
            this.currentPageLabel.Name = "currentPageLabel";
            this.currentPageLabel.Size = new System.Drawing.Size(13, 15);
            this.currentPageLabel.TabIndex = 6;
            this.currentPageLabel.Text = "1";
            this.currentPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.FormClientTlp);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClientTlp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientdataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FormClientTlp;
        private System.Windows.Forms.DataGridView ClientdataGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label currentPageLabel;
    }
}