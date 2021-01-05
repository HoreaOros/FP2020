using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_0501
{
    class Program
    {
        static void Main(string[] args)
        {
            // BS();
            
        }

        private static void BS()
        {
            int[] v = { 1, 4, 6, 8, 9, 10, 16, 20 };

            int key = 10;
            //int pos = LinearSearch(v, key);
            //if (pos == -1)
            //{
            //    Console.WriteLine($"Nu am gasit cheia {key} in vector");
            //}
            //else
            //{
            //    Console.WriteLine($"Cheia {key} este in vector pe pozitia {pos}");
            //}

            //int ret = Array.BinarySearch<int>(v, key);
            //if (ret >= 0)
            //{
            //    Console.WriteLine($"Cheia {key} este in vector pe pozitia {ret}");
            //}
            //else
            //{
            //    Console.WriteLine($"Nu am gasit cheia {key} in vector");
            //}

            int pos = MyBinarySearch(v, key);
            if (pos == -1)
            {
                Console.WriteLine($"Nu am gasit cheia {key} in vector");
            }
            else
            {
                Console.WriteLine($"Cheia {key} este in vector pe pozitia {pos}");
            }

            pos = MyBinarySearchAlt(v, key);
            pos = MyBinarySearchLeftmost(v, key);
            pos = MyBinarySearchRightmost(v, key);

            // TODO
            // rank
            // succesor
            // predecesor
            // cel mai apropiat vecin
        }

        //          function binary_search_rightmost(A, n, T):
        //      L := 0
        //      R := n
        //      while L<R:
        //          m := floor((L + R) / 2)
        //          if A[m] > T:
        //              R := m
        //          else:
        //              L := m + 1
        //      return R - 1
        private static int MyBinarySearchRightmost(int[] v, int key)
        {
            // TODO
            return 0;
        }

        //    function binary_search_leftmost(A, n, T):
        //      L := 0
        //      R := n
        //      while L<R:
        //          m := floor((L + R) / 2)
        //          if A[m] < T:
        //              L := m + 1
        //          else:
        //              R := m
        //      return L
        private static int MyBinarySearchLeftmost(int[] v, int key)
        {
            // TODO
            return 0;
        }


        //    function binary_search_alternative(A, n, T) is
        //  L := 0
        //  R := n − 1
        //  while L != R do
        //      m := ceil((L + R) / 2)
        //      if A[m] > T then
        //          R := m − 1
        //      else:
        //          L := m
        //  if A[L] = T then
        //      return L
        //  return unsuccessful
        private static int MyBinarySearchAlt(int[] v, int key)
        {
            // TODO
            
            return 0;
        }

        /// <summary>
        /// Binary Search
        /// </summary>
        /// <param name="v">Vectorul in care se cauta</param>
        /// <param name="key">Cheia care se cauta</param>
        /// <returns>pozitia pe care se afla cheia sau -1 daca nu gasim cheia in vector</returns>
        private static int MyBinarySearch(int[] v, int key)
        {
            int left, right, mid;
            left = 0; right = v.Length - 1;
            while (left <= right)
            {
                //mid = (left + right) / 2;
                mid = left + (right - left) / 2;
                if (key < v[mid])
                {
                    right = mid - 1;
                }
                else if (key > v[mid])
                {
                    left = mid + 1;
                }
                else
                    return mid;
            }

            return -1;
        }

        private static int LinearSearch(int[] v, int key)
        {
            int pos = -1;
            for (int i = 0; i < v.Length; i++)
            {
                if (key == v[i])
                {
                    pos = i;
                    break;
                }
            }
            return pos;
        }
    }
}
