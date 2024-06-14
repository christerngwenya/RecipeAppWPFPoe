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
    /// Interaction logic for DisplayAllRecipesWindow.xaml
    /// </summary>
    public partial class DisplayAllRecipesWindow : Window
    {
        public DisplayAllRecipesWindow()
        {
            InitializeComponent();
            LoadAllRecipes();
    }
        private void LoadAllRecipes()
    {
        RecipesListBox.Items.Clear();
        foreach (var recipe in RecipeBook.Instance.GetAllRecipes())
        {
            RecipesListBox.Items.Add(recipe.Name);
        }
    }

    private void Refresh_Click(object sender, RoutedEventArgs e)
    {
        LoadAllRecipes();
    }

}
}
