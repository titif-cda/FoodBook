﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Gestion
{
    public partial class GestionForm : Form
    {
        public GestionForm()
        {
            InitializeComponent();
        }



        private void NavFormPanel(object Formulaire)
        {
            if (this.GestionPnl.Controls.Count > 0)
                this.GestionPnl.Controls.RemoveAt(0);
            Form form = Formulaire as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.GestionPnl.Controls.Add(form);
            this.GestionPnl.Tag = form;
            form.Show();
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            NavFormPanel(new ServiceForm());
            string hoverColor = "#CA5100";
            string originColor = "#8C52FF";

            Color ColorHover = System.Drawing.ColorTranslator.FromHtml(hoverColor);
            Color ColorOrigin = System.Drawing.ColorTranslator.FromHtml(originColor);
            ServiceBtn.BackColor = ColorHover;
            ReservationBtn.BackColor = ColorOrigin;
            ServiceBtn.ForeColor = Color.Black;
            ReservationBtn.ForeColor = Color.White;
            //ServiceBtn.Font = new Font(ServiceBtn.Font, FontStyle.Bold);
        }

        private void ReservationBtn_Click(object sender, EventArgs e)
        {
            NavFormPanel(new ReservationForm());
            string hoverColor = "#CA5100";
            string originColor = "#8C52FF";

            Color ColorHover = System.Drawing.ColorTranslator.FromHtml(hoverColor);
            Color ColorOrigin = System.Drawing.ColorTranslator.FromHtml(originColor);
            ReservationBtn.BackColor = ColorHover;
            ServiceBtn.BackColor = ColorOrigin;
            ServiceBtn.ForeColor = Color.White;
            ReservationBtn.ForeColor = Color.Black;
        }
    }
}
