using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7_1711
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayDemo(); // Array = tablou

            // Algoritmi: online / offline.
            // OnlineSum();
            // Thread.Sleep(500);
            // OfflineSum();

            ArrayOperationsDemo();
            
        }

        private static void ArrayOperationsDemo()
        {
            int n = 10;
            int[] v = new int[n];

            InitArray(v, 0, 100);

            // Rotire spre stanga cu o pozitie
            PrintArray(v, "Before:");
            RotateLeft(v);
            PrintArray(v, "After:");



            // Rotire spre stanga cu k pozitii
            int k = 3;
            PrintArray(v, "Before:");
            RotateLeft(v, k);
            PrintArray(v, "After:");

        }

        // TODO: avem nevoie de o implementare mai eficienta a acestei operatii. 

        /// <summary>
        /// Roteste elementele vectorului v cu k pozitii spre stanga
        /// </summary>
        /// <param name="v">Vectorul care se roteste</param>
        /// <param name="k">Numarul de pozitii cu care se face rotirea</param>
        private static void RotateLeft(int[] v, int k)
        {
            for (int i = 0; i < k; i++)
            {
                RotateLeft(v);
            }
        }

        private static void PrintArray(int[] v, string message)
        {
            Console.WriteLine(message);
            foreach (var item in v)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Initializeaza elementele vectorului v cu valori aleatoare din interalul [min, max)
        /// </summary>
        /// <param name="v">vectorul care este initializat</param>
        /// <param name="min">Limita inferioara inclusiv</param>
        /// <param name="max">Limita superioara exclusiv</param>
        private static void InitArray(int[] v, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max);
            }
        }

        /// <summary>
        /// Rotire. Se da un vector cu n elemente. 
        /// Rotiti elementele vectorului cu o pozitie spre stanga. 
        /// Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.
        /// </summary>
        /// <example>
        /// Rotire la stanga cu o pozitie: 1,2,3,4,5,6 ==> 2,3,4,5,6,1
        /// </example>
        private static void RotateLeft(int[] v)
        {
            int aux;
            aux = v[0];

            for (int i = 1; i < v.Length; i++)
            {
                v[i - 1] = v[i];
            }
            v[v.Length - 1] = aux;
        }

        private static void OfflineSum()
        {
            // generez si salvez lista de numere
            Random rnd = new Random();
            int sum = 0;
            int[] v = new int[100];
            for (int i = 0; i < 100; i++)
            {
                v[i] = rnd.Next(100);
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
            // procesez lista generata anterior.
            for (int i = 0; i < 100; i++)
            {
                sum += v[i];
            }
            Console.WriteLine($"Offline sum: {sum}");
        }

        private static void OnlineSum()
        {
            Random rnd = new Random();
            int sum = 0, nr;
            for (int i = 0; i < 100; i++)
            {
                nr = rnd.Next(100);
                sum += nr;
                Console.Write($"{nr} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Online sum: {sum}");
        }

        private static void ArrayDemo()
        {
            // Tablouri = structura de date liniara in care toate elementele au acelasi tip.
            // Vector = tablou unidimensional. 
            // Matrice = tablou bidimensional (*). 

            int n = 100000;
            int[] v; // v - variabila care se va putea referi la un tablou (vector)
            // in faza asta elementele vectorulio inca nu exista. 

            v = new int[n]; // aici se aloca memorie pentru elementele vectorului si se 
            // asociaza variabila v cu vectorul alocat. 


            // |0|1|2|3|4|5|6|7|8|9| -> index
            // |0|1|4|2|4|6|8|1|0|9| -> valoarea

            Random rnd = new Random();

            int nrValori = 6;

            int[] frecvente = new int[nrValori]; // toate elementele vectorului
            // sunt initializate in mod implicit la zero. 

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(1, nrValori + 1); // primesc numere intregi din intervalul [1, 100)
                frecvente[v[i] - 1]++;
            }

            Console.WriteLine("Elementele vectorului:");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();

            for (int i = 0; i < frecvente.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {frecvente[i]}");
            }
        }
    }
}
