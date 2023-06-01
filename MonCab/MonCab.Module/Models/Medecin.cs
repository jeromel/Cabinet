using System;

namespace MonCab.Module.Models
{
    public record Medecin (Guid Id, string Nom, ICollection<string> NomsPatients, Int32 NombrePatients)
    {
    }
}
