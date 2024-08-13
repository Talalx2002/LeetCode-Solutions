namespace Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string s = "[";

            Console.WriteLine(isValid(s));
        }

        public static bool isValid(string s)
        {
            Stack<char> myStack = new Stack<char>();
            char Top;

            for (int i = 0; i< s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    myStack.Push(s[i]);
                }
                else if ((s[i] == ')' || s[i] == '}' || s[i] == ']'))
                {
                    if (myStack.Count == 0)
                        return false;

                    Top = myStack.Pop();

                    if ((s[i] == ')' && Top != '(') || (s[i] == '}' && Top != '{') || (s[i] == ']' && Top != '['))
                    {
                        return false;
                    }
                }
            }

            return myStack.Count == 0;
        }
    }
}
