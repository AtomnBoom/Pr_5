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
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public Order()
        {
            InitializeComponent();

            ListV.ItemsSource = App.context.OrderItems.Where(i => i.OrderItemID == App.curentOrder.OrderID).ToList();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ListV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListV.SelectedItem != null)
            {
                var selectedItem = ListV.SelectedItem as Equipment;
                App.curentEquipment = selectedItem;

                Eqpment eqpment = new Eqpment();
                eqpment.ShowDialog();
            }
        }
    }
}
