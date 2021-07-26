using System.Linq;

namespace CodeWars
{
    public static class Unit12
    {
        public static int Persistence(long n)
        {
            int count = 0;

            while (n >= 10)
            {
                int[] digits = n.ToString().ToCharArray().Select(c => c - '0').ToArray();
                int value = 1;

                foreach (int digit in digits)
                {
                    value *= digit;
                }

                n = value;
                count++;
            }

            return count;
        }
    }
}
