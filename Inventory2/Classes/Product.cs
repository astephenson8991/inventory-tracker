using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory2
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductInStock { get; set; }
        public int ProductMin { get; set; }
        public int ProductMax { get; set; }

        public Product(int id, string name, decimal price, int stock, int min, int max)
        {
            ProductID = id;
            ProductName = name;
            ProductPrice = price;
            ProductInStock = stock;
            ProductMin = min;
            ProductMax = max;
        }
    }
}
