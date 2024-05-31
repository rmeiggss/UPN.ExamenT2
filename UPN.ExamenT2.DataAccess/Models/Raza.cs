namespace UPN.ExamenT2.Repository.Models
{
    public class Raza
    {
        public Raza(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        
    }
}
