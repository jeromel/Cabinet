using System;

namespace MonCab.Module.Models
{
    public record Medecin (string Nom, ICollection<string> NomsPatients, Int32 NombrePatients)
    {
    }
}
