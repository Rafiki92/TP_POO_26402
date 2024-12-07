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
        private string timeSlot; 
        private string function;
        private float hours;
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

        public string TimeSlot
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
        #endregion

        #region Constructors

        public Timetable(int timetableID, DateTime date, string timeSlot, string function, float hours)
        {
            this.TimetableID = timetableID;
            this.Date = date;
            this.TimeSlot = timeSlot;
            this.Function = function;
            this.Hours = hours;
        }
        #endregion

        #region Methods
        public void DisplayTimetableDetails()
        {
            Console.WriteLine($"ID: {TimetableID}, Date: {Date.ToShortDateString()}, Time Slot: {TimeSlot}, Function: {Function}, Hours: {Hours}");
        }
        #endregion

    }
}

