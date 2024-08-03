using BinarySearchTree.Models;
using BinarySearchTree.Services;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTreeServices tree = new();

            tree.Insert(new Node(5));
            tree.Insert(new Node(1));
            tree.Insert(new Node(9));
            tree.Insert(new Node(2));
            tree.Insert(new Node(7));
            tree.Insert(new Node(3));
            tree.Insert(new Node(6));
            tree.Insert(new Node(4));
            tree.Insert(new Node(8));

            tree.Display();

            int targetNumber = 5;
            Console.WriteLine($"Is number {targetNumber} exit: {tree.Search(targetNumber)}");

            tree.Remove(5); 
            tree.Display();

        }
    }
}
