using UPN.ExamenT2.CrossCutting.Utiles;
using UPN.ExamenT2.Repository.Context;
using UPN.ExamenT2.Repository.Models;

namespace UPN.ExamenT2.Repository.Repository
{
    public class MascotaRepository
    {
        public void Guardar(Mascota duenho)
        {
            var lastId = StaticContext.des_MascotaData.Count > 0 ? StaticContext.des_MascotaData.Last().Id : 0;
            lastId++;

            duenho.Id = lastId;

            StaticContext.des_MascotaData.Add(duenho);
        }

        public List<Mascota> Listar()
        {
            var result = (from ma in StaticContext.des_MascotaData
                          join du in StaticContext.des_DuenhoData on ma.DuenhoId equals du.Id
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
            var des_MascotaArrayData = StaticContext.des_DuenhoData.Select(s => s.Id).ToArray();

            var index = AlgoritmosBusqueda.BusquedaSecuencial(des_MascotaArrayData, id);

            if (index == -1)
            {
                return null!;
            }

            return StaticContext.des_MascotaData[index];
        }

        public List<Mascota> BuscarPorNombre(string nombre)
        {
            var result = StaticContext.des_MascotaData.Where(x => x.Nombre.ToLower().Contains(nombre.ToLower())).ToList();
            return result;
        }

        public void Eliminar(int id)
        {
            StaticContext.des_MascotaData.Remove(BuscarPorId(id));
        }

        public void Actualizar(Mascota mascota)
        {
            var des_mascotaActual = BuscarPorId(mascota.Id);
            des_mascotaActual.Nombre = mascota.Nombre;
            des_mascotaActual.Edad = mascota.Edad;
            des_mascotaActual.Raza = mascota.Raza;
            des_mascotaActual.DuenhoId = mascota.DuenhoId;
        }

        

    }
}
