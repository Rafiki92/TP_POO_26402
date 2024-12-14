using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Managers;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Handles user authentication by validating credentials across multiple user services.
    /// </summary>
    public class LoginService
    {
        // Array to hold references to different user service implementations (e.g., Admins, Beneficiaries).
        private readonly IUserService[] userServices;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginService"/> class with multiple user services.
        /// </summary>
        /// <param name="userServices">A list of user services implementing the <see cref="IUserService"/> interface.</param>
        public LoginService(params IUserService[] userServices)
        {
            this.userServices = userServices;
        }

        /// <summary>
        /// Authenticates a user by their username and password across all registered user services.
        /// </summary>
        /// <param name="username">The username of the user attempting to log in.</param>
        /// <param name="password">The password of the user attempting to log in.</param>
        /// <returns>The authenticated <see cref="User"/> object if credentials are valid; otherwise, null.</returns>
        public User Authenticate(string username, string password)
        {
            // Loop through each user service to find and authenticate the user.
            foreach (var service in userServices)
            {
                // Attempt to retrieve the user by their username.
                var user = service.GetUserByUsername(username);

                // Validate the user's password if the user exists.
                if (user != null && user.Password == password)
                {
                    return user; // Authentication successful, return the user object.
                }
            }

            // Return null if no valid user was found in any service.
            return null;
        }
    }
}

