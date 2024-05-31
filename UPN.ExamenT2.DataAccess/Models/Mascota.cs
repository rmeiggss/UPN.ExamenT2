using System.Globalization;

namespace UPN.ExamenT2.Repository.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Raza { get; set; } = string.Empty;
        public int Edad { get; set; }
        public int DuenhoId { get; set; }
        public Duenho Duenho { get; set; } = new Duenho();
        public string NombreDuenho
        {
            get
            {
                return Duenho?.Nombre ?? string.Empty;
            }
        }

        public Mascota()
        {
        }
        public Mascota(string nombre, string raza, int edad, int dueñoId)
        {
            Nombre = nombre;
            Raza = raza;
            Edad = edad;
            DuenhoId = dueñoId;
        }

    }
}
