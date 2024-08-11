using System.Runtime.CompilerServices;
using System.Xml.Schema;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int results = 0;

        int[][] accounts = new int[][]
        {
            [1,2],
            [3, 4]
        };

        results = MaximumWealth(accounts);
        Console.WriteLine($"This is the output of the function {results}");
    }

    public static int MaximumWealth(int[][] accounts)
    {
        int sum = 0 , maximum = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            if(sum > maximum)
            {
                maximum = sum;
            }
            sum = 0;

        }
        return maximum;
    }
}