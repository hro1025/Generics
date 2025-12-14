using Generics.interfaces;

namespace Generics.Classes;

public static class ZooFeeder
{
    // GENERIC METHOD DEFINITION:
    // This is the most complex generic signature in your code!
    public static void Feed<T>(IPoppable<T> animals, int animalcount)
        // CONSTRAINT 1: The 'animals' parameter must implement IPoppable<T>.
        // CONSTRAINT 2 (T Type): 'where T : Animal' is the second, crucial constraint.
        // This constraint guarantees that the type being pulled out of the IPoppable<T> (the pen)
        // is an Animal, which means we can safely access 'animal.Name' and 'animal.Feed' below.
        where T : Animal
    {
        for (var i = 0; i < animalcount; i++)
        {
            var animal = animals.Pop(); // Pop() is guaranteed to return type T (which is an Animal).

            // This switch expression is safe because the 'where T : Animal' constraint
            // ensures the 'animal' variable has the 'Feed' property.
            var food = animal.Feed switch
            {
                FoodType.Herbicore => "a fresh salad!",
                FoodType.omnivore => "anything we could find!",
                FoodType.carnivore => "a nice, juicy salmon!",
                _ => throw new NotImplementedException("This Foodtype is not yet implemented"),
            };

            Console.WriteLine($"Fed animal {animal.Name} {food}");
        }
    }
}
