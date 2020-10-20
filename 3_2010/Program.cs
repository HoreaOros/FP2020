using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace _3_2010
{
    class Program
    {
        /// <summary>
        /// Definitii paradigme programare
        /// </summary>
        static void Comentarii()
        {
            // programare structurata
            // structura liniara sau structura secventiala
            // executarea unor instructiuni una dupa alta

            // structura alternativa sau structura de decizie
            // ramificarea executiei programului in functie de o conditie

            // structura repetitiva sau structura iterativa
            // repetarea uneia/sau a mai multor instructiuni de mai multe ori
            // cat timp o conditie este adevarata

            // programare procedurala
            // organizarea codului sub forma de proceduri/functii (metode) 
        }


        /// <summary>
        /// Citeste un numar de la tastatura un numar n 
        /// si afiseaza suma numerelor de la 1 la n
        /// </summary>
        static void Gauss()
        {
            // suma Gauss
            // S = 1 +    2    +  ... + n 
            // S = n + (n - 1) +  ... + 1 
            // ___________________________
            // 2*S = (n + 1) + (n + 1) + ... + (n + 1)
            // 2 * S = n * (n + 1)


            Console.WriteLine("Introduceti un numar natural");
            int n;

            n = int.Parse(Console.ReadLine());
            int suma;

            suma = n * (n + 1) / 2;
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}");
        }

        /// <summary>
        /// int types
        /// </summary>
        static void IntTypesComments()
        {
            // sbyte  - intreg cu semn pe 8 biti -128 -> 127
            // byte   - intreg fara semn pe 8 biti 0 -> 255 
            // short  - intreg cu semn pe 16 biti  -2^15 -> 2^15-1
            // ushort - intreg fara semn pe 16 biti 0 -> 2^16 - 1
            // int  - intreg cu semn pe 8 biti -2^31 -> 2^31-1
            // uint   - intreg fara semn pe 8 biti 0 -> 2^32-1 
            // long  - intreg cu semn pe 16 biti  -2^63 -> 2^63-1
            // ulong - intreg fara semn pe 16 biti 0 -> 2^64 - 1
        }

        /// <summary>
        /// Citeste 3 numere de la tastatura si le afiseaza in ordine crescatoare
        /// </summary>
        static void Ordonare3()
        {
            // se dau 3 numere naturale a, b, c; 
            int a, b, c;
            Console.WriteLine("Introduceti 3 numere: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            // solutia problemei va fi una din:
            // a b c 
            // a c b
            // b a c
            // b c a
            // c a b
            // c b a

            // sa se afiseze in ordine crescatoare. 
            if (a < b)
            {
                if (a < c)
                {
                    Console.Write($"{a} ");
                    if (b < c)
                    {
                        Console.WriteLine($"{b} {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c} {b}");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
            }
            else
            {
                if (b < c)
                {
                    Console.Write($"{b} ");
                    if (a < c)
                    {
                        Console.WriteLine($"{a} {c}");
                    }
                    else
                    {
                        Console.WriteLine($"{c} {a}");
                    }
                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }
        }

        static void Main(string[] args)
        {
            //Gauss(); // apel metoda
            //Ordonare3(); // apel metoda

            // se dau 3 numere naturale a, b, c; 
            //int a, b, c;
            //Console.WriteLine("Introduceti 3 numere: ");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());
            //Ordonare3V2(a, b, c); // apel metoda

            Gaussv2();
        }

        private static void Gaussv2()
        {
            Console.WriteLine("Introduceti un numar natural");
            int n;

            n = int.Parse(Console.ReadLine());
            int suma;
            suma = 0;
            int v = 1;

            while (v <= n)
            {
                suma += v;
                v += 1; // v++;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}");
        }

        private static void Ordonare3V2(int a, int b, int c)
        {
            int minim, maxim;
            minim = a;
            if (b < minim)
                minim = b;
            // minim = Math.Min(b, minim);
            
            if (c < minim)
                minim = c;
            maxim = a;
            
            if (b > maxim)
                maxim = b;
            
            if (c > maxim)
                maxim = c;

            int median;

            median = a + b + c - minim - maxim;

            Console.WriteLine($"{minim} {median} {maxim}");
        }
    }
}
