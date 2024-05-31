using UPN.ExamenT2.CrossCutting.Utiles;
using UPN.ExamenT2.Repository.Context;
using UPN.ExamenT2.Repository.Models;

namespace UPN.ExamenT2.Repository.Repository
{
    public class DuenhoRepository
    {
        public void Guardar(Duenho duenho)
        {
            var pd_lastId = StaticContext.pd_DuenhoData.Count > 0 ? StaticContext.pd_DuenhoData.Last().Id : 0;
            pd_lastId++;

            duenho.Id = pd_lastId;
            
            StaticContext.pd_DuenhoData.Add(duenho);
        }

        public List<Duenho> Listar()
        {
            return StaticContext.pd_DuenhoData;
        }

        public Duenho BuscarPorId(int id)
        {
            var pd_DuenhoArrayData = StaticContext.pd_DuenhoData.Select(s => s.Id).ToArray();

            var pd_index = AlgoritmosBusqueda.BusquedaSecuencial(pd_DuenhoArrayData, id);

            if (pd_index == -1)
            {
                return null!;
            }

            return StaticContext.pd_DuenhoData[pd_index];
        }

        public List<Duenho> BuscarPorNombre(string nombre)
        {
            var pd_result = StaticContext.pd_DuenhoData.Where(x => x.Nombre.ToLower().Contains(nombre.ToLower())).ToList();
            return pd_result;
        }

        public void Eliminar(int id)
        {
            StaticContext.pd_DuenhoData.Remove(BuscarPorId(id));
        }

        public void Actualizar(Duenho duenho)
        {
            var pd_duenhoActual = BuscarPorId(duenho.Id);
            pd_duenhoActual.Nombre = duenho.Nombre;
            pd_duenhoActual.Direccion = duenho.Direccion;
            pd_duenhoActual.Telefono = duenho.Telefono;
        }
    }
}
