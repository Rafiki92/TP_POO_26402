using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a volunteer in the thrift shop.
    /// </summary>
    public class Volunteer : User
    {
            #region Attributes
            private float volunteerHours;
            
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
        public override string GetUsername()
        {
            return $"[Volunteer] {base.GetUsername()}";
        }

        public override string GetPassword()
        {
            return $"[Volunteer Password] {base.GetPassword()}";
        }

        public override string GetName()
        {
            return $"Volunteer: {base.GetName()}";
        }
        #endregion
    }
    }