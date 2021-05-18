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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TopoCentras.Views;
using TopoCentras.ViewsModels;

namespace TopoCentras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrderViewModel orderViewModels =  new OrderViewModel();
        ProductViewModel productViewModels = new ProductViewModel();
        ClientViewModel clientViewModels = new ClientViewModel();
    public MainWindow()
        {
            InitializeComponent();
            DataContext = new
            {
                myViewModel = productViewModels,
                clientViewModel = clientViewModels,
                orderViewModel = orderViewModels,
        };
        }
        //open addorder window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow win2 = new AddOrderWindow();
            win2.Show();
        }
        // order
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(datagrid.SelectedIndex != -1)
            {
                int s = orderViewModels.SelectedOrdersList.Order_id;
                OrderViewModel a = new OrderViewModel();
                var order = new Order
                {
                    Order_id = orderViewModels.SelectedOrdersList.Order_id
                };
                a.DeleteOrder(order);
                refreshGrid();
            }else
            {
                MessageBox.Show("Please select row from List");
            }
        }
        //product
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(ProductCombo.SelectedIndex > -1)
            {
                var product = new Product
                {
                    Product_id = productViewModels.SelectedProduct.Product_id,
                };
                productViewModels.DeleteProduct(product);
            }else
            {
                MessageBox.Show("Please select from List");
            }
        }
        //client
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ClientCombo.SelectedIndex > -1)
            {
                var client = new Client
                {
                    Client_id = clientViewModels.SelectedClient.Client_id,
                };
                clientViewModels.DeleteClient(client);
            }else
            {
                MessageBox.Show("Please select from List");
            }
   
        }
        // refresh ui table with orders
        public void refreshGrid()
        {
            OrderViewModel a = new OrderViewModel();
            datagrid.ItemsSource = null;
            a.GetOrders();
            datagrid.ItemsSource = a.refilDataGrid();
            datagrid.Items.Refresh();
        }
       
    }
}
