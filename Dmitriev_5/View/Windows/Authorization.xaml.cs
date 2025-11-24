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
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        int a = 0;
        public Authorization()
        {
            InitializeComponent();
            
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (string.IsNullOrEmpty(LoginTb.Text)  && string.IsNullOrEmpty(PasswordPb.Password)) 
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                var user =  App.context.Customers.FirstOrDefault(u => u.Login == LoginTb.Text && u.Password == PasswordPb.Password);
                if (user != null)
                {
                    App.curentUser = user;
                    MainW main = new MainW();
                    main.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь ненайден");
                    LoginTb.Text = "";
                    PasswordPb.Password = "";
                    a += 1;
                    if (a == 3)
                    {
                        MessageBox.Show("Вы были заблокированы за многократные попытки входа");
                        LoginTb.IsEnabled = false;
                        PasswordPb.IsEnabled = false;
                        AuthBtn.IsEnabled = false;
                        RegBtn.IsEnabled = false;
                    }
                }
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }
    }
}
