using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Registers;

namespace ThriftShopApp.Users
{
    /// <summary>
    /// Represents a volunteer in the thrift shop.
    /// </summary>
    public class Volunteer : User
    {
            #region Attributes
            private float volunteerHours;
            

            private static List<Volunteer> volunteers = new List<Volunteer>();
            #endregion

            #region Properties
            public float VolunteerHours
            {
                get { return volunteerHours; }
                set { volunteerHours = value; }
            }
        #endregion

        #region Constructors
        public Volunteer(int userId, string name, DateTime startDate, DateTime endDate, int contactNumber, string address, string username, string password, float volunteerHours)
            : base(userId, name, startDate, endDate, contactNumber, address, username, password)
        {
            this.VolunteerHours = volunteerHours;
        }
        #endregion

        #region Methods
        public static void AddVolunteer(Volunteer volunteer)
        {
            if (volunteer != null)
            {
                volunteers.Add(volunteer);
                Console.WriteLine($"Volunteer {volunteer.Name} added successfully.");
            }
        }

        public static void DisplayVolunteers()
        {
            foreach (var volunteer in volunteers)
            {
                Console.WriteLine($"ID: {volunteer.UserId}, Name: {volunteer.Name}, Contact Number: {volunteer.ContactNumber}, Start Date: {volunteer.StartDate.ToShortDateString()}, End Date: {(volunteer.EndDate.HasValue ? volunteer.EndDate.Value.ToShortDateString() : "N/A")}, Hours Worked: {volunteer.VolunteerHours}");
            }
        }
#endregion
    }
    }