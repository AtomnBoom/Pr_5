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
            ModelTbl.Text = App.curentEquipment.Equipment.Model.ToString();
            ManufacturerTbl.Text = App.curentEquipment.Equipment.Manufacturer.ToString();
            CategoryTbl.Text = App.curentEquipment.Equipment.EquipmentCategories.CategoryName.ToString();
            SupplierTbl.Text = App.curentEquipment.Equipment.Suppliers.Name.ToString();
            PriceTbl.Text = App.curentEquipment.Equipment.Price.ToString();
            WeightTbl.Text = App.curentEquipment.Equipment.Weight.ToString();
            DimensionsTbl.Text = App.curentEquipment.Equipment.Dimensions.ToString();
            PowerConsumptionTbl.Text = App.curentEquipment.Equipment.PowerConsumption.ToString();
            MaxPrintSpeedTbl.Text = App.curentEquipment.Equipment.MaxPrintSpeed.ToString();
            MaxPrintFormatTbl.Text = App.curentEquipment.Equipment.MaxPrintFormat.ToString();
            TechnologyTbl.Text = App.curentEquipment.Equipment.Technology.ToString();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
