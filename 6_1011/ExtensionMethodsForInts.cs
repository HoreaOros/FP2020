using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1011
{
    static class ExtensionMethodsForInts
    {
        public static bool IsLeapYear(this int n)
        {
            return (n % 4 == 0 && n % 100 != 0) || (n % 400 == 0);
        }
        public static bool IsPrime(this int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            for (int d = 3; d <= n / 2; d = d + 2)
            {
                if (n % d == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsPrimeV2(this int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            // n = a * b, a <= b, a >=2, b >= 2
            // a <= b ==> a*a <= a*b ==> a*a <= n ==> a <= SQRT(n)
            for (int d = 3; d * d <= n; d += 2)
            {
                if (n % d == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
