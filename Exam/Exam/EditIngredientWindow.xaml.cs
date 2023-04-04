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

namespace Exam.Data
{
    /// <summary>
    /// Interaction logic for EditIngredientWindow.xaml
    /// </summary>
    public partial class EditIngredientWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        Ingredient ingredient = new Ingredient();

        public EditIngredientWindow(Ingredient ingredient)
        {
            this.ingredient = ingredient;
            InitializeComponent();
            txtName.Text = ingredient.Name;
            txtPrice.Text = ingredient.Price.ToString();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[,][0-9]+$|^[0-9]*[,]{0,1}[0-9]*$");
            e.Handled = !regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text));
        }

        private void btnUpdateIngredient_Click(object sender, RoutedEventArgs e)
        {
            bool isAlreadyExists = false;
            PizzeriaDbContext context2 = new PizzeriaDbContext();
            foreach (var ingr in context2.Ingredients)
                if (ingr.Name == txtName.Text && ingr.Id != ingredient.Id)
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
                ingredient.Name = txtName.Text;
                ingredient.Price = decimal.Parse(txtPrice.Text);
                context.Ingredients.Update(ingredient);
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
