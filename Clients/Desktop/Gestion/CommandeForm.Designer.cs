
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
            this.validDateBtn = new System.Windows.Forms.Button();
            this.Totalpnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dFin = new System.Windows.Forms.Label();
            this.dDebutLbl = new System.Windows.Forms.Label();
            this.recapDateslbl = new System.Windows.Forms.Label();
            this.montantTotalLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.aCommanderDTGV = new System.Windows.Forms.DataGridView();
            this.titleCdePnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DateSelectDTP = new System.Windows.Forms.DateTimePicker();
            this.CommandeTlp.SuspendLayout();
            this.Totalpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCommanderDTGV)).BeginInit();
            this.titleCdePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandeTlp
            // 
            this.CommandeTlp.ColumnCount = 2;
            this.CommandeTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CommandeTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CommandeTlp.Controls.Add(this.validDateBtn, 0, 1);
            this.CommandeTlp.Controls.Add(this.Totalpnl, 1, 1);
            this.CommandeTlp.Controls.Add(this.aCommanderDTGV, 1, 0);
            this.CommandeTlp.Controls.Add(this.titleCdePnl, 0, 0);
            this.CommandeTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandeTlp.Location = new System.Drawing.Point(0, 0);
            this.CommandeTlp.Name = "CommandeTlp";
            this.CommandeTlp.RowCount = 2;
            this.CommandeTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.66666F));
            this.CommandeTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33333F));
            this.CommandeTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CommandeTlp.Size = new System.Drawing.Size(800, 450);
            this.CommandeTlp.TabIndex = 0;
            // 
            // validDateBtn
            // 
            this.validDateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validDateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.validDateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.validDateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.validDateBtn.Location = new System.Drawing.Point(0, 372);
            this.validDateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.validDateBtn.Name = "validDateBtn";
            this.validDateBtn.Size = new System.Drawing.Size(400, 78);
            this.validDateBtn.TabIndex = 13;
            this.validDateBtn.Text = "Valider";
            this.validDateBtn.UseVisualStyleBackColor = false;
            this.validDateBtn.Click += new System.EventHandler(this.validDateBtn_Click);
            // 
            // Totalpnl
            // 
            this.Totalpnl.Controls.Add(this.label4);
            this.Totalpnl.Controls.Add(this.dFin);
            this.Totalpnl.Controls.Add(this.dDebutLbl);
            this.Totalpnl.Controls.Add(this.recapDateslbl);
            this.Totalpnl.Controls.Add(this.montantTotalLbl);
            this.Totalpnl.Controls.Add(this.totalLbl);
            this.Totalpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Totalpnl.Location = new System.Drawing.Point(403, 375);
            this.Totalpnl.Name = "Totalpnl";
            this.Totalpnl.Size = new System.Drawing.Size(394, 72);
            this.Totalpnl.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(285, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "au";
            // 
            // dFin
            // 
            this.dFin.AutoSize = true;
            this.dFin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dFin.Location = new System.Drawing.Point(306, 4);
            this.dFin.Name = "dFin";
            this.dFin.Size = new System.Drawing.Size(79, 19);
            this.dFin.TabIndex = 4;
            this.dFin.Text = "01/01/2021";
            // 
            // dDebutLbl
            // 
            this.dDebutLbl.AutoSize = true;
            this.dDebutLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dDebutLbl.Location = new System.Drawing.Point(213, 4);
            this.dDebutLbl.Name = "dDebutLbl";
            this.dDebutLbl.Size = new System.Drawing.Size(79, 19);
            this.dDebutLbl.TabIndex = 3;
            this.dDebutLbl.Text = "01/01/2021";
            // 
            // recapDateslbl
            // 
            this.recapDateslbl.AutoSize = true;
            this.recapDateslbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recapDateslbl.Location = new System.Drawing.Point(4, 4);
            this.recapDateslbl.Name = "recapDateslbl";
            this.recapDateslbl.Size = new System.Drawing.Size(210, 19);
            this.recapDateslbl.TabIndex = 2;
            this.recapDateslbl.Text = "Commande pour la semaine du :";
            // 
            // montantTotalLbl
            // 
            this.montantTotalLbl.AutoSize = true;
            this.montantTotalLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.montantTotalLbl.Location = new System.Drawing.Point(319, 36);
            this.montantTotalLbl.Name = "montantTotalLbl";
            this.montantTotalLbl.Size = new System.Drawing.Size(72, 30);
            this.montantTotalLbl.TabIndex = 1;
            this.montantTotalLbl.Text = "label1";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLbl.Location = new System.Drawing.Point(127, 36);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(165, 30);
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
            this.aCommanderDTGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aCommanderDTGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.aCommanderDTGV.Location = new System.Drawing.Point(403, 3);
            this.aCommanderDTGV.Name = "aCommanderDTGV";
            this.aCommanderDTGV.RowHeadersVisible = false;
            this.aCommanderDTGV.RowTemplate.Height = 25;
            this.aCommanderDTGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aCommanderDTGV.Size = new System.Drawing.Size(394, 366);
            this.aCommanderDTGV.TabIndex = 0;
            // 
            // titleCdePnl
            // 
            this.titleCdePnl.Controls.Add(this.label1);
            this.titleCdePnl.Controls.Add(this.DateSelectDTP);
            this.titleCdePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleCdePnl.Location = new System.Drawing.Point(3, 3);
            this.titleCdePnl.Name = "titleCdePnl";
            this.titleCdePnl.Size = new System.Drawing.Size(394, 366);
            this.titleCdePnl.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectionner une date puis valider";
            // 
            // DateSelectDTP
            // 
            this.DateSelectDTP.Location = new System.Drawing.Point(117, 129);
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
            this.titleCdePnl.ResumeLayout(false);
            this.titleCdePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CommandeTlp;
        private System.Windows.Forms.DataGridView aCommanderDTGV;
        private System.Windows.Forms.Panel Totalpnl;
        private System.Windows.Forms.Label montantTotalLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Panel titleCdePnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button validDateBtn;
        private System.Windows.Forms.DateTimePicker DateSelectDTP;
        private System.Windows.Forms.Label recapDateslbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dFin;
        private System.Windows.Forms.Label dDebutLbl;
    }
}