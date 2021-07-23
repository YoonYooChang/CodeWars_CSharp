using System.Linq;

namespace CodeWars
{
    public static class Unit9
    {
        public static string Rot13(string message) => new string(message.Select(c => char.IsLetter(c)? (char)(c + 13) > (char.IsLower(c) ? 'z' : 'Z') ? (char)(c + 13 - 26) : (char)(c + 13) : c).ToArray());
    }
}
