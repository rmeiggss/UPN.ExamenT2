namespace UPN.ExamenT2.CrossCutting.Utiles
{
    public class AlgoritmosOrdenamiento
    {

        //metodo de burbuja
        public static int[] burbuja(int[] vector)
        {
            int n = vector.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;
                    }
                }
            }

            return vector;
        }

        public static int[] burbujaReverse(int[] vector)
        {
            int n = vector.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vector[j] < vector[j + 1])
                    {
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;
                    }
                }
            }

            return vector;
        }

        //public static void burbuja(Contacto[] vector, int indice)
        //{
        //    int n = indice;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        for (int j = 0; j < n - i - 1; j++)
        //        {
        //            if (vector[j].Apellido.CompareTo(vector[j + 1].Apellido) > 0)  //A-Z  
        //            {
        //                Contacto temp = vector[j];
        //                vector[j] = vector[j + 1];
        //                vector[j + 1] = temp;
        //            }
        //        }
        //    }
        //}

        //metodo
        // Método de ordenamiento: Inserción (Insertion Sort)
        public static void insercion(int[] vector)
        {
            int n = vector.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = vector[i];
                int j = i - 1;

                while (j >= 0 && vector[j] > key)
                {
                    vector[j + 1] = vector[j];
                    j = j - 1;
                }
                vector[j + 1] = key;
            }
        }

        // Método de ordenamiento: Selección (Selection Sort)
        public static void seleccion(int[] vector)
        {
            int n = vector.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (vector[j] < vector[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = vector[minIndex];
                vector[minIndex] = vector[i];
                vector[i] = temp;
            }
        }

        // Método de ordenamiento: Quicksort
        public static void QuickSort(int[] vector, int baja, int alta)
        {
            if (baja < alta)
            {
                int pivotIndex = Particion(vector, baja, alta);
                QuickSort(vector, baja, pivotIndex - 1);
                QuickSort(vector, pivotIndex + 1, alta);
            }
        }

        private static int Particion(int[] vector, int baja, int alta)
        {
            int pivot = vector[alta];
            int i = baja - 1;

            for (int j = baja; j < alta; j++)
            {
                if (vector[j] < pivot)
                {
                    i++;
                    int temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                }
            }

            int temp1 = vector[i + 1];
            vector[i + 1] = vector[alta];
            vector[alta] = temp1;
            return i + 1;
        }

        // Método de ordenamiento: Mergesort
        public static void mergeOrdenar(int[] vector, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                mergeOrdenar(vector, l, m);
                mergeOrdenar(vector, m + 1, r);
                merge(vector, l, m, r);
            }
        }

        private static void merge(int[] vector, int l, int m, int r)
        {
            int n1 = m - l + 1; //calculando tamaño de arreglo 1
            int n2 = r - m;     //calculando tamaño de arreglo 2
            int[] L = new int[n1]; //creando arreglo
            int[] R = new int[n2];
            Array.Copy(vector, l, L, 0, n1); //copiando elementos arreglo
            Array.Copy(vector, m + 1, R, 0, n2);
            int i = 0, j = 0;
            int k = l;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    vector[k] = L[i];
                    i++;
                }
                else
                {
                    vector[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                vector[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                vector[k] = R[j];
                j++;
                k++;
            }
        }

        // Método auxiliar para imprimir un array
        public static void PrintArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        // Ejemplo de uso
        //static void Main(string[] args)
        //{
        //    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        //    Console.WriteLine("Array original:");
        //    PrintArray(arr);

        //    Ordenar con BubbleSort
        //    burbuja(arr);
        //    Console.WriteLine("\nArray ordenado con BubbleSort:");
        //    PrintArray(arr);

        //    Restaurar el array original
        //    arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };

        //    Ordenar con InsertionSort
        //    insercion(arr);
        //    Console.WriteLine("\nArray ordenado con InsertionSort:");
        //    PrintArray(arr);

        //    Restaurar el array original
        //    arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };

        //    Ordenar con SelectionSort
        //    seleccion(arr);
        //    Console.WriteLine("\nArray ordenado con SelectionSort:");
        //    PrintArray(arr);

        //    Restaurar el array original
        //    arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };

        //    Ordenar con QuickSort
        //    QuickSort(arr, 0, arr.Length - 1);
        //    Console.WriteLine("\nArray ordenado con QuickSort:");
        //    PrintArray(arr);

        //    Restaurar el array original
        //    arr = new int[] { 64, 34, 25, 12, 22, 11, 90 };

        //    Ordenar con MergeSort
        //    mergeOrdenar(arr, 0, arr.Length - 1);
        //    Console.WriteLine("\nArray ordenado con MergeSort:");
        //    PrintArray(arr);
        //}
    }
}
