using System;
using System.Collections;
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
    /// Логика взаимодействия для Eqpment.xaml
    /// </summary>
    public partial class Eqpment : Window
    {
        public Eqpment()
        {
            InitializeComponent();
            IDTbl.Text = App.curentEquipment.EquipmentID.ToString();
            ModelTbl.Text = App.curentEquipment.Model.ToString();
            ManufacturerTbl.Text = App.curentEquipment.Manufacturer.ToString();
            CategoryTbl.Text = App.curentEquipment.EquipmentCategories.CategoryName.ToString();
            SupplierTbl.Text = App.curentEquipment.Suppliers.Name.ToString();
            PriceTbl.Text = App.curentEquipment.Price.ToString();
            WeightTbl.Text = App.curentEquipment.Weight.ToString();
            DimensionsTbl.Text = App.curentEquipment.Dimensions.ToString();
            PowerConsumptionTbl.Text = App.curentEquipment.PowerConsumption.ToString();
            MaxPrintSpeedTbl.Text = App.curentEquipment.MaxPrintSpeed.ToString();
            MaxPrintFormatTbl.Text = App.curentEquipment.MaxPrintFormat.ToString();
            TechnologyTbl.Text = App.curentEquipment.Technology.ToString();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
