using Generics.interfaces;

namespace Generics.Classes;

// GENERIC CLASS WITH MULTIPLE CONSTRAINTS:
public class AnimalPen<T>(int animalcount) : IPoppable<T>, IPushable<T>
    // CLASS CONSTRAINT: 'where T : Animal' is a hard rule.
    // It enforces that the type T used to instantiate AnimalPen MUST be the Animal class or derived from it.
    // This provides type safety and guarantees that all objects in the pen have the 'Name', 'Age', and 'Feed' properties.
    where T : Animal
{
    private int _position;
    private T[] _pen = new T[animalcount];

    public T Pop() => _pen[--_position]; // Implementation of IPoppable<T>

    public void Push(T animal) => _pen[_position++] = animal; // Implementation of IPushable<T>

    public int Count => _position; // Property used by ZooFeeder.Feed
}
