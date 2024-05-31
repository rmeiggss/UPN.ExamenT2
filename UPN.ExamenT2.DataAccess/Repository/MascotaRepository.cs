using UPN.ExamenT2.CrossCutting.Utiles;
using UPN.ExamenT2.Repository.Context;
using UPN.ExamenT2.Repository.Models;

namespace UPN.ExamenT2.Repository.Repository
{
    public class MascotaRepository
    {
        public void Guardar(Mascota duenho)
        {
            var pd_lastId = StaticContext.pd_MascotaData.Count > 0 ? StaticContext.pd_MascotaData.Last().Id : 0;
            pd_lastId++;

            duenho.Id = pd_lastId;

            StaticContext.pd_MascotaData.Add(duenho);
        }

        public List<Mascota> Listar()
        {
            var result = (from ma in StaticContext.pd_MascotaData
                          join du in StaticContext.pd_DuenhoData on ma.DuenhoId equals du.Id
                          select new Mascota()
                          {
                              Id = ma.Id,
                              Nombre = ma.Nombre,
                              Raza = ma.Raza,
                              Edad = ma.Edad,
                              DuenhoId = ma.DuenhoId,
                              Duenho = du
                          }
                          ).ToList();
            return result;
        }

        public Mascota BuscarPorId(int id)
        {
            var pd_MascotaArrayData = StaticContext.pd_DuenhoData.Select(s => s.Id).ToArray();

            var index = AlgoritmosBusqueda.BusquedaSecuencial(pd_MascotaArrayData, id);

            if (index == -1)
            {
                return null!;
            }

            return StaticContext.pd_MascotaData[index];
        }

        public List<Mascota> BuscarPorNombre(string nombre) => StaticContext.pd_MascotaData.Where(x => x.Nombre.ToLower().Contains(nombre.ToLower())).ToList();

        public void Eliminar(int id)
        {
            StaticContext.pd_MascotaData.Remove(BuscarPorId(id));
        }

        public void Actualizar(Mascota mascota)
        {
            var pd_mascotaActual = BuscarPorId(mascota.Id);
            pd_mascotaActual.Nombre = mascota.Nombre;
            pd_mascotaActual.Edad = mascota.Edad;
            pd_mascotaActual.Raza = mascota.Raza;
            pd_mascotaActual.DuenhoId = mascota.DuenhoId;
        }

        

    }
}
