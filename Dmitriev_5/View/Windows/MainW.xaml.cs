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
    /// Логика взаимодействия для MainW.xaml
    /// </summary>
    public partial class MainW : Window
    {

        public MainW()
        {
            InitializeComponent();

            LoginTbl.Text = App.curentUser.CompanyName.ToString();
            ListV.ItemsSource = App.context.Orders.ToList().Where(o => o.CustomerID == App.curentUser.CustomerID);
        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            Close();
        }
    }
}
