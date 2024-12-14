using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents an admin in the thrift shop application.
    /// Inherits common user attributes and methods from the <see cref="User"/> class.
    /// </summary>
    public class Admin : User
    {
        #region Attributes
        // The department that the admin belongs to.
        private string department;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the department of the admin.
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Admin"/> class.
        /// </summary>
        /// <param name="userId">The unique ID of the admin.</param>
        /// <param name="name">The name of the admin.</param>
        /// <param name="startDate">The start date of the admin's employment.</param>
        /// <param name="endDate">The end date of the admin's employment (nullable).</param>
        /// <param name="contactNumber">The contact number of the admin.</param>
        /// <param name="address">The address of the admin.</param>
        /// <param name="username">The admin's username.</param>
        /// <param name="password">The admin's password.</param>
        /// <param name="department">The department the admin belongs to.</param>
        public Admin(int userId, string name, DateTime startDate, DateTime? endDate, int contactNumber, string address, string username, string password, string department)
            : base(userId, name, startDate, endDate, contactNumber, address, username, password)
        {
            // Assign the department to the admin.
            this.Department = department;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the admin's username with a prefix indicating their role.
        /// </summary>
        /// <returns>The admin's username prefixed with "[Admin]".</returns>
        public override string GetUsername()
        {
            return $"[Admin] {base.GetUsername()}";
        }

        /// <summary>
        /// Gets the admin's password with a prefix indicating their role.
        /// </summary>
        /// <returns>The admin's password prefixed with "[Admin Password]".</returns>
        public override string GetPassword()
        {
            return $"[Admin Password] {base.GetPassword()}";
        }

        /// <summary>
        /// Gets the admin's name with a prefix indicating their role.
        /// </summary>
        /// <returns>The admin's name prefixed with "Admin:".</returns>
        public override string GetName()
        {
            return $"Admin: {base.GetName()}";
        }
        #endregion
    }
}

