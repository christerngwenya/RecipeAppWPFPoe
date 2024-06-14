using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RecipeAppWPF
{
    /// <summary>
    /// Interaction logic for EnterRecipeWindow.xaml
    /// </summary>
    public partial class EnterRecipeWindow : Window
    {
        private List<Ingredient> ingredients = new List<Ingredient>();

        public EnterRecipeWindow()
        {
            InitializeComponent();
        }

        private void AddIngredients_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(NumberOfIngredientsTextBox.Text, out int numIngre))
            {
                for (int i = 0; i < numIngre; i++)
                {
                    var ingredientWindow = new IngredientWindow();
                    if (ingredientWindow.ShowDialog() == true)
                    {
                        ingredients.Add(ingredientWindow.Ingredient);
                        IngredientsListBox.Items.Add($"{ingredientWindow.Ingredient.Name} ({ingredientWindow.Ingredient.Calories} calories, {ingredientWindow.Ingredient.FoodGroup})");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid number of ingredients");
            }
        }

        private void SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            var newRecipe = new Recipe(RecipeNameTextBox.Text);
            foreach (var ingredient in ingredients)
            {
                newRecipe.AddIngredient(ingredient);
            }
            RecipeBook.Instance.AddRecipe(newRecipe);
            MessageBox.Show("Recipe saved successfully");
            Close();
        }
    }
}
