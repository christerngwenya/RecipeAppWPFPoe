using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeAppWPF
{
    public class RecipeBook
    {
        private static RecipeBook _instance;
        public static RecipeBook Instance => _instance ?? (_instance = new RecipeBook());

        private List<Recipe> recipes = new List<Recipe>();

        private RecipeBook() { }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public Recipe GetRecipe(string name)
        {
            return recipes.FirstOrDefault(r => r.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
        }

        public List<Recipe> GetAllRecipes()
        {
            return recipes;
        }
    }
}
