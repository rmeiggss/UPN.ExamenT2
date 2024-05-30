namespace UPN.ExamenT2.Repository.Models
{
    public class Dueño
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public List<Mascota> Mascotas { get; set; }
    }
}
