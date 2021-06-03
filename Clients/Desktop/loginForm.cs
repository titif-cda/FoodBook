﻿using BLLC.Services;
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
    public partial class loginForm : Form
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

        public loginForm()
        {
            InitializeComponent();
            ControlBox = false;

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

        private void registerLbl_Click(object sender, EventArgs e)
        {
            DialogResult r = new crudClientForm(null).ShowDialog();
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
                DialogResult = DialogResult.OK;
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
    }
}



