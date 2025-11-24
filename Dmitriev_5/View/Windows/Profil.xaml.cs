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
    /// Логика взаимодействия для Profil.xaml
    /// </summary>
    public partial class Profil : Window
    {
        public Profil()
        {
            InitializeComponent();
            CompanyNameTbl.Text = App.curentUser.CompanyName.ToString();
            ContactTbl.Text = App.curentUser.ContactPerson.ToString();
            PhoneTbl.Text = App.curentUser.Phone.ToString();
            EmailTbl.Text = App.curentUser.Email.ToString();
            AddressTbl.Text = App.curentUser.Address.ToString();
            TypeTbl.Text = App.curentUser.CustomerType.ToString();
        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainW mainW = new MainW();
            mainW.Show();
            Close();
        }
    }
}
