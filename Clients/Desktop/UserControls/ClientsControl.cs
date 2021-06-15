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
        public Client CurrentClient { get; private set; }
        public ClientsControl(Client client)
        {
            DoubleBuffered = true;
   
            InitializeComponent();
            CurrentClient = client;
            NomClientLbl.Text = client.Nom;
            PrenomLbl.Text = client.Prenom;
            EmailLbl.Text = client.Email;
            TelLbl.Text = client.Tel;
       

        }

    }
}
