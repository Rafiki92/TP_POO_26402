using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a timetable in the thrift shop application.
    /// Stores information about the schedule, including date, time slot, and assigned function.
    /// </summary>
    public class Timetable
    {
        #region Attributes
        // Unique identifier for the timetable.
        private int timetableID;

        // The date of the timetable.
        private DateTime date;

        // The time slot for the timetable (e.g., "Morning", "Afternoon").
        private string timeSlot;

        // The function or activity associated with the timetable.
        private string function;

        // The number of hours allocated for the function or activity.
        private float hours;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the timetable.
        /// </summary>
        public int TimetableID
        {
            get { return timetableID; }
            set { timetableID = value; }
        }

        /// <summary>
        /// Gets or sets the date of the timetable.
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Gets or sets the time slot for the timetable (e.g., "Morning", "Afternoon").
        /// </summary>
        public string TimeSlot
        {
            get { return timeSlot; }
            set { timeSlot = value; }
        }

        /// <summary>
        /// Gets or sets the function or activity associated with the timetable.
        /// </summary>
        public string Function
        {
            get { return function; }
            set { function = value; }
        }

        /// <summary>
        /// Gets or sets the number of hours allocated for the function or activity.
        /// </summary>
        public float Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Timetable"/> class.
        /// </summary>
        /// <param name="timetableID">The unique ID of the timetable.</param>
        /// <param name="date">The date of the timetable.</param>
        /// <param name="timeSlot">The time slot for the timetable (e.g., "Morning", "Afternoon").</param>
        /// <param name="function">The function or activity associated with the timetable.</param>
        /// <param name="hours">The number of hours allocated for the activity.</param>
        public Timetable(int timetableID, DateTime date, string timeSlot, string function, float hours)
        {
            this.TimetableID = timetableID;
            this.Date = date;
            this.TimeSlot = timeSlot ?? throw new ArgumentNullException(nameof(timeSlot), "Time slot cannot be null.");
            this.Function = function ?? throw new ArgumentNullException(nameof(function), "Function cannot be null.");
            this.Hours = hours > 0 ? hours : throw new ArgumentOutOfRangeException(nameof(hours), "Hours must be greater than zero.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Displays the details of the timetable.
        /// </summary>
        public void DisplayTimetableDetails()
        {
            Console.WriteLine($"ID: {TimetableID}, Date: {Date.ToShortDateString()}, Time Slot: {TimeSlot}, Function: {Function}, Hours: {Hours}");
        }
        #endregion
    }
}


