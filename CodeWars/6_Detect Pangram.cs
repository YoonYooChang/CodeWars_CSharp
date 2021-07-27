using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class Unit13
    {
        public static bool IsPangram(string str)
        {
            return str.ToUpper().ToCharArray().ToList().FindAll(c => Char.IsLetter(c)).GroupBy(c => c).Count() == 26;
        }
    }
}
