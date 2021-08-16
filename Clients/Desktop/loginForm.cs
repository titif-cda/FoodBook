using BLLC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class LoginForm : Form
    {
        public string login;
        public string motdepasse;
        
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            ControlBox = false;
            passwordTBox.UseSystemPasswordChar = true;

            //TODO - en fin de projet - supprimer lihne suivante pour cacher le bouton valider , dé commenter les methode passwordTBox_TextChanged et loginTbox_TextChanged 
            //ValidLoginBtn.Visible = true;

        }

        private void passwordTBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTbox.Text) || string.IsNullOrEmpty(passwordTBox.Text))
            {
                //TODO remettre a false
                ValidLoginBtn.Visible = false;
                //ValidLoginBtn.Visible = true;
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

        private void registerLbl_Click(object sender, EventArgs e)
        {
            DialogResult r = new CrudClientForm(null).ShowDialog();
        }

        private async void ValidLoginBtn_Click(object sender, EventArgs e)
        {
            
            string mdpHash;
            login = loginTbox.Text;
          
            motdepasse = passwordTBox.Text;

            using (SHA256 sha256Hash = SHA256.Create())
            {
                mdpHash = GetHash(sha256Hash, motdepasse);
            }

            
            var result = await AuthentificationService.Instance.Signin(login, mdpHash);
            

            if (result)
            {
                if (AuthentificationService.Instance.GetRoleUser() == "Administrateur")
                    DialogResult = DialogResult.OK;
                else
                {
                    MessageBox.Show("Vous n'avez pas l'accès autorisé à cette application");
                }
               // string userID = My.User;



            }
            else
            {
                MessageBox.Show("Veuillez entrer des identifiants valides");
            }
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void hideMDP_CBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hideMDP_CBox.Checked)
            {
                passwordTBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTBox.UseSystemPasswordChar = true;
            }
        }
    }
}




