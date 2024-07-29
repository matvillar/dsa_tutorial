# Linked List

## Introduction
A linked list is a linear data structure in which elements are stored in nodes. Each node contains a data part and a reference (or link) to the next node in the sequence. Unlike arrays, linked lists do not store data in contiguous memory locations.

## Types of Linked Lists
- **Singly Linked List**: Each node points to the next node in the sequence.
- **Doubly Linked List**: Each node points to both the next and the previous nodes.
- **Circular Linked List**: The last node points back to the first node, forming a circle.

## Pros and Cons of Linked Lists vs. Arrays

| Feature            | Linked List                              | Array                                    |
|--------------------|------------------------------------------|------------------------------------------|
| Memory Allocation  | Dynamic memory allocation.               | Fixed-size memory allocation.           |
| Insertion          | O(1) if at the beginning or end.         | O(n) due to shifting elements.           |
| Deletion           | O(1) if the node is known.               | O(n) due to shifting elements.           |
| Access             | O(n) for any element.                    | O(1) for any element.                    |
| Memory Usage       | More memory due to pointers.             | Less memory as no pointers needed.       |

### Anatomy of a Linked List Node
- **Data**: The value stored in the node.
- **Next**: A reference to the next node in the list (for singly and doubly linked lists).
- **Previous**: A reference to the previous node in the list (for doubly linked lists).

## Example Problem: Implementing a Singly Linked List in C#
#### For my examples I will be working on a Doubly LinkedList:
A doubly linked list means that each node knows where the previous and the next node is, and it finishes when the next node value = null.
```csharp
// Linked List Tutorial Adding Nodes

var linkedList = new LinkedList<string>(); // this is a doubly linked list

linkedList.AddLast("pepe");  // Adds "pepe" to the end of the list
linkedList.AddLast("mateo"); // Adds "mateo" to the end of the list
linkedList.AddFirst("carlos"); // Adds "carlos" to the start of the list
linkedList.AddFirst("matias"); // Adds "matias" to the start of the list
```
####
We can also remove an item from the linked list.
```csharp
linkedList.Remove("mateo"); // Finds the matching string and then removes it.

// Other Remove options
 linkedList.RemoveFirst(); // Removes starting item
 linkedList.RemoveLast(); // Removes last item
``` 
#### After building our linkedList, we can loop through each item.
```csharp
foreach (var name in linkedList)
{
    Console.WriteLine(name); // This will print matias -> carlos -> pepe 
}
```
#### Other Adding Methods:
```csharp
foreach (var name in linkedList)
{
    Console.WriteLine(name); // Before Matias --> matias --> carlos --> pepe --> After Pepe
}
```

### Operations on a Linked List
- **Insertion**: Adding a new node to the list.
- **Deletion**: Removing a node from the list.
- **Traversal**: Accessing each node in the list.
- **Search**: Finding a node with a specific value.

## Summary:
### LinkedList --> 
1. They are able to store Nodes in 2 parts, one will be data + address.
2. Nodes are store in a non-consecutive memory location.
3. Each Item is linked using pointers.

### So the advantages as we can see are:
 1. Dynamic Data Structure meaning that can allocate needed memory while running
 2. Easy insertion and deletion of Nodes ----> O(1)
 3. Zero/low memory wasted. 