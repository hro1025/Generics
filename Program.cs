using Generics.Classes; // Imports the namespace containing AnimalPen, Bear, Camel, etc.

namespace Generics; // The main namespace.

class Program
{
    static void Main(string[] args)
    {
        // ----------------------------------------------------------------------------------
        // Part 1: Basic Generics (Type Safety and Reusability with Stack<T>)
        // ----------------------------------------------------------------------------------

        // GENERIC INSTANTIATION:
        // By specifying <int>, the compiler creates a type-safe stack guaranteed to hold only integers.
        var intStack = new Stack<int>(10);

        // Type safety ensures these calls are valid and prevent accidental insertion of other types (e.g., strings).
        intStack.Push(10);
        intStack.Push(23);

        // No casting is required, and the return type is guaranteed to be 'int'.
        // This avoids the performance hit and runtime error risks of using a non-generic object stack.
        var number = intStack.Pop();

        // Built-in .NET generic list, demonstrating the common use of generics in the framework.
        List<int> numberList = new List<int>();
        numberList.Add(10);

        // ----------------------------------------------------------------------------------
        // Part 2: Generics with Constraints (AnimalPen<T>)
        // ----------------------------------------------------------------------------------

        // GENERIC REUSABILITY:
        // The AnimalPen<T> is used for two different types (Bear and Camel).
        // The type constraint in AnimalPen<T> ensures only classes derived from Animal can be used here.
        var bearPen = new AnimalPen<Bear>(5); // Pen holds only Bears.
        var camelPen = new AnimalPen<Camel>(3); // Pen holds only Camels.

        // Adding strongly typed objects. Type safety prevents putting a Camel in the bearPen.
        bearPen.Push(new Bear("snow", "Gunnar", 15, FoodType.carnivore));
        bearPen.Push(new Bear("brown", "Åshild", 29, FoodType.carnivore));
        camelPen.Push(new Camel(2, "Einar", 20, FoodType.Herbicore));
        camelPen.Push(new Camel(1, "Ingolf", 15, FoodType.Herbicore));

        // ----------------------------------------------------------------------------------
        // Part 3: Generics with Constraints (ZooFeeder.Feed<T>)
        // ----------------------------------------------------------------------------------

        // GENERIC METHOD USAGE:
        // ZooFeeder.Feed can take *any* type of AnimalPen (AnimalPen<Bear> or AnimalPen<Camel>)
        // because the Feed method uses generic constraints that are satisfied by both classes.
        ZooFeeder.Feed(bearPen, bearPen.Count);
        ZooFeeder.Feed(camelPen, camelPen.Count);
    }
}

// GENERIC CLASS DEFINITION:
// <T> is the type parameter. It provides the template for the type.
class Stack<T>(int stackSize)
{
    private int _position; // Tracks the current position.

    // The storage array is dynamically typed based on what the user specifies (e.g., int[], string[]).
    private T[] _stack = new T[stackSize];

    // The method parameter is of type T. Strong type safety in the input.
    public void Push(T obj) => _stack[_position++] = obj;

    // The method returns type T. Strong type safety in the output (no casting).
    public T Pop() => _stack[--_position];
}
