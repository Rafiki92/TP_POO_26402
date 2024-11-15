using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Registers;

namespace ThriftShopApp.Timetables
{/// <summary>
 /// Represents the available timetables.
 /// </summary>

    public class Timetable
    {
        #region Attributes
        private int timetableID;
        private DateTime date;
        private DateTime timeSlot; 
        private string function;
        private float hours;
        
        private static List<Timetable> timetables = new List<Timetable>();
        #endregion

        #region Properties
        public int TimetableID
        {
            get { return timetableID; }
            set { timetableID = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public DateTime TimeSlot
        {
            get { return timeSlot; }
            set { timeSlot = value; }
        }

        public string Function
        {
            get { return function; }
            set { function = value; }
        }

        public float Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public static List<Timetable> Timetables => timetables;
        #endregion

        #region Constructors

        public Timetable(int timetableID, DateTime date, DateTime timeSlot, string function, float hours)
        {
            this.TimetableID = timetableID;
            this.Date = date;
            this.TimeSlot = timeSlot;
            this.Function = function;
            this.Hours = hours;

            timetables.Add(this);
        }
        #endregion

        #region Methods
        public void DisplayTimetableDetails()
        {
            Console.WriteLine($"Timetable ID: {TimetableID}, Date: {Date.ToShortDateString()}, Time Slot: {TimeSlot.ToShortTimeString()}, Function: {Function}, Hours: {Hours}");
        }

        public static void DisplayAllTimetables()
        {
            Console.WriteLine("\nList of All Timetables:");
            foreach (var timetable in timetables)
            {
                timetable.DisplayTimetableDetails();
                Console.WriteLine();
            }
        }

        public static void AddTimetable(Timetable timetable)
        {
            if (timetable == null)
                throw new ArgumentNullException(nameof(timetable));
            timetables.Add(timetable);
            Console.WriteLine($"Timetable with ID {timetable.TimetableID} added successfully.");
        }
        #endregion

    }
}

