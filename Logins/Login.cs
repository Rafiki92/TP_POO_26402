using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Users;

namespace ThriftShopApp.Logins
{
    /// <summary>
    /// Represents the login process of a user.
    /// </summary>
    public class Login
    {
        #region Attributes
        private int loginID;
        protected string username;
        protected string password;
        protected User user;
        #endregion

        #region Properties
        public int LoginID
        {
            get { return loginID; }
            set { loginID = value; }
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

        public User User
        {
            get { return user; }
            set { user = value; }
        }
        #endregion

        #region Constructors
        public Login(int loginID, string username, string password)
        {
            this.LoginID = loginID;
            this.Username = username;
            this.Password = password;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Checks if the provided username and password match the credentials of an admin or volunteer.
        /// </summary>
        /// <param name="user">The user attempting to log in.</param>
        /// <returns>True if credentials match, false otherwise.</returns>
        public bool Authenticate(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            return user.GetUsername() == this.Username && user.GetPassword() == this.Password;
        }
        #endregion
    }
}
