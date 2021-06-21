
namespace Desktop.Gestion
{
    partial class GestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionForm));
            this.GestionTlp = new System.Windows.Forms.TableLayoutPanel();
            this.ReservationBtn = new System.Windows.Forms.Button();
            this.ServiceBtn = new System.Windows.Forms.Button();
            this.GestionPnl = new System.Windows.Forms.Panel();
            this.GestionPBox = new System.Windows.Forms.PictureBox();
            this.GestionTlp.SuspendLayout();
            this.GestionPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GestionPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GestionTlp
            // 
            this.GestionTlp.ColumnCount = 2;
            this.GestionTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GestionTlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GestionTlp.Controls.Add(this.ReservationBtn, 1, 0);
            this.GestionTlp.Controls.Add(this.ServiceBtn, 0, 0);
            this.GestionTlp.Dock = System.Windows.Forms.DockStyle.Top;
            this.GestionTlp.Location = new System.Drawing.Point(0, 0);
            this.GestionTlp.Margin = new System.Windows.Forms.Padding(0);
            this.GestionTlp.Name = "GestionTlp";
            this.GestionTlp.RowCount = 1;
            this.GestionTlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GestionTlp.Size = new System.Drawing.Size(800, 67);
            this.GestionTlp.TabIndex = 0;
            // 
            // ReservationBtn
            // 
            this.ReservationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.ReservationBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservationBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReservationBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ReservationBtn.Location = new System.Drawing.Point(400, 0);
            this.ReservationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ReservationBtn.Name = "ReservationBtn";
            this.ReservationBtn.Size = new System.Drawing.Size(400, 67);
            this.ReservationBtn.TabIndex = 5;
            this.ReservationBtn.Text = "Reservations";
            this.ReservationBtn.UseVisualStyleBackColor = false;
            this.ReservationBtn.Click += new System.EventHandler(this.ReservationBtn_Click);
            // 
            // ServiceBtn
            // 
            this.ServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.ServiceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ServiceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ServiceBtn.Location = new System.Drawing.Point(0, 0);
            this.ServiceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ServiceBtn.Name = "ServiceBtn";
            this.ServiceBtn.Size = new System.Drawing.Size(400, 67);
            this.ServiceBtn.TabIndex = 4;
            this.ServiceBtn.Text = "Services";
            this.ServiceBtn.UseVisualStyleBackColor = false;
            this.ServiceBtn.Click += new System.EventHandler(this.ServiceBtn_Click);
            // 
            // GestionPnl
            // 
            this.GestionPnl.Controls.Add(this.GestionPBox);
            this.GestionPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GestionPnl.Location = new System.Drawing.Point(0, 67);
            this.GestionPnl.Name = "GestionPnl";
            this.GestionPnl.Size = new System.Drawing.Size(800, 383);
            this.GestionPnl.TabIndex = 1;
            // 
            // GestionPBox
            // 
            this.GestionPBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GestionPBox.Image = ((System.Drawing.Image)(resources.GetObject("GestionPBox.Image")));
            this.GestionPBox.Location = new System.Drawing.Point(0, 0);
            this.GestionPBox.Margin = new System.Windows.Forms.Padding(0);
            this.GestionPBox.Name = "GestionPBox";
            this.GestionPBox.Size = new System.Drawing.Size(800, 383);
            this.GestionPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GestionPBox.TabIndex = 7;
            this.GestionPBox.TabStop = false;
            // 
            // GestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GestionPnl);
            this.Controls.Add(this.GestionTlp);
            this.Name = "GestionForm";
            this.Text = "GestionForm";
            this.GestionTlp.ResumeLayout(false);
            this.GestionPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GestionPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GestionTlp;
        private System.Windows.Forms.Button ReservationBtn;
        private System.Windows.Forms.Button ServiceBtn;
        private System.Windows.Forms.Panel GestionPnl;
        private System.Windows.Forms.PictureBox GestionPBox;
    }
}