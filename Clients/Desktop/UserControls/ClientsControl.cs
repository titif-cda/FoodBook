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
            InitializeComponent();
            CurrentClient = client;
            NomClientTbx.Text = client.NomClient;
            PrenomTbx.Text = client.PrenomClient;
            EmailTbx.Text = client.EmailClient;
            TelTbx.Text = client.TelClient;
        }

       
    }
}
