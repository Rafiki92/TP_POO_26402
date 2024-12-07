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
        private Volunteer registeredBy;

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

        public Volunteer RegisteredBy
        {
            get { return registeredBy; }
            set { registeredBy = value; }
        }


        #endregion

        #region Constructors
        public Donation(int donationID, DateTime donationDate, Donor donor, Volunteer registeredBy, string notes = "")
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
        public void UpdateStatus(DonationStatus newStatus)
        {
            this.Status = newStatus;
        }

        public override string ToString()
        {
            return $"Donation ID: {DonationID}, Donor: {Donor.Name}, Registered by: {RegisteredBy.GetName()}, Date: {DonationDate.ToShortDateString()}, Status: {Status}, Notes: {Notes}";
        }

        #endregion
    }
}

