using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Clients
{
    /// <summary>
    /// 
    /// </summary>
    public class Donors
    {
        private readonly List<Donor> donors = new List<Donor>();

        #region Methods
        public void AddDonor(Donor donor)
        {
            if (donor == null)
                throw new ArgumentNullException(nameof(donor), "Donor cannot be null.");

            // Optionally, check for duplicate DonorID
            if (donors.Any(d => d.DonorID == donor.DonorID))
                throw new ArgumentException($"A donor with ID {donor.DonorID} already exists.");

            donors.Add(donor);
        }

        public bool UpdateDonor(int donorID, string newName, int newContactNumber, DateTime newStartDate, DateTime? newEndDate)
        {
            var donor = donors.FirstOrDefault(d => d.DonorID == donorID);
            if (donor == null) return false;

            donor.Name = newName;
            donor.ContactNumber = newContactNumber;
            donor.StartDate = newStartDate;
            donor.EndDate = newEndDate;
            return true;
        }

        public bool InactivateDonor(int donorID)
        {
            var donor = donors.FirstOrDefault(d => d.DonorID == donorID);
            if (donor == null) return false;

            donor.EndDate = DateTime.Now;
            return true;
        }

        public void DisplayDonors()
        {
            Console.WriteLine($"Total Number of Donors: {donors.Count}");
            foreach (var donor in donors)
            {
                string activeStatus = donor.IsActive() ? "Active" : "Inactive";
                Console.WriteLine($"ID: {donor.DonorID}, Name: {donor.Name}, Contact: {donor.ContactNumber}, Status: {activeStatus}");
            }
        }
        #endregion
    }
}
