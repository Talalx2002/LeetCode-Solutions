namespace Invert_Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] values = { 1, 3, 6, 9, 2, 7, 4 };

            TreeNode one = new TreeNode(values[0]);
            TreeNode three = new TreeNode(values[1]);
            TreeNode six = new TreeNode(values[2]);
            TreeNode nine = new TreeNode(values[3]);
            TreeNode two = new TreeNode(values[1],one , three);
            TreeNode seven = new TreeNode(values[1] , six , nine);
            TreeNode root = new TreeNode(values[1] , two , seven);

            TreeNode resutl = InvertTree(root);
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return root;

            TreeNode temp = new TreeNode(root.val);
            temp.left  = InvertTree(root.right);
            temp.right = InvertTree(root.left);



            return temp;
        }
    }
}
