
namespace Desktop.Gestion
{
    partial class CrudServiceForm
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
            this.datelbl = new System.Windows.Forms.Label();
            this.serviceDateTP = new System.Windows.Forms.DateTimePicker();
            this.servicelbl = new System.Windows.Forms.Label();
            this.MidiCheckBox = new System.Windows.Forms.CheckBox();
            this.SoirCheckBox = new System.Windows.Forms.CheckBox();
            this.entreelbl = new System.Windows.Forms.Label();
            this.platlbl = new System.Windows.Forms.Label();
            this.dessertlbl = new System.Windows.Forms.Label();
            this.entreeCBox = new System.Windows.Forms.ComboBox();
            this.platCBox = new System.Windows.Forms.ComboBox();
            this.dessertCBox = new System.Windows.Forms.ComboBox();
            this.ActionCrudServiceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(31, 46);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(40, 15);
            this.datelbl.TabIndex = 0;
            this.datelbl.Text = "Date : ";
            // 
            // serviceDateTP
            // 
            this.serviceDateTP.Location = new System.Drawing.Point(88, 40);
            this.serviceDateTP.Name = "serviceDateTP";
            this.serviceDateTP.Size = new System.Drawing.Size(200, 23);
            this.serviceDateTP.TabIndex = 1;
            // 
            // servicelbl
            // 
            this.servicelbl.AutoSize = true;
            this.servicelbl.Location = new System.Drawing.Point(21, 103);
            this.servicelbl.Name = "servicelbl";
            this.servicelbl.Size = new System.Drawing.Size(50, 15);
            this.servicelbl.TabIndex = 3;
            this.servicelbl.Text = "Service :";
            // 
            // MidiCheckBox
            // 
            this.MidiCheckBox.AutoSize = true;
            this.MidiCheckBox.Location = new System.Drawing.Point(88, 99);
            this.MidiCheckBox.Name = "MidiCheckBox";
            this.MidiCheckBox.Size = new System.Drawing.Size(50, 19);
            this.MidiCheckBox.TabIndex = 4;
            this.MidiCheckBox.Text = "Midi";
            this.MidiCheckBox.UseVisualStyleBackColor = true;
            // 
            // SoirCheckBox
            // 
            this.SoirCheckBox.AutoSize = true;
            this.SoirCheckBox.Location = new System.Drawing.Point(159, 99);
            this.SoirCheckBox.Name = "SoirCheckBox";
            this.SoirCheckBox.Size = new System.Drawing.Size(46, 19);
            this.SoirCheckBox.TabIndex = 5;
            this.SoirCheckBox.Text = "Soir";
            this.SoirCheckBox.UseVisualStyleBackColor = true;
            // 
            // entreelbl
            // 
            this.entreelbl.AutoSize = true;
            this.entreelbl.Location = new System.Drawing.Point(25, 157);
            this.entreelbl.Name = "entreelbl";
            this.entreelbl.Size = new System.Drawing.Size(46, 15);
            this.entreelbl.TabIndex = 6;
            this.entreelbl.Text = "Entree :";
            // 
            // platlbl
            // 
            this.platlbl.AutoSize = true;
            this.platlbl.Location = new System.Drawing.Point(38, 204);
            this.platlbl.Name = "platlbl";
            this.platlbl.Size = new System.Drawing.Size(33, 15);
            this.platlbl.TabIndex = 7;
            this.platlbl.Text = "Plat :";
            // 
            // dessertlbl
            // 
            this.dessertlbl.AutoSize = true;
            this.dessertlbl.Location = new System.Drawing.Point(20, 250);
            this.dessertlbl.Name = "dessertlbl";
            this.dessertlbl.Size = new System.Drawing.Size(51, 15);
            this.dessertlbl.TabIndex = 8;
            this.dessertlbl.Text = "Dessert :";
            // 
            // entreeCBox
            // 
            this.entreeCBox.FormattingEnabled = true;
            this.entreeCBox.Location = new System.Drawing.Point(88, 149);
            this.entreeCBox.Name = "entreeCBox";
            this.entreeCBox.Size = new System.Drawing.Size(121, 23);
            this.entreeCBox.TabIndex = 9;
            // 
            // platCBox
            // 
            this.platCBox.FormattingEnabled = true;
            this.platCBox.Location = new System.Drawing.Point(88, 195);
            this.platCBox.Name = "platCBox";
            this.platCBox.Size = new System.Drawing.Size(121, 23);
            this.platCBox.TabIndex = 10;
            // 
            // dessertCBox
            // 
            this.dessertCBox.FormattingEnabled = true;
            this.dessertCBox.Location = new System.Drawing.Point(88, 241);
            this.dessertCBox.Name = "dessertCBox";
            this.dessertCBox.Size = new System.Drawing.Size(121, 23);
            this.dessertCBox.TabIndex = 11;
            // 
            // ActionCrudServiceBtn
            // 
            this.ActionCrudServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.ActionCrudServiceBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActionCrudServiceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ActionCrudServiceBtn.Location = new System.Drawing.Point(88, 296);
            this.ActionCrudServiceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ActionCrudServiceBtn.Name = "ActionCrudServiceBtn";
            this.ActionCrudServiceBtn.Size = new System.Drawing.Size(166, 39);
            this.ActionCrudServiceBtn.TabIndex = 12;
            this.ActionCrudServiceBtn.Text = "Ajouter";
            this.ActionCrudServiceBtn.UseVisualStyleBackColor = false;
            this.ActionCrudServiceBtn.Click += new System.EventHandler(this.ActionCrudServiceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // CrudServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActionCrudServiceBtn);
            this.Controls.Add(this.dessertCBox);
            this.Controls.Add(this.platCBox);
            this.Controls.Add(this.entreeCBox);
            this.Controls.Add(this.dessertlbl);
            this.Controls.Add(this.platlbl);
            this.Controls.Add(this.entreelbl);
            this.Controls.Add(this.SoirCheckBox);
            this.Controls.Add(this.MidiCheckBox);
            this.Controls.Add(this.servicelbl);
            this.Controls.Add(this.serviceDateTP);
            this.Controls.Add(this.datelbl);
            this.Name = "CrudServiceForm";
            this.Text = "CrudServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.DateTimePicker serviceDateTP;
        private System.Windows.Forms.Label servicelbl;
        private System.Windows.Forms.CheckBox MidiCheckBox;
        private System.Windows.Forms.CheckBox SoirCheckBox;
        private System.Windows.Forms.Label entreelbl;
        private System.Windows.Forms.Label platlbl;
        private System.Windows.Forms.Label dessertlbl;
        private System.Windows.Forms.ComboBox entreeCBox;
        private System.Windows.Forms.ComboBox platCBox;
        private System.Windows.Forms.ComboBox dessertCBox;
        private System.Windows.Forms.Button ActionCrudServiceBtn;
        private System.Windows.Forms.Label label1;
    }
}