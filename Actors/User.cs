using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShop
{
/// <summary>
/// Super class User, baseline for another users
/// </summary>
    public abstract class User
    {
        #region Attributes
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }

        #endregion

        #region Methods
        // to check if it is admin or volunteer, only them can use the app
        public virtual bool IsAuthorized()
        {
            return Role == UserRole.Admin || Role == UserRole.Volunteer;
        }

        #endregion

        #region Constructors
        public User(int userId, string username, string password, UserRole role)
        {
            this.UserId = userId;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }
        #endregion

        #region Properties
        public enum UserRole
        {
            Admin,
            Volunteer,
            Donor,
            Beneficiary
        }
        #endregion

    }
}
