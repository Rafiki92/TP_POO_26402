using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShop.Actors
{
    /// <summary>
    /// 
    /// </summary>
    public class Donor
    {
        #region Attributes
        public int DonorId { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Nationality { get; set; }

        private static List<Donor> donors = new List<Donor>();

        #endregion

        #region Constructors
        public Donor(int donorId, string name, string contactInfo, string nationality)
        {
            this.DonorId = donorId;
            this.Name = name;
            this.ContactInfo = contactInfo;
            this.Nationality = nationality;
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
            // Loop through each donor in the donors list
            foreach (var donor in donors)
            {
                // Display the donor's details
                Console.WriteLine($"ID: {donor.DonorId}, Name: {donor.Name}, Contact: {donor.ContactInfo}, Nationality: {donor.Nationality}");
            }
        }

        #endregion
    }
}
