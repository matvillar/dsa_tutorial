# Stacks

## Introduction
A stack is a fundamental data structure that follows the Last In, First Out (LIFO) principle. It is widely used in various applications such as managing browser history, undo mechanisms in text editors, and function call management in programming languages.

## Implementation Details

### Anatomy of a Stack
- **Push**: Add an element to the top of the stack.
- **Pop**: Remove the top element from the stack.
- **Peek**: View the top element without removing it.

### Implementations
#### Array-based Stack
An array-based stack uses a fixed-size array. When the stack is full, it needs to be resized, which can be costly in terms of time and space.

#### Linked List-based Stack
A linked list-based stack dynamically adjusts its size, making it more flexible than an array-based stack. Each element in the stack is a node in a linked list.

### Efficiency of Common Operations
- **Time Complexity**: O(1) for push, pop, and peek operations.
- **Space Complexity**: O(n) where n is the number of elements in the stack.

## Examples of simple use of Stacks

### Working with Stacks
#### Printing Items in a Stack
To print all items in a stack, iterate over it using a foreach loop:
```csharp
Stack<int> stackInt = new Stack<int>();
stackInt.Push(1);
stackInt.Push(2);
stackInt.Push(3);
stackInt.Push(4);

foreach (var n in stackInt)
{
Console.WriteLine(n); // This will print: 4 3 2 1
}
```
#### Removing the Top Item
To remove the top item, use Pop():
```csharp
stackInt.Pop();
foreach (var n in stackInt)
{
    Console.WriteLine(n); // This will print: 3 2 1 
}
```
Pop() can also return the removed item:
```csharp
int popped = stackInt.Pop();
Console.WriteLine(popped); // 3
```
#### Viewing the Top Item
To view the top item without removing it, use Peek():
```csharp
Console.WriteLine(stackInt.Peek()); // 2
```
### Defining a Stack of Strings
```csharp
Stack<string> stackString = new Stack<string>();
stackString.Push("Yes");
stackString.Push("No");
stackString.Push("Maybe");
stackString.Push("Always");

foreach (var s in stackString)
{
Console.WriteLine(s); // This will print: Always Maybe No Yes
}
```
#### Searching for an Item
```csharp
To search for an item in the stack, use Contains():
if (stackString.Contains("Maybe"))
{
Console.WriteLine($"The stack contains 'Maybe'.");
}
else
{
Console.WriteLine($"The stack does not contain 'Maybe'.");
}
```
## Summary:
### Uses of Stack
#### Stacks are useful in various scenarios, such as:

1. Undo/Redo Features: Managing actions in text editors.
2. Browser History: Moving through previous pages.
3. Backtracking Algorithms: Solving mazes and puzzles.
4. Call Stack: Managing function calls and returns.
