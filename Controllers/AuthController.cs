using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Managers;

namespace ThriftShopApp.Controllers
{
    /// <summary>
    /// Handles user authentication processes for the thrift shop application.
    /// Interacts with the <see cref="LoginService"/> to authenticate users.
    /// </summary>
    public class AuthController
    {
        // Instance of LoginService to handle authentication.
        private readonly LoginService loginService;

        #region Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthController"/> class with a specified <see cref="LoginService"/>.
        /// </summary>
        /// <param name="loginService">The login service to use for authentication.</param>
        public AuthController(LoginService loginService)
        {
            // Dependency injection of LoginService.
            this.loginService = loginService;
        }

        /// <summary>
        /// Logs in a user by authenticating their credentials.
        /// </summary>
        /// <param name="username">The username provided by the user.</param>
        /// <param name="password">The password provided by the user.</param>
        /// <returns>The authenticated <see cref="User"/> object.</returns>
        /// <exception cref="UnauthorizedAccessException">
        /// Thrown if the username or password is invalid.
        /// </exception>
        public User Login(string username, string password)
        {
            // Authenticate the user using the LoginService.
            var user = loginService.Authenticate(username, password);

            // If authentication fails, throw an exception.
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            // Return the authenticated user.
            return user;
        }

        #endregion
    }
}

