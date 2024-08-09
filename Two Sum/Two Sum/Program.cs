namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, };
            int target = 4;
            TwoSum(num, target);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j<nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        int[] indices = { i,j};
                        return indices;
                    }
                }
            }
            return new int[0];
        }
    }
}