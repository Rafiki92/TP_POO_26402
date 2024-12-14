using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages donation records for the thrift shop application.
    /// Provides functionality to add, remove, retrieve, and display donations.
    /// </summary>
    public class Donations
    {
        // List to store the collection of donations.
        private readonly List<Donation> donations = new List<Donation>();

        #region Methods

        /// <summary>
        /// Adds a new donation to the collection.
        /// </summary>
        /// <param name="donation">The donation object to add.</param>
        public void AddDonation(Donation donation)
        {
            // Ensure the donation object is not null.
            if (donation == null)
                throw new ArgumentNullException(nameof(donation));

            // Check if a donation with the same ID already exists.
            if (donations.Any(d => d.DonationID == donation.DonationID))
                throw new ArgumentException($"A donation with ID {donation.DonationID} already exists.");

            // Add the donation to the list.
            donations.Add(donation);

            // Inform the user about the successful addition.
            Console.WriteLine($"Donation with ID {donation.DonationID} added successfully.");
        }

        /// <summary>
        /// Removes a donation from the collection by its unique ID.
        /// </summary>
        /// <param name="donationID">The ID of the donation to remove.</param>
        /// <returns>True if the donation was removed successfully; otherwise, false.</returns>
        public bool RemoveDonationByID(int donationID)
        {
            // Find the donation with the specified ID.
            var donation = donations.FirstOrDefault(d => d.DonationID == donationID);

            if (donation != null)
            {
                // Remove the donation from the list.
                donations.Remove(donation);

                // Inform the user about the successful removal.
                Console.WriteLine($"Donation with ID {donationID} removed successfully.");
                return true;
            }

            // Inform the user if the donation was not found.
            Console.WriteLine($"Donation with ID {donationID} not found.");
            return false;
        }

        /// <summary>
        /// Retrieves a donation by its unique ID.
        /// </summary>
        /// <param name="donationID">The ID of the donation to retrieve.</param>
        /// <returns>The Donation object if found; otherwise, null.</returns>
        public Donation GetDonationByID(int donationID)
        {
            // Find and return the donation with the specified ID.
            return donations.FirstOrDefault(d => d.DonationID == donationID);
        }

        /// <summary>
        /// Displays all donations in the collection.
        /// </summary>
        public void DisplayAllDonations()
        {
            Console.WriteLine("\nAll Donations:");

            // Check if the collection is empty.
            if (!donations.Any())
            {
                Console.WriteLine("No donations found.");
                return;
            }

            // Loop through and display each donation's details.
            foreach (var donation in donations)
            {
                Console.WriteLine(donation.ToString());
            }
        }

        #endregion
    }
}

