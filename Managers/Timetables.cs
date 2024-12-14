using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages the collection of timetables for the thrift shop application.
    /// Provides functionality to add, update, remove, and display timetables.
    /// </summary>
    public class Timetables
    {
        // List to store Timetable objects.
        private readonly List<Timetable> timetables = new List<Timetable>();

        #region Methods

        /// <summary>
        /// Adds a new timetable to the collection.
        /// </summary>
        /// <param name="timetable">The timetable object to add.</param>
        public void AddTimetable(Timetable timetable)
        {
            // Ensure the timetable object is not null.
            if (timetable == null)
                throw new ArgumentNullException(nameof(timetable), "Timetable cannot be null.");

            // Add the timetable to the list.
            timetables.Add(timetable);

            // Optional: Inform the user about the successful addition.
            Console.WriteLine($"Timetable with ID {timetable.TimetableID} added successfully.");
        }

        /// <summary>
        /// Removes a timetable from the collection by its unique ID.
        /// </summary>
        /// <param name="timetableID">The ID of the timetable to remove.</param>
        /// <returns>True if the timetable was removed successfully; otherwise, false.</returns>
        public bool RemoveTimetableByID(int timetableID)
        {
            // Find the timetable by its ID.
            var timetable = timetables.FirstOrDefault(t => t.TimetableID == timetableID);

            if (timetable != null)
            {
                // Remove the timetable from the list.
                timetables.Remove(timetable);

                // Inform the user about the successful removal.
                Console.WriteLine($"Timetable with ID {timetableID} removed successfully.");
                return true;
            }

            // Inform the user if the timetable was not found.
            Console.WriteLine($"Timetable with ID {timetableID} not found.");
            return false;
        }

        /// <summary>
        /// Updates the details of an existing timetable.
        /// </summary>
        /// <param name="timetableID">The ID of the timetable to update.</param>
        /// <param name="newDate">The new date of the timetable.</param>
        /// <param name="newTimeSlot">The new time slot for the timetable.</param>
        /// <param name="newFunction">The updated function or purpose of the timetable.</param>
        /// <param name="newHours">The new duration in hours for the timetable.</param>
        /// <returns>True if the timetable was updated successfully; otherwise, false.</returns>
        public bool UpdateTimetable(int timetableID, DateTime newDate, string newTimeSlot, string newFunction, float newHours)
        {
            // Find the timetable by its ID.
            var timetable = timetables.FirstOrDefault(t => t.TimetableID == timetableID);
            if (timetable == null)
                return false;

            // Update the timetable's details with the provided values.
            timetable.Date = newDate;
            timetable.TimeSlot = newTimeSlot;
            timetable.Function = newFunction;
            timetable.Hours = newHours;

            // Inform the user about the successful update.
            Console.WriteLine($"Timetable with ID {timetableID} updated successfully.");
            return true;
        }

        /// <summary>
        /// Displays all timetables in the collection.
        /// </summary>
        public void DisplayAllTimetables()
        {
            // Display the total number of timetables.
            Console.WriteLine($"Total Number of Timetables: {timetables.Count}");

            // Loop through and display each timetable's details.
            foreach (var timetable in timetables)
            {
                // Assuming the Timetable class has a method to display its details.
                timetable.DisplayTimetableDetails();
            }
        }

        #endregion
    }
}

