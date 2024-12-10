using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class Timetables
    {
      private readonly List<Timetable> timetables = new List<Timetable>();

        #region Methods
        public void AddTimetable(Timetable timetable)
        {
            if (timetable == null)
                throw new ArgumentNullException(nameof(timetable), "Timetable cannot be null.");

            timetables.Add(timetable);
        }

        public bool RemoveTimetableByID(int timetableID)
        {
            var timetable = timetables.FirstOrDefault(t => t.TimetableID == timetableID);
            if (timetable != null)
            {
                timetables.Remove(timetable);
                Console.WriteLine($"Timetable with ID {timetableID} removed successfully.");
                return true;
            }

            Console.WriteLine($"Timetable with ID {timetableID} not found.");
            return false;
        }

        /// <summary>
        /// Updates a timetable's details.
        /// </summary>
        public bool UpdateTimetable(int timetableID, DateTime newDate, string newTimeSlot, string newFunction, float newHours)
        {
            var timetable = timetables.FirstOrDefault(t => t.TimetableID == timetableID);
            if (timetable == null)
                return false;

            timetable.Date = newDate;
            timetable.TimeSlot = newTimeSlot;
            timetable.Function = newFunction;
            timetable.Hours = newHours;

            Console.WriteLine($"Timetable with ID {timetableID} updated successfully.");
            return true;
        }

        public void DisplayAllTimetables()
        {
            Console.WriteLine($"Total Number of Timetables: {timetables.Count}");
            foreach (var timetable in timetables)
            {
                timetable.DisplayTimetableDetails();
            }
        }

        #endregion
    }
}
