using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace ExtraPoints_Grillino.Models
{
    public class Food
    {
        [Key] public required string Name { get; set; }
        public required string Description { get; set; }
        public ushort Price { get; set; }
        public string? Ingredients { get; set; } 
        public string? SmallImagePath { get; set; }
        public string? FullImagePath { get; set; }

        public IEnumerable<string>? GetIngredients()
        {
            IEnumerable<string>? ingredients = JsonSerializer.Deserialize<IEnumerable<string>>(Ingredients);
            return ingredients;
        }
        public void SetIngredients(IEnumerable<string> ingredientList)
        {
            var newIngredients = JsonSerializer.Serialize(ingredientList);
            Ingredients = newIngredients;
        }

        public override string ToString()
        {
            return $"{Name},\n{Description},\n{string.Join(", ", GetIngredients() ?? new string[]{"empty ingredients"})}";
        }
    }
}
