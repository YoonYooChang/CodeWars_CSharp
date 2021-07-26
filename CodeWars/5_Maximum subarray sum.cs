using System;

namespace CodeWars
{
    public static class Unit10
    {
        public static int MaxSequence(int[] arr)
        {
            int max = int.MinValue;
            int sequenceSum = 0;

            if (arr.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sequenceSum = Math.Max(0, sequenceSum) + arr[i];
                max = Math.Max(sequenceSum, max);
            }

            return max;
        }
    }
}
