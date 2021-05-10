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
    public partial class frmActivites : Form
    {
        public frmActivites()
        {
            InitializeComponent();
        }

        private void btSuivi_Click(object sender, EventArgs e)
        {
            cda28_bd3DataSet.listActTypeRow  currentActRow = (cda28_bd3DataSet.listActTypeRow)((DataRowView)listActTypeBindingSource.Current).Row;
            using (frmActInscriptions frmAct = new frmActInscriptions())
            {
                frmAct.IdActivite = currentActRow.IDACTIVITE;
                frmAct.lblNomAct.Text = currentActRow.INTITULEACTIVITE;
                frmAct.lblDateAct.Text = currentActRow.DDEBUT.ToString("d");
                
                frmAct.ShowDialog();
            }
        }

        private void frmActivites_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: cette ligne de code charge les données dans la table 'cda28_bd3DataSet.listActType'. Vous pouvez la déplacer ou la supprimer selon les besoins.
                this.listActTypeTableAdapter.Fill(this.cda28_bd3DataSet.listActType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

            

        }

       
    }
}
