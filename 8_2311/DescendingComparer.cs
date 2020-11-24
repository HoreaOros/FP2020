using System;
using System.Collections.Generic;

namespace _8_2311
{
    internal class DescendingComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if (x > y)
                return -1;
            else
                return 1;
        }
    }
}