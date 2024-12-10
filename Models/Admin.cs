using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents an admin in the thrift shop.
    /// </summary>
    public class Admin : User
    {
        #region Attributes
        private string department;
        #endregion

        #region Properties
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        #endregion

        #region Constructors
        public Admin(int userId, string name, DateTime startDate, DateTime? endDate, int contactNumber, string address, string username, string password, string department)
            : base(userId, name, startDate, endDate, contactNumber, address, username, password)
        {
            {
                this.Department = department;
            }
            #endregion
        }

        #region Methods
            public override string GetUsername()
        {
            return $"[Admin] {base.GetUsername()}";
        }

        public override string GetPassword()
        {
            return $"[Admin Password] {base.GetPassword()}";
        }

        public override string GetName()
        {
            return $"Admin: {base.GetName()}";
        }
        #endregion
    }
}
