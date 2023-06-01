using MonCab.Module.ConnectedServices.Patients;
using MonCab.Module.Models;

namespace MonCab.Module.Services.PatientService
{
    public class PatientService : IPatientService
 {
  private readonly IPatientsServiceProvider patientServiceProvider;

  public PatientService(IPatientsServiceProvider patientServiceProvider)
  {
   this.patientServiceProvider = patientServiceProvider;
  }

  public async Task<Patient[]> GetPatientAsync()
  {
   return await patientServiceProvider.GetPatientAsync();
  }
 }
}
