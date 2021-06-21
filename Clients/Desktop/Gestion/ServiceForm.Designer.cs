
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
            this.serviceTlp = new System.Windows.Forms.TableLayoutPanel();
            this.addDeleteServiceTlp = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteServiceBtn = new System.Windows.Forms.Button();
            this.AddServiceBtn = new System.Windows.Forms.Button();
            this.btnTlp = new System.Windows.Forms.TableLayoutPanel();
            this.previousServiceBtn = new System.Windows.Forms.Button();
            this.RefreshServiceBtn = new System.Windows.Forms.Button();
            this.nextServiceBtn = new System.Windows.Forms.Button();
            this.CurrentPageServiceLbl = new System.Windows.Forms.Label();
            this.PreviousMetBtn = new System.Windows.Forms.Button();
            this.serviceDtGv = new System.Windows.Forms.DataGridView();
            this.serviceTlp.SuspendLayout();
            this.addDeleteServiceTlp.SuspendLayout();
            this.btnTlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDtGv)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceTlp
            // 
            this.serviceTlp.ColumnCount = 2;
            this.serviceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serviceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serviceTlp.Controls.Add(this.addDeleteServiceTlp, 0, 1);
            this.serviceTlp.Controls.Add(this.btnTlp, 1, 1);
            this.serviceTlp.Controls.Add(this.PreviousMetBtn, 1, 0);
            this.serviceTlp.Controls.Add(this.serviceDtGv, 0, 0);
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
            this.addDeleteServiceTlp.ColumnCount = 2;
            this.addDeleteServiceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.addDeleteServiceTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.addDeleteServiceTlp.Controls.Add(this.DeleteServiceBtn, 0, 0);
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
            // DeleteServiceBtn
            // 
            this.DeleteServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteServiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteServiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteServiceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteServiceBtn.Location = new System.Drawing.Point(235, 0);
            this.DeleteServiceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteServiceBtn.Name = "DeleteServiceBtn";
            this.DeleteServiceBtn.Size = new System.Drawing.Size(157, 35);
            this.DeleteServiceBtn.TabIndex = 7;
            this.DeleteServiceBtn.Text = "Supprimer";
            this.DeleteServiceBtn.UseVisualStyleBackColor = false;
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
            this.AddServiceBtn.Size = new System.Drawing.Size(235, 35);
            this.AddServiceBtn.TabIndex = 2;
            this.AddServiceBtn.Text = "Ajouter";
            this.AddServiceBtn.UseVisualStyleBackColor = false;
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
            // PreviousMetBtn
            // 
            this.PreviousMetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviousMetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousMetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PreviousMetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PreviousMetBtn.Location = new System.Drawing.Point(395, 3);
            this.PreviousMetBtn.Name = "PreviousMetBtn";
            this.PreviousMetBtn.Size = new System.Drawing.Size(386, 303);
            this.PreviousMetBtn.TabIndex = 2;
            this.PreviousMetBtn.Text = "<";
            this.PreviousMetBtn.UseVisualStyleBackColor = true;
            // 
            // serviceDtGv
            // 
            this.serviceDtGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceDtGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDtGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceDtGv.Location = new System.Drawing.Point(0, 0);
            this.serviceDtGv.Margin = new System.Windows.Forms.Padding(0);
            this.serviceDtGv.Name = "serviceDtGv";
            this.serviceDtGv.ReadOnly = true;
            this.serviceDtGv.RowTemplate.Height = 25;
            this.serviceDtGv.Size = new System.Drawing.Size(392, 309);
            this.serviceDtGv.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel serviceTlp;
        private System.Windows.Forms.TableLayoutPanel addDeleteServiceTlp;
        private System.Windows.Forms.Button DeleteServiceBtn;
        private System.Windows.Forms.Button AddServiceBtn;
        private System.Windows.Forms.TableLayoutPanel btnTlp;
        private System.Windows.Forms.Button RefreshServiceBtn;
        private System.Windows.Forms.Label CurrentPageServiceLbl;
        private System.Windows.Forms.Button PreviousMetBtn;
        private System.Windows.Forms.DataGridView serviceDtGv;
        private System.Windows.Forms.Button previousServiceBtn;
        private System.Windows.Forms.Button nextServiceBtn;
    }
}