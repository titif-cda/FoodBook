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
    public partial class frmActInscriptions : Form
    {
        public frmActInscriptions()
        {
            InitializeComponent();
        }

        public int IdActivite { get; internal set; }

        private void frmActInscriptions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet1.vActDate'. Vous pouvez la déplacer ou la supprimer selon les besoins.
           this.vActDateTableAdapter.Fill(this.cda28_bd3DataSet.vActDate);
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.ActivitéparDate'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.activitéparDateTableAdapter.Fill(this.cda28_bd3DataSet.ActivitéparDate);


            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listeInscriptionsAvecActetAdh'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeInscriptionsAvecActetAdhTableAdapter.Fill(this.cda28_bd3DataSet.listeInscriptionsAvecActetAdh);
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listeInscriptionsAvecActetAdh'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeInscriptionsAvecActetAdhTableAdapter.FillByIdAct(cda28_bd3DataSet.listeInscriptionsAvecActetAdh, IdActivite);
            listActTypeTableAdapter.Fill(cda28_bd3DataSet.listActType);
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listAdherent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listAdherentTableAdapter.Fill(this.cda28_bd3DataSet.listAdherent);
           
            
        }

        private void dtpAct_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void iconButtonAjouterAdherents1_Click(object sender, EventArgs e)
        {
            // On teste si un utilisateur portant les mêmes noms, prénoms et date de naissance existe dèja dans le SGBD
            cda28_bd3DataSet.listActTypeRow currentActRow = (cda28_bd3DataSet.listActTypeRow)((DataRowView)listActTypeBindingSource.Current).Row;

            int valSelect = Convert.ToInt32(cBoxNom.SelectedValue);
            // ON verifie si l'adhérent est déja inscrit à une activité ce jour là
            long? InscrExist = (long?)listeInscriptionsAvecActetAdhTableAdapter.InscrExist(valSelect, currentActRow.DDEBUT);

            if (InscrExist == 0)
            {

                if (currentActRow.DLIMITEINSCRIPTION <= DateTime.Today)
                {
                    MessageBox.Show(Properties.Resources.TXT_DLIMITE, Properties.Resources.TITRE_DLIMITE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    // On ajoute l'utilisateur
                    int nbPart = Convert.ToInt32(numericUpDownPart.Value);
                    int nbadh = inscriptionTableAdapter.Insert(valSelect, currentActRow.IDACTIVITE, DateTime.Today, nbPart);
                    // On teste si la ligne a bien été ajoutée
                    if (nbadh == 0)
                    {
                        // Affichage d'un message d'erreur
                        MessageBox.Show(Properties.Resources.TXT_ERRADDAD, Properties.Resources.TITRE_ERRADDAD, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Affichage réussite

                        MessageBox.Show(String.Format(Properties.Resources.TXT_OKAJOUTINSCRIPTION2, valSelect, currentActRow.INTITULEACTIVITE), Properties.Resources.TITRE_OKAJOUTINSCRIPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                // Affichage d'un message d'erreur deja inscrit
                MessageBox.Show(Properties.Resources.TXT_DEJAINSCRIT, Properties.Resources.TITRE_DEJAINSCRIT, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Ré-actualisation des DataTables
            listeInscriptionsAvecActetAdhTableAdapter.FillByIdAct(cda28_bd3DataSet.listeInscriptionsAvecActetAdh, currentActRow.IDACTIVITE);

        }

        private void iconBtnSuppr1_Click(object sender, EventArgs e)
        {
            // Vérifier si il y a un enregistrement courant
            if (listeInscriptionsAvecActetAdhBindingSource.Current != null)
            {
                // Récupération de l'enregistrement courant
                cda28_bd3DataSet.listeInscriptionsAvecActetAdhRow currentRow = (cda28_bd3DataSet.listeInscriptionsAvecActetAdhRow)((DataRowView)listeInscriptionsAvecActetAdhBindingSource.Current).Row;


                // Demande confirmation Suppression
                if (MessageBox.Show(Properties.Resources.TXT_SUPP, String.Format(Properties.Resources.TITRE_SUPP, currentRow.NOM, currentRow.PRENOM), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes
                    )
                {
                   


                    // Suppression de l'enregistrement courant dans le SGBD
                    int nb = inscriptionTableAdapter.SuppressionInscription(currentRow.IDINSCRIPTION);

                    // On teste si la ligne a bien été supprimée
                    if (nb == 0)
                    {
                        // Affichage d'un message d'erreur
                        MessageBox.Show(Properties.Resources.TXT_ERRSUPP, Properties.Resources.TITRE_ERRSUPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show(String.Format(Properties.Resources.TXT_OKSUP, currentRow.NOM, currentRow.PRENOM ), Properties.Resources.TITRE_OKSUP, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Ré-actualisation de la DataGridView
                    this.listeInscriptionsAvecActetAdhTableAdapter.FillByIdAct(cda28_bd3DataSet.listeInscriptionsAvecActetAdh, IdActivite);
                }
            }
        }

        private void listeInscriptionsAvecActetAdhBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            decimal? nbParticipation = listeInscriptionsAvecActetAdhTableAdapter.CountInscr(IdActivite);
            lblPart.Text = nbParticipation.ToString();
        }

       

     

        private void comboBoxDates_SelectedValueChanged(object sender, EventArgs e)
        {
            //int Actselect = Convert.ToInt32(comboBoxDates.SelectedValue);
            //// listActTypeTableAdapter.FillByActivite(cda28_bd3DataSet.listActType, Actselect);
            //listActDateTableAdapter.FillByAct(cda28_bd3DataSet.listActDate, Actselect);
          DateTime Actselect = Convert.ToDateTime(comboBoxDates.SelectedValue);
            // listActTypeTableAdapter.FillByActivite(cda28_bd3DataSet.listActType, Actselect);
            listActDateTableAdapter.FillbyDate(cda28_bd3DataSet.listActDate, Actselect);
        }
    }
}
