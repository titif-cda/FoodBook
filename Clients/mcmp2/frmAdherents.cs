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

namespace mcmp2
{
    public partial class frmAdherents : Form
    {
        public frmAdherents()
        {
            InitializeComponent();
        }

        private void listAdherentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (listAdherentBindingSource.Current != null)
            {
                cda28_bd3DataSet.listAdherentRow currentAdhRow = (cda28_bd3DataSet.listAdherentRow)((DataRowView)listAdherentBindingSource.Current).Row;
                //
                listeInscriptionsAvecActetAdhTableAdapter.FillByAdherent(cda28_bd3DataSet.listeInscriptionsAvecActetAdh, currentAdhRow.IDADHERENT);
                textNom.Enabled = false;
                textPrenom.Enabled = false;
                textAd1.Enabled = false;
                textAd2.Enabled = false;
                textCP.Enabled = false;
                textEmail.Enabled = false;
                textTel.Enabled = false;
                textVille.Enabled = false;
                dtpDNaiss.Enabled = false;
                dtpAdh.Enabled = false;
                ckbxOrg.Enabled = false;
                btModifier.Enabled = true;
            }

            decimal? nbAdherents = listAdherentTableAdapter.CountAdherent();
            if (nbAdherents > 0)
            {
                lblTotalAd.Text = nbAdherents.ToString();
            }
            else
            {
                lblTotalAd.Text = "aucun adhérent";
            }
        }
        //internal int IdAdherent ;
        private void btSuivi_Click(object sender, EventArgs e)
        {
            cda28_bd3DataSet.listAdherentRow currentAdhRow = (cda28_bd3DataSet.listAdherentRow)((DataRowView)listAdherentBindingSource.Current).Row;

            using (frmAdhInscription frmAd = new frmAdhInscription())
            {
                frmAd.lblNomAdhSelect.Text = currentAdhRow.NOM;
                frmAd.lblPrenAdhSelect.Text = currentAdhRow.PRENOM;
                frmAd.IdAdherent = currentAdhRow.IDADHERENT;
                frmAd.ShowDialog();
            }
        }

        private void frmAdherents_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listAdherent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.listAdherentTableAdapter.Fill(this.cda28_bd3DataSet.listAdherent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            decimal? nbAdherents = listAdherentTableAdapter.CountAdherent();
            if (nbAdherents > 0)
            {
                lblTotalAd.Text = nbAdherents.ToString();
            }
            else
            {
                lblTotalAd.Text = "aucun adhérent";
            }

        }

        private void btActualiser_Click(object sender, EventArgs e)
        {
            // Ré-actualisation des DataTables
            Fill_DataTables();
        }


