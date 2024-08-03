# Binary Search Tree Services

This repository contains an implementation of a Binary Search Tree (BST) in C#. The implementation includes basic operations such as insertion, search, and removal of nodes. Additionally, there are methods to display the BST.

## Implementation

### BinarySearchTreeServices Class

The `BinarySearchTreeServices` class provides methods to perform various operations on the binary search tree:

- **Insert(Node node)**: Inserts a node into the BST using a helper method to find the correct position for the new node.
- **Search(int data)**: Searches for a node with the specified data using a recursive helper method.
- **Remove(int data)**: Removes a node with the specified data from the BST, using a helper method to handle various cases (no children, one child, two children).
- **Display()**: Displays the nodes of the BST in in-order traversal using a recursive helper method.

### Program Class

The `Program` class contains the `Main` method which tests the `BinarySearchTreeServices` class. It demonstrates inserting nodes, displaying the tree, searching for a node, and removing a node.

### Time Complexity

The time complexity of the `Search` method in a BST depends on the structure of the tree:

- **Best Case**: \( O(\log n) \)
- **Worst Case**: \( O(n) \)
