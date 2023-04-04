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
    /// Interaction logic for EditUserWindow.xaml
    /// </summary>
    public partial class EditUserWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        User user = new User();
        public EditUserWindow(User user)
        {
            this.user = user;
            InitializeComponent();
            txtUsername.Text = user.UserName;
            txtPassword.Text = user.Password;
            txtEmail.Text = user.Email;
            txtPhone.Text = user.Phone;
            cbIsAdmin.IsChecked = user.isAdmin;
        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {
            bool isAlreadyExists = false;
            PizzeriaDbContext context2 = new PizzeriaDbContext();
            foreach (var u in context2.Users)
                if (u.UserName == txtUsername.Text && u.Id != user.Id)
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
                user.UserName = txtUsername.Text;
                user.Email = txtEmail.Text;
                user.Phone = txtPhone.Text;
                user.Password = txtPassword.Text;
                user.isAdmin = (bool)cbIsAdmin.IsChecked;
                context.Users.Update(user);
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
