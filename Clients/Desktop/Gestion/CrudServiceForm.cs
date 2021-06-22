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

namespace Desktop.Gestion
{
    public partial class CrudServiceForm : Form
    {
        private readonly IRestaurantService _restaurantService;
        public bool isCreation = false;
        Service currentService;
        public CrudServiceForm()
        {
            InitializeComponent();
        }

        public void Initialize(Service service =null)
        {
            if (service == null)
            {
                currentService = new Service();
                //creation
                isCreation = true;
                //creation
                currentService.Date = serviceDateTP.Value;
                if (MidiCheckBox.Checked)
                {
                    currentService.Midi = true;
                }
                else
                {
                    currentService.Midi = false;
                }
               // dessertCBox.SelectedIndex = currentService.ListPlats.

            }
            else
            {
                //modif
                currentService = service;
                ActionCrudServiceBtn.Text = "Modifier";
                label1.Text = service.Date.ToString("dd MMMM yyyy");
                serviceDateTP.Value = service.Date;
                if (service.Midi)
                {
                    MidiCheckBox.Checked = true;
                    SoirCheckBox.Checked = false;
                }
                else
                {
                    SoirCheckBox.Checked = true;
                    MidiCheckBox.Checked = false;
                }




            }
        }
    }

}
