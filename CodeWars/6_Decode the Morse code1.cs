namespace CodeWars
{
    public static class Unit11
    {
        public static string Decode(string morseCode)
        {
            string decodeString = string.Empty;
            bool isNull = false;

            foreach (string s in morseCode.Trim().Split(new char[] { ' ', '\t' }))
            {
                if (!string.IsNullOrEmpty(s))
                {
                    //Only work CodeWars
                    //decodeString += MorseCode.Get(s);
                    isNull = false;
                }
                else
                {
                    if (!isNull) // first space skip;
                    {
                        isNull = true;
                        continue;
                    }

                    decodeString += " ";
                }
            }
            return decodeString;
        }
    }
}
