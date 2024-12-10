using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ThriftShopApp.Models
{
    /// <summary>
    /// Base class User, baseline for other user types like Admin and Volunteer.
    /// </summary>
    public abstract class User
    {
        #region Attributes
        private int userId;
        private string name;
        private DateTime startDate;
        private DateTime? endDate;
        private int? contactNumber;
        private string address;
        protected string username;
        protected string password;
        #endregion

        #region Properties
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime? EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int? ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        #endregion

        #region Constructors
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
        public virtual string GetUsername()
        {
            return username;
        }

        public virtual string GetPassword()
        {
            return password;
        }
        public virtual string GetName()
        {
            return name;
        }
        #endregion
    }
}

