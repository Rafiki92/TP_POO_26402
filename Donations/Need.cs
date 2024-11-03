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
    public class Need
    {
        #region Attributes
        public int NeedId { get; set; }
        public string Description { get; set; }
        public int PriorityLevel { get; set; }
        public NeedStatus Status { get; set; }

        public enum NeedStatus
        {
            Pending,
            Fulfilled
        }

        #endregion

        #region Constructors
        public Need(int needId, string description, int priorityLevel, NeedStatus status = NeedStatus.Pending)
        {
            NeedId = needId;
            Description = description;
            PriorityLevel = priorityLevel;
            Status = status;
        }
        #endregion
    }
}
