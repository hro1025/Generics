using System.ComponentModel.DataAnnotations.Schema;

namespace Generics.Classes;

public class Bear(string coat, string name, int age, FoodType feed) : Animal(name, age, feed)
{
    public string CoatColor { get; set; } = coat;
}
