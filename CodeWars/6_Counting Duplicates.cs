using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public static class Unit2
    {
        public static int DuplicateCount(string str)
        {
            int count = 0;
            List<char> strList = str.ToLower().ToList();

            while (strList.Count != 0)
            {
                char firstChar = strList[0];

                if (strList.FindAll(c => c == firstChar).Count > 1)
                {
                    count++;
                }

                strList.RemoveAll(c => c == firstChar);
            }

            return count;
        }
    }
}
