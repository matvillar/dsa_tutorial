// See https://aka.ms/new-console-template for more information

using stack_tutorial;

BrowseHistoryExample browserHistory = new BrowseHistoryExample();
browserHistory.Visit("google.com");
browserHistory.Visit("youtube.com");
browserHistory.Visit("github.com");

Console.WriteLine(browserHistory.Back()); // Output: youtube.com
Console.WriteLine(browserHistory.Back()); // Output: google.com
Console.WriteLine(browserHistory.Forward()); // Output: youtube.com









// Stacks = LIFO data structure, this means Last-in First-out.
// Imagine stacks as a 'pancake tower' where we store objects on top of each others.
// Push() method to add to the top
// Pop() to remove from top.
//Peek() View the top element without removing it.




// defining a new stack of integers
// Stack<int> stackInt = new Stack<int>();
// stackInt.Push(1);
// stackInt.Push(2);
// stackInt.Push(3);
// stackInt.Push(4);

// to print all of the items in a stack  we need to use a for loop

// foreach (var n in stackInt)
// {
//     Console.WriteLine(n); // this will print: 4 3 2 1 
// }
// // So if we want to remove the top Item we need to use Pop()
// stackInt.Pop();
// foreach (var n in stackInt)
// {
//     Console.WriteLine(n); // this will print: 3 2 1 
// }
// // At the same time Pop() can return the removed Item:
// int popped =  stackInt.Pop();
// Console.WriteLine(popped); // 3


// However, if we only want to check the top item without removing it
// We can use Peek()
// Console.WriteLine(stackInt.Peek()); // 2
//
// // defining a new stack of strings
// Stack<string> stackString = new Stack<string>();
// stackString.Push("Yes");
// stackString.Push("No");
// stackString.Push("Maybe");
// stackString.Push("Always");

// stacks will run out of memory 
// for (var i = 0; i < 1000000000; i++)
// {
//     stackString.Push("Pepe");
// }

// foreach (var s in stackString)
// {
//     Console.WriteLine(s); // this will print: Always
//                           // Maybe
//                           // No
//                           // Yes
//                           // 
// }
//
// // We can also search for an Item in a stack using .Contains()
//
// if (stackString.Contains("Maybe")) // The stack contains 'Maybe'.
//                                    
// {
//     Console.WriteLine($"The stack contains '{"Maybe"}'.");
// }
// else
// {
//     Console.WriteLine($"The stack does not contain '{"Maybe"}'.");
// }

// Some uses of Stack:
// 1. Undo/redo features in text editors
// 2. Moving through browser history
// 3. Backtracking algorithms(maze)
// 4. Call Stack

