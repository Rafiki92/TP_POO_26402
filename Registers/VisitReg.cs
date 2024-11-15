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
        private User user;

        private static List<VisitReg> visitRegs = new List<VisitReg>();
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

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public static List<VisitReg> VisitRegs => visitRegs;

        #endregion

        #region Constructors
        // Parameterized constructor
        public VisitReg(int visitID, DateTime date, Beneficiary beneficiary, User user)
        {
            this.VisitID = visitID;
            this.Date = date;
            this.Beneficiary = beneficiary;
            this.User = user;
        }

        #endregion

        #region Methods
        public static void AddVisit(VisitReg visit)
        {
            if (visit == null)
                throw new ArgumentNullException(nameof(visit));
            visitRegs.Add(visit);
            Console.WriteLine($"Visit registration with ID {visit.VisitID} added successfully.");
        }

        public static void DisplayAllVisits()
        {
            Console.WriteLine("\nList of All Visit Registrations:");
            foreach (var visit in visitRegs)
            {
                Console.WriteLine($"Visit ID: {visit.VisitID}, Date: {visit.Date.ToShortDateString()}, Beneficiary: {visit.Beneficiary.Name}, Registered by: {visit.User.GetUsername()}");
            }
        }


        public static void DisplayVisitsByBeneficiary(Beneficiary beneficiary)
        {
            if (beneficiary == null)
                throw new ArgumentNullException(nameof(beneficiary));

            Console.WriteLine($"\nVisits for Beneficiary: {beneficiary.Name}");
            foreach (var visit in visitRegs)
            {
                if (visit.Beneficiary.BenID == beneficiary.BenID)
                {
                    Console.WriteLine($"Visit ID: {visit.VisitID}, Date: {visit.Date.ToShortDateString()}, Registered by: {visit.User.GetUsername()}");
                }
            }
        }

        public override string ToString()
        {
            return $"Visit ID: {visitID}, Date: {date.ToShortDateString()}, Beneficiary: {beneficiary.Name}, Registered by: {user.GetUsername()}";
        }
        #endregion
    }
}