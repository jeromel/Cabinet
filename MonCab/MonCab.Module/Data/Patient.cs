using System;

namespace MonCab.Module.Data
{
    public class Patient
    {
        public DateTime Date { get; set; }

        public string Nom { get; set;}

        public string Prenom { get; set; }

        public string? Summary { get; set; }
    }
}
