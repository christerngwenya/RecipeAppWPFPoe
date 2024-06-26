﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterRecipe_Click(object sender, RoutedEventArgs e)
        {
            var window = new EnterRecipeWindow();
            window.ShowDialog();
        }

        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            var window = new DisplayRecipeWindow();
            window.ShowDialog();
        }

        private void DisplayAllRecipes_Click(object sender, RoutedEventArgs e)
        {
            var window = new DisplayAllRecipesWindow();
            window.ShowDialog();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}