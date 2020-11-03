using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _4_2710
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            int n;

            n = Util.GetIntFromConsole();

            if (Palindrom(n))
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom");
            }
        }

        /// <summary>
        /// Determina daca argumentul este palindrom. 
        /// </summary>
        /// <param name="n">Numarul care este verificat</param>
        /// <returns>true daca numarul este palindrom, false in caz contrar</returns>
        /// <example>palindrom => 121, 123321, nu este palindrom 1233 </example>
        public static bool Palindrom(int n)
        {
            if (n == Reverse(n))
                return true;
            else
                return false;

            // echivalent
            // return n == Reverse(n);
        }

        /// <summary>
        /// Calculeaza inversul/rasturnatul unui numar
        /// </summary>
        /// <param name="n">numarul pentru care calculam invrsul</param>
        /// <returns>inversul argumentului</returns>
        /// <example>inversul lui 123 este 321</example>
        private static int Reverse(int n)
        {
            int result = 0;
            int cifra;
            while (n > 0)
            {
                cifra = n % 10;
                n = n / 10;

                result = result * 10 + cifra;
            }
            return result;
        }
    }
}
