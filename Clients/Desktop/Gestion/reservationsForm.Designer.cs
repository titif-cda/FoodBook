
namespace Desktop.Gestion
{
    partial class reservationsForm
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
            this.nomLbl = new System.Windows.Forms.Label();
            this.resaNomLbl = new System.Windows.Forms.Label();
            this.nbLbl = new System.Windows.Forms.Label();
            this.serviceResaLbl = new System.Windows.Forms.Label();
            this.reservationDtGv = new System.Windows.Forms.DataGridView();
            this.resaNbLbl = new System.Windows.Forms.Label();
            this.detailReservationPnl = new System.Windows.Forms.Panel();
            this.servicelbl = new System.Windows.Forms.Label();
            this.dateServiceLbl = new System.Windows.Forms.Label();
            this.dateResa = new System.Windows.Forms.Label();
            this.resaPrenomLbl = new System.Windows.Forms.Label();
            this.prenomLbl = new System.Windows.Forms.Label();
            this.titreReservationLbl = new System.Windows.Forms.Label();
            this.serviceDetailTlp = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDtGv)).BeginInit();
            this.detailReservationPnl.SuspendLayout();
            this.serviceDetailTlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomLbl
            // 
            this.nomLbl.AutoSize = true;
            this.nomLbl.BackColor = System.Drawing.Color.Transparent;
            this.nomLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nomLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nomLbl.Location = new System.Drawing.Point(126, 194);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(51, 20);
            this.nomLbl.TabIndex = 3;
            this.nomLbl.Text = "Nom :";
            // 
            // resaNomLbl
            // 
            this.resaNomLbl.AutoSize = true;
            this.resaNomLbl.BackColor = System.Drawing.Color.Transparent;
            this.resaNomLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resaNomLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.resaNomLbl.Location = new System.Drawing.Point(201, 199);
            this.resaNomLbl.Name = "resaNomLbl";
            this.resaNomLbl.Size = new System.Drawing.Size(32, 15);
            this.resaNomLbl.TabIndex = 6;
            this.resaNomLbl.Text = "nom";
            // 
            // nbLbl
            // 
            this.nbLbl.AutoSize = true;
            this.nbLbl.BackColor = System.Drawing.Color.Transparent;
            this.nbLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nbLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nbLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.nbLbl.Location = new System.Drawing.Point(46, 265);
            this.nbLbl.Name = "nbLbl";
            this.nbLbl.Size = new System.Drawing.Size(131, 20);
            this.nbLbl.TabIndex = 5;
            this.nbLbl.Text = "Nombre de plats :";
            // 
            // serviceResaLbl
            // 
            this.serviceResaLbl.AutoSize = true;
            this.serviceResaLbl.BackColor = System.Drawing.Color.Transparent;
            this.serviceResaLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceResaLbl.Location = new System.Drawing.Point(201, 136);
            this.serviceResaLbl.Name = "serviceResaLbl";
            this.serviceResaLbl.Size = new System.Drawing.Size(43, 15);
            this.serviceResaLbl.TabIndex = 7;
            this.serviceResaLbl.Text = "service";
            // 
            // reservationDtGv
            // 
            this.reservationDtGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationDtGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reservationDtGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationDtGv.DefaultCellStyle = dataGridViewCellStyle2;
            this.reservationDtGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationDtGv.Location = new System.Drawing.Point(0, 0);
            this.reservationDtGv.Margin = new System.Windows.Forms.Padding(0);
            this.reservationDtGv.Name = "reservationDtGv";
            this.reservationDtGv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationDtGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.reservationDtGv.RowHeadersVisible = false;
            this.reservationDtGv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.reservationDtGv.RowTemplate.Height = 25;
            this.reservationDtGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationDtGv.Size = new System.Drawing.Size(392, 344);
            this.reservationDtGv.TabIndex = 1;
            this.reservationDtGv.SelectionChanged += new System.EventHandler(this.reservationDtGv_SelectionChanged);
            // 
            // resaNbLbl
            // 
            this.resaNbLbl.AutoSize = true;
            this.resaNbLbl.BackColor = System.Drawing.Color.Transparent;
            this.resaNbLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resaNbLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.resaNbLbl.Location = new System.Drawing.Point(201, 270);
            this.resaNbLbl.Name = "resaNbLbl";
            this.resaNbLbl.Size = new System.Drawing.Size(21, 15);
            this.resaNbLbl.TabIndex = 12;
            this.resaNbLbl.Text = "nb";
            // 
            // detailReservationPnl
            // 
            this.detailReservationPnl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.detailReservationPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.detailReservationPnl.Controls.Add(this.servicelbl);
            this.detailReservationPnl.Controls.Add(this.dateServiceLbl);
            this.detailReservationPnl.Controls.Add(this.dateResa);
            this.detailReservationPnl.Controls.Add(this.resaPrenomLbl);
            this.detailReservationPnl.Controls.Add(this.prenomLbl);
            this.detailReservationPnl.Controls.Add(this.titreReservationLbl);
            this.detailReservationPnl.Controls.Add(this.resaNbLbl);
            this.detailReservationPnl.Controls.Add(this.serviceResaLbl);
            this.detailReservationPnl.Controls.Add(this.resaNomLbl);
            this.detailReservationPnl.Controls.Add(this.nbLbl);
            this.detailReservationPnl.Controls.Add(this.nomLbl);
            this.detailReservationPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailReservationPnl.ForeColor = System.Drawing.SystemColors.Control;
            this.detailReservationPnl.Location = new System.Drawing.Point(395, 3);
            this.detailReservationPnl.Name = "detailReservationPnl";
            this.detailReservationPnl.Size = new System.Drawing.Size(386, 338);
            this.detailReservationPnl.TabIndex = 2;
            // 
            // servicelbl
            // 
            this.servicelbl.AutoSize = true;
            this.servicelbl.BackColor = System.Drawing.Color.Transparent;
            this.servicelbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.servicelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.servicelbl.Location = new System.Drawing.Point(110, 131);
            this.servicelbl.Name = "servicelbl";
            this.servicelbl.Size = new System.Drawing.Size(67, 20);
            this.servicelbl.TabIndex = 19;
            this.servicelbl.Text = "Service :";
            // 
            // dateServiceLbl
            // 
            this.dateServiceLbl.AutoSize = true;
            this.dateServiceLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateServiceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateServiceLbl.Location = new System.Drawing.Point(201, 166);
            this.dateServiceLbl.Name = "dateServiceLbl";
            this.dateServiceLbl.Size = new System.Drawing.Size(86, 15);
            this.dateServiceLbl.TabIndex = 18;
            this.dateServiceLbl.Text = "date du service";
            // 
            // dateResa
            // 
            this.dateResa.AutoSize = true;
            this.dateResa.BackColor = System.Drawing.Color.Transparent;
            this.dateResa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateResa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateResa.ForeColor = System.Drawing.SystemColors.Control;
            this.dateResa.Location = new System.Drawing.Point(65, 161);
            this.dateResa.Name = "dateResa";
            this.dateResa.Size = new System.Drawing.Size(112, 20);
            this.dateResa.TabIndex = 17;
            this.dateResa.Text = "Date réservée :";
            // 
            // resaPrenomLbl
            // 
            this.resaPrenomLbl.AutoSize = true;
            this.resaPrenomLbl.BackColor = System.Drawing.Color.Transparent;
            this.resaPrenomLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resaPrenomLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.resaPrenomLbl.Location = new System.Drawing.Point(201, 233);
            this.resaPrenomLbl.Name = "resaPrenomLbl";
            this.resaPrenomLbl.Size = new System.Drawing.Size(49, 15);
            this.resaPrenomLbl.TabIndex = 16;
            this.resaPrenomLbl.Text = "prenom";
            // 
            // prenomLbl
            // 
            this.prenomLbl.AutoSize = true;
            this.prenomLbl.BackColor = System.Drawing.Color.Transparent;
            this.prenomLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prenomLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prenomLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.prenomLbl.Location = new System.Drawing.Point(106, 228);
            this.prenomLbl.Name = "prenomLbl";
            this.prenomLbl.Size = new System.Drawing.Size(71, 20);
            this.prenomLbl.TabIndex = 15;
            this.prenomLbl.Text = "Prénom :";
            // 
            // titreReservationLbl
            // 
            this.titreReservationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titreReservationLbl.AutoSize = true;
            this.titreReservationLbl.BackColor = System.Drawing.Color.Transparent;
            this.titreReservationLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titreReservationLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titreReservationLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.titreReservationLbl.Location = new System.Drawing.Point(110, 27);
            this.titreReservationLbl.Name = "titreReservationLbl";
            this.titreReservationLbl.Size = new System.Drawing.Size(106, 21);
            this.titreReservationLbl.TabIndex = 14;
            this.titreReservationLbl.Text = "reservation";
            this.titreReservationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serviceDetailTlp
            // 
            this.serviceDetailTlp.ColumnCount = 2;
            this.serviceDetailTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serviceDetailTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serviceDetailTlp.Controls.Add(this.reservationDtGv, 0, 0);
            this.serviceDetailTlp.Controls.Add(this.detailReservationPnl, 1, 0);
            this.serviceDetailTlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serviceDetailTlp.Location = new System.Drawing.Point(0, 0);
            this.serviceDetailTlp.Margin = new System.Windows.Forms.Padding(0);
            this.serviceDetailTlp.Name = "serviceDetailTlp";
            this.serviceDetailTlp.RowCount = 1;
            this.serviceDetailTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.44186F));
            this.serviceDetailTlp.Size = new System.Drawing.Size(784, 344);
            this.serviceDetailTlp.TabIndex = 2;
            // 
            // reservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 344);
            this.Controls.Add(this.serviceDetailTlp);
            this.Name = "reservationsForm";
            this.Text = "reservationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.reservationDtGv)).EndInit();
            this.detailReservationPnl.ResumeLayout(false);
            this.detailReservationPnl.PerformLayout();
            this.serviceDetailTlp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.Label resaNomLbl;
        private System.Windows.Forms.Label nbLbl;
        private System.Windows.Forms.Label serviceResaLbl;
        private System.Windows.Forms.DataGridView reservationDtGv;
        private System.Windows.Forms.Label resaNbLbl;
        private System.Windows.Forms.Panel detailReservationPnl;
        private System.Windows.Forms.Label titreReservationLbl;
        private System.Windows.Forms.TableLayoutPanel serviceDetailTlp;
        private System.Windows.Forms.Label resaPrenomLbl;
        private System.Windows.Forms.Label prenomLbl;
        private System.Windows.Forms.Label dateResa;
        private System.Windows.Forms.Label servicelbl;
        private System.Windows.Forms.Label dateServiceLbl;
    }
}