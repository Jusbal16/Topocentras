using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using TopoCentras.Helpers;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Windows;

namespace TopoCentras.ViewsModels
{
    class ClientViewModel : NotifyPropertyBase
    {
        TopoDBEntities context = new TopoDBEntities();

        private ObservableCollection<Client> _ClientCollection;
        public ObservableCollection<Client> ClientCollection
        {
            get { return _ClientCollection; }
            set
            {
                _ClientCollection = value;
                OnPropertyChanged("ClientCollection");
            }
        }
        private Client _SelectedClient;
        public Client SelectedClient
        {
            get { return _SelectedClient; }
            set
            {
                _SelectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
        }
        // get all clients from database
        public void GetClients()
        {
            var query = from a in context.Clients
                        select a;

            _ClientCollection = new ObservableCollection<Client>(query);
        }
        // add client from database
        public void AddClient(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
            RefreshEntities();
        }
        // delete client from database
        public void DeleteClient(Client client)
        {
            if (context.Orders.Any(Orders => Orders.Client_id == client.Client_id))
            {
                MessageBox.Show("Cannot delete client. Client exist ir order");
            }
            else
            {
                var cli = context.Clients.Find(client.Client_id);
                context.Clients.Remove(cli);
                context.SaveChanges();
                RefreshEntities();
                MessageBox.Show("Product successfully deleted");
            }
        }



        public ClientViewModel()
        {
            GetClients();
        }
        // refresh UI entities from database
        private void RefreshEntities()
        {
            var objectContext = ((IObjectContextAdapter)context).ObjectContext;
            var objectSet = objectContext.CreateObjectSet<Client>();
            objectSet.MergeOption = MergeOption.OverwriteChanges;
            ClientCollection = new ObservableCollection<Client>(objectSet);
        }
    }
}
