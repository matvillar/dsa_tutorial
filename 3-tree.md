# Tree Data Structure

## Introduction
A tree is a hierarchical data structure that consists of nodes, having a start line with a single node designated as the root. Each node can have zero or more child nodes, and nodes with no children are called leaves. Trees are widely used in various applications such as hierarchical data representation, searching algorithms, and more. The purpose of this tutorial is to get to know this data structure and implement it in a challenge.

## Types of Trees
- **Binary Tree**: A tree where each node has at most two children.
- **Binary Search Tree (BST)**: A binary tree where the left child of a node contains only nodes with values less than the parent node, and the right child contains only nodes with values greater than the parent node.
- **AVL Tree**: A self-balancing binary search tree where the difference between heights of left and right subtrees cannot be more than one for all nodes.
- **Red-Black Tree**: A self-balancing binary search tree where nodes can be either red or black, ensuring the tree remains balanced during insertions and deletions.

## Basic Operations
- **Insertion**: Adding a new node to the tree.
- **Deletion**: Removing a node from the tree.
- **Traversal**: Visiting all nodes in a specific order (e.g., in-order, pre-order, post-order).

# Binary Search Tree Tutorial

## Code Implementation

```csharp
namespace tree_tutorial;

public class BinarySearch
{
    private Node root;

    public void Insert(Node node)
    {
        root = InsertHelper(root, node);
    }

    private Node InsertHelper(Node root, Node node)
    {
        int data = node.data;
        if (root == null)
        {
            root = node;
            return root;
        } 
        else if(data < root.data)
        {
            root.left = InsertHelper(root.left, node);
        }
        else
        {
            root.right = InsertHelper(root.right, node);
        }
        return root;
    }

    public void Display()
    {
        DisplayHelper(root);
    }

    private void DisplayHelper(Node root)
    {
        if (root != null)
        {
            // Displaying values in ascending order
            DisplayHelper(root.left); // lowest value
            Console.WriteLine(root.data);
            DisplayHelper(root.right);
        }
    }

    public Boolean Search(int data)
    {
        return SearchHelper(root, data);
    }

    private Boolean SearchHelper(Node root, int data)
    {
        if (root == null)
        {
            return false;
        } 
        else if (root.data == data)
        {
            return true;
        } 
        else if (root.data > data)
        {
            return SearchHelper(root.left, data);
        }
        else
        {
            return SearchHelper(root.right, data);
        }
    }

    public void Remove(int data)
    {
        if (Search(data))
        {
            RemoveHelper(root, data);
        }
        else
        {
            Console.WriteLine("Data --> " + data +" was not found.");
        }
    }

    private Node RemoveHelper(Node root, int data)
    {
        if (root == null)
        {
            return root;
        } 
        else if (data < root.data)
        {
            root.left = RemoveHelper(root.left, data);
        } 
        else if (data > root.data)
        {
            root.right = RemoveHelper(root.right, data);
        }
        else 
        {
            // if we reach else statement we found our node
            if (root.left == null && root.right == null)
            {
                // this means the node is a leaf node
                root = null;
            }
            else if (root.right != null)
            {
                // here we can find the next bigger and replace
                root.data = BiggerValue(root);
                root.right = RemoveHelper(root.right, root.data);
            }
            else
            {
                root.data = LowerValue(root);
                root.left = RemoveHelper(root.left, root.data);
            }
        }
        return root;
    }

    private int BiggerValue(Node root)
    {
        // We are trying to find the least value below the right child of this root node
        root = root.right;
        while (root.left != null)
        {
            root = root.left;
        }
        return root.data;
    }    

    private int LowerValue(Node root)
    {
        // We are trying to find the greatest value below the left child of this root node
        root = root.left;
        while (root.right != null)
        {
            root = root.right;
        }
        return root.data;
    }
}

```
## Benefits of Binary Search
### 1. Efficiency: 
Binary search has a time complexity of O(log n), making it significantly faster than linear search, which has a time complexity of O(n). This efficiency makes binary search ideal for large datasets.
### 2. Simplicity: 
The binary search algorithm is relatively simple to implement and understand. The logic of repeatedly dividing the search interval in half until the target value is found (or the interval is empty) is straightforward and easy to grasp.
### 3. Performance: 
Due to its logarithmic time complexity, binary search performs very well with large data sets. Even with millions of elements, binary search can quickly locate an item.
### 4. Memory Usage: 
Binary search does not require additional memory space proportional to the size of the input data. It uses a constant amount of extra space (O(1)), making it space-efficient.

## Where we can apply it? 

### Real World Problems
#### Tree Data Structure:
1. File System Organization: Operating systems often use tree structures to represent file directories and their hierarchical relationships.
2. Database Indexing: Databases use B-trees and other tree structures to manage indexes, enabling quick data retrieval.
3. Routing Algorithms: Trees are used in network routing protocols to determine the most efficient paths for data transmission.