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
    /// Interaction logic for CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        List<Pizza> cart = new List<Pizza>();

        public CartWindow(List<Pizza> cart)
        {
            this.cart = cart;
            InitializeComponent();
            FillAll();
        }

        

        public void FillAll()
        {
            lbPizza.Items.Clear();
            foreach (var pizza in cart)
                lbPizza.Items.Add(pizza.Name);

            string receipt = "\n =========== Receipt =========== \n\n";
            decimal price = 0;
            foreach (var pizza in cart)
            {
                price += pizza.Price;
                receipt += $" {pizza.Name} =============== ${pizza.Price.ToString()}\n\n";
            }
            receipt += $" ============================ \n\n Total price: ${price.ToString()}";
            txtReceipt.Text = receipt;
        }

        private void lbPizza_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbPizza.SelectedItem != null)
            {
                string description = "";
                List<string> ingredientNames = new List<string>();
                foreach (var pizza in cart)
                {
                    if (lbPizza.SelectedItem.ToString() == pizza.Name)
                    {
                        try
                        {
                            description = $"Name: {pizza.Name}\nPrice: ${pizza.Price.ToString()}\nIngredients: ";
                            foreach (PizzaIngredient pizzaIngredient in pizza.PizzaIngredients)
                            {
                                PizzeriaDbContext context3 = new PizzeriaDbContext();
                                Ingredient ingredient = context3.Ingredients.Find(pizzaIngredient.IngredientId);
                                ingredientNames.Add(ingredient.Name);
                            }
                        }
                        catch
                        {
                            PizzeriaDbContext context2 = new PizzeriaDbContext();
                            description = $"Name: {pizza.Name}\nPrice: ${pizza.Price.ToString()}\nIngredients: ";
                            foreach (PizzaIngredient pizzaIngredient in context2.PizzaIngredients)
                            {
                                if(pizza.Id == pizzaIngredient.PizzaId)
                                {
                                    PizzeriaDbContext context3 = new PizzeriaDbContext();
                                    Ingredient ingredient = context3.Ingredients.Find(pizzaIngredient.IngredientId);
                                    ingredientNames.Add(ingredient.Name);
                                }
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

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lbPizza.SelectedItem != null)
            {
                foreach (var pizza in cart)
                {
                    if (pizza.Name == lbPizza.SelectedItem.ToString())
                    {
                        PizzaEditorWindow window = new PizzaEditorWindow(cart, pizza);
                        window.Show();
                        this.Close();
                    }
                }     
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            UserWindow window = new UserWindow(cart);   
            window.Show();
            this.Close();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Order successfully placed! Bon apetit! Have a nice day!");
            UserWindow window = new UserWindow();
            window.Show();
            this.Close();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lbPizza.SelectedItem != null)
            {
                cart.RemoveAt(lbPizza.SelectedIndex);
                lbPizza.Items.Remove(lbPizza.SelectedItem);
                txtPizzaDescription.Text = "Pizza description";
                FillAll();
            }
        }
    }
}
