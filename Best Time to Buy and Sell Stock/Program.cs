namespace Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int profit = 0;
            profit = MaxProfit(prices);

            Console.WriteLine($"The Profit is {profit}");
        }
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0, profit = 0, minprice = int.MaxValue;

            foreach (int price in prices)
            {
                minprice = price < minprice ? price : minprice;

                profit = price - minprice;

                maxProfit = profit > maxProfit ? profit : maxProfit;
            }

            return maxProfit;
        }
    }
}

