using Generics.interfaces;

namespace Generics.Classes;

public static class ZooFeeder
{
    public static void Feed<T>(IPoppable<T> animals, int animalcount)
        where T : Animal
    {
        for (var i = 0; i < animalcount; i++)
        {
            var animal = animals.Pop();
            var food = animal.Feed switch
            {
                FoodType.Herbicore => "a fresh salad!",
                FoodType.cenivore => "anything we could find!",
                FoodType.carnivore => "a nice, juicy salmon!",
                _ => throw new NotImplementedException("This Foodtype is not yet implemented"),
            };

            Console.WriteLine($"Fed animal {animal.Name} {food}");
        }
    }
}
