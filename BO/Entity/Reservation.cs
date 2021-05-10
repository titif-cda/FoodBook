using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entity
{
    public class Reservation
    {
        public int? IdResa { get; set; }
        public int? IdClient { get; set; }
        public int? IdMenu { get; set; }
        public DateTime DateResa { get; set; }
        public int? NbResa { get; set; }
        public bool FormMatin { get; set; }
        public bool FormMidi { get; set; }
        public bool FormSoir { get; set; }

        public Reservation()
        {
        }

        public Reservation(int? idResa, int? idClient, int? idMenu, DateTime dateResa, int? nbResa, bool formMatin, bool formMidi, bool formSoir)
        {
            IdResa = idResa;
            IdClient = idClient;
            IdMenu = idMenu;
            DateResa = dateResa;
            NbResa = nbResa;
            FormMatin = formMatin;
            FormMidi = formMidi;
            FormSoir = formSoir;
        }

        public override bool Equals(object obj)
        {
            return obj is Reservation resa &&
                IdResa == resa.IdResa &&
                IdClient == resa.IdClient &&
                IdMenu == resa.IdMenu &&
                DateResa == resa.DateResa &&
                NbResa == resa.NbResa &&
                FormMatin == resa.FormMatin &&
                FormMidi == resa.FormMidi &&
                FormSoir == resa.FormSoir;
            
        }

        public override int GetHashCode()
        {
                return HashCode.Combine(IdResa,IdClient,IdMenu,DateResa,NbResa,FormMatin,FormMidi,FormSoir);
        }
    }
}
