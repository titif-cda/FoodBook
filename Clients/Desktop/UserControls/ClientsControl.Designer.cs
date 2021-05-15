
namespace Desktop
{
    partial class ClientsControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomClientTbx = new System.Windows.Forms.TextBox();
            this.PrenomTbx = new System.Windows.Forms.TextBox();
            this.EmailTbx = new System.Windows.Forms.TextBox();
            this.TelTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(67, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(67, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(67, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telephone";
            // 
            // NomClientTbx
            // 
            this.NomClientTbx.BackColor = System.Drawing.Color.White;
            this.NomClientTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomClientTbx.Location = new System.Drawing.Point(67, 30);
            this.NomClientTbx.Name = "NomClientTbx";
            this.NomClientTbx.Size = new System.Drawing.Size(100, 16);
            this.NomClientTbx.TabIndex = 5;
            // 
            // PrenomTbx
            // 
            this.PrenomTbx.BackColor = System.Drawing.Color.White;
            this.PrenomTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrenomTbx.Location = new System.Drawing.Point(67, 70);
            this.PrenomTbx.Name = "PrenomTbx";
            this.PrenomTbx.Size = new System.Drawing.Size(100, 16);
            this.PrenomTbx.TabIndex = 6;
            // 
            // EmailTbx
            // 
            this.EmailTbx.BackColor = System.Drawing.Color.White;
            this.EmailTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTbx.Location = new System.Drawing.Point(67, 110);
            this.EmailTbx.Name = "EmailTbx";
            this.EmailTbx.Size = new System.Drawing.Size(100, 16);
            this.EmailTbx.TabIndex = 7;
            // 
            // TelTbx
            // 
            this.TelTbx.BackColor = System.Drawing.Color.White;
            this.TelTbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelTbx.Location = new System.Drawing.Point(67, 150);
            this.TelTbx.Name = "TelTbx";
            this.TelTbx.Size = new System.Drawing.Size(100, 16);
            this.TelTbx.TabIndex = 8;
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.TelTbx);
            this.Controls.Add(this.EmailTbx);
            this.Controls.Add(this.PrenomTbx);
            this.Controls.Add(this.NomClientTbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(179, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NomClientTbx;
        private System.Windows.Forms.TextBox Prenomtbox;
        private System.Windows.Forms.TextBox EmailTbx;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox TelTbx;
        private System.Windows.Forms.TextBox PrenomTbx;
    }
}
