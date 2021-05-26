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
    public partial class crudClientForm : Form
    {
        Client CurrentClient;
        public bool isCreation = false;
        private readonly IClientService _clientSercice;
        public crudClientForm(Client client)
        {
            _clientSercice = new ClientService();
            InitializeComponent();
            Initialize(client);
        }

       
        private void Initialize(Client client)
        {
            if (client == null)
            {
                CurrentClient = new Client();
                //creation
                isCreation = true;

                DeleteCrudClientBtn.Visible = false;
                DeleteCrudClientBtn.Enabled = false;
            }
            else
            {
                CurrentClient = client;
                //modif
                ActionCrudClientBtn.Text = "Modifier";
                IdClientlbl.Text = client.Id.ToString();
                NomCrudClientTbox.Text = client.Nom;
                PrenomCrudClientTbox.Text = client.Prenom;
                EmailCrudClientTbox.Text = client.Email;
                TelCrudClientTbox.Text = client.Tel;
            }
        }
        private async void ActionCrudClientBtn_Click(object sender, EventArgs e)
        {
            CurrentClient = Compute();

            if (isCreation)
            {
                var client = await _clientSercice.CreateClient(CurrentClient);
                if(client == null)
                {
                    MessageBox.Show("Service Indisponible");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {

                CurrentClient = await _clientSercice.PutClient(CurrentClient);
                DialogResult = DialogResult.OK;
            }
            if ( CurrentClient == null)
            {
                MessageBox.Show("Service Indisponible");
            }
        }
        private async void DeleteCrudClientBtn_Click(object sender, EventArgs e)
        {
            if(!isCreation)
            {
                CurrentClient = Compute();
                await _clientSercice.DeleteClient(CurrentClient);
                DialogResult = DialogResult.OK;
            }
        }

        public Client Compute()
        {
            int? id = null;
            if (!isCreation)
            {
                id = CurrentClient.Id;
            }
            return new Client()
            {
                Id = id,
                Nom = NomCrudClientTbox.Text,
                Prenom = PrenomCrudClientTbox.Text,
                Email = EmailCrudClientTbox.Text,
                Tel = TelCrudClientTbox.Text,
            };
        }

    }
}
