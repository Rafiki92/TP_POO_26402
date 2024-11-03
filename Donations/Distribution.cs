using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Actors;

namespace ThriftShop.Donations
{
    /// <summary>
    /// 
    /// </summary>
    public class Distribution
    {
        public int DistributionId { get; set; }
        public DateTime DistributionDate { get; set; }
        public Beneficiary Beneficiary { get; set; }
        //public List<DistributedProduct> DistributedProducts { get; set; } = new List<DistributedProduct>
    }
}
