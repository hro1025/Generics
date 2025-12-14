using Generics.interfaces;

namespace Generics.Classes;

public class AnimalPen<T>(int animalcount) : IPoppable<T>, IPushable<T>
    where T : Animal
{
    private int _position;
    private T[] _pen = new T[animalcount];

    public T Pop() => _pen[--_position];

    public void Push(T animal) => _pen[_position++] = animal;

    public int Count => _position;
}
