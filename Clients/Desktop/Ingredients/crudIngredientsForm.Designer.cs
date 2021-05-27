
namespace Desktop.Ingredients
{
    partial class crudIngredientsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ActionCrudIngredientBtn = new System.Windows.Forms.Button();
            this.deleteIngredientBtn = new System.Windows.Forms.Button();
            this.ingredientsControl1 = new Desktop.UserControls.IngredientsControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.875F));
            this.tableLayoutPanel1.Controls.Add(this.ActionCrudIngredientBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteIngredientBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ingredientsControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 200);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ActionCrudIngredientBtn
            // 
            this.ActionCrudIngredientBtn.Location = new System.Drawing.Point(641, 167);
            this.ActionCrudIngredientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ActionCrudIngredientBtn.Name = "ActionCrudIngredientBtn";
            this.ActionCrudIngredientBtn.Size = new System.Drawing.Size(75, 23);
            this.ActionCrudIngredientBtn.TabIndex = 1;
            this.ActionCrudIngredientBtn.Text = "Ajouter";
            this.ActionCrudIngredientBtn.UseVisualStyleBackColor = true;
            this.ActionCrudIngredientBtn.Click += new System.EventHandler(this.ActionCrudIngredientBtn_Click);
            // 
            // deleteIngredientBtn
            // 
            this.deleteIngredientBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteIngredientBtn.Location = new System.Drawing.Point(566, 167);
            this.deleteIngredientBtn.Margin = new System.Windows.Forms.Padding(0);
            this.deleteIngredientBtn.Name = "deleteIngredientBtn";
            this.deleteIngredientBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteIngredientBtn.TabIndex = 2;
            this.deleteIngredientBtn.Text = "Supprimer";
            this.deleteIngredientBtn.UseVisualStyleBackColor = true;
            this.deleteIngredientBtn.Click += new System.EventHandler(this.deleteIngredientBtn_Click);
            // 
            // ingredientsControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ingredientsControl1, 2);
            this.ingredientsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsControl1.Location = new System.Drawing.Point(3, 3);
            this.ingredientsControl1.Name = "ingredientsControl1";
            this.ingredientsControl1.Size = new System.Drawing.Size(794, 161);
            this.ingredientsControl1.TabIndex = 3;
            // 
            // crudIngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "crudIngredientsForm";
            this.Text = "crudIngredients";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ActionCrudIngredientBtn;
        private System.Windows.Forms.Button deleteIngredientBtn;
        private UserControls.IngredientsControl ingredientsControl1;
    }
}