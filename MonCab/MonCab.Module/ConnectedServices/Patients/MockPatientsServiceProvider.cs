using MonCab.Module.Models;
using System.Collections.ObjectModel;

namespace MonCab.Module.ConnectedServices.Patients
{
 public class MockPatientsServiceProvider : IPatientsServiceProvider
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
            "Durand", "Dupont", "Deniès", "Lerond", "Leguerec", "Arkano", "Turnutin"
        };


  private ICollection<Patient> _patients = new ObservableCollection<Patient>();
  private ICollection<Medecin> _medecins = new ObservableCollection<Medecin>();

  public MockPatientsServiceProvider()
  {
   Initialize();
  }


  private void Initialize()
  {
   var startDate = DateTime.Now;

   var rng = new Random();

   _medecins = Enumerable.Range(1, 15).Select(index => new Medecin
   (
       Guid.NewGuid(),
       Medecins[rng.Next(Medecins.Length)],
       Enumerable.Range(1, rng.Next(1, 10)).Select(index => Noms[rng.Next(Noms.Length)]).ToList(),
       rng.Next(1, 10)
   )).ToArray();

   foreach (var med in _medecins)
   {
    var pat = new Patient()
    {
     DateNaissance = startDate.AddDays(rng.Next(0,28)).AddYears(-rng.Next(0,18)),
     Nom = Noms[rng.Next(Noms.Length)],
     Prenom = Prenoms[rng.Next(Prenoms.Length)],
     NomMedecin = Medecins[rng.Next(Medecins.Length)],
     DatePriseEnCharge = startDate.AddDays(-rng.Next(0,365)),
    };

    _patients.Add(pat);
   }
  }

  public Task<ICollection<Patient>> GetPatientAsync()
  {
   return Task.FromResult(_patients);
  }
  public Task<ICollection<Medecin>> GetMedecinAsync()
  {
   return Task.FromResult(_medecins);
  }
 }
}
