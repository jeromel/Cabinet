using MonCab.Module.Models;

namespace MonCab.Module.Services.PatientService
{
 public interface IMedecinService
 {
  Task<ICollection<Medecin>> GetMedecinAsync();
 }
}