        private void btSupprimer_Click(object sender, EventArgs e)
        {

            // Vérifier si il y a un enregistrement courant
            if (listAdherentBindingSource.Current != null)
            {

                // Demande confirmation Suppression
                if (MessageBox.Show(String.Format(Properties.Resources.TXT_SUPP, textPrenom.Text, textNom.Text), String.Format(Properties.Resources.TITRE_SUPP, textPrenom.Text, textNom.Text), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    // Récupération de l'enregistrement courant
                    cda28_bd3DataSet.listAdherentRow currentRow = (cda28_bd3DataSet.listAdherentRow)((DataRowView)listAdherentBindingSource.Current).Row;
                    try
                    {
                        //long? count = adherentTableAdapter.CountAdherent(currentRow.NOM, currentRow.PRENOM, currentRow.DNAISSANCE);
                        //if (count == 0) { 
                        // Suppression de l'enregistrement courant dans le SGBD
                        int nb = adherentTableAdapter.SuppressionQuery(currentRow.IDADHERENT, currentRow.NOM);

                        // On teste si la ligne a bien été supprimée
                        if (nb == 0)
                        {
                            // Affichage d'un message d'erreur
                            MessageBox.Show(Properties.Resources.TXT_ERRSUPP, Properties.Resources.TITRE_ERRSUPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        MessageBox.Show(String.Format(Properties.Resources.TXT_OKSUP, textPrenom.Text, textNom.Text), Properties.Resources.TITRE_OKSUP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception)
                    {
                        MessageBox.Show(String.Format(Properties.Resources.TXT_SUPPIMPOSSIBLE, textPrenom.Text, textNom.Text), Properties.Resources.TITRE_SUPPIMPOSSIBLE, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    // Ré-actualisation de la DataGridView
                    Fill_DataTables();
                }
            }
        }

        private void btMaj_Click(object sender, EventArgs e)
        {
            textNom.Enabled = true;
            textPrenom.Enabled = true;
            textAd1.Enabled = true;
            textAd2.Enabled = true;
            textCP.Enabled = true;
            textEmail.Enabled = true;
            textTel.Enabled = true;
            textVille.Enabled = true;
            dtpDNaiss.Enabled = true;
            dtpAdh.Enabled = true;
            ckbxOrg.Enabled = true;
            btModifier.Enabled = true;
            btAjouter.Enabled = false;
            btModifier.BackColor = Color.DarkRed;
            btAjouter.BackColor = Color.FromArgb(190, 183, 165);

        }

        private void btAd_Click(object sender, EventArgs e)
        {
            textNom.Enabled = true;
            textPrenom.Enabled = true;
            textAd1.Enabled = true;
            textAd2.Enabled = true;
            textCP.Enabled = true;
            textEmail.Enabled = true;
            textTel.Enabled = true;
            textVille.Enabled = true;
            dtpDNaiss.Enabled = true;
            dtpAdh.Enabled = true;
            ckbxOrg.Enabled = true;
            btModifier.Enabled = false;

            btModifier.BackColor = Color.FromArgb(190, 183, 165);
            textNom.Clear();
            textPrenom.Clear();
            textAd1.Clear();
            textAd2.Clear();
            textCP.Clear();
            textEmail.Clear();
            textTel.Clear();
            textVille.Clear();
            dtpAdh.Value = DateTime.Now;
            dtpDNaiss.Value = DateTime.Now;
            btAjouter.Enabled = true;
            btAjouter.BackColor = Color.DarkRed;
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (listAdherentBindingSource.Current != null)
            {
                // Récupération de l'enregistrement courant
                cda28_bd3DataSet.listAdherentRow currentRow = (cda28_bd3DataSet.listAdherentRow)((DataRowView)listAdherentBindingSource.Current).Row;
                int age = DateTime.Now.Year - dtpDNaiss.Value.Year;
                if (age < 16)
                {
                    MessageBox.Show(Properties.Resources.TXT_AGE, Properties.Resources.TITRE_AGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (String.IsNullOrWhiteSpace(textNom.Text) || String.IsNullOrWhiteSpace(textPrenom.Text))
                    {
                        if (String.IsNullOrWhiteSpace(textNom.Text) == true)
                        {
                            MessageBox.Show(Properties.Resources.TXT_VALNOM, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            textNom.Select();
                            textNom.Focus();
                            return;
                        }
                        else
                        {
                            MessageBox.Show(Properties.Resources.TXT_VALPRENOM, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            textPrenom.Select();
                            textPrenom.Focus();
                            return;
                        }
                    }
                    else
                    {




                        // On teste si un utilisateur portant les mêmes noms, prénoms et date de naissance existe dèja dans le SGBD (avec un ID différent !!)
                        var countadh = adherentTableAdapter.CountAdherentModif(currentRow.IDADHERENT, textNom.Text, textPrenom.Text, dtpDNaiss.Value, textAd1.Text,
                                                         textAd2.Text,
                                                         textCP.Text,
                                                         textVille.Text,
                                                         textEmail.Text,
                                                         textTel.Text,
                                                         dtpAdh.Value);

                        if (Convert.ToInt32(countadh) == 0)
                        {
                            int orgNew = ckbxOrg.Checked ? 1 : 0;
                            // On teste si l'adresse mail est valide
                            if (String.IsNullOrWhiteSpace(textCP.Text) == false && ValidMail(textEmail.Text) == false)
                            {
                                MessageBox.Show(Properties.Resources.TXT_VALEMAIL, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textEmail.Select();
                                textEmail.Focus();
                                return;
                            }
                            //on teste la validité du format du code postal
                            if (String.IsNullOrWhiteSpace(textCP.Text) == false && ValidCpost(textCP.Text) == false)
                            {
                                MessageBox.Show(Properties.Resources.TXT_VALCP, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textCP.Select();
                                textCP.Focus();
                                return;
                            }

                            if (String.IsNullOrWhiteSpace(textTel.Text) == false && PhoneNumber.IsPhoneNbr(textTel.Text) == false)
                            {
                                MessageBox.Show(Properties.Resources.TXT_TEL, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textTel.Select();
                                textTel.Focus();
                                return;
                            }

                            int nbadh = adherentTableAdapter.MajAdherentRequette(
                                                                     textNom.Text,
                                                                     textPrenom.Text,
                                                                     dtpDNaiss.Value,
                                                                     textAd1.Text,
                                                                     textAd2.Text,
                                                                     textCP.Text,
                                                                     textVille.Text,
                                                                     textEmail.Text,
                                                                     textTel.Text,
                                                                     dtpAdh.Value,
                                                                     orgNew,
                                                                     currentRow.IDADHERENT,
                                                                     currentRow.NOM,
                                                                     currentRow.PRENOM,
                                                                     currentRow.DNAISSANCE,
                                                                     currentRow.ADRESSE1,
                                                                     currentRow.ADRESSE2,
                                                                     currentRow.CDPOST,
                                                                     currentRow.VILLE,
                                                                     currentRow.EMAIL,
                                                                     currentRow.TELEPHONE,
                                                                     currentRow.DADHESION,
                                                                     currentRow.ORGANISATEUR
                                                                     );

                            // On modifie l'utilisateur

                            //On teste si la ligne a bien été modifiée
                            if (nbadh == 0)
                            {
                                // Affichage d'un message d'erreur
                                MessageBox.Show(Properties.Resources.TXT_ERRMODIF, Properties.Resources.TITRE_ERRMODIF, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            MessageBox.Show(String.Format(Properties.Resources.TXT_OKMODIF, textPrenom.Text, textNom.Text), Properties.Resources.TITRE_OKMODIF, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Ré - actualisation des DataTables
                            Fill_DataTables();
                        }
                        else
                        {
                            MessageBox.Show(String.Format(Properties.Resources.TXT_ERRDOUBL, textPrenom.Text, textNom.Text), Properties.Resources.TITRE_ERRDOUBL, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dtpDNaiss.Value.Year;
            if (age < 16)
            {
                MessageBox.Show(Properties.Resources.TXT_AGE, Properties.Resources.TITRE_AGE, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // on controle que les noms, prenoms et emails soient bien saisis
                if (String.IsNullOrWhiteSpace(textNom.Text) || String.IsNullOrWhiteSpace(textPrenom.Text))
                {
                    if (String.IsNullOrWhiteSpace(textNom.Text) == true)
                    {
                        MessageBox.Show(Properties.Resources.TXT_VALNOM, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textNom.Select();
                        textNom.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.TXT_VALPRENOM, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        textPrenom.Select();
                        textPrenom.Focus();
                        return;
                    }
                }
                else
                {
                    Controles(); // fonction Controle des saisies non obligatoires
                    // On teste si un utilisateur portant les mêmes noms, prénoms et date de naissance existe dèja dans le SGBD
                    var countadh = adherentTableAdapter.CountAdherent(textNom.Text, textPrenom.Text, dtpDNaiss.Value);
                    if (Convert.ToInt32(countadh) == 0)
                    {
                        // On teste si la CheckBox null est cochée.
                        int org = ckbxOrg.Checked ? 1 : 0;
                        // On teste si l'adresse mail est valide


                        // On ajoute l'utilisateur
                        int nbadh = adherentTableAdapter.Insert(textNom.Text, textPrenom.Text, dtpDNaiss.Value, textAd1.Text, textAd2.Text, textCP.Text, textVille.Text, textEmail.Text,
                                                              textTel.Text, dtpAdh.Value, (byte?)org);
                        // On teste si la ligne a bien été ajoutée
                        if (nbadh == 0)
                        {
                            // Affichage d'un message d'erreur
                            MessageBox.Show(Properties.Resources.TXT_ERRADDAD, Properties.Resources.TITRE_ERRADDAD, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show(String.Format(Properties.Resources.TXT_OKAJOUT, textPrenom.Text, textNom.Text), Properties.Resources.TITRE_OKAJOUT, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Ré-actualisation des DataTables
                        Fill_DataTables();
                    }

                    else
                    {
                        MessageBox.Show(String.Format(Properties.Resources.TXT_ERRDOUBL, textPrenom.Text, textNom.Text),
                            Properties.Resources.TITRE_ERRDOUBL, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }


        #region Mes Fonctions

        private void Fill_DataTables()
        {
            // Chargement de la vue liste des adhérents à partir du SGBD
            this.listAdherentTableAdapter.Fill(this.cda28_bd3DataSet.listAdherent);

        }

        private void Controles()
        {
            if (String.IsNullOrWhiteSpace(textCP.Text) == false && ValidMail(textEmail.Text) == false)
            {
                MessageBox.Show(Properties.Resources.TXT_VALEMAIL, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEmail.Select();
                textEmail.Focus();
                return;
            }
            //on teste la validité du format du code postal
            if (String.IsNullOrWhiteSpace(textCP.Text) == false && ValidCpost(textCP.Text) == false)
            {
                MessageBox.Show(Properties.Resources.TXT_VALCP, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCP.Select();
                textCP.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(textTel.Text) == false && PhoneNumber.IsPhoneNbr(textTel.Text) == false)
            {
                MessageBox.Show(Properties.Resources.TXT_TEL, Properties.Resources.TITRE_CHAMPOBLIGATOIRE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textTel.Select();
                textTel.Focus();
                return;
            }
        }

        //Fonction validité mail
        private bool ValidMail(string mail_address)
        {
            Regex myRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
            return myRegex.IsMatch(mail_address);
        }

        private bool ValidCpost(string codePostal)
        {
            Regex testCp = new Regex("^(([0-8][0-9])|(9[0-5])|(2[ab]))[0-9]{3}$");
            return testCp.IsMatch(codePostal);
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
        #endregion Mes Fonctions




    }
}

