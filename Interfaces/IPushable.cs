namespace Generics.interfaces;

// VARIANCE: The 'in' keyword makes the interface CONTRAVARIANT.
// This means: If Animal is a superclass of Bear, then IPushable<Animal> can be safely treated as IPushable<Bear>.
// It can only be used on T when T is used in an INPUT position (method parameter).
public interface IPushable<in T>
{
    void Push(T obj); // T is in an input position (parameter).
}
