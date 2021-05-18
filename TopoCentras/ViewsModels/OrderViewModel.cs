using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TopoCentras.Helpers;
using TopoCentras.Models;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Windows;

namespace TopoCentras.ViewsModels
{
    class OrderViewModel : NotifyPropertyBase
    {
        TopoDBEntities _context = new TopoDBEntities();
        private ObservableCollection<OrdersList> _OrderCollection;

        public ObservableCollection<OrdersList> OrderCollection
        {
            get { return _OrderCollection; }
            set
            {
                _OrderCollection = value;
                OnPropertyChanged("OrderCollection");
            }
        }
        // add order to database
        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            MessageBox.Show("Order successfully added");
        }
        private OrdersList _SelectedOrdersList;
        public OrdersList SelectedOrdersList
        {
            get { return _SelectedOrdersList; }
            set
            {
                _SelectedOrdersList = value;
                OnPropertyChanged("SelectedOrdersList");
            }
        }
        // delete order form database
        public void DeleteOrder(Order order)
        {
            var ord = _context.Orders.Find(order.Order_id);
            _context.Orders.Remove(ord);
            _context.SaveChanges();
            MessageBox.Show("Order successfully deleted");
        }
        // get orders form database
        public void GetOrders()
        {
            var quer =(from a in _context.Orders
                       join m in _context.Products on a.Product_id equals m.Product_id
                       join c in _context.Clients on a.Client_id equals c.Client_id
                       select new OrdersList
                       {
                           Order_id = a.Order_id,
                           Client_name = c.Name,
                           Product_name = m.Name,
                           Product_price = m.Price
                       });
         
            _OrderCollection = new ObservableCollection<OrdersList>(quer);
        }
        // refill datagrid in ui
        public ObservableCollection<OrdersList> refilDataGrid ()
        {
            return _OrderCollection;
        }
        public OrderViewModel()
        {
            GetOrders();
        }
    }
}
