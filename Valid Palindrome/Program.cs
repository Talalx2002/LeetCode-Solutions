
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


            Console.Write($"this is before {s}\n");

            s = Regex.Replace(s, "[^a-zA-Z0-9]", " ").ToLower();
            /*string ns = Regex.Replace(s, "[^a-zA-Z0-9]", " ").ToLower();*/

            Console.Write($"this is after {s}kdkfjdkfdk\n");


            if (s == " ")
            {
                return true;
            }

            s = s.Replace(" ", "");
            Console.Write($"this is after removing space {s}\n");
            bool flag = false;
            int k = s.Length - 1;

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"This is s[i] = {s[i]} and this is s[k] = {s[k]}");
                if ((s[i] == s[k]))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }


                if (i == k)
                {
                    break;
                }
                k--;
            }

            return flag;
        }
    }
}
