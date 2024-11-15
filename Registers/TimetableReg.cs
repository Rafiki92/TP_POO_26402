using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Timetables;
using ThriftShopApp.Users;

namespace ThriftShopApp.Registers
{/// <summary>
 /// Represents the register of a Timetable, from a User.
 /// </summary>
    public class TimetableReg
    {
        #region Attributes
        private int timetableRegID;
        private Volunteer volunteer;
        private Timetable timetable;

        private static List<TimetableReg> timetableRegs = new List<TimetableReg>();
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

        public static List<TimetableReg> TimetableRegs => timetableRegs;
        #endregion

        #region Constructors
        // Parameterized constructor
        public TimetableReg(int timetableRegID, Volunteer volunteer, Timetable timetable)
        {
            this.TimetableRegID = timetableRegID;
            this.Volunteer = volunteer;
            this.Timetable = timetable;

            timetableRegs.Add(this);
        }

        #endregion

        #region Methods
        public static void AddTimetableReg(TimetableReg timetableReg)
        {
            if (timetableReg == null)
                throw new ArgumentNullException(nameof(timetableReg));
            timetableRegs.Add(timetableReg);
            Console.WriteLine($"Timetable registration ID {timetableReg.TimetableRegID} added successfully for volunteer {timetableReg.Volunteer.Name}.");
        }

        public static void DisplayAllTimetableRegistrations()
        {
            Console.WriteLine("\nList of All Timetable Registrations:");
            if (timetableRegs.Count == 0)
            {
                Console.WriteLine("No timetable registrations found.");
                return;
            }

            foreach (var reg in timetableRegs)
            {
                Console.WriteLine(reg.ToString());
            }
        }

        public static void DisplayRegistrationsByVolunteer(Volunteer volunteer)
        {
            if (volunteer == null)
                throw new ArgumentNullException(nameof(volunteer));

            Console.WriteLine($"\nTimetable Registrations for Volunteer: {volunteer.Name}");
            bool hasRegistrations = false;

            foreach (var reg in timetableRegs)
            {
                if (reg.Volunteer.UserId == volunteer.UserId)
                {
                    Console.WriteLine(reg.ToString());
                    hasRegistrations = true;
                }
            }

            if (!hasRegistrations)
            {
                Console.WriteLine("No registrations found for this volunteer.");
            }
        }

        public override string ToString()
        {
            return $"TimetableReg ID: {timetableRegID}, Volunteer: {volunteer.Name}, Timetable ID: {timetable.TimetableID}, Date: {timetable.Date.ToShortDateString()}, Function: {timetable.Function}, Hours: {timetable.Hours}";
        }
        #endregion
    }
}