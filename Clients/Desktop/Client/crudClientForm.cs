using BLLC.Services;
using BO.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                NomCrudClientTbox.Text = client.Nom;
                PrenomCrudClientTbox.Text = client.Prenom;
                EmailCrudClientTbox.Text = client.Email;
                TelCrudClientTbox.Text = client.Tel;
            }
        }
        private async void ActionCrudClientBtn_Click(object sender, EventArgs e)
        {
            CurrentClient = Compute();

            if (Controles())
            {
                if (isCreation)
                {
                    var client = await _clientSercice.CreateClient(CurrentClient);

                    if (client == null)
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
                if (CurrentClient == null)
                {
                    MessageBox.Show("Service Indisponible");
                }
            }
        }
        private async void DeleteCrudClientBtn_Click(object sender, EventArgs e)
        {
            if (!isCreation)
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
                Login= LoginCrudClientTbox.Text,
                Password = Password1TBox.Text,
                Role ="Client"

            };
        }

        private bool Controles()
        {
            //if (String.IsNullOrWhiteSpace(NomCrudClientTbox.Text) || String.IsNullOrWhiteSpace(PrenomCrudClientTbox.Text))
            //{
            //    if (String.IsNullOrWhiteSpace(NomCrudClientTbox.Text))
            //    {
            //        MessageBox.Show("Saisie du Nom incorrect", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        NomCrudClientTbox.Select();
            //        NomCrudClientTbox.Focus();
            //        return false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Saisie du Prenom incorrect", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        PrenomCrudClientTbox.Select();
            //        PrenomCrudClientTbox.Focus();
            //        return false;
            //    }
            //}

            ////on teste la validité du format de l'email
            //if (!String.IsNullOrWhiteSpace(EmailCrudClientTbox.Text) && !ValidMail(EmailCrudClientTbox.Text))
            //{
            //    MessageBox.Show("Le Format de l'Email est incorrect", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    EmailCrudClientTbox.Select();
            //    EmailCrudClientTbox.Focus();
            //    return false;
            //}
            ////on teste la validité du format du telephone

            //if (!String.IsNullOrWhiteSpace(TelCrudClientTbox.Text) && !PhoneNumber.IsPhoneNbr(TelCrudClientTbox.Text))
            //{
            //    MessageBox.Show("Le Format du telephone est incorrect", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TelCrudClientTbox.Select();
            //    TelCrudClientTbox.Focus();
            //    return false;
            //}
            ////on teste si le password1 et password2 sont les memes

            //if (Password1TBox.Text != pasword2TBox.Text)
            //{
            //    MessageBox.Show("Les mots de passes saisis ne sont pas identiques", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    TelCrudClientTbox.Select();
            //    TelCrudClientTbox.Focus();
            //    return false;
            //}

            return true;
        }


        public static class PhoneNumber
        {
            // Expression régulière utilisée pour valider un numéro de téléphone.
            public const string tetsTel = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            public static bool IsPhoneNbr(string numero)
            {
                if (numero != null) return Regex.IsMatch(numero, tetsTel);
                else return false;
            }
        }
        private bool ValidMail(string mail_address)
        {
            Regex myRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
            return myRegex.IsMatch(mail_address);
        }

        private void NomCrudClientTbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
