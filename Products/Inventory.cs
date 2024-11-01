using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShop.Products
{
    /// <summary>
    /// 
    /// </summary>
    public class Inventory
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
