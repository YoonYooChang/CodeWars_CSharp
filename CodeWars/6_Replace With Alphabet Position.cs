using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Unit6
    {
        public static string AlphabetPosition(string text)
        {
            List<char> alphabets = text.ToLower().ToList().FindAll(c => c - 'a' >= 0 && c - 'a' <= 25);

            return string.Join(" ", alphabets.Select(c => c - 'a' + 1).ToList());
        }
    }
}
