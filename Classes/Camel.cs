namespace Generics.Classes;

// INHERITANCE: Camel is also an Animal.
public class Camel(int humpcount, string name, int age, FoodType feed) : Animal(name, age, feed)
{
    public int HumpCount { get; set; } = humpcount;
}
