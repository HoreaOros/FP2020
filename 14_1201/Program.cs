using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_1201
{
    class Program
    {
        static void Main(string[] args)
        {
            //FactorialHelper();

            //FibonacciHelper();

            //GCDHelper();

            //DigitSumHelper();

            //MaxDigitHelper();

            //HanoiHelper();

            QuickSortHelper();
        }

        // TODO: implementati algoritmul Quick Sort.
        private static void QuickSortHelper()
        {
            //_# choose pivot_
            //swap a[1, rand(1, n)]

            //_# 2-way partition_
            //k = 1
            //for i = 2:n, if a[i] < a[1], swap a[++k, i]
            //swap a[1, k]
            //_→ invariant: a[1..k - 1] < a[k] <= a[k + 1..n]_

            //    _# recursive sorts_
            //sort a[1..k - 1]
            //sort a[k + 1, n]
        }

        private static void HanoiHelper()
        {
            int n = 10; 
            int a = 1, b = 2, c = 3;

            Hanoi(n, a, b, c);
        }

        /// <summary>
        /// Mutam n discuri de pe tija a pe tija b folosindu-ne de tija intermediara c
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        private static void Hanoi(int n, int a, int b, int c)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Hanoi(n - 1, a, c, b);
                Console.WriteLine($"{a} -> {b}");
                Hanoi(n - 1, c, b, a);
            }
        }

        private static void MaxDigitHelper()
        {
            int n = 2567;
            Console.WriteLine($"Cifra maxima a numarului {n} este {MaxDigit(n)}");
        }

        /// <summary>
        /// Determina cea mai mare cifra a unui numar natural
        /// MaxDigit(n) = n daca n e format dintr-o singura cifra
        /// MaxDigit(n) = Max(n % 10, MaxDigit(n / 10)) daca n e format din mai mult de o cifra
        /// </summary>
        /// <param name="n">numarul natural pentru care determinam cea mai mare cifra</param>
        /// <returns>cea mai mare cifra a parametrului</returns>
        private static int MaxDigit(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                return Math.Max(n % 10, MaxDigit(n / 10));
            }
        }

        private static void DigitSumHelper()
        {
            int n = 5873;
            Console.WriteLine($"Suma cifrelor lui {n} este {DigitSum(n)}");
            Console.WriteLine($"Suma cifrelor lui {n} este {DigitSum2(n)}");
        }

        private static int DigitSum2(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            return suma;
        }
        /// <summary>
        /// Calculeaza suma cifrelor unui numar
        /// SC(n) = 0, daca n = 0
        /// SC(n) = n % 10 + SC(n / 10), daca n > 0
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int DigitSum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
                return n % 10 + DigitSum(n / 10);
        }

        private static void GCDHelper()
        {
            int a = 25, b = 9;
            Console.WriteLine($"CMMMDC({a}, {b}) = {gcd(a, b)}");
        }

        /// <summary>
        /// Calculeaza cmmdc a 2 numere  a si b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>cmmdc(a, b)</returns>
        private static int gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
                return gcd(b, a % b);
        }

        /// <summary>
        /// Generam numere Fibonacci
        /// f0 = 1, f1 = 1, f_n = f_{n-1} + f_{n-2}
        /// 1,1,2,3,5,8,13,21,34,...
        /// </summary>
        private static void FibonacciHelper()
        {
            int n = 40;

            for (int i = 0; i <= n; i++)
            {
                Console.Write($"{fibonacci(i)} "); 
            }
        }

        /// <summary>
        /// Calculeaza al n-lea termen din sirul Fibonacci
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
                return fibonacci(n - 1) + fibonacci(n - 2);
        }

        private static void FactorialHelper()
        {
            for (int i = 0; i <= 13; i++)
            {
                Console.WriteLine($"{i}! = {factorial(i)}");
            }
        }

        /// <summary>
        /// Calculeaza factorialul unui numar natural
        /// n! = 1 * 2 * ... * n
        /// n! = 1 daca n este 0
        /// n! = n * (n - 1)! daca n este mai mare decat zero
        /// </summary>
        /// <param name="n"></param>
        /// <returns>factorialul lui n</returns>
        private static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
                return n * factorial(n - 1);
        }
    }
}
