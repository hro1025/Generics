namespace Generics.interfaces;

// VARIANCE: The 'out' keyword makes the interface COVARIANT.
// This means: If Bear is an Animal, then IPoppable<Bear> can be safely treated as IPoppable<Animal>.
// It can only be used on T when T is used in an OUTPUT position (return value).
public interface IPoppable<out T>
{
    T Pop(); // T is in an output position (return type).
}
