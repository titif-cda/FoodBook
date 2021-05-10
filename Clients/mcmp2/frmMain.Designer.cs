namespace mcmp2
{
    partial class frmMain
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuitter = new FontAwesome.Sharp.IconButton();
            this.iBtnInscriptions = new FontAwesome.Sharp.IconButton();
            this.ibtnActivites = new FontAwesome.Sharp.IconButton();
            this.iBtnAdherents = new FontAwesome.Sharp.IconButton();
            this.pnlMenuHorizontal = new System.Windows.Forms.Panel();
            this.lblAccueil = new System.Windows.Forms.Label();
            this.pnlIconeFenetres = new System.Windows.Forms.Panel();
            this.iconClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconMax = new FontAwesome.Sharp.IconPictureBox();
            this.iconRestore = new FontAwesome.Sharp.IconPictureBox();
            this.iconMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.IcHome = new FontAwesome.Sharp.IconPictureBox();
            this.pnlContenu = new System.Windows.Forms.Panel();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tblMenu.SuspendLayout();
            this.pnlMenuHorizontal.SuspendLayout();
            this.pnlIconeFenetres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcHome)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97875F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.02126F));
            this.tblMain.Controls.Add(this.pbLogo, 0, 0);
            this.tblMain.Controls.Add(this.tblMenu, 0, 1);
            this.tblMain.Controls.Add(this.pnlMenuHorizontal, 1, 0);
            this.tblMain.Controls.Add(this.pnlContenu, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.46026F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.53974F));
            this.tblMain.Size = new System.Drawing.Size(941, 541);
            this.tblMain.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::mcmp2.Properties.Resources.logo2;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(182, 56);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // tblMenu
            // 
            this.tblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMenu.BackColor = System.Drawing.Color.Maroon;
            this.tblMenu.ColumnCount = 1;
            this.tblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMenu.Controls.Add(this.btnQuitter, 0, 3);
            this.tblMenu.Controls.Add(this.iBtnInscriptions, 0, 2);
            this.tblMenu.Controls.Add(this.ibtnActivites, 0, 1);
            this.tblMenu.Controls.Add(this.iBtnAdherents, 0, 0);
            this.tblMenu.Location = new System.Drawing.Point(3, 65);
            this.tblMenu.Name = "tblMenu";
            this.tblMenu.RowCount = 4;
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMenu.Size = new System.Drawing.Size(182, 473);
            this.tblMenu.TabIndex = 1;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuitter.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnQuitter.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuitter.IconSize = 58;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(3, 385);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnQuitter.Size = new System.Drawing.Size(176, 56);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // iBtnInscriptions
            // 
            this.iBtnInscriptions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iBtnInscriptions.FlatAppearance.BorderSize = 0;
            this.iBtnInscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnInscriptions.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.iBtnInscriptions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iBtnInscriptions.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.iBtnInscriptions.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iBtnInscriptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnInscriptions.IconSize = 58;
            this.iBtnInscriptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnInscriptions.Location = new System.Drawing.Point(3, 275);
            this.iBtnInscriptions.Name = "iBtnInscriptions";
            this.iBtnInscriptions.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iBtnInscriptions.Size = new System.Drawing.Size(176, 40);
            this.iBtnInscriptions.TabIndex = 7;
            this.iBtnInscriptions.Text = "&Inscriptions";
            this.iBtnInscriptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iBtnInscriptions.UseVisualStyleBackColor = true;
            this.iBtnInscriptions.Click += new System.EventHandler(this.iBtnInscriptions_Click);
            // 
            // ibtnActivites
            // 
            this.ibtnActivites.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ibtnActivites.FlatAppearance.BorderSize = 0;
            this.ibtnActivites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnActivites.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.ibtnActivites.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ibtnActivites.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.ibtnActivites.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtnActivites.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnActivites.IconSize = 58;
            this.ibtnActivites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnActivites.Location = new System.Drawing.Point(3, 157);
            this.ibtnActivites.Name = "ibtnActivites";
            this.ibtnActivites.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ibtnActivites.Size = new System.Drawing.Size(176, 40);
            this.ibtnActivites.TabIndex = 6;
            this.ibtnActivites.Text = "&Activités";
            this.ibtnActivites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnActivites.UseVisualStyleBackColor = true;
            this.ibtnActivites.Click += new System.EventHandler(this.ibtnActivites_Click);
            // 
            // iBtnAdherents
            // 
            this.iBtnAdherents.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iBtnAdherents.FlatAppearance.BorderSize = 0;
            this.iBtnAdherents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnAdherents.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.iBtnAdherents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iBtnAdherents.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iBtnAdherents.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iBtnAdherents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAdherents.IconSize = 38;
            this.iBtnAdherents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnAdherents.Location = new System.Drawing.Point(3, 39);
            this.iBtnAdherents.Name = "iBtnAdherents";
            this.iBtnAdherents.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iBtnAdherents.Size = new System.Drawing.Size(176, 40);
            this.iBtnAdherents.TabIndex = 5;
            this.iBtnAdherents.Text = "&Adhérents";
            this.iBtnAdherents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iBtnAdherents.UseVisualStyleBackColor = true;
            this.iBtnAdherents.Click += new System.EventHandler(this.iBtnAdherents_Click);
            // 
            // pnlMenuHorizontal
            // 
            this.pnlMenuHorizontal.Controls.Add(this.lblAccueil);
            this.pnlMenuHorizontal.Controls.Add(this.pnlIconeFenetres);
            this.pnlMenuHorizontal.Controls.Add(this.IcHome);
            this.pnlMenuHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuHorizontal.Location = new System.Drawing.Point(191, 3);
            this.pnlMenuHorizontal.Name = "pnlMenuHorizontal";
            this.pnlMenuHorizontal.Size = new System.Drawing.Size(747, 56);
            this.pnlMenuHorizontal.TabIndex = 5;
            this.pnlMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMenuHorizontal_MouseDown);
            // 
            // lblAccueil
            // 
            this.lblAccueil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblAccueil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAccueil.Location = new System.Drawing.Point(95, 17);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(66, 18);
            this.lblAccueil.TabIndex = 5;
            this.lblAccueil.Text = "&Accueil";
            this.lblAccueil.Click += new System.EventHandler(this.lblAccueil_Click);
            // 
            // pnlIconeFenetres
            // 
            this.pnlIconeFenetres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlIconeFenetres.Controls.Add(this.iconClose);
            this.pnlIconeFenetres.Controls.Add(this.iconMax);
            this.pnlIconeFenetres.Controls.Add(this.iconRestore);
            this.pnlIconeFenetres.Controls.Add(this.iconMinimize);
            this.pnlIconeFenetres.Location = new System.Drawing.Point(592, 3);
            this.pnlIconeFenetres.Name = "pnlIconeFenetres";
            this.pnlIconeFenetres.Size = new System.Drawing.Size(152, 39);
            this.pnlIconeFenetres.TabIndex = 4;
            // 
            // iconClose
            // 
            this.iconClose.BackColor = System.Drawing.Color.Maroon;
            this.iconClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconClose.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClose.Location = new System.Drawing.Point(117, 0);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(32, 32);
            this.iconClose.TabIndex = 3;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // iconMax
            // 
            this.iconMax.BackColor = System.Drawing.Color.Maroon;
            this.iconMax.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconMax.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMax.Location = new System.Drawing.Point(79, 0);
            this.iconMax.Name = "iconMax";
            this.iconMax.Size = new System.Drawing.Size(32, 32);
            this.iconMax.TabIndex = 2;
            this.iconMax.TabStop = false;
            this.iconMax.Click += new System.EventHandler(this.iconMax_Click);
            // 
            // iconRestore
            // 
            this.iconRestore.BackColor = System.Drawing.Color.Maroon;
            this.iconRestore.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.iconRestore.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRestore.Location = new System.Drawing.Point(79, 0);
            this.iconRestore.Name = "iconRestore";
            this.iconRestore.Size = new System.Drawing.Size(32, 32);
            this.iconRestore.TabIndex = 1;
            this.iconRestore.TabStop = false;
            this.iconRestore.Click += new System.EventHandler(this.iconRestore_Click);
            // 
            // iconMinimize
            // 
            this.iconMinimize.BackColor = System.Drawing.Color.Maroon;
            this.iconMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMinimize.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMinimize.Location = new System.Drawing.Point(41, 0);
            this.iconMinimize.Name = "iconMinimize";
            this.iconMinimize.Size = new System.Drawing.Size(32, 32);
            this.iconMinimize.TabIndex = 0;
            this.iconMinimize.TabStop = false;
            this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
            // 
            // IcHome
            // 
            this.IcHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.IcHome.BackColor = System.Drawing.Color.Maroon;
            this.IcHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IcHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IcHome.IconColor = System.Drawing.Color.WhiteSmoke;
            this.IcHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcHome.IconSize = 44;
            this.IcHome.Location = new System.Drawing.Point(45, 3);
            this.IcHome.Name = "IcHome";
            this.IcHome.Size = new System.Drawing.Size(44, 45);
            this.IcHome.TabIndex = 2;
            this.IcHome.TabStop = false;
            this.IcHome.Click += new System.EventHandler(this.IcHome_Click);
            // 
            // pnlContenu
            // 
            this.pnlContenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.pnlContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenu.Location = new System.Drawing.Point(191, 65);
            this.pnlContenu.Name = "pnlContenu";
            this.pnlContenu.Size = new System.Drawing.Size(747, 473);
            this.pnlContenu.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(941, 541);
            this.Controls.Add(this.tblMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MCMP";
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tblMenu.ResumeLayout(false);
            this.pnlMenuHorizontal.ResumeLayout(false);
            this.pnlMenuHorizontal.PerformLayout();
            this.pnlIconeFenetres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tblMenu;
        private FontAwesome.Sharp.IconButton btnQuitter;
        private FontAwesome.Sharp.IconButton iBtnInscriptions;
        private FontAwesome.Sharp.IconButton ibtnActivites;
        private FontAwesome.Sharp.IconButton iBtnAdherents;
        private System.Windows.Forms.Panel pnlMenuHorizontal;
        private System.Windows.Forms.Panel pnlIconeFenetres;
        private FontAwesome.Sharp.IconPictureBox iconClose;
        private FontAwesome.Sharp.IconPictureBox iconMax;
        private FontAwesome.Sharp.IconPictureBox iconRestore;
        private FontAwesome.Sharp.IconPictureBox iconMinimize;
        private FontAwesome.Sharp.IconPictureBox IcHome;
        private System.Windows.Forms.Panel pnlContenu;
        private System.Windows.Forms.Label lblAccueil;
    }
}

