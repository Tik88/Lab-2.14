using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab_2._14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Манго",
                Price = 100,                
                Image = "/Image/Mango.jpg",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Картошка",
                Price = 90,
                Image = "/Image/Bylba.jpg",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Системный блок",
                Price = 80000,
                Image = "/Image/Block.jpg",
                Category = Category.Technics
            });
            products.Add(new Product()
            {
                NameProduct = "Кофе машина",
                Price = 35000,
                Image = "/image/Coffe.jpg",
                Category = Category.HouseholdAppliances
            });
            IstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                NameProduct = "Автомобиль",
                Price = 3200000,
                Image = "/Image/Avto.jpg",
                Category = Category.Transport
            });
        }
    }
}
