using System;
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
        Color ColorHover = System.Drawing.ColorTranslator.FromHtml("#CA5100");
        Color ColorOrigin = System.Drawing.ColorTranslator.FromHtml("#8C52FF");
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
            
            ServiceBtn.BackColor = ColorHover;
            CommandesBtn.BackColor = ColorOrigin;
            ReservationsBtn.BackColor = ColorOrigin;
            ServiceBtn.ForeColor = Color.Black;
            CommandesBtn.ForeColor = Color.White;
            ReservationsBtn.ForeColor = Color.White;
            //ServiceBtn.Font = new Font(ServiceBtn.Font, FontStyle.Bold);
        }


        private void ReservationsBtn_Click(object sender, EventArgs e)
        {
            NavFormPanel(new reservationsForm());
            
            ReservationsBtn.BackColor = ColorHover;
            ServiceBtn.BackColor = ColorOrigin;
            CommandesBtn.BackColor = ColorOrigin;
            ReservationsBtn.ForeColor = Color.Black;
            ServiceBtn.ForeColor = Color.White;
            CommandesBtn.ForeColor = Color.White;
        }

        private void CommandesBtn_Click(object sender, EventArgs e)
        {

            NavFormPanel(new CommandeForm());
            
            CommandesBtn.BackColor = ColorHover;
            ServiceBtn.BackColor = ColorOrigin;
            ReservationsBtn.BackColor = ColorOrigin;
            CommandesBtn.ForeColor = Color.Black;
            ServiceBtn.ForeColor = Color.White;
            ReservationsBtn.ForeColor = Color.White;

        }
    }
}
