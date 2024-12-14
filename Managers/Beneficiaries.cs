using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Concrete implementation of the IBeneficiaries interface.
    /// Manages the list of beneficiaries and provides operations for adding, updating, and retrieving them.
    /// </summary>
    public class Beneficiaries : IBeneficiaries
    {
        // List to store beneficiary objects.
        private readonly List<Beneficiary> beneficiaries = new List<Beneficiary>();

        #region Methods
        /// <summary>
        /// Adds a new beneficiary to the list.
        /// </summary>
        /// <param name="beneficiary">The beneficiary object to add.</param>
        public void AddBeneficiary(Beneficiary beneficiary)
        {
            // Ensure the beneficiary object is not null.
            if (beneficiary == null)
                throw new ArgumentNullException(nameof(beneficiary), "Beneficiary cannot be null.");

            // Optionally, prevent adding duplicate entries based on BenID.
            if (beneficiaries.Any(b => b.BenID == beneficiary.BenID))
                throw new ArgumentException($"A beneficiary with ID {beneficiary.BenID} already exists.");

            // Add the beneficiary to the internal list.
            beneficiaries.Add(beneficiary);
        }

        /// <summary>
        /// Updates an existing beneficiary's details.
        /// </summary>
        /// <param name="benID">The ID of the beneficiary to update.</param>
        /// <param name="newName">The new name of the beneficiary.</param>
        /// <param name="newPhoneNumber">The new phone number of the beneficiary.</param>
        /// <param name="newReference">The new reference for the beneficiary.</param>
        /// <param name="newFamilyNumber">The updated family number.</param>
        /// <param name="newHasChildren">Indicates if the beneficiary has children.</param>
        /// <param name="newNotes">Additional notes for the beneficiary.</param>
        /// <param name="newNationality">The updated nationality.</param>
        /// <param name="newStartDate">The new start date.</param>
        /// <param name="newEndDate">The new end date (nullable).</param>
        /// <returns>True if the beneficiary was updated successfully; otherwise, false.</returns>
        public bool UpdateBeneficiary(int benID, string newName, int newPhoneNumber, string newReference, int newFamilyNumber, bool newHasChildren, string newNotes, string newNationality, DateTime newStartDate, DateTime? newEndDate)
        {
            // Find the beneficiary by their ID.
            var beneficiary = beneficiaries.FirstOrDefault(b => b.BenID == benID);
            if (beneficiary == null)
            {
                // Return false if the beneficiary is not found.
                return false;
            }

            // Update the beneficiary's details with the provided values.

            beneficiary.Name = newName;
            beneficiary.PhoneNumber = newPhoneNumber;
            beneficiary.Reference = newReference;
            beneficiary.FamilyNumber = newFamilyNumber;
            beneficiary.HasChildren = newHasChildren;
            beneficiary.Notes = newNotes;
            beneficiary.Nationality = newNationality;
            beneficiary.StartDate = newStartDate;
            beneficiary.EndDate = newEndDate;

            return true;
        }
        /// <summary>
        /// Marks a beneficiary as inactive by setting their EndDate to the current date.
        /// </summary>
        /// <param name="benID">The ID of the beneficiary to inactivate.</param>
        /// <returns>True if the beneficiary was inactivated successfully; otherwise, false.</returns>

        public bool InactivateBeneficiary(int benID)
        {
            // Find the beneficiary by their ID
            var beneficiary = beneficiaries.FirstOrDefault(b => b.BenID == benID);
            if (beneficiary == null)
                return false; // Return false if the beneficiary is not found.

            // Set the EndDate to the current date to mark the beneficiary as inactive.
            beneficiary.EndDate = DateTime.Now;
            return true;
        }

        /// <summary>
        /// Retrieves all beneficiaries in the internal list.
        /// </summary>
        /// <returns>A list of all beneficiary objects.</returns>
        public List<Beneficiary> GetAll()
        {
            // Return the internal list of beneficiaries.
            return new List<Beneficiary>(beneficiaries); 
        }

        /// <summary>
        /// Displays the details of all beneficiaries, including their active status.
        /// </summary>
        public void DisplayBeneficiaries()
        {
            // Display the total count of beneficiaries.
            Console.WriteLine($"Total Number of Beneficiaries: {beneficiaries.Count}");
            // Loop through each beneficiary and display their details.
            foreach (var beneficiary in beneficiaries)
            {
                // Determine if the beneficiary is active or inactive based on their EndDate.
                string activeStatus = beneficiary.IsActive() ? "Active" : "Inactive";
                // Display the beneficiary's details.
                Console.WriteLine($"ID: {beneficiary.BenID}, Name: {beneficiary.Name}, Contact: {beneficiary.PhoneNumber}, Nationality: {beneficiary.Nationality}, Status: {activeStatus}");
            }

            #endregion
        }
    }
}

