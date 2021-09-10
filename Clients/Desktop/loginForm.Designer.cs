
namespace Desktop
{
    partial class LoginForm
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
            this.registerLbl = new System.Windows.Forms.Label();
            this.ConnexionLbl = new System.Windows.Forms.Label();
            this.ValidLoginBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.loginTbox = new System.Windows.Forms.TextBox();
            this.hideMDP_CBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // registerLbl
            // 
            this.registerLbl.AutoSize = true;
            this.registerLbl.BackColor = System.Drawing.Color.Transparent;
            this.registerLbl.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.registerLbl.Location = new System.Drawing.Point(48, 239);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(112, 18);
            this.registerLbl.TabIndex = 16;
            this.registerLbl.Text = "Créer un compte";
            this.registerLbl.Click += new System.EventHandler(this.registerLbl_Click);
            // 
            // ConnexionLbl
            // 
            this.ConnexionLbl.AutoSize = true;
            this.ConnexionLbl.BackColor = System.Drawing.Color.Transparent;
            this.ConnexionLbl.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConnexionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.ConnexionLbl.Location = new System.Drawing.Point(60, 31);
            this.ConnexionLbl.Name = "ConnexionLbl";
            this.ConnexionLbl.Size = new System.Drawing.Size(100, 21);
            this.ConnexionLbl.TabIndex = 15;
            this.ConnexionLbl.Text = "Connexion";
            // 
            // ValidLoginBtn
            // 
            this.ValidLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.ValidLoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ValidLoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ValidLoginBtn.Location = new System.Drawing.Point(48, 213);
            this.ValidLoginBtn.Name = "ValidLoginBtn";
            this.ValidLoginBtn.Size = new System.Drawing.Size(112, 23);
            this.ValidLoginBtn.TabIndex = 14;
            this.ValidLoginBtn.Text = "Valider";
            this.ValidLoginBtn.UseVisualStyleBackColor = false;
            this.ValidLoginBtn.Visible = false;
            this.ValidLoginBtn.Click += new System.EventHandler(this.ValidLoginBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passwordLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.passwordLbl.Location = new System.Drawing.Point(48, 115);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(98, 20);
            this.passwordLbl.TabIndex = 13;
            this.passwordLbl.Text = "Mot de passe";
            this.passwordLbl.UseMnemonic = false;
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.loginLbl.Location = new System.Drawing.Point(48, 62);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(46, 20);
            this.loginLbl.TabIndex = 12;
            this.loginLbl.Text = "Login";
            // 
            // passwordTBox
            // 
            this.passwordTBox.Location = new System.Drawing.Point(48, 138);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(112, 23);
            this.passwordTBox.TabIndex = 11;
            this.passwordTBox.TextChanged += new System.EventHandler(this.passwordTBox_TextChanged);
            // 
            // loginTbox
            // 
            this.loginTbox.Location = new System.Drawing.Point(48, 85);
            this.loginTbox.Name = "loginTbox";
            this.loginTbox.Size = new System.Drawing.Size(112, 23);
            this.loginTbox.TabIndex = 10;
            this.loginTbox.TextChanged += new System.EventHandler(this.loginTbox_TextChanged);
            // 
            // hideMDP_CBox
            // 
            this.hideMDP_CBox.AutoSize = true;
            this.hideMDP_CBox.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hideMDP_CBox.Location = new System.Drawing.Point(48, 168);
            this.hideMDP_CBox.Name = "hideMDP_CBox";
            this.hideMDP_CBox.Size = new System.Drawing.Size(143, 16);
            this.hideMDP_CBox.TabIndex = 17;
            this.hideMDP_CBox.Text = "Afficher/ cacher les caractères";
            this.hideMDP_CBox.UseVisualStyleBackColor = true;
            this.hideMDP_CBox.CheckedChanged += new System.EventHandler(this.hideMDP_CBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 276);
            this.Controls.Add(this.hideMDP_CBox);
            this.Controls.Add(this.registerLbl);
            this.Controls.Add(this.ConnexionLbl);
            this.Controls.Add(this.ValidLoginBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.passwordTBox);
            this.Controls.Add(this.loginTbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerLbl;
        private System.Windows.Forms.Label ConnexionLbl;
        private System.Windows.Forms.Button ValidLoginBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.TextBox loginTbox;
        private System.Windows.Forms.CheckBox hideMDP_CBox;
    }
}