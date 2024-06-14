using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppWPF
{
    public class Recipe
    {
        public string Name { get; private set; }
        public List<Ingredient> Ingredients { get; private set; } = new List<Ingredient>();

        public Recipe(string name)
        {
            Name = name;
        }

        public void AddIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }
}
