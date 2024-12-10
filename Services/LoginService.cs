using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Services;

namespace ThriftShopApp.Services
{
    /// <summary>
    /// Represents the login process of a user.
    /// </summary>
    public class LoginService
    {
        private readonly IUserService[] userServices;

        public LoginService(params IUserService[] userServices)
        {
            this.userServices = userServices;
        }

        public User Authenticate(string username, string password)
        {
            foreach (var service in userServices)
            {
                var user = service.GetUserByUsername(username);
                if (user != null && user.Password == password)
                {
                    return user;
                }
            }
            return null; // Authentication failed
        }

    }
}
