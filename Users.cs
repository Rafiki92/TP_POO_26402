using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShop
{
    public class User
    {
        #region SUPERCLASS
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        #endregion

    }

    #region Administrator
    public class Administrator : User
    {
        public int IdA { get; set; }

    }

    #endregion

    #region Volunteer
    public class Volunteer : User
    {
        public int IdV { get; set; }
        public int HoursWorked { get; set; }

    }

    #endregion

    #region Donor
    public class Donor : User
    {
        public int IdD { get; set; }
        public int TotalDonations { get; set; }

    }

    #endregion

    #region Beneficiary
    public class Beneficiary : User
    {
        public int IdB { get; set; }
        public int ItemsReceived { get; set; }

    }

    #endregion
}
