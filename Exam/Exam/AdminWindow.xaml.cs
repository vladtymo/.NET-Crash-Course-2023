using Azure.Identity;
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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        public AdminWindow()
        {
            InitializeComponent();
            lbPizzaFilling();
            lbUserFilling();
        }
        public void lbPizzaFilling()
        {
            foreach (var pizza in context.Pizzas)
                lbPizza.Items.Add(pizza.Name);
        }
        public void lbUserFilling()
        {
            foreach (var user in context.Users)
                lbUsers.Items.Add(user.UserName);
        }
        private void lbPizza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbPizza.SelectedItem != null)
            {
                string description = "";
                List<string> ingredientNames = new List<string>();
                foreach (var pizza in context.Pizzas)
                {
                    if (pizza.Name == lbPizza.SelectedItem.ToString())
                    {
                        description = $"Name: {pizza.Name}\nPrice: ${pizza.Price.ToString()}\nIngredients: ";
                        PizzeriaDbContext context2 = new PizzeriaDbContext();
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
                for(int i = 0; i < ingredientNames.Count; i++)
                {
                    if (i == 0) description += ingredientNames[i];
                    else description += $", {ingredientNames[i]}";
                }
                txtPizzaDescription.Text = $"{description}.";
            }
        }

        private void btnAddPizza_Click(object sender, RoutedEventArgs e)
        {
            AddPizzaWindow window = new AddPizzaWindow();
            window.Show();
            this.Close();
        }

        private void btnEditPizza_Click(object sender, RoutedEventArgs e)
        {
            if(lbPizza.SelectedItem != null)
            {
                foreach (var pizza in context.Pizzas)
                {
                    if (pizza.Name == lbPizza.SelectedItem.ToString())
                    {
                        EditPizzaWindow window = new EditPizzaWindow(pizza);
                        window.Show();
                        this.Close();
                    }
                }
            }
        }

        private void btnDeletePizza_Click(object sender, RoutedEventArgs e)
        {
            if (lbPizza.SelectedItem != null)
            {
                foreach (var pizza in context.Pizzas)
                {
                    if (lbPizza.SelectedItem.ToString() == pizza.Name)
                    {
                        PizzeriaDbContext context2 = new PizzeriaDbContext();
                        context2.Pizzas.Remove(pizza);
                        context2.SaveChanges();
                        lbPizza.Items.Remove(lbPizza.SelectedItem);
                        txtPizzaDescription.Text = "Pizza description";
                    }
                }
            }
            
        }

        private void lbUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
                foreach (var user in context.Users)
                    if (user.UserName == lbUsers.SelectedItem.ToString())
                        txtUserDescription.Text = $"Username: {user.UserName}\nEmail: {user.Email}\nPhone number: {user.Phone}\nPassword: {user.Password}\nIs Administrator: {user.isAdmin.ToString()}";
        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                foreach (var user in context.Users)
                {
                    if (user.UserName == lbUsers.SelectedItem.ToString())
                    {
                        EditUserWindow window = new EditUserWindow(user);
                        window.Show();
                        this.Close();
                    }
                }
            }
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                foreach (var user in context.Users)
                {     
                    if (lbUsers.SelectedItem.ToString() == user.UserName)
                    {
                        PizzeriaDbContext context2 = new PizzeriaDbContext();
                        context2.Users.Remove(user);
                        context2.SaveChanges();
                        lbUsers.Items.Remove(lbUsers.SelectedItem);
                        txtUserDescription.Text = "User description";
                    }
                }
            }
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow window = new AddUserWindow();
            window.Show();
            this.Close();
        }

        private void btnPizzaSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txtPizzaSearch.Text != "")
            {
                lbPizza.Items.Clear();
                txtPizzaDescription.Text = "Pizza description";
                foreach (var pizza in context.Pizzas)
                    if (txtPizzaSearch.Text == pizza.Name)
                        lbPizza.Items.Add(pizza.Name);

                foreach (var ingredient in context.Ingredients)
                {
                    if (txtPizzaSearch.Text == ingredient.Name)
                    {
                        PizzeriaDbContext context2 = new PizzeriaDbContext();
                        foreach (PizzaIngredient pizzaIngredient in context2.PizzaIngredients)
                        {
                            if (pizzaIngredient.IngredientId == ingredient.Id)
                            {
                                bool isExists = false;
                                PizzeriaDbContext context3 = new PizzeriaDbContext();
                                var pizza = context3.Pizzas.Find(pizzaIngredient.PizzaId);
                                foreach (var item in lbPizza.Items)
                                    if (item.ToString() == pizza.Name)
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

        private void btnUserSearch_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserSearch.Text != "")
            {
                lbUsers.Items.Clear();
                txtUserDescription.Text = "User description";
                foreach (var user in context.Users)
                    if (txtUserSearch.Text == user.UserName)
                        lbPizza.Items.Add(user.UserName);
            }
            else
            {
                lbUserFilling();
            }
        }
    }
}
