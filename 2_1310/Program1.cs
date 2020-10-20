using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1310
{
    class Program1
    {
        static void Main(string[] args)
        {
            /* Programul afiseaza in ordine inversa cifrele unui numar format din maxim 3 cifre. 
             * Exemplu: n = 123 -> se va afisa 321
             */

            int n;


            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("Introduceti un numar natural format din maxim 3 cifre");
            n = int.Parse(Console.ReadLine());

            // TODO - rezolvarea situatiilor in care numarul 
            //introdus nu respecta cerintele problemei 
            //(nu e format din maxim 3 cifre/sau e negativ/sau nu e numar).

            if (n < 10)
            {
                Console.WriteLine(n);
            }
            else
            {
                if(n < 100)
                {
                    Console.WriteLine($"{n % 10}{n / 10}");
                }
                else
                {
                    Console.WriteLine($"{n % 10}{n / 10 % 10}{n / 100}");
                }
            }


            // Console.ReadKey();
        }
    }
}
