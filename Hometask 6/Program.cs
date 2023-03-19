using System.ComponentModel.Design;
using System.Globalization;
using System.Text;

namespace Hometask_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compare("Hello to everyone", "hello to everyOne");

            Analyze("This is  - a new string, string!", out int numAlphabetic, out int numDigits, out int numSpecial);
            Console.WriteLine("In: \"This is  - a new string, string!\" contains {0} letters, {1}" +
                " numbers and {2} symbols.", numAlphabetic, numDigits, numSpecial);
            Console.WriteLine();

            Sort(" there are many letters in that string");

            StringBuilder sb = new StringBuilder();
            List <char> duplicate = Duplicate(" there are many letters in that string");
            sb.Append("There are duplicates: ");            
            foreach(char c in duplicate)
                sb.Append(c);
            sb.Append(" in this line \" there are many letters in that string\" ");
            Console.WriteLine(sb);
        }


        static bool Compare (string s1, string s2)
        {
            if(s1.Length != s2.Length)
                return false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                    return false;
            }
            return true;
        }

        static void Analyze(string s,out int numAlphabetic, out int numDigits, out int numSpecial)
        {
            numAlphabetic = 0;
            numDigits = 0;
            numSpecial = 0;
            foreach(char c in s)
            {
                if(char.IsLetter(c))
                    numAlphabetic++;
                else if(char.IsDigit(c))
                    numDigits++;
                else
                    numSpecial++;
            }
        }

        static string Sort(string s)
        {
            s = s.Replace(" ", "");
            char[] chars = s.ToCharArray();
            Array.Sort(chars,StringComparer.OrdinalIgnoreCase);
            s = new string(chars);  
            return s;
        }

        static List<char> Duplicate(string s)
        {
            List<char> duplicates = new List<char>();
            List<char> seen = new List<char>();
            s = s.Replace(" ", "");
            foreach (char c in s)
            {
                if (seen.Contains(c) && !duplicates.Contains(c))
                {
                    duplicates.Add(c);
                }
                else
                {
                    seen.Add(c);
                }
            }
            duplicates.Sort();
            return duplicates;
        }
    }
}