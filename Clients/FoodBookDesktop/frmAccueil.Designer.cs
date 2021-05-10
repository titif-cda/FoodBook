
namespace mcmp2
{
    partial class frmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.pbAccueil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccueil)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAccueil
            // 
            this.pbAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAccueil.Image = ((System.Drawing.Image)(resources.GetObject("pbAccueil.Image")));
            this.pbAccueil.Location = new System.Drawing.Point(0, 0);
            this.pbAccueil.Name = "pbAccueil";
            this.pbAccueil.Size = new System.Drawing.Size(731, 435);
            this.pbAccueil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAccueil.TabIndex = 0;
            this.pbAccueil.TabStop = false;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.ClientSize = new System.Drawing.Size(731, 435);
            this.Controls.Add(this.pbAccueil);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pbAccueil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAccueil;
    }
}