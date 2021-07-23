using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Unit8
    {
        public static IEnumerable<string> FriendOrFoe(string[] names) => names.Where(s => s.Length == 4);
    }
}
