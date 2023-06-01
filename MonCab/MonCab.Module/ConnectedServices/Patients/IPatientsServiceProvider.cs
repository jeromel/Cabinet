using MonCab.Module.Models;

namespace MonCab.Module.ConnectedServices.Patients
{
    public interface IPatientsServiceProvider
    {
        Task<Medecin[]> GetMedecinAsync();
        Task<Patient[]> GetPatientAsync();
    }
}