using System;

namespace CodeWars
{
    public static class Unit5
    {
        public static string SpinWords(string sentence)
        {
            string reversSentence = string.Empty;

            foreach (var word in sentence.Split(" "))
            {
                if (word.Length >= 5)
                {
                    char[] charArray = word.ToCharArray();
                    Array.Reverse(charArray);
                    reversSentence += new string(charArray);
                }
                else
                {
                    reversSentence += word;
                }
                reversSentence += " ";
            }
            
            return reversSentence.Trim();
        }
    }
}
