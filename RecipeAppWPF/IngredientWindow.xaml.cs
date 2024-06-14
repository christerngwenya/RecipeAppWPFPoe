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
    /// Interaction logic for IngredientWindow.xaml
    /// </summary>
    public partial class IngredientWindow : Window
    {
        public Ingredient Ingredient { get; private set; }

        public IngredientWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(CaloriesTextBox.Text, out int calories))
            {
                Ingredient = new Ingredient(NameTextBox.Text, calories, FoodGroupTextBox.Text);
                DialogResult = true;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid calories input");
            }
        }
    }
}
