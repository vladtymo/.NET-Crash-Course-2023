using Exam.Data;
using Exam.Entities;
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

namespace Exam
{
    /// <summary>
    /// Interaction logic for PizzaEditorWindow.xaml
    /// </summary>
    public partial class PizzaEditorWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        List<Pizza> cart = new List<Pizza>();
        Pizza pizza = new Pizza();
        decimal price = 0;

        public PizzaEditorWindow(List<Pizza> cart, Pizza pizza)
        {
            this.cart = cart;
            this.pizza = pizza;
            InitializeComponent();
            lbIngredientsFilling();
            txtName.Text = pizza.Name;
            txtPrice.Text = pizza.Price.ToString();
            price = pizza.Price;
            try
            {
                foreach (var pizzaIngredient in pizza.PizzaIngredients)
                {
                    PizzeriaDbContext context2 = new PizzeriaDbContext();
                    Ingredient ingredient = context2.Ingredients.Find(pizzaIngredient.IngredientId);
                    lbIngredients2.Items.Add($"{ingredient.Name}");
                }
            }
            catch
            {
                foreach (var pizzaIngredient in context.PizzaIngredients)
                {
                    if (pizzaIngredient.PizzaId == pizza.Id)
                    {
                        PizzeriaDbContext context2 = new PizzeriaDbContext();
                        Ingredient ingredient = context2.Ingredients.Find(pizzaIngredient.IngredientId);
                        lbIngredients2.Items.Add($"{ingredient.Name}");
                    }
                }
            }
        }

        public void lbIngredientsFilling()
        {
            foreach (var ingredient in context.Ingredients)
                lbIngredients.Items.Add($"{ingredient.Name}");
        }

        private void btnEditPizza_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length < 3 || (txtPrice.Text == "" || txtPrice.Text == "0") || lbIngredients2.Items.Count < 3)
            {
                lblError.Content = "Enter all fields!";
            }
            else
            {
                List<Ingredient> ingredients = new List<Ingredient>();
                foreach (string ingredientName in lbIngredients2.Items)
                    foreach (var ingredient in context.Ingredients)
                        if (ingredientName == ingredient.Name)
                            ingredients.Add(ingredient);

                pizza.Name = txtName.Text;
                pizza.Price = decimal.Parse(txtPrice.Text);
                pizza.PizzaIngredients = new List<PizzaIngredient>() { };
                foreach (var ingredient in ingredients)
                    pizza.PizzaIngredients.Add(new PizzaIngredient { Pizza = pizza, Ingredient = ingredient, PizzaId = pizza.Id, IngredientId = ingredient.Id });

                cart.Remove(pizza);
                cart.Add(pizza);
                CartWindow window = new CartWindow(cart);
                window.Show();
                this.Close();
            }
        }

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (lbIngredients.SelectedItem != null)
            {
                string name = lbIngredients.SelectedItem.ToString();
                lbIngredients2.Items.Add(name);
                foreach (var ingredient in context.Ingredients)
                    if (name == ingredient.Name)
                        price += ingredient.Price; txtPrice.Text = price.ToString();
            }
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
            CartWindow window = new CartWindow(cart);
            window.Show();
            this.Close();
        }
    }
}
