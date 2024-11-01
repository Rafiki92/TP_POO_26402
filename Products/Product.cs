using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Actors;

namespace ThriftShop.Products
{
    /// <summary>
    /// 
    /// </summary>
    public class Product
    {
        #region Attributes
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public Donor Donor { get; set; }
        #endregion

        #region Constructors
        public Product(int productId, string name, string category, int quantity, Donor donor)
        {
            ProductId = productId;
            Name = name;
            Category = category;
            Quantity = quantity;
            Donor = donor;
        }
        #endregion
    }
}
