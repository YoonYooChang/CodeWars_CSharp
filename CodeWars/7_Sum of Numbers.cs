using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class Unit4
    {
        public static int GetSum(int a, int b)
        {
            int min = a > b ? b : a;
            int max = a > b ? a : b;
            int sum = 0;

            for (int i = min; i <= max; i++)
                sum += i;

            return sum;
        }
    }
}
