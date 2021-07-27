using System;
using System.Linq;

namespace CodeWars
{
    public static class Unit14
    {
        public static int GetLongestPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int maxLength = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    if (str.Substring(i, j - i + 1).Equals(new string(str.Substring(i, j - i + 1).Reverse().ToArray())))
                    {
                        maxLength = maxLength > j - i + 1 ? maxLength : j - i + 1;
                    }
                }
            }

            return maxLength;
        }
    }
}
