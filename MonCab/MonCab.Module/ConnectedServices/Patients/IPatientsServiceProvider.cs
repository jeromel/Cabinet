using MonCab.Module.Models;

namespace MonCab.Module.ConnectedServices.Patients
{
    public interface IPatientsServiceProvider
    {
        Task<ICollection<Medecin>> GetMedecinAsync();
        Task<ICollection<Patient>> GetPatientAsync();
    }
}