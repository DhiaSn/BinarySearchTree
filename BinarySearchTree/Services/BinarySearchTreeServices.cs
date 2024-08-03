using BinarySearchTree.Models;

namespace BinarySearchTree.Services
{
    public class BinarySearchTreeServices
    {
        private Node _root { get; set; }

        #region Insert Methods

        #region Insert
        public void Insert(Node node)
        {
            _root = InsertHelper(_root, node);
        }

        #endregion

        #region InsertHelper
        private Node InsertHelper(Node root, Node node)
        {
            int data = node.Data;

            if (root == null)
            {
                root = node;
                return root;
            }
            else if (data < root.Data)
                root.Left = InsertHelper(root.Left, node);
            else
                root.Right = InsertHelper(root.Right, node);

            return root;
        }
        #endregion

        #endregion

        #region Display Methods

        #region Display
        public void Display()
        {
            DisplayHelper(_root);
        }
        #endregion

        #region DisplayHelper
        private void DisplayHelper(Node root)
        {
            if (root != null)
            {
                DisplayHelper(root.Left);
                Console.WriteLine(root.Data);
                DisplayHelper(root.Right);
            }
        }
        #endregion

        #endregion

        #region Search Methods

        #region Search
        public bool Search(int data)
        {
            return SearchHelper(_root, data);
        }
        #endregion

        #region SearchHelper
        private bool SearchHelper(Node root, int data)
        {
            if (root == null)
                return false;
            else if (root.Data == data)
                return true;
            else if (data > root.Data)
                return SearchHelper(root.Right, data);
            else
                return SearchHelper(root.Left, data);
        }
        #endregion

        #endregion

        #region Remove Methods

        #region Remove
        public void Remove(int data)
        {
            if (Search(data))
                RemoveHelper(_root, data);
            else
                Console.WriteLine($"the data \"{data}\" dosen't exist!"); 
        }
        #endregion

        #region RemoveHelper
        private Node RemoveHelper(Node root, int data)
        {
            if (root == null)
                return root; 
            else if(data < root.Data)
                root.Left = RemoveHelper(root.Left, data);
            else if (data > root.Data)
                root.Right = RemoveHelper(root.Right, data);
            else
            {
                if (root.Left == null && root.Right == null)
                    root = null; 
                else if (root.Right != null)
                {
                    root.Data = Successor(root); 
                    root.Right = RemoveHelper(root.Right, root.Data);
                }
                else
                {
                    root.Data = Predecessor(root);
                    root.Left = RemoveHelper(root.Left, root.Data);
                }

            }

            return root;
        }
        #endregion

        #region Successor
        private int Successor(Node root)
        {
            root = root.Right;

            while (root.Left != null)
                root = root.Left;

            return root.Data;
        }
        #endregion

        #region Predecessor
        private int Predecessor(Node root)
        {
            root = root.Left;

            while (root.Right != null)
                root = root.Right;

            return root.Data;
        }
        #endregion

        #endregion

    }
}
