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
using Exam.Data;
using Exam.Entities;

namespace Exam
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>

    public partial class AddUserWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        public AddUserWindow()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            bool isAlreadyExists = false;
            foreach (var user in context.Users)
                if (user.UserName == txtUsername.Text)
                    isAlreadyExists = true;

            if (txtUsername.Text.Length < 3 || txtEmail.Text.Length < 3 || txtPhone.Text.Length < 9 || txtPassword.Text.Length < 3)
            {
                lblError.Content = "Enter all data!";
            }
            else if (isAlreadyExists)
            {
                lblError.Content = "User with this user name already exists!";
            }
            else
            {
                context.Users.Add(new User()
                {
                    UserName = txtUsername.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Password = txtPassword.Text,
                    isAdmin = (bool)cbIsAdmin.IsChecked
                });
                context.SaveChanges();
                AdminWindow window = new AdminWindow();
                window.Show();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow window = new AdminWindow();
            window.Show();
            this.Close();
        }
    }
}
