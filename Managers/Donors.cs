using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages donor records for the thrift shop application.
    /// Provides functionality to add, update, inactivate, and display donors.
    /// </summary>
    public class Donors
    {
        // List to store donor objects.
        private readonly List<Donor> donors = new List<Donor>();

        #region Methods

        /// <summary>
        /// Adds a new donor to the collection.
        /// </summary>
        /// <param name="donor">The donor object to add.</param>
        public void AddDonor(Donor donor)
        {
            // Ensure the donor object is not null.
            if (donor == null)
                throw new ArgumentNullException(nameof(donor), "Donor cannot be null.");

            // Prevent duplicate donor entries based on DonorID.
            if (donors.Any(d => d.DonorID == donor.DonorID))
                throw new ArgumentException($"A donor with ID {donor.DonorID} already exists.");

            // Add the donor to the list.
            donors.Add(donor);
        }

        /// <summary>
        /// Updates the details of an existing donor.
        /// </summary>
        /// <param name="donorID">The ID of the donor to update.</param>
        /// <param name="newName">The new name of the donor.</param>
        /// <param name="newContactNumber">The new contact number of the donor.</param>
        /// <param name="newStartDate">The new start date of the donor.</param>
        /// <param name="newEndDate">The new end date of the donor (nullable).</param>
        /// <returns>True if the donor was updated successfully; otherwise, false.</returns>
        public bool UpdateDonor(int donorID, string newName, int newContactNumber, DateTime newStartDate, DateTime? newEndDate)
        {
            // Find the donor by their ID.
            var donor = donors.FirstOrDefault(d => d.DonorID == donorID);
            if (donor == null) return false;

            // Update the donor's details with the provided values.
            donor.Name = newName;
            donor.ContactNumber = newContactNumber;
            donor.StartDate = newStartDate;
            donor.EndDate = newEndDate;
            return true;
        }

        /// <summary>
        /// Inactivates a donor by setting their EndDate to the current date and time.
        /// </summary>
        /// <param name="donorID">The ID of the donor to inactivate.</param>
        /// <returns>True if the donor was inactivated successfully; otherwise, false.</returns>
        public bool InactivateDonor(int donorID)
        {
            // Find the donor by their ID.
            var donor = donors.FirstOrDefault(d => d.DonorID == donorID);
            if (donor == null) return false;

            // Mark the donor as inactive by setting the EndDate to the current date.
            donor.EndDate = DateTime.Now;
            return true;
        }

        /// <summary>
        /// Displays the details of all donors, including their active/inactive status.
        /// </summary>
        public void DisplayDonors()
        {
            // Display the total count of donors.
            Console.WriteLine($"Total Number of Donors: {donors.Count}");

            // Loop through each donor and display their details.
            foreach (var donor in donors)
            {
                // Determine if the donor is active or inactive.
                string activeStatus = donor.IsActive() ? "Active" : "Inactive";

                // Display the donor's details.
                Console.WriteLine($"ID: {donor.DonorID}, Name: {donor.Name}, Contact: {donor.ContactNumber}, Status: {activeStatus}");
            }
        }

        /// <summary>
        /// Retrieves the list of all donors.
        /// </summary>
        /// <returns>A list of donor objects.</returns>
        public List<Donor> GetAllDonors()
        {
            // Return the internal list of donors.
            return donors;
        }

        #endregion
    }
}

