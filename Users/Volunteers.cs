using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Users
{
    /// <summary>
    /// 
    /// </summary>
    public class Volunteers
    {
        private readonly List<Volunteer> volunteers = new List<Volunteer>();

        #region Methods
        public void AddVolunteer(Volunteer volunteer)
        {
            if (volunteer == null)
                throw new ArgumentNullException(nameof(volunteer), "Volunteer cannot be null.");

            if (volunteers.Any(v => v.UserId == volunteer.UserId))
                throw new ArgumentException($"A volunteer with ID {volunteer.UserId} already exists.");

            volunteers.Add(volunteer);
            Console.WriteLine($"Volunteer '{volunteer.Name}' added successfully.");
        }

        public bool UpdateVolunteer(int userId, string newName, string newAddress, int? newContactNumber, string newUsername, string newPassword, float newVolunteerHours)
        {
            var volunteer = volunteers.FirstOrDefault(v => v.UserId == userId);
            if (volunteer == null)
            {
                Console.WriteLine($"Volunteer with ID {userId} not found.");
                return false;
            }

            volunteer.Name = newName;
            volunteer.Address = newAddress;
            volunteer.ContactNumber = newContactNumber;
            volunteer.Username = newUsername;
            volunteer.Password = newPassword;
            volunteer.VolunteerHours = newVolunteerHours;

            Console.WriteLine($"Volunteer with ID {userId} updated successfully.");
            return true;
        }

        public bool InactivateVolunteer(int userId)
        {
            var volunteer = volunteers.FirstOrDefault(v => v.UserId == userId);
            if (volunteer == null)
            {
                Console.WriteLine($"Volunteer with ID {userId} not found.");
                return false;
            }

            volunteer.EndDate = DateTime.Now;
            Console.WriteLine($"Volunteer with ID {userId} has been inactivated.");
            return true;
        }

        public void DisplayAllVolunteers()
        {
            Console.WriteLine($"Total Number of Volunteers: {volunteers.Count}");
            foreach (var volunteer in volunteers)
            {
                Console.WriteLine($"ID: {volunteer.UserId}, Name: {volunteer.Name}, Hours: {volunteer.VolunteerHours}, End Date: { (volunteer.EndDate.HasValue ? volunteer.EndDate.Value.ToShortDateString() : "Active")}");
            }
        }
        #endregion

    }
}
