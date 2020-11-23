using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Monoton
            monotonCrescator();

            // MonotonRotit
            monotonCrescatorRotit();

        }
        /// <summary>
        /// O secventa crescatoare rotita este o secventa de numere care este in ordine crescatoare 
        /// sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive 
        /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). 
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        /// <example>
        /// [4,5,1,2,3] -> este monton crescatoare rotita
        /// </example>
        private static void monotonCrescatorRotit()
        {
            
        }

        /// <summary>
        /// Sa se determine daca o secventa de n (n >= 1) numere naturale pozitive este monoton crescator.
        /// Secventa monotona = secventa monoton crescatoare.
        /// </summary>
        private static void monotonCrescator()
        {
            int n, a, b;
            
            n = int.Parse(Console.ReadLine());


            bool monotonCrescator = true;
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    monotonCrescator = false;
                }

                a = b;
            }
            if (monotonCrescator)
            {
                Console.WriteLine("Secventa este monoton crescatoare");
            }
            else
            {
                Console.WriteLine("Secventa nu este monoton crescatoare");
            }
        }
    }
}
