
namespace TestDesktop
{
    partial class CrudIngredients
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
            this.ActionCrudBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.formIngredient1 = new TestDesktop.UserControls.formIngredient();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.875F));
            this.tableLayoutPanel1.Controls.Add(this.ActionCrudBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.formIngredient1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ActionCrudBtn
            // 
            this.ActionCrudBtn.Location = new System.Drawing.Point(641, 119);
            this.ActionCrudBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ActionCrudBtn.Name = "ActionCrudBtn";
            this.ActionCrudBtn.Size = new System.Drawing.Size(75, 23);
            this.ActionCrudBtn.TabIndex = 1;
            this.ActionCrudBtn.Text = "Ajouter";
            this.ActionCrudBtn.UseVisualStyleBackColor = true;
            this.ActionCrudBtn.Click += new System.EventHandler(this.CrudBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.Location = new System.Drawing.Point(566, 119);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Supprimer";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // formIngredient1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.formIngredient1, 2);
            this.formIngredient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formIngredient1.Location = new System.Drawing.Point(3, 3);
            this.formIngredient1.Name = "formIngredient1";
            this.formIngredient1.Size = new System.Drawing.Size(794, 113);
            this.formIngredient1.TabIndex = 3;
            // 
            // CrudIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CrudIngredients";
            this.Text = "CrudIngredients";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ActionCrudBtn;
        private System.Windows.Forms.Button deleteBtn;
        private UserControls.formIngredient formIngredient1;
    }
}