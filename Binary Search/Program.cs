namespace Binary_Searchs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] nums = { 2,5};
            int target = 2;

            Console.WriteLine($"This is the Index of target = {Search(nums , target)}");
        }
        public static int Search(int[] nums, int target)
        {
            int mid;
            int startIndex = 0;
            int endIndex = nums.Length -1 ;

            while (startIndex <= endIndex)
            {
                mid = (startIndex + endIndex) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                {
                    startIndex = mid +1 ;
                }
                else
                {
                    endIndex = mid -1 ;
                }
            }


            return -1;
        }
    }
}
