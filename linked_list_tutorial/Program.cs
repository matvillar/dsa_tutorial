// See https://aka.ms/new-console-template for more information
// Linked List Tutorial

// Doubly linked list means that each node knows where the previous and the next node is,
// and finishes when the next node value = null.
var linkedList = new LinkedList<string>(); // this is a doubly linked list

linkedList.AddLast("pepe");  // Adds "pepe" to the end of the list
linkedList.AddLast("mateo"); // Adds "mateo" to the end of the list
linkedList.AddFirst("carlos"); // Adds "carlos" to the start of the list
linkedList.AddFirst("matias"); // Adds "matias" to the start of the list

// We can also remove an item from the linked list.
linkedList.Remove("mateo"); // Finds the matching string and then removes it.

// Other Remove options
// linkedList.RemoveFirst(); // Removes starting item
// linkedList.RemoveLast(); // Removes last item


foreach (var name in linkedList)
{
    Console.WriteLine(name); // This will print matias -> carlos -> pepe 
}

// other add methods 
linkedList.AddBefore(linkedList.Find("matias"), "Before Matias");
linkedList.AddAfter(linkedList.Find("pepe"), "After Pepe"); 
                          
foreach (var name in linkedList)
{
    Console.WriteLine(name); // Before Matias --> matias --> carlos --> pepe --> After Pepe
}                      

// Summary

// LinkedList --> they are able to store Nodes in 2 parts, one will be data + address.
//                Nodes are store in a non-consecutive memory location. 
//                Each Item is linked using pointers.


//                  Singly Linked List
//    +-----+-------+    +-----+-------+    +-----+-------+
//   |Data |  Next |--> |Data |  Next | --> |Data |  Next | --> null
//   

//                  Doubly Linked List
//      null<--|  Prev |Data |  Next |-->    |  Prev |Data |  Next |-->    |  Prev |Data |  Next |--> null


    
