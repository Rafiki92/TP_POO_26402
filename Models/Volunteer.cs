using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a volunteer in the thrift shop application.
    /// Extends the <see cref="User"/> class and includes additional attributes specific to volunteers.
    /// </summary>
    public class Volunteer : User
    {
        #region Attributes
        // Total hours the volunteer has contributed.
        private float volunteerHours;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the total hours the volunteer has contributed.
        /// </summary>
        public float VolunteerHours
        {
            get { return volunteerHours; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Volunteer hours cannot be negative.");
                volunteerHours = value;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Volunteer"/> class.
        /// </summary>
        /// <param name="userId">The unique ID of the volunteer.</param>
        /// <param name="name">The name of the volunteer.</param>
        /// <param name="startDate">The start date of the volunteer's service.</param>
        /// <param name="endDate">The end date of the volunteer's service (if applicable).</param>
        /// <param name="contactNumber">The contact number of the volunteer.</param>
        /// <param name="address">The address of the volunteer.</param>
        /// <param name="username">The username for the volunteer's account.</param>
        /// <param name="password">The password for the volunteer's account.</param>
        /// <param name="volunteerHours">The total hours contributed by the volunteer.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown if <paramref name="volunteerHours"/> is negative.
        /// </exception>
        public Volunteer(int userId, string name, DateTime startDate, DateTime endDate, int contactNumber, string address, string username, string password, float volunteerHours)
            : base(userId, name, startDate, endDate, contactNumber, address, username, password)
        {
            this.VolunteerHours = volunteerHours;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the username of the volunteer with a prefix indicating their role.
        /// </summary>
        /// <returns>A string with the volunteer's username prefixed by "[Volunteer]".</returns>
        public override string GetUsername()
        {
            return $"[Volunteer] {base.GetUsername()}";
        }

        /// <summary>
        /// Returns the password of the volunteer with a prefix indicating their role.
        /// </summary>
        /// <returns>A string with the volunteer's password prefixed by "[Volunteer Password]".</returns>
        public override string GetPassword()
        {
            return $"[Volunteer Password] {base.GetPassword()}";
        }

        /// <summary>
        /// Returns the name of the volunteer with a prefix indicating their role.
        /// </summary>
        /// <returns>A string with the volunteer's name prefixed by "Volunteer:".</returns>
        public override string GetName()
        {
            return $"Volunteer: {base.GetName()}";
        }
        #endregion
    }
}
