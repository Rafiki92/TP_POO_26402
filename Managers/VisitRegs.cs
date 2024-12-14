using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages visit registrations for the thrift shop application.
    /// Provides functionality to add, remove, and display visit records.
    /// </summary>
    public class VisitRegs
    {
        // List to store VisitReg objects, representing individual visit registrations.
        private readonly List<VisitReg> visitRegs = new List<VisitReg>();

        #region Methods

        /// <summary>
        /// Adds a new visit registration to the collection.
        /// </summary>
        /// <param name="visit">The visit registration object to add.</param>
        public void AddVisit(VisitReg visit)
        {
            // Ensure the visit object is not null.
            if (visit == null)
                throw new ArgumentNullException(nameof(visit));

            // Check for duplicate visit IDs.
            if (visitRegs.Any(v => v.VisitID == visit.VisitID))
                throw new ArgumentException($"A visit with ID {visit.VisitID} already exists.");

            // Add the visit to the list.
            visitRegs.Add(visit);

            // Inform the user about the successful addition.
            Console.WriteLine($"Visit registration with ID {visit.VisitID} added successfully.");
        }

        /// <summary>
        /// Displays all visit registrations in the collection.
        /// </summary>
        public void DisplayAllVisits()
        {
            Console.WriteLine("\nList of All Visit Registrations:");

            // Check if there are any visit registrations.
            if (visitRegs.Count == 0)
            {
                Console.WriteLine("No visit registrations found.");
                return;
            }

            // Loop through and display each visit's details.
            foreach (var visit in visitRegs)
            {
                Console.WriteLine($"Visit ID: {visit.VisitID}, Date: {visit.Date.ToShortDateString()}, Beneficiary: {visit.Beneficiary.Name}, Registered by: {visit.Volunteer.GetUsername()}");
            }
        }

        /// <summary>
        /// Displays all visit registrations for a specific beneficiary.
        /// </summary>
        /// <param name="beneficiary">The beneficiary whose visits are to be displayed.</param>
        public void DisplayVisitsByBeneficiary(Beneficiary beneficiary)
        {
            // Ensure the beneficiary object is not null.
            if (beneficiary == null)
                throw new ArgumentNullException(nameof(beneficiary));

            Console.WriteLine($"\nVisits for Beneficiary: {beneficiary.Name}");
            bool hasVisits = false;

            // Find and display visits associated with the given beneficiary.
            foreach (var visit in visitRegs.Where(v => v.Beneficiary.BenID == beneficiary.BenID))
            {
                Console.WriteLine($"Visit ID: {visit.VisitID}, Date: {visit.Date.ToShortDateString()}, Registered by: {visit.Volunteer.GetUsername()}");
                hasVisits = true;
            }

            // Inform the user if no visits were found for the beneficiary.
            if (!hasVisits)
            {
                Console.WriteLine("No visits found for this beneficiary.");
            }
        }

        /// <summary>
        /// Removes a visit registration by its unique ID.
        /// </summary>
        /// <param name="visitID">The unique ID of the visit registration to remove.</param>
        /// <returns>True if the visit was removed successfully; otherwise, false.</returns>
        public bool RemoveVisitByID(int visitID)
        {
            // Find the visit by its ID.
            var visit = visitRegs.FirstOrDefault(v => v.VisitID == visitID);

            if (visit != null)
            {
                // Remove the visit from the list.
                visitRegs.Remove(visit);

                // Inform the user about the successful removal.
                Console.WriteLine($"Visit registration with ID {visitID} removed successfully.");
                return true;
            }

            // Inform the user if the visit was not found.
            Console.WriteLine($"Visit registration with ID {visitID} not found.");
            return false;
        }

        #endregion
    }
}

