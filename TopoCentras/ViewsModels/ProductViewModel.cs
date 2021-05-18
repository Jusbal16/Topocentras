using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TopoCentras.Helpers;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Windows;

namespace TopoCentras.ViewsModels
{
    class ProductViewModel : NotifyPropertyBase
    {
        TopoDBEntities context = new TopoDBEntities();

        private ObservableCollection<Product> _ProductCollection;
        public ObservableCollection<Product> ProductCollection
        {
            get { return _ProductCollection; }
            set
            {
                _ProductCollection = value;
                OnPropertyChanged("ProductCollection");
            }
        }

        private Product _SelectedProduct;
        public Product SelectedProduct
        {
            get { return _SelectedProduct; }
            set
            {
                _SelectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        // get all products from database
        public void GetProducts()
        {
            var query = from a in context.Products
                        select a;

            _ProductCollection = new ObservableCollection<Product>(query);
        }
        // Add product to database
        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            RefreshEntities();
        }

        // delete product from database
        public void DeleteProduct(Product product)
        {
            if (context.Orders.Any(Orders => Orders.Product_id == product.Product_id))
            {
                MessageBox.Show("Cannot delete product. Product exist ir order");
            }
            else
            {
                var pro = context.Products.Find(product.Product_id);
                context.Products.Remove(pro);
                context.SaveChanges();
                RefreshEntities();
                MessageBox.Show("Product successfully deleted");
            }
        }

        public ProductViewModel()
        {
            GetProducts();
        }
        // refresh UI entities from database
        private void RefreshEntities()
        {
            var objectContext = ((IObjectContextAdapter)context).ObjectContext;
            var objectSet = objectContext.CreateObjectSet<Product>();
            objectSet.MergeOption = MergeOption.OverwriteChanges;
            ProductCollection = new ObservableCollection<Product>(objectSet);
        }
    }
}
