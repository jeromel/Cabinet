using MonCab.Module.ConnectedServices.Patients;
using MonCab.Module.Models;

namespace MonCab.Module.Services.PatientService
{
    public class MedecinService : IMedecinService
 {
  private readonly IPatientsServiceProvider patientServiceProvider;

  public MedecinService(IPatientsServiceProvider patientServiceProvider)
  {
   this.patientServiceProvider = patientServiceProvider;
  }

  public async Task<Medecin[]> GetMedecinAsync()
  {
   return await patientServiceProvider.GetMedecinAsync();
  }
 }
}
