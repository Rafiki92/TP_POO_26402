using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;

namespace ThriftShopApp.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserByUsername(string username);
    }
}
