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
using TopoCentras.Views;
using TopoCentras.ViewsModels;

namespace TopoCentras.Views
{
    /// <summary>
    /// Interaction logic for AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        ProductViewModel productViewModels = new ProductViewModel();
        ClientViewModel clientViewModels = new ClientViewModel();
        public AddOrderWindow()
        {
            InitializeComponent();
           // DataContext = new MyViewModel();
            DataContext = new
            {
                myViewModel = productViewModels,
                clientViewModel = clientViewModels,
            };
        }
        //add order
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (productCombobox.SelectedIndex > -1 && clientCombobox.SelectedIndex > -1)
            {
                int client_id = clientViewModels.SelectedClient.Client_id;
                int product_id = productViewModels.SelectedProduct.Product_id;
                OrderViewModel a = new OrderViewModel();
                var order = new Order
                {
                    Client_id = client_id,
                    Product_id = product_id,
                };

                a.AddOrder(order);
                (Application.Current.MainWindow as MainWindow).refreshGrid();
            }
            else
            {
                MessageBox.Show("Please select from List");
            }
        }
        // create product
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(product_name.Text) && String.IsNullOrEmpty(product_price.Text))
            {
                MessageBox.Show("Textboxes are empty, please fill information");
            } else
            {
                string name = product_name.Text;
                string price = product_price.Text;
                var product = new Product
                {
                    Name = name,
                    Price = price,
                };
                productViewModels.AddProduct(product);
                product_name.Text = string.Empty;
                product_price.Text = string.Empty;
                MessageBox.Show("Product successfully added");
            }
        }
        //create client
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(client_name.Text))
            {
                MessageBox.Show("Textboxes are empty, please fill information");
            }
            else
            {
                string name = client_name.Text;
                var client = new Client
                {
                    Name = name,
                };

                clientViewModels.AddClient(client);
                client_name.Text = string.Empty;
                MessageBox.Show("Client successfully added");
            }
        }
    }
}
