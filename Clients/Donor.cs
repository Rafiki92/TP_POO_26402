using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Processes;

namespace ThriftShopApp.Clients
{
    /// <summary>
    /// Represents a Donor in the thrift shop.
    /// </summary>
    public class Donor
    {
        #region Attributes
        private int donorID;
        private string name;
        private int contactNumber;
        private DateTime startDate;
        private DateTime? endDate;


        // List to hold all donors
        private static List<Donor> donors = new List<Donor>();
        #endregion

        #region Properties
        public int DonorID
        {
            get { return donorID; }
            set { donorID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
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
        #endregion

        #region Constructors
        public Donor(int donorID, string name, int contactNumber, DateTime startDate, DateTime? endDate, Donation donation = null)
        {
            this.DonorID = donorID;
            this.Name = name;
            this.ContactNumber = contactNumber;
            this.StartDate = startDate;
            this.EndDate = endDate;
            
        }
        #endregion

        #region Methods
        public static void AddDonor(Donor donor)
        {
            donors.Add(donor);
        }

        public static void DisplayDonors()
        {
            Console.WriteLine("Donors:");
            foreach (var donor in donors)
            {
                Console.WriteLine($"ID: {donor.DonorID}, Name: {donor.Name}, Contact: {donor.ContactNumber}, Start Date: {donor.StartDate.ToShortDateString()}, End Date: {(donor.EndDate.HasValue ? donor.EndDate.Value.ToShortDateString() : "N/A")}");
            }
        }
        #endregion
    }
}
