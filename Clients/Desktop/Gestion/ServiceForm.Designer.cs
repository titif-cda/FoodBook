
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
            this.serviceTlp = new System.Windows.Forms.TableLayoutPanel();
            this.addDeleteServiceTlp = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteServiceBtn = new System.Windows.Forms.Button();
            this.AddServiceBtn = new System.Windows.Forms.Button();
            this.btnTlp = new System.Windows.Forms.TableLayoutPanel();
            this.previousServiceBtn = new System.Windows.Forms.Button();
            this.RefreshServiceBtn = new System.Windows.Forms.Button();
            this.nextServiceBtn = new System.Windows.Forms.Button();
            this.CurrentPageServiceLbl = new System.Windows.Forms.Label();
            this.serviceDtGv = new System.Windows.Forms.DataGridView();
            this.detailServicePnl = new System.Windows.Forms.Panel();
            this.serviceDTPicker = new System.Windows.Forms.DateTimePicker();
            this.isMidiCkBox = new System.Windows.Forms.CheckBox();
            this.metsListBox = new System.Windows.Forms.ComboBox();
            this.isMidiLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // serviceDtGv
            // 
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
            // 
            // detailServicePnl
            // 
            this.detailServicePnl.Controls.Add(this.label2);
            this.detailServicePnl.Controls.Add(this.label1);
            this.detailServicePnl.Controls.Add(this.isMidiLbl);
            this.detailServicePnl.Controls.Add(this.metsListBox);
            this.detailServicePnl.Controls.Add(this.isMidiCkBox);
            this.detailServicePnl.Controls.Add(this.serviceDTPicker);
            this.detailServicePnl.Location = new System.Drawing.Point(395, 3);
            this.detailServicePnl.Name = "detailServicePnl";
            this.detailServicePnl.Size = new System.Drawing.Size(386, 303);
            this.detailServicePnl.TabIndex = 2;
            // 
            // serviceDTPicker
            // 
            this.serviceDTPicker.Location = new System.Drawing.Point(136, 89);
            this.serviceDTPicker.Name = "serviceDTPicker";
            this.serviceDTPicker.Size = new System.Drawing.Size(200, 23);
            this.serviceDTPicker.TabIndex = 0;
            // 
            // isMidiCkBox
            // 
            this.isMidiCkBox.AutoSize = true;
            this.isMidiCkBox.Location = new System.Drawing.Point(136, 50);
            this.isMidiCkBox.Name = "isMidiCkBox";
            this.isMidiCkBox.Size = new System.Drawing.Size(15, 14);
            this.isMidiCkBox.TabIndex = 1;
            this.isMidiCkBox.UseVisualStyleBackColor = true;
            // 
            // metsListBox
            // 
            this.metsListBox.FormattingEnabled = true;
            this.metsListBox.Location = new System.Drawing.Point(136, 147);
            this.metsListBox.Name = "metsListBox";
            this.metsListBox.Size = new System.Drawing.Size(121, 23);
            this.metsListBox.TabIndex = 2;
            // 
            // isMidiLbl
            // 
            this.isMidiLbl.AutoSize = true;
            this.isMidiLbl.Location = new System.Drawing.Point(18, 49);
            this.isMidiLbl.Name = "isMidiLbl";
            this.isMidiLbl.Size = new System.Drawing.Size(94, 15);
            this.isMidiLbl.TabIndex = 3;
            this.isMidiLbl.Text = "Service du midi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plats :";
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
        private System.Windows.Forms.Button DeleteServiceBtn;
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
        private System.Windows.Forms.ComboBox metsListBox;
        private System.Windows.Forms.CheckBox isMidiCkBox;
        private System.Windows.Forms.DateTimePicker serviceDTPicker;
    }
}