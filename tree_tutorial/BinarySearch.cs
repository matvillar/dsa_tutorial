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
        } else if (root.data == data)
        {
            return true;
        } else if (root.data > data)
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

    public Node RemoveHelper(Node root, int data)
    {
        if (root == null)
        {
            return root;
        } else if (data < root.data)
        {
            root.left = RemoveHelper(root.left, data);
            
        } else if (data > root.data)
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
// Binary Search tree --> A Tree data structure, where the parent node is greater than its left child node but less than its right child node
//                    --> When everything is organized the way it should, it becomes easier to find a node.
//                    --> time complexity best case would be O(log n) and the worst case O(n).
//                    --> Space Complexity: O(n)
