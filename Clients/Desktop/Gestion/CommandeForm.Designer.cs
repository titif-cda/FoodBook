﻿
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Totalpnl = new System.Windows.Forms.Panel();
            this.montantTotalLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.CommandeTlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Totalpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandeTlp
            // 
            this.CommandeTlp.ColumnCount = 2;
            this.CommandeTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CommandeTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CommandeTlp.Controls.Add(this.dataGridView1, 0, 0);
            this.CommandeTlp.Controls.Add(this.Totalpnl, 0, 1);
            this.CommandeTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandeTlp.Location = new System.Drawing.Point(0, 0);
            this.CommandeTlp.Name = "CommandeTlp";
            this.CommandeTlp.RowCount = 2;
            this.CommandeTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.22222F));
            this.CommandeTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.777778F));
            this.CommandeTlp.Size = new System.Drawing.Size(800, 450);
            this.CommandeTlp.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(394, 400);
            this.dataGridView1.TabIndex = 0;
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
            // CommandeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommandeTlp);
            this.Name = "CommandeForm";
            this.Text = "ReservationForm";
            this.CommandeTlp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Totalpnl.ResumeLayout(false);
            this.Totalpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CommandeTlp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel Totalpnl;
        private System.Windows.Forms.Label montantTotalLbl;
        private System.Windows.Forms.Label totalLbl;
    }
}