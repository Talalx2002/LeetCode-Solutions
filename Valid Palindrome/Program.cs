
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
    }
}
