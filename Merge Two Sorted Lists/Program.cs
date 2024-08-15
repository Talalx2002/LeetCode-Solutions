namespace Merge_Two_Sorted_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] values = {1,2,3,4,5,6,7,};

            ListNode temp2 = new ListNode(values[2]);
            ListNode temp1 = new ListNode(values[1],temp2);

            ListNode list1 = new ListNode(values[0],temp1);

            ListNode temp3 = new ListNode(values[3]);
            ListNode temp4 = new ListNode(values[4], temp3);

            ListNode list2 = new ListNode(values[5],temp4);
            ListNode result;

            result = MergeTwoLists(list1, list2);

            Console.WriteLine(result.ToString());

        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode tempList1 ;
            ListNode tempList2;
            while (list1.next != null)
            {
                tempList1 = list1;
                tempList2 = list2;

                list1.next = tempList2;
                list2.next = tempList1;

                list1.next = list2.next;

                Console.WriteLine("working");

            }
            return list1;
        }
    }
}
