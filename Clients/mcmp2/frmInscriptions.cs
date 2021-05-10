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
    public partial class frmInscriptions : Form
    {
        public frmInscriptions()
        {
            InitializeComponent();
        }

        private void frmInscriptions_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listeInscriptionsAvecActetAdh'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listeInscriptionsAvecActetAdhTableAdapter.Fill(this.cda28_bd3DataSet.listeInscriptionsAvecActetAdh);
            // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listActType'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.listActTypeTableAdapter.Fill(this.cda28_bd3DataSet.listActType);

        }

        private void listActTypeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //Récupération de la ligne courante
            if (listActTypeBindingSource.Current != null)
            {
                cda28_bd3DataSet.listActTypeRow currentActRow = (cda28_bd3DataSet.listActTypeRow)((DataRowView)listActTypeBindingSource.Current).Row;
                // On renseigne les DataTables 'listeInscriptionsAvecActetAdh' et 'listAdhNOTINInscr' avec IDACTIVITE courant
                listeInscriptionsAvecActetAdhTableAdapter.FillByIdAct(cda28_bd3DataSet.listeInscriptionsAvecActetAdh, currentActRow.IDACTIVITE);
                listAdhNOTINInscrTableAdapter.Fill(cda28_bd3DataSet.listAdhNOTINInscr, currentActRow.IDACTIVITE);
            }
            else
            {
                // On vide les DataTables 'listeInscriptionsAvecActetAdh' et 'listAdhNOTINInscr'
                cda28_bd3DataSet.listeInscriptionsAvecActetAdh.Clear();
                cda28_bd3DataSet.listAdhNOTINInscr.Clear();
            }
        }

        private void iconActualiser_Click(object sender, EventArgs e)
        {
            listActTypeTableAdapter.Fill(this.cda28_bd3DataSet.listActType);
        }

        private void iconButtonAjouterAdherents_Click(object sender, EventArgs e)
        {
            if (listActTypeBindingSource.Current != null && listAdhNOTINInscrBindingSource.Current != null)
            {
                // On récupère l'activité courante
                cda28_bd3DataSet.listActTypeRow currentActRow = (cda28_bd3DataSet.listActTypeRow)((DataRowView)listActTypeBindingSource.Current).Row;
                // On récupère l'adherent courant
                cda28_bd3DataSet.listAdhNOTINInscrRow currentAdherentRow = (cda28_bd3DataSet.listAdhNOTINInscrRow)((DataRowView)listAdhNOTINInscrBindingSource.Current).Row;
                // ON verifie si l'adhérent est déja inscrit à une activité ce jour là
                long? InscrExist = (long?)listeInscriptionsAvecActetAdhTableAdapter.InscrExist(currentAdherentRow.IDADHERENT, currentActRow.DDEBUT);
                decimal? nbParticipation = listeInscriptionsAvecActetAdhTableAdapter.CountInscr(currentActRow.IDACTIVITE);
                //on Verifie si l'adherent n'est pas déjà inscrit à l'activité
                if (InscrExist == 0)
                {
                    //On teste si le nombre nombre maximum d'adhérent n'est pas atteint
                    if (currentActRow.NBLIMITE <= nbParticipation )
                    {
                        MessageBox.Show(Properties.Resources.TXT_PARTICIPANTMAX, Properties.Resources.TITRE_PARTICIPANTMAX, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ////On teste si la date limite d'inscription n'est pas atteinte
                    else if (currentActRow.DLIMITEINSCRIPTION <= DateTime.Today)
                    {
                        MessageBox.Show(Properties.Resources.TXT_DLIMITE, Properties.Resources.TITRE_DLIMITE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        // on récupére le nombre de participants saisi dans le numericUpDown
                        int? part = Convert.ToInt32(numUpPart.Value);
                        //on crée l'inscription
                        int nbadh = inscriptionTableAdapter.Insert(currentAdherentRow.IDADHERENT, currentActRow.IDACTIVITE, DateTime.Today, part);
                        // On teste le nombre d'inscriptions créés
                        if (nbadh == 0)
                        {
                            MessageBox.Show(String.Format(Properties.Resources.TXT_OKAJOUTINSCRIPTION, currentAdherentRow.PRENOM, 
                                currentAdherentRow.NOM, currentActRow.INTITULEACTIVITE),
                                Properties.Resources.TITRE_OKAJOUTINSCRIPTION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    // Affichage d'un message d'erreur
                    MessageBox.Show(Properties.Resources.TXT_DEJAINSCRIT, Properties.Resources.TITRE_DEJAINSCRIT, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //  On synchronise les vues 'listeInscriptionsAvecActetAdh' et 'listAdhNOTINInscr' avec IDACTIVITE courant
                listeInscriptionsAvecActetAdhTableAdapter.FillByIdAct(cda28_bd3DataSet.listeInscriptionsAvecActetAdh, currentActRow.IDACTIVITE);
                listAdhNOTINInscrTableAdapter.Fill(cda28_bd3DataSet.listAdhNOTINInscr, currentActRow.IDACTIVITE);
            }
        }

        private void iconBtnSuppr_Click(object sender, EventArgs e)
        {
            // Vérifier si il y a un enregistrement courant
            if (listActTypeBindingSource.Current != null && listeInscriptionsAvecActetAdhBindingSource.Current != null)
            {
                // On récupère l'activité courante
                cda28_bd3DataSet.listActTypeRow currentActRow = (cda28_bd3DataSet.listActTypeRow)((DataRowView)listActTypeBindingSource.Current).Row;
                // On récupère l'adherent courant
                cda28_bd3DataSet.listeInscriptionsAvecActetAdhRow currentInscrRow = (cda28_bd3DataSet.listeInscriptionsAvecActetAdhRow)((DataRowView)listeInscriptionsAvecActetAdhBindingSource.Current).Row;

                // Demande confirmation Suppression
                if (MessageBox.Show(Properties.Resources.TXT_SUPP, String.Format(Properties.Resources.TITRE_SUPP, currentInscrRow.NOM, currentInscrRow.PRENOM),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                   // Suppression de l'enregistrement courant dans le SGBD
                    int sup = inscriptionTableAdapter.SuppressionInscription(currentInscrRow.IDINSCRIPTION);

                    // On teste si la ligne a bien été supprimée
                    if (sup == 0)
                    {
                        // Affichage d'un message d'erreur
                        MessageBox.Show(Properties.Resources.TXT_ERRSUPP, Properties.Resources.TITRE_ERRSUPP, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   //  On synchronise les vues 'listeInscriptionsAvecActetAdh' et 'listAdhNOTINInscr' avec IDACTIVITE courant
                    listeInscriptionsAvecActetAdhTableAdapter.FillByIdAct(cda28_bd3DataSet.listeInscriptionsAvecActetAdh, currentActRow.IDACTIVITE);
                    listAdhNOTINInscrTableAdapter.Fill(cda28_bd3DataSet.listAdhNOTINInscr, currentActRow.IDACTIVITE);
                }
            }
        }

        private void listeInscriptionsAvecActetAdhBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            cda28_bd3DataSet.listActTypeRow currentActRow = (cda28_bd3DataSet.listActTypeRow)((DataRowView)listActTypeBindingSource.Current).Row;
            decimal? nbParticipation = listeInscriptionsAvecActetAdhTableAdapter.CountInscr(currentActRow.IDACTIVITE);
            if (nbParticipation > 0) 
            {
               
            

               if (nbParticipation >= currentActRow.NBLIMITE)
                {
                    llblparticipants.Text = "complet";
                }
                else
                {
                    llblparticipants.Text = nbParticipation.ToString();
                }
            }
            else
            {
                llblparticipants.Text = "aucun inscrit";
            }

        
        }

        
    }
}
