using System.Threading.Tasks;
using System;
using MonCab.Module.Data;

namespace MonCab.Module.Services
{
    public class PatientService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Prenoms = new[]
        {
            "David", "Paola", "Alain", "Jérôme", "Mickael", "Pierre-Louis", "Isabelle", "Hélène", "Karim", "Moussa", "Anne", "Véronique", "Marguerite", "Lila"
        };

        private static readonly string[] Noms = new[]
        {
            "Durand", "Dupont", "Deniès", "Lerond", "Leguerec", "Arkano", "Turnutin"
        };

        public Task<Patient[]> GetPatientAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 15).Select(index => new Patient
            {
                Date = startDate.AddDays(index),
                Nom = Noms[rng.Next(Noms.Length)],
                Prenom = Prenoms[rng.Next(Prenoms.Length)],
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
