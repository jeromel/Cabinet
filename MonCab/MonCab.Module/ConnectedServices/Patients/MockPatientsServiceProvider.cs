using MonCab.Module.Models;

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


  private ICollection<Patient> patients; 
  private ICollection<Medecin> medecins;

  public MockPatientsServiceProvider()
  {
   Initialize();
  }


  private void Initialize()
  {
   var startDate = DateTime.Now;

   var rng = new Random();

   patients = Enumerable.Range(1, 15).Select(index => new Patient
   {
    DateNaissance = startDate.AddDays(index).AddYears(-index),
    Nom = Noms[rng.Next(Noms.Length)],
    Prenom = Prenoms[rng.Next(Prenoms.Length)],
    NomMedecin = Medecins[rng.Next(Medecins.Length)],
    DatePriseEnCharge = startDate.AddDays(index),

   }).ToList();

   medecins = Enumerable.Range(1, 15).Select(index => new Medecin
   (
       Medecins[rng.Next(Medecins.Length)],
       Enumerable.Range(1, rng.Next(1, 10)).Select(index => Noms[rng.Next(Noms.Length)]).ToList(),
       rng.Next(1, 10)
   )).ToArray();
  }
  
  public Task<ICollection<Patient>> GetPatientAsync()
  {
   return Task.FromResult(patients);
  }
  public Task<ICollection<Medecin>> GetMedecinAsync()
  {
   return Task.FromResult(medecins);
  }
 }
}
