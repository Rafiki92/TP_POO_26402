using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShop.Actors
{
    /// <summary>
    /// 
    /// </summary>
    public class Beneficiary
    {
        public int BeneficiaryId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Nationality { get; set; }
        public bool HasChildren { get; set; }
        public int ChildrenCount { get; set; }

    }
}
