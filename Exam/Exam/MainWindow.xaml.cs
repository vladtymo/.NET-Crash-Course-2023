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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Exam.Data;
using Exam.Entities;

namespace Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PizzeriaDbContext context = new PizzeriaDbContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            foreach(var user in context.Users)
            {
                if(user.UserName == txtUsername.Text && user.Password == txtPassword.Text)
                {
                    if (user.isAdmin == true)
                    {
                        if (MessageBox.Show("Do you want to enter as admin?", "Admin or user?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                        {
                            AdminWindow window = new AdminWindow();
                            window.Show();
                            this.Close();
                        }
                        else
                        {
                            UserWindow window = new UserWindow();
                            window.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        UserWindow window = new UserWindow();
                        window.Show();
                        this.Close();
                    }
                    continue;
                }
            }
            lblError.Content = "Invalid username or password! Try again!";
        }

        private void lblSignUp_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            RegisterWindow window = new RegisterWindow();
            window.Show();
            this.Close();
        }
    }
}
