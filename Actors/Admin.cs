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
        public string Name { get; set; }

        public Admin(int userId, string username, string password, string name)
            : base(userId, username, password, UserRole.Admin) 
        {
            Name = name;
        }
    }
}
