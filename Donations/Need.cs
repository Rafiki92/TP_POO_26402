using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Actors;

namespace ThriftShop.Donation
{
    /// <summary>
    /// 
    /// </summary>
    public class Need
    {
        public int NeedId { get; set; }
        public Beneficiary Beneficiary { get; set; }
        public string Description { get; set; }
        public int PriorityLevel { get; set; }
    }
}
