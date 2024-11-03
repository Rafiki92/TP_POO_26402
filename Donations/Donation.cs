using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Actors;
using ThriftShop.Products;

namespace ThriftShop.Donations
{
    /// <summary>
    /// 
    /// </summary>

    public class Donation
    {
        #region Attributes
        public int DonationID { get; set; }
        public DateTime DonationDate { get; set; }
        public Donor Donor { get; set; }
        public DonationStatus Status { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        private static List<Donation> donations = new List<Donation>();
        #endregion

        #region Properties
        public enum DonationStatus
        {
            Pending,
            Received,
            Distributed,
            Cancelled
        }
        #endregion

        #region Constructors
        public Donation(int donationID, DateTime donationDate, Donor donor, DonationStatus status)
        {
            this.DonationID = donationID;
            this.DonationDate = donationDate;
            this.Donor = donor;
            this.Status = DonationStatus.Pending;
        }
        #endregion

        #region Methods
        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            Products.Add(product);
        }

        public static void AddDonation(Donation donation)
        {
            if (donation == null)
                throw new ArgumentNullException(nameof(donation));
            donations.Add(donation);
        }

        public void DisplayDonationDetails()
        {
            Console.WriteLine($"Donation ID: {DonationID}, Date: {DonationDate.ToShortDateString()}, Donor: {Donor.Name}, Status: {Status}");
            Console.WriteLine("Products in this donation:");
            foreach (var product in Products)
            {
                Console.WriteLine($" Product ID: {product.ProductId}, Name: {product.Name}, Quantity: {product.Quantity}, Category: {product.Category}, Condition: {product.Condition}");
            }
        }

        public static void DisplayAllDonations()
        {
            Console.WriteLine("Donations:");
            foreach (var donation in donations)
            {
                donation.DisplayDonationDetails();
                Console.WriteLine();
            }
        }

        public void UpdateStatus(DonationStatus newStatus)
        {
            this.Status = newStatus;
        }
        #endregion
    }
}
