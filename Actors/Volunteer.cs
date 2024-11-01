using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShop.Actors
{
    /// <summary>
    /// 
    /// </summary>
    public class Volunteer : User
    {
        
        #region Attributes
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public DateTime JoinDate { get; set; }
        public double HoursWorked { get; set; }

        #endregion

        #region Constructors

        public Volunteer(int userId, string username, string password, string name, string contactInfo, DateTime joinDate, double hoursWorked)
        : base(userId, username, password, UserRole.Volunteer) // Call base constructor for User properties
        {
            Name = name;
            ContactInfo = contactInfo;
            JoinDate = joinDate;
            HoursWorked = hoursWorked;
        }
    }
        #endregion
    }

