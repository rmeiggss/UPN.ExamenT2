using UPN.ExamenT2.Repository.Models;

namespace UPN.ExamenT2.Repository.Context
{
    public class StaticContext
    {
        public StaticContext() { }

        public static List<Duenho> des_DuenhoData = new List<Duenho>()!;
        public static List<Mascota> des_MascotaData = new List<Mascota>()!;
    }
}
