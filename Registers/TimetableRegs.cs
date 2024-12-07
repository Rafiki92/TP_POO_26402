using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Users;

namespace ThriftShopApp.Registers
{
    /// <summary>
    /// 
    /// </summary>
    public class TimetableRegs
    {
        private readonly List<TimetableReg> timetableRegs = new List<TimetableReg>();


        #region Methods
        public void AddTimetableReg(TimetableReg timetableReg)
        {
            if (timetableReg == null)
                throw new ArgumentNullException(nameof(timetableReg));

            // Optional: Check for duplicate IDs
            if (timetableRegs.Any(tr => tr.TimetableRegID == timetableReg.TimetableRegID))
                throw new ArgumentException($"A timetable registration with ID {timetableReg.TimetableRegID} already exists.");

            timetableRegs.Add(timetableReg);
            Console.WriteLine($"Timetable registration ID {timetableReg.TimetableRegID} added successfully for volunteer {timetableReg.Volunteer.Name}.");
        }

        public bool RemoveTimetableRegByID(int timetableRegID)
        {
            var reg = timetableRegs.FirstOrDefault(r => r.TimetableRegID == timetableRegID);
            if (reg != null)
            {
                timetableRegs.Remove(reg);
                Console.WriteLine($"Timetable registration with ID {timetableRegID} removed successfully.");
                return true;
            }

            Console.WriteLine($"Timetable registration with ID {timetableRegID} not found.");
            return false;
        }

        public void DisplayAllTimetableRegistrations()
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

        public void DisplayRegistrationsByVolunteer(Volunteer volunteer)
        {
            if (volunteer == null)
                throw new ArgumentNullException(nameof(volunteer));

            Console.WriteLine($"\nTimetable Registrations for Volunteer: {volunteer.Name}");
            bool hasRegistrations = false;

            foreach (var reg in timetableRegs.Where(r => r.Volunteer.UserId == volunteer.UserId))
            {
                Console.WriteLine(reg.ToString());
                hasRegistrations = true;
            }

            if (!hasRegistrations)
            {
                Console.WriteLine("No registrations found for this volunteer.");
            }
        }

        #endregion
    }
}
