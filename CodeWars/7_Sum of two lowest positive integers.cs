using System;

namespace CodeWars
{
    public static class Unit3
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);

            return numbers[0] + numbers[1];
        }
    }
}
