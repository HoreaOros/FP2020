using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1512
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] w = { 3, 6, 2, 1, 5, 7, 2, 4, 1, 9 };

            int C = 10; 
            NF(w, C);

            FF(w, C);

            BF(w, C);

            WF(w, C);
            // 3, 6 = 9
            // 2, 1, 5 = 8
            // 7, 2 = 9
            // 4, 1 = 5
            // 9 = 9


            
            
            FFD(w, C);
            // 9, 7, 6, 5, 4, 3, 2, 2, 1, 1
            //1. 9, 1
            //2. 7, 3
            //3. 6, 4
            //4. 5, 2, 2, 1 

            NFD(w, C);

            BFD(w, C);

            WFD(w, C);

        }

        private static void NFD(int[] w, int C)
        {
            MySort(w);
            NF(w, C);
        }

        private static void BFD(int[] w, int C)
        {
            MySort(w);
            BF(w, C);
        }

        private static void WFD(int[] w, int C)
        {
            MySort(w);
            WF(w, C);
        }

        /// <summary>
        /// First Fit Decreasing
        /// </summary>
        /// <param name="w">Lista dimensiunilor obiectelor care trebuie impachetate</param>
        /// <param name="C">Capacitatea maxima a unui containter</param>
        private static void FFD(int[] w, int C)
        {
            MySort(w);
            FF(w, C);
        }

        private static void MySort(int[] w)
        {
            for (int i = 0; i < w.Length; i++)
            {
                for (int j = i + 1; j < w.Length; j++)
                {
                    if (w[i] < w[j])
                    {
                        int aux = w[i];
                        w[i] = w[j];
                        w[j] = aux;
                    }
                }
            }
        }

        /// <summary>
        /// Worst Fit
        /// </summary>
        /// <param name="w">Lista dimensiunilor obiectelor care trebuie impachetate</param>
        /// <param name="C">Capacitatea maxima a unui containter</param>
        private static void WF(int[] w, int C)
        {
            Console.WriteLine("Worst Fit:");
            int[] bins = new int[w.Length];
            int k = 1;
            for (int i = 0; i < w.Length; i++)
            {
                int bin = -1;
                int maxim = 0;
                for (int j = 0; j < k; j++)
                {
                    if (w[i] + bins[j] <= C)
                    {
                        int remain = C - (w[i] + bins[j]);
                        if (remain > maxim)
                        {
                            maxim = remain;
                            bin = j;
                        }

                    }
                }
                if (bin == -1)
                {
                    k++;
                    bins[k - 1] = w[i];
                }
                else
                {
                    bins[bin] += w[i];
                }
            }
            Console.WriteLine($"Numarul de containere de capacitate {C} folosite este: {k}");
            Console.WriteLine("Bins load:");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{bins[i]} ");
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Best Fit
        /// </summary>
        /// <param name="w">Lista dimensiunilor obiectelor care trebuie impachetate</param>
        /// <param name="C">Capacitatea maxima a unui containter</param>
        private static void BF(int[] w, int C)
        {
            Console.WriteLine("Best Fit:");
            int[] bins = new int[w.Length];
            int k = 1;
            for (int i = 0; i < w.Length; i++)
            {
                int bin = -1;
                int minim = C;
                for (int j = 0; j < k; j++)
                {
                    if (w[i] + bins[j] <= C)
                    {
                        int remain = C - (w[i] + bins[j]);
                        if (remain < minim)
                        {
                            minim = remain;
                            bin = j;
                        }
                            
                    }
                }
                if (bin == -1)
                {
                    k++;
                    bins[k - 1] = w[i];
                }
                else
                {
                    bins[bin] += w[i];
                }
            }
            Console.WriteLine($"Numarul de containere de capacitate {C} folosite este: {k}");
            Console.WriteLine("Bins load:");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{bins[i]} ");
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// First Fit
        /// </summary>
        /// <param name="w">Lista dimensiunilor obiectelor care trebuie impachetate</param>
        /// <param name="C">Capacitatea maxima a unui containter</param>
        private static void FF(int[] w, int C)
        {
            Console.WriteLine("First Fit:");
            int[] bins = new int[w.Length];
            int k = 1;
            for (int i = 0; i < w.Length; i++)
            {
                bool packed = false;
                for (int j = 0; j < k; j++)
                {
                    if (w[i] + bins[j] <= C)
                    {
                        bins[j] += w[i];
                        packed = true;
                        break;
                    }
                }
                if (!packed)
                {
                    k++;
                    bins[k - 1] = w[i];
                }
            }
            Console.WriteLine($"Numarul de containere de capacitate {C} folosite este: {k}");
            Console.WriteLine("Bins load:");
            for (int i = 0; i < k; i++)
            {
                Console.Write($"{bins[i]} ");
            }
            Console.WriteLine(Environment.NewLine);
        }

        /// <summary>
        /// Next Fit 
        /// </summary>
        /// <param name="w">Lista dimensiunilor obiectelor care trebuie impachetate</param>
        /// <param name="C">Capacitatea maxima a unui containter</param>
        private static void NF(int[] w, int C)
        {
            Console.WriteLine("Next Fit:");
            int bins = 1;
            int current_capacity = 0; // tine evidenta capacitatii umplute in containterului curent
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] + current_capacity <= C) // daca obiectul curent incape in containterul deschis
                    current_capacity += w[i];     // atunci il adaug in containerul deschis
                else  // altfel deschid un nou container in care pun obiectul curent
                {
                    bins++;
                    current_capacity = w[i];
                }
            }
            Console.WriteLine($"Numarul de containere de capacitate {C} folosite este: {bins}");
            Console.WriteLine();
        }

    }
}
