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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        List<Pizza> cart = new List<Pizza>();

        public UserWindow()
        {
            InitializeComponent();
            lbPizzaFilling();
        }
        public UserWindow(List<Pizza> cart)
        {
            this.cart = cart;
            InitializeComponent();
            lbPizzaFilling();
        }

        public void lbPizzaFilling()
        {
            lbPizza.Items.Clear();
            foreach (var pizza in context.Pizzas)
                lbPizza.Items.Add(pizza.Name);
            btnCart.Content = $"Cart ({cart.Count})";
        }

        private void lbPizza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbPizza.SelectedItem != null)
            {
                string description = "";
                List<string> ingredientNames = new List<string>();
                foreach (var pizza in context.Pizzas)
                {
                    if (lbPizza.SelectedItem.ToString() == pizza.Name)
                    {
                        PizzeriaDbContext context2 = new PizzeriaDbContext();
                        description = $"Name: {pizza.Name}\nPrice: ${pizza.Price.ToString()}\nIngredients: ";
                        foreach (PizzaIngredient pizzaIngredient in context2.PizzaIngredients)
                        {
                            if (pizzaIngredient.PizzaId == pizza.Id)
                            {
                                PizzeriaDbContext context3 = new PizzeriaDbContext();
                                Ingredient ingredient = context3.Ingredients.Find(pizzaIngredient.IngredientId);
                                ingredientNames.Add(ingredient.Name);
                            }
                        }
                    }
                }
                for (int i = 0; i < ingredientNames.Count; i++)
                {
                    if (i == 0) description += ingredientNames[i];
                    else description += $", {ingredientNames[i]}";
                }
                txtPizzaDescription.Text = $"{description}.";
            }
        }

        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (lbPizza.SelectedItem != null)
                foreach (var pizza in context.Pizzas)
                    if (lbPizza.SelectedItem.ToString() == pizza.Name)
                        cart.Add(pizza);
            btnCart.Content = $"Cart ({cart.Count})";
        }

        private void btnPizzaCreator_Click(object sender, RoutedEventArgs e)
        {
            PizzaCreatorWindow window = new PizzaCreatorWindow(cart);
            window.Show();
            this.Close();
        }

        private void btnCart_Click(object sender, RoutedEventArgs e)
        {
            CartWindow window = new CartWindow(cart);
            window.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text != "")
            {
                lbPizza.Items.Clear();
                txtPizzaDescription.Text = "Pizza description";
                foreach (var pizza in context.Pizzas)
                    if (txtSearch.Text == pizza.Name)
                        lbPizza.Items.Add(pizza.Name);
   
                foreach (var ingredient in context.Ingredients)
                {
                    if (txtSearch.Text == ingredient.Name)
                    {
                        PizzeriaDbContext context2 = new PizzeriaDbContext();
                        foreach (PizzaIngredient pizzaIngredient in context2.PizzaIngredients)
                        {
                            if (pizzaIngredient.IngredientId == ingredient.Id)
                            {
                                bool isExists = false;
                                PizzeriaDbContext context3 = new PizzeriaDbContext();
                                var pizza = context3.Pizzas.Find(pizzaIngredient.PizzaId);
                                foreach(var item in lbPizza.Items)
                                    if(item.ToString() == pizza.Name)
                                        isExists = true;
                                if (!isExists)
                                    lbPizza.Items.Add(pizza.Name);
                            }
                        }
                    }
                }   
            }
            else
            {
                lbPizzaFilling();
            }
        }
    }
}
