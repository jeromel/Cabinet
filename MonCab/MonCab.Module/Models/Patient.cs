using System;

namespace MonCab.Module.Models
{
    public class Patient
    {
        public DateTime DateNaissance { get; set; }

        public string Nom { get; set;}

        public string Prenom { get; set; }

        public string? NomMedecin { get; set; }
        public DateTime DatePriseEnCharge { get; set; }

    }
}
