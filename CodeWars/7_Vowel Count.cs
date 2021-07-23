using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Unit7
    {
        public static int GetVowelCount(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            return vowels.Select(c => str.Count(ch => ch == c)).Sum();
        }
    }
}
