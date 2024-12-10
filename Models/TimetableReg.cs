using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThriftShopApp.Models
{/// <summary>
 /// Represents the register of a Timetable, from a Volunteer.
 /// </summary>
    public class TimetableReg
    {
        #region Attributes
        private int timetableRegID;
        private Volunteer volunteer;
        private Timetable timetable;
        #endregion

        #region Properties
        public int TimetableRegID
        {
            get { return timetableRegID; }
            set { timetableRegID = value; }
        }

        public Volunteer Volunteer
        {
            get { return volunteer; }
            set { volunteer = value; }
        }

        public Timetable Timetable
        {
            get { return timetable; }
            set { timetable = value; }
        }
        #endregion

        #region Constructors
        // Parameterized constructor
        public TimetableReg(int timetableRegID, Volunteer volunteer, Timetable timetable)
        {
            this.TimetableRegID = timetableRegID;
            this.Volunteer = volunteer;
            this.Timetable = timetable;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            string endDateString = (Timetable != null && Timetable.Date != null)
                ? Timetable.Date.ToShortDateString()
                : "N/A";

            return $"TimetableReg ID: {TimetableRegID}, " +
                   $"Volunteer: {Volunteer.Name}, " +
                   $"Timetable ID: {Timetable.TimetableID}, " +
                   $"Date: {endDateString}, " +
                   $"Function: {Timetable.Function}, " +
                   $"Hours: {Timetable.Hours}";
        }
        #endregion
    }
}