using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Processes
{
    /// <summary>
    /// 
    /// </summary>
    public class Donations
    {
        private readonly List<Donation> donations = new List<Donation>();

        #region Methods
        public void AddDonation(Donation donation)
        {
            if (donation == null)
                throw new ArgumentNullException(nameof(donation));

            if (donations.Any(d => d.DonationID == donation.DonationID))
                throw new ArgumentException($"A donation with ID {donation.DonationID} already exists.");

            donations.Add(donation);
            Console.WriteLine($"Donation with ID {donation.DonationID} added successfully.");
        }

        public bool RemoveDonationByID(int donationID)
        {
            var donation = donations.FirstOrDefault(d => d.DonationID == donationID);
            if (donation != null)
            {
                donations.Remove(donation);
                Console.WriteLine($"Donation with ID {donationID} removed successfully.");
                return true;
            }

            Console.WriteLine($"Donation with ID {donationID} not found.");
            return false;
        }

        public Donation GetDonationByID(int donationID)
        {
            return donations.FirstOrDefault(d => d.DonationID == donationID);
        }

        public void DisplayAllDonations()
        {
            Console.WriteLine("\nAll Donations:");
            if (!donations.Any())
            {
                Console.WriteLine("No donations found.");
                return;
            }

            foreach (var donation in donations)
            {
                Console.WriteLine(donation.ToString());
            }
        }
        #endregion
    }
}
