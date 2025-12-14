using Generics.Classes;

namespace Generics;

class Program
{
    static void Main(string[] args)
    {
        var intStack = new Stack<int>(10);

        intStack.Push(10);
        intStack.Push(23);

        var number = intStack.Pop();

        List<int> numberList = new List<int>();
        numberList.Add(10);

        var bearPen = new AnimalPen<Bear>(5);
        var camelPen = new AnimalPen<Camel>(3);

        bearPen.Push(new Bear("snow", "Gunnar", 15, FoodType.carnivore));
        bearPen.Push(new Bear("brown", "Åshild", 29, FoodType.carnivore));
        camelPen.Push(new Camel(2, "Einar", 20, FoodType.Herbicore));
        camelPen.Push(new Camel(1, "Ingolf", 15, FoodType.Herbicore));

        ZooFeeder.Feed(bearPen, bearPen.Count);
        ZooFeeder.Feed(camelPen, camelPen.Count);
    }
}

class Stack<T>(int stackSize)
{
    private int _position;
    private T[] _stack = new T[stackSize];

    public void Push(T obj) => _stack[_position++] = obj;

    public T Pop() => _stack[--_position];
}

// class ObjectStack(int stackSize)
// {
//     private int _position;
//     private object[] _stack = new object[stackSize];

//     public void Push(object obj) => _stack[_position++] = obj;

//     public object Pop() => _stack[--_position];
// }

// class IntegerStack(int stackSize)
// {
//     private int _position;
//     private int[] _stack = new int[stackSize];

//     public void Push(int obj) => _stack[_position++] = obj;

//     public int Pop() => _stack[--_position];
// }
