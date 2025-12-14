using System.ComponentModel.DataAnnotations.Schema;

namespace Generics.Classes;

// INHERITANCE: Bear is an Animal. This is what allows it to be used in AnimalPen<Bear>
// due to the constraint 'where T : Animal' (explained below).
public class Bear(string coat, string name, int age, FoodType feed) : Animal(name, age, feed)
{
    public string CoatColor { get; set; } = coat;
}
