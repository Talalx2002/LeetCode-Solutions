using System.Reflection.Metadata.Ecma335;

namespace Merge_Two_Sorted_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] values = {1,2,4,1,3,4,7};

            ListNode temp2 = new ListNode(values[2]);
            ListNode temp1 = new ListNode(values[1],temp2);

            ListNode list1 = new ListNode(values[0],temp1);

            ListNode temp3 = new ListNode(values[5]);
            ListNode temp4 = new ListNode(values[4], temp3);

            ListNode list2 = new ListNode(values[3],temp4);
            ListNode result;


            result = MergeTwoLists(list1, list2);

            Console.WriteLine(  "this is list 1");
            while (list1.next != null)
            {
                Console.WriteLine(list1.val);
                list1 = list1.next;
            }
            Console.WriteLine(list1.val);

            Console.WriteLine("this is list 2");
            while (list2.next != null)
            {
                Console.WriteLine(list2.val);
                list2 = list2.next;
            }
            Console.WriteLine(list2.val);


            Console.WriteLine("this is result");
            while (result.next != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
            Console.WriteLine(result.val);

        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();
            ListNode temp = result;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    temp.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    temp.next = list2;
                    list2 = list2.next;
                }
                temp = temp.next;
            }

            if (list1 != null)
            {
                temp.next = list1;
            }
            if (list2 != null)
            {
                temp.next = list2;
            }

            return result.next;
        }
    }
}
