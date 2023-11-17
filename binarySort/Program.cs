namespace binarySort
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }

        Random r = new Random();

    }

    public class BinaryTree
    {
        public BinaryTreeNode root = null;
        public BinaryTreeNode comparer;

        public void add(int n)
        {
            BinaryTreeNode node = new BinaryTreeNode(n);
            if (root != null)
            {
                root = node;
            }
            else
            {
                comparer = root;
            }

            while (comparer != null)
            {
                if (comparer.data < node.data)
                {

                }
            }
        }

        public void search(BinaryTreeNode node)
        {
            if (comparer.data == node.data)
            {

            }
            else if (comparer.data < node.data)
            {
               comparer = 


                    '
                    
                    
                    '
            }
        }

        public void print()
        {

        }


    }

    public class BinaryTreeNode
    {
        public int data;
        public BinaryTreeNode left;
        public BinaryTreeNode right;
        public BinaryTreeNode mid;

        public BinaryTreeNode(int date)
        {
            this.data = data;
        }
    }

}