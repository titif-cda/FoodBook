
namespace Desktop
{
    partial class AccueilForm
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
            this.loginTbox = new System.Windows.Forms.TextBox();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.ValidLoginBtn = new System.Windows.Forms.Button();
            this.ConnexionLbl = new System.Windows.Forms.Label();
            this.registerLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTbox
            // 
            this.loginTbox.Location = new System.Drawing.Point(357, 265);
            this.loginTbox.Name = "loginTbox";
            this.loginTbox.Size = new System.Drawing.Size(112, 23);
            this.loginTbox.TabIndex = 0;
            this.loginTbox.TextChanged += new System.EventHandler(this.loginTbox_TextChanged);
            // 
            // passwordTBox
            // 
            this.passwordTBox.Location = new System.Drawing.Point(357, 318);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(112, 23);
            this.passwordTBox.TabIndex = 1;
            this.passwordTBox.TextChanged += new System.EventHandler(this.passwordTBox_TextChanged);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.loginLbl.Location = new System.Drawing.Point(357, 242);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(46, 20);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "Login";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.passwordLbl.Location = new System.Drawing.Point(357, 295);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(98, 20);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Mot de passe";
            this.passwordLbl.UseMnemonic = false;
            // 
            // ValidLoginBtn
            // 
            this.ValidLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.ValidLoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValidLoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ValidLoginBtn.Location = new System.Drawing.Point(357, 356);
            this.ValidLoginBtn.Name = "ValidLoginBtn";
            this.ValidLoginBtn.Size = new System.Drawing.Size(112, 23);
            this.ValidLoginBtn.TabIndex = 4;
            this.ValidLoginBtn.Text = "Valider";
            this.ValidLoginBtn.UseVisualStyleBackColor = false;
            this.ValidLoginBtn.Visible = false;
            // 
            // ConnexionLbl
            // 
            this.ConnexionLbl.AutoSize = true;
            this.ConnexionLbl.BackColor = System.Drawing.Color.Transparent;
            this.ConnexionLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConnexionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.ConnexionLbl.Location = new System.Drawing.Point(369, 211);
            this.ConnexionLbl.Name = "ConnexionLbl";
            this.ConnexionLbl.Size = new System.Drawing.Size(100, 21);
            this.ConnexionLbl.TabIndex = 7;
            this.ConnexionLbl.Text = "Connexion";
            // 
            // registerLbl
            // 
            this.registerLbl.AutoSize = true;
            this.registerLbl.BackColor = System.Drawing.Color.Transparent;
            this.registerLbl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.registerLbl.Location = new System.Drawing.Point(357, 382);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(112, 18);
            this.registerLbl.TabIndex = 8;
            this.registerLbl.Text = "Créer un compte";
            this.registerLbl.Click += new System.EventHandler(this.registerLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(545, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Créer un compte";
            // 
            // AccueilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerLbl);
            this.Controls.Add(this.ConnexionLbl);
            this.Controls.Add(this.ValidLoginBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.passwordTBox);
            this.Controls.Add(this.loginTbox);
            this.Name = "AccueilForm";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTbox;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button ValidLoginBtn;
        private System.Windows.Forms.Label ConnexionLbl;
        private System.Windows.Forms.Label registerLbl;
        private System.Windows.Forms.Label label1;
    }
}