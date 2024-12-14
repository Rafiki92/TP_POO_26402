using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a donation in the thrift shop application.
    /// Tracks donation details, including the donor, the volunteer who registered it, and its current status.
    /// </summary>
    public class Donation
    {
        #region Attributes
        // Unique identifier for the donation.
        private int donationID;

        // Date the donation was made or registered.
        private DateTime donationDate;

        // Additional notes about the donation.
        private string notes;

        // Current status of the donation.
        private DonationStatus status;

        // Donor who made the donation.
        private Donor donor;

        // Volunteer who registered the donation.
        private Volunteer registeredBy;

        /// <summary>
        /// Enum representing the possible statuses of a donation.
        /// </summary>
        public enum DonationStatus
        {
            Pending,       // Donation is pending and has not yet been received.
            Received,      // Donation has been received.
            Distributed,   // Donation has been distributed to beneficiaries.
            Cancelled      // Donation was cancelled.
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the donation.
        /// </summary>
        public int DonationID
        {
            get { return donationID; }
            set { donationID = value; }
        }

        /// <summary>
        /// Gets or sets the date the donation was made or registered.
        /// </summary>
        public DateTime DonationDate
        {
            get { return donationDate; }
            set { donationDate = value; }
        }

        /// <summary>
        /// Gets or sets additional notes about the donation.
        /// </summary>
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        /// <summary>
        /// Gets or sets the current status of the donation.
        /// </summary>
        public DonationStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// Gets or sets the donor who made the donation.
        /// </summary>
        public Donor Donor
        {
            get { return donor; }
            set { donor = value; }
        }

        /// <summary>
        /// Gets or sets the volunteer who registered the donation.
        /// </summary>
        public Volunteer RegisteredBy
        {
            get { return registeredBy; }
            set { registeredBy = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Donation"/> class.
        /// </summary>
        /// <param name="donationID">The unique ID of the donation.</param>
        /// <param name="donationDate">The date the donation was made or registered.</param>
        /// <param name="donor">The donor who made the donation.</param>
        /// <param name="registeredBy">The volunteer who registered the donation.</param>
        /// <param name="notes">Optional notes about the donation.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="donor"/> or <paramref name="registeredBy"/> is null.</exception>
        public Donation(int donationID, DateTime donationDate, Donor donor, Volunteer registeredBy, string notes = "")
        {
            this.DonationID = donationID;
            this.DonationDate = donationDate;
            this.Donor = donor ?? throw new ArgumentNullException(nameof(donor));
            this.RegisteredBy = registeredBy ?? throw new ArgumentNullException(nameof(registeredBy));
            this.Notes = notes;
            this.Status = DonationStatus.Pending; // Default status when a donation is created.
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the status of the donation.
        /// </summary>
        /// <param name="newStatus">The new status to set for the donation.</param>
        public void UpdateStatus(DonationStatus newStatus)
        {
            this.Status = newStatus;
        }

        /// <summary>
        /// Provides a string representation of the donation object.
        /// </summary>
        /// <returns>A string containing the donation details.</returns>
        public override string ToString()
        {
            return $"Donation ID: {DonationID}, Donor: {Donor.Name}, Registered by: {RegisteredBy.GetName()}, Date: {DonationDate.ToShortDateString()}, Status: {Status}, Notes: {Notes}";
        }
        #endregion
    }
}


