using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPN.ExamenT2.CrossCutting.Utiles;
using UPN.ExamenT2.Repository.Context;
using UPN.ExamenT2.Repository.Models;

namespace UPN.ExamenT2.Repository.Repository
{
    public class RazaRepository
    {
        
        public void Guardar(Raza raza)
        {
            var pd_lastId = StaticContext.pd_RazaData.Count > 0 ? StaticContext.pd_RazaData.Last().Id : 0;
            pd_lastId++;
            
            raza.Id = pd_lastId;
            
            StaticContext.pd_RazaData.Add(raza);
        }

        public List<Raza> Listar()
        {
            return StaticContext.pd_RazaData;
        }

        public Raza BuscarPorId(int id)
        {
            var pd_RazaArrayData = StaticContext.pd_RazaData.Select(s => s.Id).ToArray();

            var pd_index = AlgoritmosBusqueda.BusquedaSecuencial(pd_RazaArrayData, id);

            if (pd_index == -1)
            {
                return null!;
            }

            return StaticContext.pd_RazaData[pd_index];
        }

        public List<Raza> BuscarPorNombre(string nombre)
        {
            var pd_result = StaticContext.pd_RazaData.Where(x => x.Nombre.ToLower().Contains(nombre.ToLower())).ToList();
            return pd_result;
        }

        public void Eliminar(int id)
        {
            StaticContext.pd_RazaData.Remove(BuscarPorId(id));
        }

        public void Actualizar(Raza raza)
        {
            var pd_razaActual = BuscarPorId(raza.Id);
            pd_razaActual.Nombre = raza.Nombre;
        }
    }
}
