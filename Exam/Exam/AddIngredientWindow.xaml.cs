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
    /// Interaction logic for AddIngredientWindow.xaml
    /// </summary>
    public partial class AddIngredientWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        public AddIngredientWindow()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[,][0-9]+$|^[0-9]*[,]{0,1}[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void btnCreateIngredient_Click(object sender, RoutedEventArgs e)
        {
            bool isAlreadyExists = false;
            foreach (var ingredient in context.Ingredients)
                if (ingredient.Name == txtName.Text)
                    isAlreadyExists = true;

            if (txtName.Text.Length < 3 || (txtPrice.Text == "" || txtPrice.Text == "0"))
            {
                lblError.Content = "Enter all fields!";
            }
            else if (isAlreadyExists)
            {
                lblError.Content = "Ingredient with this name already exists!";
            }
            else
            {
                context.Ingredients.Add(new Ingredient { Name = txtName.Text, Price = decimal.Parse(txtPrice.Text), PizzaIngredients = new List<PizzaIngredient>() });
                context.SaveChanges();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
