using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Actors;
using ThriftShop.Products;

namespace ThriftShop.Donation
{
    /// <summary>
    /// 
    /// </summary>
    public class Donation
    {
        public int DonationID { get; set; }
        public DateTime DonationDate { get; set; }
        public Donor Donor { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
