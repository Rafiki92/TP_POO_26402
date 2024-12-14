using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents the registration of a timetable by a volunteer in the thrift shop application.
    /// Tracks details about the assigned timetable and the volunteer who registered.
    /// </summary>
    public class TimetableReg
    {
        #region Attributes
        // Unique identifier for the timetable registration.
        private int timetableRegID;

        // Volunteer associated with this timetable registration.
        private Volunteer volunteer;

        // The timetable associated with this registration.
        private Timetable timetable;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the timetable registration.
        /// </summary>
        public int TimetableRegID
        {
            get { return timetableRegID; }
            set { timetableRegID = value; }
        }

        /// <summary>
        /// Gets or sets the volunteer associated with this timetable registration.
        /// </summary>
        public Volunteer Volunteer
        {
            get { return volunteer; }
            set { volunteer = value ?? throw new ArgumentNullException(nameof(volunteer), "Volunteer cannot be null."); }
        }

        /// <summary>
        /// Gets or sets the timetable associated with this registration.
        /// </summary>
        public Timetable Timetable
        {
            get { return timetable; }
            set { timetable = value ?? throw new ArgumentNullException(nameof(timetable), "Timetable cannot be null."); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="TimetableReg"/> class.
        /// </summary>
        /// <param name="timetableRegID">The unique ID of the timetable registration.</param>
        /// <param name="volunteer">The volunteer associated with this registration.</param>
        /// <param name="timetable">The timetable associated with this registration.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="volunteer"/> or <paramref name="timetable"/> is null.
        /// </exception>
        public TimetableReg(int timetableRegID, Volunteer volunteer, Timetable timetable)
        {
            this.TimetableRegID = timetableRegID;
            this.Volunteer = volunteer ?? throw new ArgumentNullException(nameof(volunteer), "Volunteer cannot be null.");
            this.Timetable = timetable ?? throw new ArgumentNullException(nameof(timetable), "Timetable cannot be null.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns a string representation of the timetable registration.
        /// </summary>
        /// <returns>
        /// A string containing the details of the registration, including the volunteer's name, timetable ID, date, function, and hours.
        /// </returns>
        public override string ToString()
        {
            string dateString = Timetable?.Date.ToShortDateString() ?? "N/A";

            return $"TimetableReg ID: {TimetableRegID}, " +
                   $"Volunteer: {Volunteer.Name}, " +
                   $"Timetable ID: {Timetable.TimetableID}, " +
                   $"Date: {dateString}, " +
                   $"Function: {Timetable.Function}, " +
                   $"Hours: {Timetable.Hours}";
        }
        #endregion
    }
}
