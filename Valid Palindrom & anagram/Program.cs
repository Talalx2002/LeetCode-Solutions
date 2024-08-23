
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace Valid_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string s = ".,";
            Console.WriteLine(isPalindrome(s));

            string t = "aacc";
            string k = "ccac";

            Console.WriteLine($"this is anagram = {isanagram(t ,k )} ");
        }

        public static bool isPalindrome(string s)
        {
            // Convert to lowercase and remove non-alphanumeric characters
            string cleanedString = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");

            // Compare cleaned string with its reverse
            char[] arr = cleanedString.ToCharArray();
            Array.Reverse(arr);
            string reversedString = new string(arr);

            return cleanedString == reversedString;
        }

        public static bool isanagram(string s ,string t)
        {

            char[] schars = s.ToCharArray();
            char[] tchars = t.ToCharArray();

            bool flag = false;
            int index;
            if(s.Length != t.Length)
            {
                return false;
            }


            for (int i = 0; i < s.Length; i++)
            {
                index = t.IndexOf(s[i]);
                if (index > -1)
                {
                    flag = true; 
                    schars[i] = '\0';
                    tchars[index] = '\0';

                    s = new string(schars);
                    t = new string(tchars);

                }
                else
                {
                    flag = false; break;
                }
            }

            return flag;
        }
    }
}
