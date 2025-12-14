using System.Dynamic;

namespace Generics.Classes;

public class Animal(string name, int age, FoodType Feed)
{
    public string Name { get; set; } = name;

    public int Age { get; set; } = age;

    public FoodType Feed { get; set; } = Feed;
}
