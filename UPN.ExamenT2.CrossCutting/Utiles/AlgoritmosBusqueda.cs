using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPN.ExamenT2.CrossCutting.Utiles
{
    public class AlgoritmosBusqueda
    {
        public static int BusquedaSecuencial(int[] array, int valor)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valor)
                {
                    return i; // Retorna el índice donde se encontró el valor
                }
            }
            return -1; // Retorna -1 si el valor no se encuentra en el array
        }


        public static int BusquedaBinaria(int[] array, int valor)
        {
            int inicio = 0;
            int fin = array.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (array[medio] == valor)
                {
                    return medio; // Retorna el índice donde se encontró el valor
                }
                else if (array[medio] < valor)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }
            return -1; // Retorna -1 si el valor no se encuentra en el array
        }

        public static int BusquedaInterpolada(int[] array, int valor)
        {
            int inicio = 0;
            int fin = array.Length - 1;

            while (inicio <= fin && valor >= array[inicio] && valor <= array[fin])
            {
                int posicion = inicio + ((valor - array[inicio]) * (fin - inicio)) / (array[fin] - array[inicio]);

                if (array[posicion] == valor)
                {
                    return posicion; // Retorna el índice donde se encontró el valor
                }
                else if (array[posicion] < valor)
                {
                    inicio = posicion + 1;
                }
                else
                {
                    fin = posicion - 1;
                }
            }
            return -1; // Retorna -1 si el valor no se encuentra en el array
        }
    }
}
