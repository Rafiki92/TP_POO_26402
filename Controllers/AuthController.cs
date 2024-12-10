using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Services;

namespace ThriftShopApp.Controllers
{
    public class AuthController
    {
        private readonly LoginService loginService;

        #region Methods
        public AuthController(LoginService loginService)
        {
            this.loginService = loginService;
        }

        /// <summary>
        /// Logs in a user by authenticating credentials.
        /// </summary>
        /// <param name="username">The username provided.</param>
        /// <param name="password">The password provided.</param>
        /// <returns>The authenticated user.</returns>
        public User Login(string username, string password)
        {
            var user = loginService.Authenticate(username, password);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }
            return user;
        }

        #endregion



    }
}
