using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Clients;
using ThriftShopApp.Products;
using ThriftShopApp.Registers;
using ThriftShopApp.Users;

namespace ThriftShopApp.Processes
{
    /// <summary>
    /// Represents a donation.
    /// </summary>
    public class Donation
    {
        #region Attributes
        private int donationID;
        private DateTime donationDate;
        private string notes;
        private DonationStatus status;
        private Donor donor;
        private User registeredBy;
        private List<DonationProductReg> productDonations = new List<DonationProductReg>();

        public enum DonationStatus
        {
            Pending,
            Received,
            Distributed,
            Cancelled
        }
        #endregion

        #region Properties
        public int DonationID
        {
            get { return donationID; }
            set { donationID = value; }
        }

        public DateTime DonationDate
        {
            get { return donationDate; }
            set { donationDate = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public DonationStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public Donor Donor
        {
            get { return donor; }
            set { donor = value; }
        }

        public User RegisteredBy
        {
            get { return registeredBy; }
            set { registeredBy = value; }
        }


        #endregion

        #region Constructors
        public Donation(int donationID, DateTime donationDate, Donor donor, User registeredBy, string notes = "")
        {
            this.DonationID = donationID;
            this.DonationDate = donationDate;
            this.Donor = donor ?? throw new ArgumentNullException(nameof(donor));
            this.RegisteredBy = registeredBy ?? throw new ArgumentNullException(nameof(registeredBy));
            this.Notes = notes;
            this.Status = DonationStatus.Pending; // Default status when a donation is created
        }
        #endregion

        #region Methods
        public void AddProductDonation(int dpid, Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            // Create a new DonationProductReg with the provided dpid
            var donationReg = new DonationProductReg(dpid, this, product, registeredBy, quantity);
            productDonations.Add(donationReg);

            // Update product availability
            product.Quantity += quantity; // Ensure the `set` accessor in `Product` is public
            Console.WriteLine($"Product {product.Name} (Qty: {quantity}) added to Donation ID {DonationID}. New quantity available: {product.Quantity}");
        }

        public void DisplayDonationDetails()
        {
            Console.WriteLine($"\nDonation ID: {DonationID}, Donor: {Donor.Name}, Registered by: {RegisteredBy.GetName()}, Date: {DonationDate.ToShortDateString()}, Status: {Status}");
            foreach (var reg in productDonations)
            {
                Console.WriteLine(reg.ToString());
            }
        }

        public void UpdateStatus(DonationStatus newStatus)
        {
            this.Status = newStatus;
        }
        #endregion
    }
}

