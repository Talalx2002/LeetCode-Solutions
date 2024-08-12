namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            System.Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if(s.Length == 0) return 0; 

            int newCount = 0;
            int preCount = 1;
            string? newString = null;
            newString += s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (newString.Contains(s[i]) == false)
                {
                    newString += s[i];
                    preCount++;
                }
                else
                {
                    newString = "";
                    newString+= s[i];
                    newCount = Math.Max(preCount,newCount);
                    preCount= 1;
                    
                }

                
            }
            return Math.Max(preCount,newCount);
        }
    }
}