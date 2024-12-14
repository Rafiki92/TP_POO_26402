using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages the list of needs for the thrift shop application.
    /// Provides functionality to add, remove, retrieve, and display needs.
    /// </summary>
    public class Needs
    {
        // List to store Need objects.
        private readonly List<Need> needs = new List<Need>();

        #region Methods

        /// <summary>
        /// Adds a new need to the collection.
        /// </summary>
        /// <param name="need">The need object to add.</param>
        public void AddNeed(Need need)
        {
            // Ensure the need object is not null.
            if (need == null)
                throw new ArgumentNullException(nameof(need));

            // Check if a need with the same ID already exists.
            if (needs.Any(n => n.NeedID == need.NeedID))
                throw new ArgumentException($"A need with ID {need.NeedID} already exists.");

            // Add the need to the list.
            needs.Add(need);

            // Inform the user about the successful addition.
            Console.WriteLine($"Need '{need.Name}' added successfully.");
        }

        /// <summary>
        /// Removes a need from the collection by its unique ID.
        /// </summary>
        /// <param name="needID">The ID of the need to remove.</param>
        /// <returns>True if the need was removed successfully; otherwise, false.</returns>
        public bool RemoveNeedByID(int needID)
        {
            // Find the need by its ID.
            var need = needs.FirstOrDefault(n => n.NeedID == needID);

            if (need != null)
            {
                // Remove the need from the list.
                needs.Remove(need);

                // Inform the user about the successful removal.
                Console.WriteLine($"Need with ID {needID} removed successfully.");
                return true;
            }

            // Inform the user if the need was not found.
            Console.WriteLine($"Need with ID {needID} not found.");
            return false;
        }

        /// <summary>
        /// Retrieves a need by its unique ID.
        /// </summary>
        /// <param name="needID">The ID of the need to retrieve.</param>
        /// <returns>The <see cref="Need"/> object if found; otherwise, null.</returns>
        public Need GetNeedByID(int needID)
        {
            // Find and return the need with the specified ID.
            return needs.FirstOrDefault(n => n.NeedID == needID);
        }

        /// <summary>
        /// Displays all needs in the collection.
        /// </summary>
        public void DisplayAllNeeds()
        {
            Console.WriteLine("\nAll Needs:");

            // Check if the collection is empty.
            if (!needs.Any())
            {
                Console.WriteLine("No needs found.");
                return;
            }

            // Loop through and display each need's details.
            foreach (var need in needs)
            {
                Console.WriteLine(need.ToString());
            }
        }

        #endregion
    }
}

