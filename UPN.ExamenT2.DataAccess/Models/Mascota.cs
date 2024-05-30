namespace UPN.ExamenT2.Repository.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int DueñoId { get; set; }
        public Dueño Dueño { get; set; }


    }
}
