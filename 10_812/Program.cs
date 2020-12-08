using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_812
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            /*
            for (int i = 0; i < 100; i++)
            {
                // System.Threading.Thread.Sleep(50);
                int[] arr = InitArray(8, 0, 100, rnd);
                PrintArray(arr);
            }
            */

            Console.WriteLine("BubbleSort");
            int noOfValuesToSort = 1000;
            int maxValue = 100;
            int[] arr = InitArray(noOfValuesToSort, 0, maxValue, rnd);
            //PrintArray(arr, "Before: ");
            //BubbleSort(arr);
            //PrintArray(arr, "After: ");

            Console.WriteLine("CountingSort");
            noOfValuesToSort = 1000000;
            maxValue = 100;
            arr = InitArray(noOfValuesToSort, 0, maxValue, rnd);
            CountingSort(arr, maxValue);


            //PrintArray(arr, "After: ");


            // TODO
            // Se da un vector arr format din n numere naturale.
            // Se cere sa se determine cea mai mare valoarea k (k <= n) cu proprietatea ca in vectorul arr
            // sunt cel putin k elemente mai mari sau egale decat k. 
            // Precizare: creati un algoritm eficient pentru rezolvarea acestei probleme. (algoritm liniar) 
        }

        /// <summary>
        /// Sortare prin numarare (CountingSort)
        /// </summary>
        /// <param name="arr">Vectorul pe care il sortez</param>
        /// <param name="maxValue">Valoarea maxima exclusiva a elementelor din vector</param>
        private static void CountingSort(int[] arr, int maxValue)
        {
            int[] freq = new int[maxValue];
            foreach (var item in arr)
            {
                freq[item]++;
            }
            int index = 0;
            for (int i = 0; i < freq.Length; i++)
            {
                for (int j = 0; j < freq[i]; j++)
                {
                    arr[index++] = i;
                }
            }
        }

        /// <summary>
        /// Bubble sort
        /// for i = 1:n,
        ///     swapped = false
        ///     for j = n:i+1,
        ///         if a[j] < a[j - 1],
        ///              swap a[j, j - 1]
        ///              swapped = true
        ///     → invariant: a[1..i] in final position
        ///     break if not swapped
        /// end
        /// </summary>
        /// <param name="arr">Vectorul pe care vreau sa il sortez</param>
        private static void BubbleSort(int[] arr)
        {
            bool swapped;
            for (int i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for (int j  = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int aux;
                        aux = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = aux;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        private static void PrintArray(int[] arr, string message)
        {
            // iteratia read-only peste elementele v
            Console.WriteLine(message);
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
        private static int[] InitArray(int length, int min, int max, Random rnd)
        {
            int[] v = new int[length];
            
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max);
            }
            return v;
        }
    }
}
