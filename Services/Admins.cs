using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class Admins : IUserService
    {
        private readonly List <Admin> admins = new List <Admin> ();

        #region Methods
        public void AddAdmin(Admin admin)
        {
            if (admin == null)
                throw new ArgumentNullException(nameof(admin), "Admin cannot be null.");

            if (admins.Any(a => a.UserId == admin.UserId))
                throw new ArgumentException($"An admin with ID {admin.UserId} already exists.");

            admins.Add(admin);
            Console.WriteLine($"Admin '{admin.Name}' added successfully.");
        }
        public bool UpdateAdmin(int userId, string newName, string newAddress, int? newContactNumber, string newUsername, string newPassword, string newDepartment)
        {
            var admin = admins.FirstOrDefault(a => a.UserId == userId);
            if (admin == null)
            {
                Console.WriteLine($"Admin with ID {userId} not found.");
                return false;
            }

            admin.Name = newName;
            admin.Address = newAddress;
            admin.ContactNumber = newContactNumber;
            admin.Username = newUsername;
            admin.Password = newPassword;
            admin.Department = newDepartment;

            Console.WriteLine($"Admin with ID {userId} updated successfully.");
            return true;
        }

        public bool InactivateAdmin(int userId)
        {
            var admin = admins.FirstOrDefault(a => a.UserId == userId);
            if (admin == null)
            {
                Console.WriteLine($"Admin with ID {userId} not found.");
                return false;
            }

            admin.EndDate = DateTime.Now;
            Console.WriteLine($"Admin with ID {userId} has been inactivated.");
            return true;
        }

        public void DisplayAllAdmins()
        {
            Console.WriteLine($"Total Number of Admins: {admins.Count}");
            foreach (var admin in admins)
            {
                Console.WriteLine($"ID: {admin.UserId}, Name: {admin.Name}, Department: {admin.Department}, End Date: {(admin.EndDate.HasValue ? admin.EndDate.Value.ToShortDateString() : "Active")}");
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            return admins.Cast<User>();
        }

        public User GetUserByUsername(string username)
        {
            return admins.FirstOrDefault(a => a.Username == username);
        }

        #endregion
    }
}
