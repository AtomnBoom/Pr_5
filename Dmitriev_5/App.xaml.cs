using Dmitriev_5.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Dmitriev_5
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Dmitriev_5Entities context = new Dmitriev_5Entities();
        public static Customers curentUser { get; set; }
        public static Equipment currentOrder { get; set; }
    }
}
