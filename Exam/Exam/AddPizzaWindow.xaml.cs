using Exam.Data;
using Exam.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Exam
{
    /// <summary>
    /// Interaction logic for AddPizzaWindow.xaml
    /// </summary>
    public partial class AddPizzaWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        decimal price = 0;
        public AddPizzaWindow()
        {
            InitializeComponent();
            lbIngredientsFilling();
        }
        public void lbIngredientsFilling()
        {
            lbIngredients.Items.Clear();
            foreach (var ingredient in context.Ingredients)
                lbIngredients.Items.Add($"{ingredient.Name}");
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[,][0-9]+$|^[0-9]*[,]{0,1}[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void btnCreatePizza_Click(object sender, RoutedEventArgs e)
        {
            bool isAlreadyExists = false;
            foreach (var pizza in context.Pizzas)
                if (pizza.Name == txtName.Text)
                    isAlreadyExists = true;

            if (txtName.Text.Length < 3 || (txtPrice.Text == "" || txtPrice.Text == "0") || lbIngredients2.Items.Count < 3)
            {
                lblError.Content = "Enter all fields!";
            }
            else if (isAlreadyExists)
            {
                lblError.Content = "Pizza with this name already exists!";
            }
            else 
            {
                List<Ingredient> ingredients = new List<Ingredient>();
                foreach(string ingredientName in lbIngredients2.Items)
                    foreach(var ingredient in context.Ingredients)
                        if(ingredientName == ingredient.Name)
                            ingredients.Add(ingredient);

                Pizza pizza = new Pizza
                {
                    Name = txtName.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    PizzaIngredients = new List<PizzaIngredient>() { }
                };
                foreach (var ingredient in ingredients)
                    pizza.PizzaIngredients.Add(new PizzaIngredient { Pizza = pizza, Ingredient = ingredient });
                
                context.Pizzas.Add(pizza);
                context.SaveChanges();
                AdminWindow window = new AdminWindow();
                window.Show();
                this.Close();
            }
        }

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            if(lbIngredients.SelectedItem != null)
            {
                string name = lbIngredients.SelectedItem.ToString();
                lbIngredients2.Items.Add(name);
                foreach (var ingredient in context.Ingredients)
                    if (name == ingredient.Name)
                        price += ingredient.Price; txtPrice.Text = price.ToString();
            }
        }

        private void btnCreateIngredient_Click(object sender, RoutedEventArgs e)
        {
            AddIngredientWindow window = new AddIngredientWindow();
            window.Show();
        }

        private void btnRemoveIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (lbIngredients2.SelectedItem != null)
            {
                string name = lbIngredients2.SelectedItem.ToString();
                lbIngredients2.Items.Remove(name);
                foreach (var ingredient in context.Ingredients)
                    if (name == ingredient.Name)
                        price -= ingredient.Price;
                if (price < 0) price = 0;
                txtPrice.Text = price.ToString();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow window = new AdminWindow();
            window.Show();
            this.Close();
        }

        private void btnEditIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (lbIngredients.SelectedItem != null)
            {
                foreach (var ingredient in context.Ingredients)
                {
                    if (lbIngredients.SelectedItem.ToString() == ingredient.Name)
                    {
                        EditIngredientWindow window = new EditIngredientWindow(ingredient);
                        window.Show();
                    }
                }  
            }
        }

        private void btnReload_Click(object sender, RoutedEventArgs e)
        {
            AddPizzaWindow window = new AddPizzaWindow();
            window.Show();
            this.Close();
        }
    }
}
