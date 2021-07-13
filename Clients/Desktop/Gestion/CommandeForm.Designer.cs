
namespace Desktop.Gestion
{
    partial class CommandeForm
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
            this.CommandeTlp = new System.Windows.Forms.TableLayoutPanel();
            this.Totalpnl = new System.Windows.Forms.Panel();
            this.montantTotalLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.aCommanderDTGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateSelectDTP = new System.Windows.Forms.DateTimePicker();
            this.CommandeTlp.SuspendLayout();
            this.Totalpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCommanderDTGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandeTlp
            // 
            this.CommandeTlp.ColumnCount = 2;
            this.CommandeTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CommandeTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CommandeTlp.Controls.Add(this.Totalpnl, 0, 1);
            this.CommandeTlp.Controls.Add(this.aCommanderDTGV, 1, 0);
            this.CommandeTlp.Controls.Add(this.panel1, 0, 0);
            this.CommandeTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandeTlp.Location = new System.Drawing.Point(0, 0);
            this.CommandeTlp.Name = "CommandeTlp";
            this.CommandeTlp.RowCount = 2;
            this.CommandeTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22222F));
            this.CommandeTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.777778F));
            this.CommandeTlp.Size = new System.Drawing.Size(800, 450);
            this.CommandeTlp.TabIndex = 0;
            // 
            // Totalpnl
            // 
            this.Totalpnl.Controls.Add(this.montantTotalLbl);
            this.Totalpnl.Controls.Add(this.totalLbl);
            this.Totalpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Totalpnl.Location = new System.Drawing.Point(3, 409);
            this.Totalpnl.Name = "Totalpnl";
            this.Totalpnl.Size = new System.Drawing.Size(394, 38);
            this.Totalpnl.TabIndex = 1;
            // 
            // montantTotalLbl
            // 
            this.montantTotalLbl.AutoSize = true;
            this.montantTotalLbl.Location = new System.Drawing.Point(314, 16);
            this.montantTotalLbl.Name = "montantTotalLbl";
            this.montantTotalLbl.Size = new System.Drawing.Size(38, 15);
            this.montantTotalLbl.TabIndex = 1;
            this.montantTotalLbl.Text = "label1";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(211, 17);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(87, 15);
            this.totalLbl.TabIndex = 0;
            this.totalLbl.Text = "Montant Total :";
            // 
            // aCommanderDTGV
            // 
            this.aCommanderDTGV.AllowUserToAddRows = false;
            this.aCommanderDTGV.AllowUserToDeleteRows = false;
            this.aCommanderDTGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aCommanderDTGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.aCommanderDTGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.aCommanderDTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aCommanderDTGV.ColumnHeadersVisible = false;
            this.aCommanderDTGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aCommanderDTGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.aCommanderDTGV.Location = new System.Drawing.Point(403, 3);
            this.aCommanderDTGV.Name = "aCommanderDTGV";
            this.aCommanderDTGV.RowHeadersVisible = false;
            this.aCommanderDTGV.RowTemplate.Height = 25;
            this.aCommanderDTGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aCommanderDTGV.Size = new System.Drawing.Size(394, 400);
            this.aCommanderDTGV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DateSelectDTP);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 384);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "DateFin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "DatreDebut";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DateSelectDTP
            // 
            this.DateSelectDTP.Location = new System.Drawing.Point(139, 6);
            this.DateSelectDTP.Name = "DateSelectDTP";
            this.DateSelectDTP.Size = new System.Drawing.Size(200, 23);
            this.DateSelectDTP.TabIndex = 3;
            this.DateSelectDTP.ValueChanged += new System.EventHandler(this.DateSelectDTP_ValueChanged);
            // 
            // CommandeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommandeTlp);
            this.Name = "CommandeForm";
            this.Text = "ReservationForm";
            this.CommandeTlp.ResumeLayout(false);
            this.Totalpnl.ResumeLayout(false);
            this.Totalpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCommanderDTGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CommandeTlp;
        private System.Windows.Forms.DataGridView aCommanderDTGV;
        private System.Windows.Forms.Panel Totalpnl;
        private System.Windows.Forms.Label montantTotalLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.DateTimePicker DateSelectDTP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}