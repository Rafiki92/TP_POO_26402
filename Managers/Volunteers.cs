using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages the list of volunteers in the thrift shop application.
    /// Implements the <see cref="IUserService"/> interface to provide user-related functionality.
    /// </summary>
    public class Volunteers : IUserService
    {
        // List to store Volunteer objects.
        private readonly List<Volunteer> volunteers = new List<Volunteer>();

        #region Methods

        /// <summary>
        /// Adds a new volunteer to the collection.
        /// </summary>
        /// <param name="volunteer">The volunteer object to add.</param>
        public void AddVolunteer(Volunteer volunteer)
        {
            // Ensure the volunteer object is not null.
            if (volunteer == null)
                throw new ArgumentNullException(nameof(volunteer), "Volunteer cannot be null.");

            // Prevent duplicates by checking for existing UserId.
            if (volunteers.Any(v => v.UserId == volunteer.UserId))
                throw new ArgumentException($"A volunteer with ID {volunteer.UserId} already exists.");

            // Add the volunteer to the list.
            volunteers.Add(volunteer);

            // Inform the user about the successful addition.
            Console.WriteLine($"Volunteer '{volunteer.Name}' added successfully.");
        }

        /// <summary>
        /// Updates the details of an existing volunteer.
        /// </summary>
        /// <param name="userId">The ID of the volunteer to update.</param>
        /// <param name="newName">The new name of the volunteer.</param>
        /// <param name="newAddress">The new address of the volunteer.</param>
        /// <param name="newContactNumber">The new contact number of the volunteer (nullable).</param>
        /// <param name="newUsername">The new username for the volunteer.</param>
        /// <param name="newPassword">The new password for the volunteer.</param>
        /// <param name="newVolunteerHours">The updated volunteer hours.</param>
        /// <returns>True if the volunteer was updated successfully; otherwise, false.</returns>
        public bool UpdateVolunteer(int userId, string newName, string newAddress, int? newContactNumber, string newUsername, string newPassword, float newVolunteerHours)
        {
            // Find the volunteer by their UserId.
            var volunteer = volunteers.FirstOrDefault(v => v.UserId == userId);
            if (volunteer == null)
            {
                Console.WriteLine($"Volunteer with ID {userId} not found.");
                return false;
            }

            // Update the volunteer's details with the provided values.
            volunteer.Name = newName;
            volunteer.Address = newAddress;
            volunteer.ContactNumber = newContactNumber;
            volunteer.Username = newUsername;
            volunteer.Password = newPassword;
            volunteer.VolunteerHours = newVolunteerHours;

            // Inform the user about the successful update.
            Console.WriteLine($"Volunteer with ID {userId} updated successfully.");
            return true;
        }

        /// <summary>
        /// Inactivates a volunteer by setting their EndDate to the current date and time.
        /// </summary>
        /// <param name="userId">The ID of the volunteer to inactivate.</param>
        /// <returns>True if the volunteer was inactivated successfully; otherwise, false.</returns>
        public bool InactivateVolunteer(int userId)
        {
            // Find the volunteer by their UserId.
            var volunteer = volunteers.FirstOrDefault(v => v.UserId == userId);
            if (volunteer == null)
            {
                Console.WriteLine($"Volunteer with ID {userId} not found.");
                return false;
            }

            // Set the EndDate to mark the volunteer as inactive.
            volunteer.EndDate = DateTime.Now;

            // Inform the user about the successful inactivation.
            Console.WriteLine($"Volunteer with ID {userId} has been inactivated.");
            return true;
        }

        /// <summary>
        /// Displays all volunteers in the collection.
        /// </summary>
        public void DisplayAllVolunteers()
        {
            // Display the total number of volunteers.
            Console.WriteLine($"Total Number of Volunteers: {volunteers.Count}");

            // Loop through and display each volunteer's details.
            foreach (var volunteer in volunteers)
            {
                Console.WriteLine($"ID: {volunteer.UserId}, Name: {volunteer.Name}, Hours: {volunteer.VolunteerHours}, End Date: {(volunteer.EndDate.HasValue ? volunteer.EndDate.Value.ToShortDateString() : "Active")}");
            }
        }

        /// <summary>
        /// Retrieves all volunteers as an enumerable collection of users.
        /// </summary>
        /// <returns>An enumerable collection of <see cref="User"/> objects.</returns>
        public IEnumerable<User> GetAllUsers()
        {
            // Cast the list of volunteers to a collection of User and return it.
            return volunteers.Cast<User>();
        }

        /// <summary>
        /// Retrieves a volunteer by their username.
        /// </summary>
        /// <param name="username">The username of the volunteer to retrieve.</param>
        /// <returns>The <see cref="User"/> object if found; otherwise, null.</returns>
        public User GetUserByUsername(string username)
        {
            // Find and return the volunteer with the matching username.
            return volunteers.FirstOrDefault(v => v.Username == username);
        }

        #endregion
    }
}

