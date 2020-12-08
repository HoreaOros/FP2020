using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _8_2311
{
    /// <summary>
    /// Sorting algos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = InitArray(8, 0, 100);
            
            Console.WriteLine("Before...");
            PrintArray(arr);

            // Processing...
            //Array.Sort(arr, new DescendingComparer());


            //Console.WriteLine("Insertion Sorting...");
            //InsertionSort(arr);

            Console.WriteLine("Selection Sorting...");
            SelectionSort(arr);

            Console.WriteLine("After...");
            PrintArray(arr);
        }

        private static void SelectionSort(int[] arr)
        {
            int aux;
            for (int i = 0; i < arr.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr [k])
                    {
                        k = j;
                    }
                }
                aux = arr[k];
                arr[k] = arr[i];
                arr[i] = aux;
            }
        }

        private static void InsertionSort(int[] arr)
        {
            int aux;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int k = i; k > 0 && arr[k] < arr[k - 1]; k--)
                {
                    aux = arr[k];
                    arr[k] = arr[k - 1];
                    arr[k - 1] = aux;
                }
                // invariant: elementele vectorului de la pozitia 0 pana la i 
                // sunt in ordine crescatoare. 
            }
        }

        private static void PrintArray(int[] arr)
        {
            // iteratia read-only peste elementele v
            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Aloca memorie pentru un vector si initializeaza elementele vectorului 
        /// v cu valori aleatoare din interalul [min, max)
        /// </summary>
        /// <param name="length">lungimea vectorului care este initializat</param>
        /// <param name="min">Limita inferioara inclusiv</param>
        /// <param name="max">Limita superioara exclusiv</param>
        private static int[] InitArray(int length, int min, int max)
        {
            int[] v = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max);
            }
            return v;
        }
    }
}
