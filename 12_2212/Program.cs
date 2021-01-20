using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _12_2212
{

    // Matrici. 
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10]; // tablou unidimensional sau vector.

            int[,] matrice = new int[3, 4]; // tablou bidimensional sau matrice.


            int[,] a = CreateMatrix(2, 3);
            PrintMatrix(a);
            Console.WriteLine("Matrix a generated");
            
            int[,] b = CreateMatrix(3, 5);
            PrintMatrix(b);
            Console.WriteLine("Matrix b generated");
            
            int[,] c = MatrixMultiply(a, b);
            PrintMatrix(c);
            Console.WriteLine("Matrix product generated");

            // Matrici patratice = numarul liniilor este egal cu numarul coloanelor
            // 1 2 3
            // 4 5 6
            // 7 8 9
            // diagonala principala -> 1, 5, 9
            // diagonala secundara -> 3, 5, 7

            int[,] p = CreateMatrix(4);
            PrintMatrix(p);

            Console.WriteLine($"Suma elementelor de pe diagonala principala este: {SumaDP(p)}");
            Console.WriteLine($"Suma elementelor de pe diagonala secundara este: {SumaDS(p)}");

            Console.WriteLine($"Suma elementelor de deasupra diagonalei principale: {SumaDDP(p)}");

            // TODO
            Console.WriteLine($"Suma elementelor de sub diagonala principala: {SumaSDP(p)}");

            // TODO
            Console.WriteLine($"Suma elementelor de deasupra diagonalei secundare: {SumaDDS(p)}");

            // TODO
            Console.WriteLine($"Suma elementelor de sub diagonala secundara: {SumaSDS(p)}");


            // TODO
            // Se da o matrice cu m linii si n coloane. Se cere sa se parcurga matricea in spirala. 
            // 1 2 3
            // 4 5 6
            // 7 8 9
            // ==> 1 2 3 6 9 8 7 4 5
            Console.WriteLine();
            int[,] mtr = CreateMatrix(3, 3);
            PrintMatrix(mtr);           
            Console.Write($"Matricea parcursa in spirala ==> ");
            Matspiral(mtr, 3, 3);

            // TODO
            // Se da o matrice cu m linii si n coloane. Se cere sa se determine toate punctele de maxim.
            // O valoarea din matrice se numeste punct de maxim daca este mai mare sau egal decat toti 
            // vecinii sai. O valoare din matrice poate avea maxim 8 vecini.

            // TODO
            // Se da o matrice binara cu m linii si n coloane (formata doar din 0 si 1). 
            // Se cere sa se determine cea mai mare submatrice patratica din 
            // matricea data formata doar din valoarea 1.
            //   0 0 0 1 1 1 
            //   0 0 0 1 1 0
            //   1 1 1 0 0 1 
            //   1 1 1 1 0 1
            //   1 1 1 1 1 1
            // rezultatul este 3 si incepe in linia 2, coloana 0
            // Hint: Maximum size square sub-matrix with all 1s
        }

        private static void Matspiral(int[,] mtr, int m, int n)
        {
            for (int i = 0; i < n - 1; i++)
                Console.Write(mtr[0, i] + " ");
            for (int i = 0; i < m - 1; i++)
                Console.Write(mtr[i, n - 1] + " ");
            for (int i = n - 1; i >= 1; i--)
                Console.Write(mtr[m - 1, i] + " ");
            for (int i = m - 1; i >= 1; i--)
                    Console.Write(mtr[i, 0] + " ");
            for (int i = 1; i < n - 1; i++)
                Console.Write(mtr[1, i] + " ");           
        }

        private static object SumaSDS(int[,] p)
        {
            int n = p.GetLength(0);
            int suma = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (j > n - 1 - i)
                        suma += p[i, j];
            return suma;
        }

        private static object SumaDDS(int[,] p)
        {
            int n = p.GetLength(0);
            int suma = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (j < n - 1 - i)
                        suma += p[i, j];
            return suma;
        }

        private static object SumaSDP(int[,] p)
        {
            int n = p.GetLength(0);
            int suma = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i > j)
                        suma += p[i, j];
            return suma;
        }


        /// <summary>
        /// Calculeaza suma elementelor de deasupra diagonalei principale
        /// </summary>
        /// <param name="p">Matrice patratica</param>
        /// <returns>Suma elementelor de deasupra diagonalei principale</returns>
        private static int SumaDDP(int[,] p)
        {
            // conditia ca un element p[i, j] sa fie deasupra diagonalei principale este: i < j
            int n = p.GetLength(0);
            int suma = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i < j)
                        suma += p[i, j];
            return suma;
        }
        /// <summary>
        /// Calculeaza suma elementelor de deasupra diagonalei principale
        /// </summary>
        /// <param name="p">Matrice patratica</param>
        /// <returns>Suma elementelor de deasupra diagonalei principale</returns>
        private static int SumaDDPv2(int[,] p)
        {
            // conditia ca un element p[i, j] sa fie deasupra diagonalei principale este: i < j
            int n = p.GetLength(0);
            int suma = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                      suma += p[i, j];
            return suma;
        }

        /// <summary>
        /// Calculeaza suma elementelor de pe diagonala secundara
        /// </summary>
        /// <param name="p">Matrice patratica</param>
        /// <returns>Suma elementelor de pe diagonala secundara</returns>
        private static int SumaDS(int[,] p)
        {
            // un element p[i, j] este pe diagonala secundara daca i + j = n - 1 (n e dimensiunea matricii)
            int suma = 0;
            int n;
            if (p.GetLength(0) != p.GetLength(1))
            {
                throw new InvalidOperationException();
            }

            n = p.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                suma += p[i, n - 1 - i];
            }
            return suma;
        }

        /// <summary>
        /// Calculeaza suma elementelor de pe diagonala principala
        /// </summary>
        /// <param name="p">Matrice patratica</param>
        /// <returns>Suma elementelor de pe diagonala principala</returns>
        private static int SumaDP(int[,] p)
        {
            int suma = 0;
            if (p.GetLength(0) != p.GetLength(1))
            {
                throw new InvalidOperationException();
            }

            for (int i = 0; i < p.GetLength(0); i++)
            {
                suma += p[i, i];
            }
            return suma;
        }

        private static int[,] CreateMatrix(int n)
        {
            return CreateMatrix(n, n);
        }

        /// <summary>
        /// Inmulteste doua matrici
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>rezultatul inmultirii</returns>
        /// <example>
        /// 1 2   x  3 4 5   = 7 10 17
        /// 3 4      2 3 6     17 24 39
        /// </example> 
        private static int[,] MatrixMultiply(int[,] a, int[,] b)
        {
            if (a.GetLength(1) !=  b.GetLength(0))
            {
                // matricile nu pot fi inmultite
                throw new InvalidOperationException();
            }

            int[,] p = new int[a.GetLength(0), b.GetLength(1)];
            int suma; 
            for (int i = 0; i < p.GetLength(0); i++)
            {
                for (int j = 0; j < p.GetLength(1); j++)
                {
                    suma = 0;
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        suma += a[i, k] * b[k, j];
                    }
                    p[i, j] = suma;
                }
            }

            return p;

        }

        /// <summary>
        /// Creaza o matrice si initializeaza elementele la valori aleatorii
        /// </summary>
        /// <param name="linii"></param>
        /// <param name="coloane"></param>
        /// <returns></returns>
        private static int[,] CreateMatrix(int linii, int coloane)
        {
            int[,] mat = new int[linii, coloane];

            Random rnd = new Random();

            
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] = rnd.Next(-10, 10);


            return mat;

        }

        private static void PrintMatrix(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j], 4} "); // 
                }
                Console.WriteLine();
            }
        }
    }
}
