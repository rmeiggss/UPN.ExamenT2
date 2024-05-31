using UPN.ExamenT2.CrossCutting.Utiles;
using UPN.ExamenT2.Repository.Context;
using UPN.ExamenT2.Repository.Models;

namespace UPN.ExamenT2.Repository.Repository
{
    public class DuenhoRepository
    {
        public void Guardar(Duenho duenho)
        {
            var lastId = StaticContext.des_DuenhoData.Count > 0 ? StaticContext.des_DuenhoData.Last().Id : 0;
            lastId++;

            duenho.Id = lastId;
            
            StaticContext.des_DuenhoData.Add(duenho);
        }

        public List<Duenho> Listar()
        {
            return StaticContext.des_DuenhoData;
        }

        public Duenho BuscarPorId(int id)
        {
            var des_DuenhoArrayData = StaticContext.des_DuenhoData.Select(s => s.Id).ToArray();

            var index = AlgoritmosBusqueda.BusquedaSecuencial(des_DuenhoArrayData, id);

            if (index == -1)
            {
                return null!;
            }

            return StaticContext.des_DuenhoData[index];
        }

        public List<Duenho> BuscarPorNombre(string nombre)
        {
            var result = StaticContext.des_DuenhoData.Where(x => x.Nombre.ToLower().Contains(nombre.ToLower())).ToList();
            return result;
        }

        public void Eliminar(int id)
        {
            StaticContext.des_DuenhoData.Remove(BuscarPorId(id));
        }

        public void Actualizar(Duenho duenho)
        {
            var duenhoActual = BuscarPorId(duenho.Id);
            duenhoActual.Nombre = duenho.Nombre;
            duenhoActual.Direccion = duenho.Direccion;
            duenhoActual.Telefono = duenho.Telefono;
        }
    }
}
