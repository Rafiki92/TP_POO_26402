using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Clients;

namespace ThriftShopApp.Registers
{
    /// <summary>
    /// 
    /// </summary>
    public class VisitRegs
    {
        private readonly List<VisitReg> visitRegs = new List<VisitReg>();

        #region Methods
        public void AddVisit(VisitReg visit)
        {
            if (visit == null)
                throw new ArgumentNullException(nameof(visit));

            // Optional: Check for duplicate ID
            if (visitRegs.Any(v => v.VisitID == visit.VisitID))
                throw new ArgumentException($"A visit with ID {visit.VisitID} already exists.");

            visitRegs.Add(visit);
            Console.WriteLine($"Visit registration with ID {visit.VisitID} added successfully.");
        }

        public void DisplayAllVisits()
        {
            Console.WriteLine("\nList of All Visit Registrations:");
            if (visitRegs.Count == 0)
            {
                Console.WriteLine("No visit registrations found.");
                return;
            }

            foreach (var visit in visitRegs)
            {
                Console.WriteLine($"Visit ID: {visit.VisitID}, Date: {visit.Date.ToShortDateString()}, Beneficiary: {visit.Beneficiary.Name}, Registered by: {visit.Volunteer.GetUsername()}");
            }
        }

        public void DisplayVisitsByBeneficiary(Beneficiary beneficiary)
        {
            if (beneficiary == null)
                throw new ArgumentNullException(nameof(beneficiary));

            Console.WriteLine($"\nVisits for Beneficiary: {beneficiary.Name}");
            bool hasVisits = false;

            foreach (var visit in visitRegs.Where(v => v.Beneficiary.BenID == beneficiary.BenID))
            {
                Console.WriteLine($"Visit ID: {visit.VisitID}, Date: {visit.Date.ToShortDateString()}, Registered by: {visit.Volunteer.GetUsername()}");
                hasVisits = true;
            }

            if (!hasVisits)
            {
                Console.WriteLine("No visits found for this beneficiary.");
            }
        }

        public bool RemoveVisitByID(int visitID)
        {
            var visit = visitRegs.FirstOrDefault(v => v.VisitID == visitID);
            if (visit != null)
            {
                visitRegs.Remove(visit);
                Console.WriteLine($"Visit registration with ID {visitID} removed successfully.");
                return true;
            }

            Console.WriteLine($"Visit registration with ID {visitID} not found.");
            return false;
        }
        #endregion
    }
}
