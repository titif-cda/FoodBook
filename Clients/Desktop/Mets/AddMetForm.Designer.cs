
namespace Desktop.Mets
{
    partial class AddMetForm
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
            this.ListAllIngredientsTLP = new System.Windows.Forms.TableLayoutPanel();
            this.ListeIngredientsDtGv = new System.Windows.Forms.DataGridView();
            this.listTousIngredientsLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddMetBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NomMetLbl = new System.Windows.Forms.Label();
            this.CreerMetlbl = new System.Windows.Forms.Label();
            this.descriptionMetLbl = new System.Windows.Forms.Label();
            this.TypeMetLbl = new System.Windows.Forms.Label();
            this.NomMetTBox = new System.Windows.Forms.TextBox();
            this.DescriptionMetRTBox = new System.Windows.Forms.RichTextBox();
            this.ListeIngredientparPlatDGV = new System.Windows.Forms.DataGridView();
            this.TypeRepasCBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ListAllIngredientsTLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeIngredientsDtGv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeIngredientparPlatDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListAllIngredientsTLP
            // 
            this.ListAllIngredientsTLP.ColumnCount = 1;
            this.ListAllIngredientsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ListAllIngredientsTLP.Controls.Add(this.ListeIngredientsDtGv, 0, 1);
            this.ListAllIngredientsTLP.Controls.Add(this.listTousIngredientsLbl, 0, 0);
            this.ListAllIngredientsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListAllIngredientsTLP.Location = new System.Drawing.Point(532, 0);
            this.ListAllIngredientsTLP.Margin = new System.Windows.Forms.Padding(0);
            this.ListAllIngredientsTLP.Name = "ListAllIngredientsTLP";
            this.ListAllIngredientsTLP.RowCount = 2;
            this.ListAllIngredientsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.ListAllIngredientsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.59259F));
            this.ListAllIngredientsTLP.Size = new System.Drawing.Size(268, 411);
            this.ListAllIngredientsTLP.TabIndex = 5;
            // 
            // ListeIngredientsDtGv
            // 
            this.ListeIngredientsDtGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeIngredientsDtGv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListeIngredientsDtGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListeIngredientsDtGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeIngredientsDtGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeIngredientsDtGv.GridColor = System.Drawing.SystemColors.Control;
            this.ListeIngredientsDtGv.Location = new System.Drawing.Point(3, 33);
            this.ListeIngredientsDtGv.Name = "ListeIngredientsDtGv";
            this.ListeIngredientsDtGv.RowHeadersVisible = false;
            this.ListeIngredientsDtGv.RowTemplate.Height = 25;
            this.ListeIngredientsDtGv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ListeIngredientsDtGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListeIngredientsDtGv.Size = new System.Drawing.Size(262, 375);
            this.ListeIngredientsDtGv.TabIndex = 4;
            this.ListeIngredientsDtGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeIngredientsDtGv_CellClick);
            this.ListeIngredientsDtGv.SelectionChanged += new System.EventHandler(this.ListeIngredientsDtGv_SelectionChanged);
            // 
            // listTousIngredientsLbl
            // 
            this.listTousIngredientsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listTousIngredientsLbl.AutoSize = true;
            this.listTousIngredientsLbl.Location = new System.Drawing.Point(45, 7);
            this.listTousIngredientsLbl.Name = "listTousIngredientsLbl";
            this.listTousIngredientsLbl.Size = new System.Drawing.Size(177, 15);
            this.listTousIngredientsLbl.TabIndex = 0;
            this.listTousIngredientsLbl.Text = "Liste des ingredients disponibles";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.AddMetBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ListAllIngredientsTLP, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.48936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.510639F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // AddMetBtn
            // 
            this.AddMetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.AddMetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddMetBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddMetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddMetBtn.Location = new System.Drawing.Point(0, 411);
            this.AddMetBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddMetBtn.Name = "AddMetBtn";
            this.AddMetBtn.Size = new System.Drawing.Size(459, 39);
            this.AddMetBtn.TabIndex = 8;
            this.AddMetBtn.Text = "Ajouter";
            this.AddMetBtn.UseVisualStyleBackColor = false;
            this.AddMetBtn.Click += new System.EventHandler(this.AddMetBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.06181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.93819F));
            this.tableLayoutPanel2.Controls.Add(this.NomMetLbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CreerMetlbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.descriptionMetLbl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TypeMetLbl, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.NomMetTBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DescriptionMetRTBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ListeIngredientparPlatDGV, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TypeRepasCBox, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(453, 405);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // NomMetLbl
            // 
            this.NomMetLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NomMetLbl.AutoSize = true;
            this.NomMetLbl.Location = new System.Drawing.Point(26, 52);
            this.NomMetLbl.Name = "NomMetLbl";
            this.NomMetLbl.Size = new System.Drawing.Size(80, 15);
            this.NomMetLbl.TabIndex = 1;
            this.NomMetLbl.Text = "Nom du plat :";
            // 
            // CreerMetlbl
            // 
            this.CreerMetlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreerMetlbl.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.CreerMetlbl, 2);
            this.CreerMetlbl.Location = new System.Drawing.Point(159, 12);
            this.CreerMetlbl.Name = "CreerMetlbl";
            this.CreerMetlbl.Size = new System.Drawing.Size(135, 15);
            this.CreerMetlbl.TabIndex = 0;
            this.CreerMetlbl.Text = "Ajouter un nouveau plat";
            // 
            // descriptionMetLbl
            // 
            this.descriptionMetLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionMetLbl.AutoSize = true;
            this.descriptionMetLbl.Location = new System.Drawing.Point(33, 113);
            this.descriptionMetLbl.Name = "descriptionMetLbl";
            this.descriptionMetLbl.Size = new System.Drawing.Size(73, 15);
            this.descriptionMetLbl.TabIndex = 2;
            this.descriptionMetLbl.Text = "Description :";
            // 
            // TypeMetLbl
            // 
            this.TypeMetLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TypeMetLbl.AutoSize = true;
            this.TypeMetLbl.Location = new System.Drawing.Point(30, 173);
            this.TypeMetLbl.Name = "TypeMetLbl";
            this.TypeMetLbl.Size = new System.Drawing.Size(76, 15);
            this.TypeMetLbl.TabIndex = 3;
            this.TypeMetLbl.Text = "Type de Plat :";
            // 
            // NomMetTBox
            // 
            this.NomMetTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NomMetTBox.Location = new System.Drawing.Point(112, 48);
            this.NomMetTBox.Name = "NomMetTBox";
            this.NomMetTBox.Size = new System.Drawing.Size(338, 23);
            this.NomMetTBox.TabIndex = 4;
            // 
            // DescriptionMetRTBox
            // 
            this.DescriptionMetRTBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionMetRTBox.Location = new System.Drawing.Point(112, 83);
            this.DescriptionMetRTBox.Name = "DescriptionMetRTBox";
            this.DescriptionMetRTBox.Size = new System.Drawing.Size(338, 75);
            this.DescriptionMetRTBox.TabIndex = 5;
            this.DescriptionMetRTBox.Text = "";
            // 
            // ListeIngredientparPlatDGV
            // 
            this.ListeIngredientparPlatDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeIngredientparPlatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeIngredientparPlatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeIngredientparPlatDGV.Location = new System.Drawing.Point(112, 204);
            this.ListeIngredientparPlatDGV.MultiSelect = false;
            this.ListeIngredientparPlatDGV.Name = "ListeIngredientparPlatDGV";
            this.ListeIngredientparPlatDGV.RowTemplate.Height = 25;
            this.ListeIngredientparPlatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListeIngredientparPlatDGV.Size = new System.Drawing.Size(338, 198);
            this.ListeIngredientparPlatDGV.TabIndex = 7;
            // 
            // TypeRepasCBox
            // 
            this.TypeRepasCBox.FormattingEnabled = true;
            this.TypeRepasCBox.Location = new System.Drawing.Point(112, 164);
            this.TypeRepasCBox.Name = "TypeRepasCBox";
            this.TypeRepasCBox.Size = new System.Drawing.Size(247, 23);
            this.TypeRepasCBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(462, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 405);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantité";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddMetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddMetForm";
            this.Text = "AddMetForm";
            this.ListAllIngredientsTLP.ResumeLayout(false);
            this.ListAllIngredientsTLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeIngredientsDtGv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeIngredientparPlatDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ListAllIngredientsTLP;
        private System.Windows.Forms.DataGridView ListeIngredientsDtGv;
        private System.Windows.Forms.Label listTousIngredientsLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label NomMetLbl;
        private System.Windows.Forms.Label CreerMetlbl;
        private System.Windows.Forms.Label descriptionMetLbl;
        private System.Windows.Forms.Label TypeMetLbl;
        private System.Windows.Forms.TextBox NomMetTBox;
        private System.Windows.Forms.RichTextBox DescriptionMetRTBox;
        private System.Windows.Forms.DataGridView ListeIngredientparPlatDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddMetBtn;
        private System.Windows.Forms.ComboBox TypeRepasCBox;
    }
}