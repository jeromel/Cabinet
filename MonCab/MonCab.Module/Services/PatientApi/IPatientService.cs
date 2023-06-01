using MonCab.Module.Models;

namespace MonCab.Module.Services.PatientService
{
 public interface IPatientService
 {
  Task<ICollection<Patient>> GetPatientAsync();
 }
}