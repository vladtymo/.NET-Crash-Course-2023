using Exam.Data;
using Exam.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for EditPizzaWindow.xaml
    /// </summary>
    public partial class EditPizzaWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        Pizza pizza = new Pizza();
        decimal price = 0;
        public EditPizzaWindow(Pizza pizza)
        {
            this.pizza = pizza;
            InitializeComponent();
            lbIngredientsFilling();
            txtName.Text = pizza.Name;
            txtPrice.Text = pizza.Price.ToString();
            price = pizza.Price;
            foreach (var pizzaIngredient in context.PizzaIngredients)
            {
                if(pizzaIngredient.PizzaId == pizza.Id)
                {
                    PizzeriaDbContext context2 = new PizzeriaDbContext();
                    Ingredient ingredient = context2.Ingredients.Find(pizzaIngredient.IngredientId);
                    lbIngredients2.Items.Add($"{ingredient.Name}");
                }
            }   
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

        private void btnUpdatePizza_Click(object sender, RoutedEventArgs e)
        {
            bool isAlreadyExists = false;
            PizzeriaDbContext context2 = new PizzeriaDbContext();
            foreach (var p in context2.Pizzas)
                if (p.Name == txtName.Text && p.Id != pizza.Id)
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
                try
                {
                    List<Ingredient> ingredients = new List<Ingredient>();
                    foreach (string ingredientName in lbIngredients2.Items)
                        foreach (var ingredient in context.Ingredients)
                            if (ingredientName == ingredient.Name)
                                ingredients.Add(ingredient);

                    pizza.Name = txtName.Text;
                    pizza.Price = decimal.Parse(txtPrice.Text);
                    foreach (var pizzaIngredient in context.PizzaIngredients)
                        if (pizzaIngredient.PizzaId == pizza.Id)
                            context2.PizzaIngredients.Remove(pizzaIngredient);

                    context.SaveChanges();
                    pizza.PizzaIngredients = new List<PizzaIngredient>() { };
                    foreach (var ingredient in ingredients)
                        pizza.PizzaIngredients.Add(new PizzaIngredient { Pizza = pizza, Ingredient = ingredient });

                    //context.Pizzas.Remove(newPizza);
                    //context.SaveChanges();

                    context.Pizzas.Update(pizza);
                    context.SaveChanges();
                    AdminWindow window = new AdminWindow();
                    window.Show();
                    this.Close();
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
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
            EditPizzaWindow window = new EditPizzaWindow(pizza);
            window.Show();
            this.Close();
        }
    }
}
