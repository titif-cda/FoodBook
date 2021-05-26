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

namespace Desktop
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            NavFormPanel(new AccueilForm());
        }
        //permet de manipuler la fenetre 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void NavFormPanel(object Formulaire)
        {
            if (this.ContenuPnl.Controls.Count > 0)
                this.ContenuPnl.Controls.RemoveAt(0);
            Form form = Formulaire as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.ContenuPnl.Controls.Add(form);
            this.ContenuPnl.Tag = form;
            form.Show();
        }
        
        #region Gestion des Icones
        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestoreBtn.Visible = false;
            MaximizeBtn.Visible = true;
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            RestoreBtn.Visible = true;
            MaximizeBtn.Visible = false;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            //MainFormPBox.Visible = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void ClientBtn_Click(object sender, EventArgs e)
        {
           
            
            NavFormPanel(new listClientsForm());
            //if (this.WindowState == FormWindowState.Maximized)
            //{
               
            //}
        }

       

        private void pnlMenuHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainFormPBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavFormPanel(new listClientsForm());
        }

       
    }
}
