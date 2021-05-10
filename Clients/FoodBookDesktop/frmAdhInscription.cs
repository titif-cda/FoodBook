using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcmp2
{
    public partial class frmAdhInscription : Form
    {
        public frmAdhInscription()
        {
            InitializeComponent();
        }

        public int IdAdherent { get; internal set; }

        private void frmAdhInscription_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listActAvenir'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listActAvenirTableAdapter.Fill(this.cda28_bd3DataSet.listActAvenir);
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listActType'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listActTypeTableAdapter.Fill(this.cda28_bd3DataSet.listActType);
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.vAnnee'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vAnneeTableAdapter.Fill(this.cda28_bd3DataSet.vAnnee);
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listeInscriptionsAvecActetAdh'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeInscriptionsAvecActetAdhTableAdapter.FillByAdherent(this.cda28_bd3DataSet.listeInscriptionsAvecActetAdh, IdAdherent);
            this.vAnneeBindingSource.Position = 2;

        }

        private void comboBoxAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            //decimal anne = cBxAnnee.;
            decimal annee = Convert.ToDecimal(comboBoxAnnee.SelectedValue);


            inscriptionAnneeTableAdapter.FillbyAnnee(cda28_bd3DataSet.inscriptionAnnee, IdAdherent, annee);

        }

        private void iconButtonAjouterAdherents2_Click(object sender, EventArgs e)
        {

            //On recupere la ligne courante de l'activité de la comboBox

            cda28_bd3DataSet.listActAvenirRow currentActTypeRow = (cda28_bd3DataSet.listActAvenirRow)((DataRowView)listActAvenirBindingSource.Current).Row;
            //cda28_bd3DataSet.listActTypeRow currentActTypeRow = (cda28_bd3DataSet.listActTypeRow)((DataRowView)listActTypeBindingSource.Current).Row;
            //on teste si l'adherent n'est pas inscrit a une activité ce même jour
            long? InscrExist = (long?)listeInscriptionsAvecActetAdhTableAdapter.InscrExist(IdAdherent, currentActTypeRow.DDEBUT);
            decimal? nbParticipation = listeInscriptionsAvecActetAdhTableAdapter.CountInscr(currentActTypeRow.IDACTIVITE);
            int nbPart = Convert.ToInt32(numericUpDownPartnbPart.Value);
            if (InscrExist == 0)
            {
                if (nbParticipation > currentActTypeRow.NBLIMITE || nbPart > (currentActTypeRow.NBLIMITE - nbParticipation))
                {
                    MessageBox.Show(Properties.Resources.TXT_PARTICIPANTMAX, Properties.Resources.TITRE_PARTICIPANTMAX, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    if (currentActTypeRow.DLIMITEINSCRIPTION <= DateTime.Today && InscrExist == 0)
                    {
                        MessageBox.Show(Properties.Resources.TXT_DLIMITE, Properties.Resources.TITRE_DLIMITE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {                    // On ajoute l'utilisateur
                        int actSelect = Convert.ToInt32(cBxInscrAd.SelectedValue);
                        int nbadh = inscriptionTableAdapter.Insert(IdAdherent, actSelect, DateTime.Today, nbPart);

                        if (nbadh == 0)
                        {
                            MessageBox.Show(String.Format(Properties.Resources.TXT_OKAJOUTINSCRIPTION, lblNomAdSelect.Text, lblPrenomAdSelect.Text, currentActTypeRow.INTITULEACTIVITE), Properties.Resources.TITRE_OKAJOUTINSCRIPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                // Affichage d'un message d'erreur
                MessageBox.Show(Properties.Resources.TXT_DEJAINSCRIT, Properties.Resources.TITRE_DEJAINSCRIT, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Ré-actualisation des DataTables
            listeInscriptionsAvecActetAdhTableAdapter.FillByAdherent(cda28_bd3DataSet.listeInscriptionsAvecActetAdh, IdAdherent);


        }

        private void listActTypeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            // if (String.IsNullOrWhiteSpace(label2.Text))
            // {
            //    label2.Text= "aucune inscription";


            // }
            // else
            // {
            //    var max = Convert.ToDecimal(label2.Text.ToString());

            // //cda28_bd3DataSet.listActTypeRow currentActTypeRow = (cda28_bd3DataSet.listActTypeRow)((DataRowView)listActTypeBindingSource.Current).Row;
            // int idActSelect = Convert.ToInt32(cBxInscrAd.SelectedValue);
            //var inscrits = listeInscriptionsAvecActetAdhTableAdapter.CountInscr(idActSelect);

            // var dispo =  max - inscrits;

            // lblplaceDispo.Text = dispo.ToString();
            // }


        }

        private void iconBtnSuppr2_Click(object sender, EventArgs e)
        {
            // Vérifier si il y a un enregistrement courant
            if (listeInscriptionsAvecActetAdhBindingSource.Current != null)
            {
                // Récupération de l'enregistrement courant
                cda28_bd3DataSet.listeInscriptionsAvecActetAdhRow currentRow = (cda28_bd3DataSet.listeInscriptionsAvecActetAdhRow)((DataRowView)listeInscriptionsAvecActetAdhBindingSource.Current).Row;

                // Demande confirmation Suppression
                if (MessageBox.Show(String.Format(Properties.Resources.TXT_SUPPINSCR2, currentRow.NOM, currentRow.PRENOM, currentRow.INTITULEACTIVITE), String.Format(Properties.Resources.TITRE_SUPPINSCR), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {



                    // Suppression de l'enregistrement courant dans le SGBD
                    int nb = inscriptionTableAdapter.SuppressionInscription(currentRow.IDINSCRIPTION);

                    // On teste si la ligne a bien été supprimée
                    if (nb == 0)
                    {
                        // Affichage d'un message d'erreur
                        MessageBox.Show(Properties.Resources.TXT_ERRSUPP, Properties.Resources.TITRE_ERRSUPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show(String.Format(Properties.Resources.TXT_SUPPINSCR, currentRow.NOM, currentRow.PRENOM, currentRow.INTITULEACTIVITE), Properties.Resources.TITRE_SUPPINSCR, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Ré-actualisation de la DataGridView
                    // Ré-actualisation des DataTables
                    listeInscriptionsAvecActetAdhTableAdapter.FillByAdherent(cda28_bd3DataSet.listeInscriptionsAvecActetAdh, IdAdherent);
                }
            }
        }
    }
}
