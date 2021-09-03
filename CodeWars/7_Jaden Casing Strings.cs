using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class Unit17
    {
        public static string ToJadenCase(this string phrase) => string.Join(" ", phrase.Split(' ').Select(word => word.ToUpper().Substring(0, 1) + word.ToLower().Substring(1)));
    }
}
