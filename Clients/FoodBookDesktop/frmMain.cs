using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcmp2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            NavFormPanel(new frmAccueil());
            //cacher le barre du Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //permet de manipuler la fenetre 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);



        #region Gestion des Boutons
        private void iBtnAdherents_Click(object sender, EventArgs e)
        {
            NavFormPanel(new frmAdherents());
        }

        private void ibtnActivites_Click(object sender, EventArgs e)
        {
            NavFormPanel(new frmActivites());
        }

        private void iBtnInscriptions_Click(object sender, EventArgs e)
        {
            NavFormPanel(new frmInscriptions());
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IcHome_Click(object sender, EventArgs e)
        {
            NavFormPanel(new frmAccueil());
        }

        private void lblAccueil_Click(object sender, EventArgs e)
        {
            NavFormPanel(new frmAccueil());
        }


        #endregion

        #region Gestion des Icones
        private void iconMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconRestore.Visible = true;
            iconMax.Visible = false;
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            pbLogo.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconRestore.Visible = false;
            iconMax.Visible = true;
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Fonctions
        //méthode pour afficher un formulaire dans le panneau de conteneur pnlContenu
        private void NavFormPanel(object Formulaire)
        {
            if (this.pnlContenu.Controls.Count > 0)
                this.pnlContenu.Controls.RemoveAt(0);
            Form form = Formulaire as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.pnlContenu.Controls.Add(form);
            this.pnlContenu.Tag = form;
            form.Show();
        }

        //fonction de glisser le formulaire
        private void pnlMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


    }
}
