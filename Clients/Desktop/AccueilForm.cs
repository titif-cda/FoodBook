using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
        }


     

        private void registerLbl_Click(object sender, EventArgs e)
        {
            DialogResult r = new crudClientForm(null).ShowDialog();
        }

       

        private void passwordTBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTbox.Text) || string.IsNullOrEmpty(passwordTBox.Text))
            {
                ValidLoginBtn.Visible = false;
            }
            else
            {
                ValidLoginBtn.Visible = true;
            }
        }

        private void loginTbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTbox.Text) || string.IsNullOrEmpty(passwordTBox.Text))
            {
                ValidLoginBtn.Visible = false;
            }
            else
            {
                ValidLoginBtn.Visible = true;
            }
        }
    }
}
