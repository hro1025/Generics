namespace Generics.interfaces;

public interface IPushable<in T>
{
    void Push(T obj);
}
