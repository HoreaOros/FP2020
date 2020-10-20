using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1310
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se dau 3 numere. Sa se spuna daca ele pot fi lungimile laturilor unui triunghi");

            double a, b, c;

            Console.WriteLine("Introduceti lungimile laturilor: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());



            // varianta 1;
            if (a + b > c) 
            {
                if (b + c > a)
                {
                    //DA
                    if (c + a > b)
                    {
                        // DA
                        Console.WriteLine("pot forma triunghi");
                    }
                    else
                    {
                        // NU
                        Console.WriteLine("nu pot forma triunghi");
                    }
                }
                else
                {
                    //NU
                    Console.WriteLine("nu pot forma triunghi");
                }
            }
            else
            {
                Console.WriteLine("nu pot forma triunghi");
            }
            // varianta 2
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("pot forma triunghi");
            }
            else
            {
                Console.WriteLine("nu pot forma triunghi");
            }
        }  
    }
}
