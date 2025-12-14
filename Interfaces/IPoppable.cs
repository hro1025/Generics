namespace Generics.interfaces;

public interface IPoppable<out T>
{
    T Pop();
}
