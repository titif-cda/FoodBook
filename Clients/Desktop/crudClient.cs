using BLLC.Services;
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
    public partial class crudClient : Form
    {
        public bool isCreation = false;
        private readonly IClientService _clientSercice;
        public crudClient(Client client)
        {
            _clientSercice = new ClientService();
            InitializeComponent();
            Initialize(client);
        }

        private async void ActionCrudClientBtn_Click(object sender, EventArgs e)
        {
           
        }
        private void Initialize(Client client)
        {
            if (client == null)
            {
                //creation
                isCreation = true;

                DeleteCrudClientBtn.Visible = false;
                DeleteCrudClientBtn.Enabled = false;
            }
            else
            {
                //modif
                ActionCrudClientBtn.Text = "Modifier";
                NomCrudClientLabel.Text = client.Nom;
            }
        }

    }
}
