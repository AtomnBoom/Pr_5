using Dmitriev_5.Model;
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

namespace Dmitriev_5.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) && string.IsNullOrEmpty(PasswordPb.Password) && string.IsNullOrEmpty(Password2Pb.Password) && string.IsNullOrEmpty(CompanyNameTb.Text))
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (Password2Pb.Password == PasswordPb.Password)
                {
                    var user = App.context.Customers.FirstOrDefault(u => u.Login == LoginTb.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Пользователь уже существует");
                    }
                    else
                    {
                        var customer = new Customers
                        {
                            Login = LoginTb.Text,
                            Password = PasswordPb.Password,
                            CompanyName = CompanyNameTb.Text
                        };
                        App.context.Customers.Add(customer);
                        App.context.SaveChanges();

                        Authorization authorization = new Authorization();
                        authorization.Show();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }
    }
}
