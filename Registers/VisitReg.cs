using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Clients;
using ThriftShopApp.Users;

namespace ThriftShopApp.Registers
{/// <summary>
 /// Represents the register of a visit, from the beneficiary.
 /// </summary>
    public class VisitReg
    {
        #region Attributes
        private int visitID;
        private DateTime date;
        private Beneficiary beneficiary;
        private Volunteer volunteer;

        #endregion

        #region Properties
        public int VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Beneficiary Beneficiary
        {
            get { return beneficiary; }
            set { beneficiary = value; }
        }

        public Volunteer Volunteer
        {
            get { return volunteer; }
            set { volunteer = value; }
        }

        #endregion

        #region Constructors
        // Parameterized constructor
        public VisitReg(int visitID, DateTime date, Beneficiary beneficiary, Volunteer volunteer)
        {
            this.VisitID = visitID;
            this.Date = date;
            this.Beneficiary = beneficiary;
            this.Volunteer = volunteer;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Visit ID: {VisitID}, Date: {Date.ToShortDateString()}, Beneficiary: {Beneficiary.Name}, Registered by: {Volunteer.GetUsername()}";
        }
        #endregion
    }
}