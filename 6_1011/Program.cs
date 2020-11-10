using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _6_1011
{
    class Program
    {
        static void Main(string[] args)
        {

            // numaram numerele prime dintr-un interval
            //CountPrimes();

            // nr. zile dintre doua date calendaristice
            DateDiff1();

            DateDiff2();
        }

        /// <summary>
        /// Determina numarul de zile dintre doua date calendaristice
        /// </summary>
        private static void DateDiff2()
        {
            // ziua 1
            int z1 = 1, l1 = 1, a1 = 2001;
            // ziua 2
            int z2 = 10, l2 = 11, a2 = 2020;

            int contor = 0;

            while (!(z1 == z2 && l1 == l2 && a1 == a2)) // z1 != z2 || l1 != l2 || a1 != a2
            {
                // scad o zi din ziua 2;
                if (z2 > 1)
                {
                    z2--;
                }
                else
                {
                    switch (l2)
                    {
                        case 12: case 10: case 7: case 5:
                            z2 = 30;
                            l2--;
                            break;
                        case 11: case 9: case 8: case 6: case 4:
                        case 2:
                            z2 = 31;
                            l2--;
                            break;
                        case 1:
                            z2 = 31;
                            l2 = 12;
                            a2--;
                            break;
                        case 3:
                            // ziua anterioara este 28 sau 29 feb.
                            if (a2.IsLeapYear())
                                z2 = 29;
                            else
                                z2 = 28;
                            l2--;
                            break;
                        default:
                            break;
                    }
                }
                // maresc contor;
                contor++;
            }


            Console.WriteLine($"Numarul de zile dintre cele doua date este {contor}");
        }

        /// <summary>
        /// Determina numarul de zile dintre doua date calendaristice
        /// </summary>
        private static void DateDiff1()
        {
            int z1 = 1, l1 = 1, a1 = 2001;
            int z2 = 10, l2 = 11, a2 = 2020;


            DateTime azi = DateTime.Now;
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(azi.ToString("d MMMM yyyy, HH:mm:ss"));

            DateTime d = new DateTime(a1, l1, z1);
            TimeSpan diff = azi.Subtract(d);
            Console.WriteLine($"Numarul de zile dintre cele doua date este {diff.Days}");



        }

        /// <summary>
        /// Metoda determina numarul de numere prime dintr-un interval
        /// </summary>
        private static void CountPrimes()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int contorPrime = 0;


            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int nr = a; nr <= b; nr++)
            {
                // verificam daca nr este nr prim
                if (nr.IsPrime())
                {
                    contorPrime++;
                    //Console.Write($"{nr} ");
                }
            }

            sw.Stop();
            Console.WriteLine($"In intervalul [{a},{b}] sunt {contorPrime} numere prime ");
            Console.WriteLine($"Operatia a durat {sw.ElapsedMilliseconds} milisecunde");
        }
    }
}
