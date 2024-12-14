using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages admin users for the Thrift Shop application. Implements the IUserService interface.
    /// </summary>
    public class Admins : IUserService
    {
        // List to store the collection of admin objects.
        private readonly List <Admin> admins = new List <Admin> ();

        #region Methods

        /// <summary>
        /// Adds a new admin to the list.
        /// </summary>
        /// <param name="admin">The admin object to add.</param>
        public void AddAdmin(Admin admin)
        {
            // Check if the provided admin object is null.
            if (admin == null)
                throw new ArgumentNullException(nameof(admin), "Admin cannot be null.");

            // Ensure there is no duplicate admin with the same UserId.
            if (admins.Any(a => a.UserId == admin.UserId))
                throw new ArgumentException($"An admin with ID {admin.UserId} already exists.");

            // Add the admin to the list.
            admins.Add(admin);

            // Inform the user that the admin has been successfully added.
            Console.WriteLine($"Admin '{admin.Name}' added successfully.");
        }
        /// <summary>
        /// Updates the details of an existing admin.
        /// </summary>
        /// <param name="userId">The ID of the admin to update.</param>
        /// <param name="newName">The new name for the admin.</param>
        /// <param name="newAddress">The new address for the admin.</param>
        /// <param name="newContactNumber">The new contact number for the admin (nullable).</param>
        /// <param name="newUsername">The new username for the admin.</param>
        /// <param name="newPassword">The new password for the admin.</param>
        /// <param name="newDepartment">The new department for the admin.</param>
        /// <returns>True if the admin was updated successfully, false otherwise.</returns>
        public bool UpdateAdmin(int userId, string newName, string newAddress, int? newContactNumber, string newUsername, string newPassword, string newDepartment)
        {
            // Find the admin by their UserId.
            var admin = admins.FirstOrDefault(a => a.UserId == userId);
            if (admin == null)
            {
                // Inform the user if the admin was not found.
                Console.WriteLine($"Admin with ID {userId} not found.");
                return false;
            }
            // Update the admin's details with the provided values.
            admin.Name = newName;
            admin.Address = newAddress;
            admin.ContactNumber = newContactNumber;
            admin.Username = newUsername;
            admin.Password = newPassword;
            admin.Department = newDepartment;

            // Inform the user that the admin was updated successfully.
            Console.WriteLine($"Admin with ID {userId} updated successfully.");
            return true;
        }

        /// <summary>
        /// Inactivates an admin by setting their EndDate to the current date and time.
        /// </summary>
        /// <param name="userId">The ID of the admin to inactivate.</param>
        /// <returns>True if the admin was inactivated successfully, false otherwise.</returns>
        public bool InactivateAdmin(int userId)
        {
            // Find the admin by their UserId.
            var admin = admins.FirstOrDefault(a => a.UserId == userId);
            if (admin == null)
            {
                // Inform the user if the admin was not found.
                Console.WriteLine($"Admin with ID {userId} not found.");
                return false;
            }
            // Set the EndDate to mark the admin as inactivated.
            admin.EndDate = DateTime.Now;
            // Inform the user that the admin has been inactivated.
            Console.WriteLine($"Admin with ID {userId} has been inactivated.");
            return true;
        }

        /// <summary>
        /// Displays all admins in the collection, including their details.
        /// </summary>
        public void DisplayAllAdmins()
        {
            // Display the total number of admins.
            Console.WriteLine($"Total Number of Admins: {admins.Count}");
            
            // Loop through the admins and display their details.
            foreach (var admin in admins)
            {
                Console.WriteLine($"ID: {admin.UserId}, Name: {admin.Name}, Department: {admin.Department}, End Date: {(admin.EndDate.HasValue ? admin.EndDate.Value.ToShortDateString() : "Active")}");
            }
        }

        /// <summary>
        /// Retrieves all users as an enumerable collection.
        /// </summary>
        /// <returns>An enumerable collection of users.</returns>
        public IEnumerable<User> GetAllUsers()
        {
            return admins.Cast<User>();
        }

        /// <summary>
        /// Retrieves a user by their username.
        /// </summary>
        /// <param name="username">The username of the admin to retrieve.</param>
        /// <returns>The User object if found, otherwise null.</returns>
        public User GetUserByUsername(string username)
        {
            // Find and return the admin with the matching username.
            return admins.FirstOrDefault(a => a.Username == username);
        }

        #endregion
    }
}
