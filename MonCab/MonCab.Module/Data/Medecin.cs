using System;

namespace MonCab.Module.Data
{
    public record Medecin (string Nom, ICollection<string> NomsPatients, Int32 NombrePatients)
    {
    }
}
