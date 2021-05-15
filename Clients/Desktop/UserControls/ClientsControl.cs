using BO.Entity;
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
    public partial class ClientsControl : UserControl
    {
        public ClientsControl(Client client)
        {
            InitializeComponent();
            NomClientTbx.Text = client.NomClient; 
        }

       
    }
}
