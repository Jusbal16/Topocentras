using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopoCentras.Helpers;

namespace TopoCentras.Models
{
    class OrdersList : NotifyPropertyBase
    {
        [DisplayName("Orders ID")]
        public int Order_id { get; set; }
        [DisplayName("Client name")]
        public string Client_name { get; set; }
        [DisplayName("Product name")]
        public string Product_name { get; set; }
        [DisplayName("Price")]
        public string Product_price { get; set; }
    }
}
