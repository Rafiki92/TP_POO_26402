using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShop.Actors
{
    /// <summary>
    /// Represents a volunteer in the thrift shop.
    /// </summary>
    public class Volunteer : User
    {
        #region Attributes
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public DateTime JoinDate { get; set; }
        public double HoursWorked { get; set; }

        private static List<Volunteer> volunteers = new List<Volunteer>();
        #endregion

        #region Constructors
        public Volunteer(int userId, string username, string password, string name, string contactInfo, DateTime joinDate, double hoursWorked)
            : base(userId, username, password, UserRole.Volunteer) // Call base constructor for User properties
        {
            this.Name = name;
            this.ContactInfo = contactInfo;
            this.JoinDate = joinDate;
            this.HoursWorked = hoursWorked;
        }
        #endregion

        #region Methods
        public static void AddVolunteer(Volunteer volunteer)
        {
            volunteers.Add(volunteer);
        }
        public static void DisplayVolunteers()
        {
            // Loop through each volunteer in the volunteers list
            foreach (var volunteer in volunteers)
            {
                // Display the volunteer's details
                Console.WriteLine($"ID: {volunteer.UserId}, Name: {volunteer.Name}, Contact: {volunteer.ContactInfo}, Join Date: {volunteer.JoinDate.ToShortDateString()}, Hours Worked: {volunteer.HoursWorked}");
            }
        }
    }

    #endregion
}

