# C# ObjectDisposedException Bug

This repository demonstrates a common error in C#:  `ObjectDisposedException` that happens after using the `using` statement to dispose of an object.  This happens because code attempts to access the object's methods or properties after it has already been disposed of.

The `bug.cs` file shows the error; `bugSolution.cs` demonstrates the solution.

## Bug Description
The code creates a database context using a `using` statement.  The context is correctly disposed of at the end of the `using` block. However, the code attempts to access the context again *after* it has been disposed, leading to an `ObjectDisposedException`. 

## Solution
The corrected code ensures that all operations involving the context are done within the `using` block.  No attempt is made to access it afterward.

## How to Reproduce
1. Clone this repository.
2. Open the solution in Visual Studio.
3. Run the `bug.cs` code (it will throw the exception)
4. Run the `bugSolution.cs` code (it will execute successfully)
