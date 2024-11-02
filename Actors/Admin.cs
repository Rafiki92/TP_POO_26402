using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShop.Actors

{
    /// <summary>
    /// Class Admin, only for enter in the application
    /// </summary>
    public class Admin : User
    {
        #region Attributes
        public string Name { get; set; }

        #endregion

        #region Constructors

        public Admin(int userId, string username, string password, string name)
            : base(userId, username, password, UserRole.Admin) 
        {
            this.Name = name;
        }

        #endregion
    }
}
