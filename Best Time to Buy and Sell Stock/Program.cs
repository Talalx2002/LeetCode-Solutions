namespace Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] prices = { 7, 6, 4, 3, 1 };
            int profit = 0;
            profit = MaxProfit(prices);

            Console.WriteLine($"The Profit is {profit}");
        }
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0 ,  profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                for (int k = i+1; k < prices.Length; k++)
                {
                    profit = prices[k] - prices[i];

                    if(profit <= 0)
                    {
                        profit = 0;
                    }

                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }
            return maxProfit;
        }
    }
}

