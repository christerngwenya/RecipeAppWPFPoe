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
    /// Interaction logic for DisplayRecipeWindow.xaml
    /// </summary>
    public partial class DisplayRecipeWindow : Window
    {
        public DisplayRecipeWindow()
        {
            InitializeComponent();
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            var recipe = RecipeBook.Instance.GetRecipe(RecipeNameTextBox.Text);
            if (recipe != null)
            {
                RecipeDetailsTextBlock.Text = $"Recipe: {recipe.Name}\nIngredients:";
                foreach (var ingredient in recipe.Ingredients)
                {
                    RecipeDetailsTextBlock.Text += $"\n{ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})";
                }
            }
            else
            {
                RecipeDetailsTextBlock.Text = $"Recipe '{RecipeNameTextBox.Text}' not found.";
            }
            }
        }
}
