using System;
using System.Collections.Generic;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Defines a contract for user management services in the thrift shop application.
    /// Provides methods to retrieve all users and get a user by their username.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Retrieves all users managed by the implementing service.
        /// </summary>
        /// <returns>An enumerable collection of <see cref="User"/> objects.</returns>
        IEnumerable<User> GetAllUsers();

        /// <summary>
        /// Retrieves a user by their unique username.
        /// </summary>
        /// <param name="username">The username of the user to retrieve.</param>
        /// <returns>
        /// A <see cref="User"/> object if a user with the specified username exists; otherwise, null.
        /// </returns>
        User GetUserByUsername(string username);
    }
}

