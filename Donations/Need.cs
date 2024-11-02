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
        #region Attributes
        public int NeedId { get; set; }
        public Beneficiary Beneficiary { get; set; }
        public string Description { get; set; }
        public int PriorityLevel { get; set; }

        #endregion

        #region Constructors
        public Need(int needId, Beneficiary beneficiary, string description, int priorityLevel)
        {
            this.NeedId = needId;
            this.Beneficiary = beneficiary;
            this.Description = description;
            this.PriorityLevel = priorityLevel;
        }
        #endregion
    }
}
