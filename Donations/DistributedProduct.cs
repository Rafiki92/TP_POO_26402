using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Products;

namespace ThriftShop.Donation
{
    /// <summary>
    /// 
    /// </summary>
    public class DistributedProduct
    {
        public int DistributedProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime DistributionDate { get; set; }

    }
}
