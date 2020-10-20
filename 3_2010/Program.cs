using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2010
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
