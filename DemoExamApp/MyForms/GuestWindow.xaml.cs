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
using System.Windows.Shapes;
using DemoExamApp.View;
using DemoExamApp.DB;
using static System.Net.Mime.MediaTypeNames;
using System.Numerics;

namespace DemoExamApp.MyForms
{
    /// <summary>
    /// Interaction logic for GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        public ObservableCollection<ProductView> ProductsToList { get; set; }
        public GuestWindow()
        {
            InitializeComponent();
            AddProductsToList();
        }
        
        public void AddProductsToList()
        {
            MyContext Db = new MyContext();

            ProductsToList = new ObservableCollection<ProductView>();

            foreach(var item in Db.Products)
            {
                if(item.Sale > 14.99)
                {
                    ProductsToList.Add(new ProductView()
                    {
                        Name = item.Name,
                        Manufacturer = item.Manufacturer,
                        Description = item.Description,
                        Price = item.Price,
                        Sale = item.Sale,
                        ImagePath = item.ImagePath,
                        PriceWithSale = item.Price - (item.Price * (decimal)item.Sale / 100),
                        SaleFill = true 
                    });
                }
                else
                {
                    ProductsToList.Add(new ProductView()
                    {
                        Name = item.Name,
                        Manufacturer = item.Manufacturer,
                        Description = item.Description,
                        Price = item.Price,
                        Sale = item.Sale,
                        ImagePath = item.ImagePath,
                        PriceWithSale = item.Price - (item.Price * (decimal)item.Sale / 100),
                        SaleFill = false
                    });
                }
                
            }

            LbProducts.ItemsSource = ProductsToList;
            
        }

        private void BtLogOut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
