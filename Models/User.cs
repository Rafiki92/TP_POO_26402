using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a base class for users in the thrift shop application.
    /// Serves as a baseline for other user types like Admin and Volunteer.
    /// </summary>
    public abstract class User
    {
        #region Attributes
        // Unique identifier for the user.
        private int userId;

        // Name of the user.
        private string name;

        // The start date of the user's association with the thrift shop.
        private DateTime startDate;

        // The end date of the user's association, if applicable.
        private DateTime? endDate;

        // Contact number of the user (optional).
        private int? contactNumber;

        // Address of the user.
        private string address;

        // Username for the user account (protected for subclass access).
        protected string username;

        // Password for the user account (protected for subclass access).
        protected string password;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the user.
        /// </summary>
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the start date of the user's association.
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        /// <summary>
        /// Gets or sets the end date of the user's association, if applicable.
        /// </summary>
        public DateTime? EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        /// <summary>
        /// Gets or sets the contact number of the user.
        /// </summary>
        public int? ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        /// <summary>
        /// Gets or sets the address of the user.
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Gets or sets the username for the user account.
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// Gets or sets the password for the user account.
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="userId">The unique ID of the user.</param>
        /// <param name="name">The name of the user.</param>
        /// <param name="startDate">The start date of the user's association.</param>
        /// <param name="endDate">The end date of the user's association, if applicable.</param>
        /// <param name="contactNumber">The contact number of the user (optional).</param>
        /// <param name="address">The address of the user.</param>
        /// <param name="username">The username for the user account.</param>
        /// <param name="password">The password for the user account.</param>
        public User(int userId, string name, DateTime startDate, DateTime? endDate, int? contactNumber, string address, string username, string password)
        {
            this.UserId = userId;
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ContactNumber = contactNumber;
            this.Address = address;
            this.Username = username;
            this.Password = password;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the username for the user account.
        /// Can be overridden by subclasses for custom behavior.
        /// </summary>
        /// <returns>The username of the user.</returns>
        public virtual string GetUsername()
        {
            return username;
        }

        /// <summary>
        /// Gets the password for the user account.
        /// Can be overridden by subclasses for custom behavior.
        /// </summary>
        /// <returns>The password of the user.</returns>
        public virtual string GetPassword()
        {
            return password;
        }

        /// <summary>
        /// Gets the name of the user.
        /// Can be overridden by subclasses for custom behavior.
        /// </summary>
        /// <returns>The name of the user.</returns>
        public virtual string GetName()
        {
            return name;
        }
        #endregion
    }
}
