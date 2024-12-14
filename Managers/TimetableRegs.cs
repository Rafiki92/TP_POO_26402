using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages timetable registrations for volunteers in the thrift shop application.
    /// Provides functionality to add, remove, and display timetable registrations.
    /// </summary>
    public class TimetableRegs
    {
        // List to store TimetableReg objects, representing volunteer schedule registrations.
        private readonly List<TimetableReg> timetableRegs = new List<TimetableReg>();

        #region Methods

        /// <summary>
        /// Adds a new timetable registration to the collection.
        /// </summary>
        /// <param name="timetableReg">The timetable registration object to add.</param>
        public void AddTimetableReg(TimetableReg timetableReg)
        {
            // Ensure the timetable registration object is not null.
            if (timetableReg == null)
                throw new ArgumentNullException(nameof(timetableReg));

            // Check for duplicate registrations by ID.
            if (timetableRegs.Any(tr => tr.TimetableRegID == timetableReg.TimetableRegID))
                throw new ArgumentException($"A timetable registration with ID {timetableReg.TimetableRegID} already exists.");

            // Add the timetable registration to the list.
            timetableRegs.Add(timetableReg);

            // Inform the user about the successful addition.
            Console.WriteLine($"Timetable registration ID {timetableReg.TimetableRegID} added successfully for volunteer {timetableReg.Volunteer.Name}.");
        }

        /// <summary>
        /// Removes a timetable registration by its unique ID.
        /// </summary>
        /// <param name="timetableRegID">The unique ID of the timetable registration to remove.</param>
        /// <returns>True if the registration was removed successfully; otherwise, false.</returns>
        public bool RemoveTimetableRegByID(int timetableRegID)
        {
            // Find the timetable registration by its ID.
            var reg = timetableRegs.FirstOrDefault(r => r.TimetableRegID == timetableRegID);

            if (reg != null)
            {
                // Remove the registration from the list.
                timetableRegs.Remove(reg);

                // Inform the user about the successful removal.
                Console.WriteLine($"Timetable registration with ID {timetableRegID} removed successfully.");
                return true;
            }

            // Inform the user if the registration was not found.
            Console.WriteLine($"Timetable registration with ID {timetableRegID} not found.");
            return false;
        }

        /// <summary>
        /// Displays all timetable registrations in the collection.
        /// </summary>
        public void DisplayAllTimetableRegistrations()
        {
            Console.WriteLine("\nList of All Timetable Registrations:");

            // Check if the collection is empty.
            if (timetableRegs.Count == 0)
            {
                Console.WriteLine("No timetable registrations found.");
                return;
            }

            // Loop through and display each timetable registration's details.
            foreach (var reg in timetableRegs)
            {
                Console.WriteLine(reg.ToString());
            }
        }

        /// <summary>
        /// Displays timetable registrations for a specific volunteer.
        /// </summary>
        /// <param name="volunteer">The volunteer whose registrations to display.</param>
        public void DisplayRegistrationsByVolunteer(Volunteer volunteer)
        {
            // Ensure the volunteer object is not null.
            if (volunteer == null)
                throw new ArgumentNullException(nameof(volunteer));

            Console.WriteLine($"\nTimetable Registrations for Volunteer: {volunteer.Name}");
            bool hasRegistrations = false;

            // Find and display registrations associated with the given volunteer.
            foreach (var reg in timetableRegs.Where(r => r.Volunteer.UserId == volunteer.UserId))
            {
                Console.WriteLine(reg.ToString());
                hasRegistrations = true;
            }

            // Inform the user if no registrations were found for the volunteer.
            if (!hasRegistrations)
            {
                Console.WriteLine("No registrations found for this volunteer.");
            }
        }

        #endregion
    }
}

