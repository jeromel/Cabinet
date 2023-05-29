using System.Threading.Tasks;
using System;
using MonCab.Module.Data;

namespace MonCab.Module.Services
{
    public class MedecinService
    {
        private static readonly string[] Medecins = new[]
        {
            "Dr Freezing", "Dr Bracing", "Dr Chilly", "Dr Cool", "Dr Mild", "Dr Warm", "Dr Balmy", "Dr Hot", "Dr Sweltering", "Dr Scorching"
        };

        private static readonly string[] Prenoms = new[]
        {
            "David", "Paola", "Alain", "Jérôme", "Mickael", "Pierre-Louis", "Isabelle", "Hélène", "Karim", "Moussa", "Anne", "Véronique", "Marguerite", "Lila"
        };

        private static readonly string[] Noms = new[]
        {
            "Durand", "Dupont", "Deniès", "Lerond", "Leguerec", "Arkano", "Turnutin", "Bobo", "Marnottin", "Valor", "Scapin", "Butago"
        };

        public Task<Medecin[]> GetMedecinAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 15).Select(index => new Medecin
            (
                Medecins[rng.Next(Medecins.Length)],
                Enumerable.Range(1, rng.Next(1, 10)).Select(index => Noms[rng.Next(Noms.Length)]).ToList(),
                rng.Next(1, 10)
            )).ToArray());
        }
    }
}
