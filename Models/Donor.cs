using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a donor in the thrift shop application.
    /// Tracks information about the donor, including contact details and activity status.
    /// </summary>
    public class Donor
    {
        #region Attributes
        // Unique identifier for the donor.
        private int donorID;

        // Name of the donor.
        private string name;

        // Contact number of the donor.
        private int contactNumber;

        // The start date of the donor's participation.
        private DateTime startDate;

        // The end date of the donor's participation, if applicable.
        private DateTime? endDate;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the donor.
        /// </summary>
        public int DonorID
        {
            get { return donorID; }
            set { donorID = value; }
        }

        /// <summary>
        /// Gets or sets the name of the donor.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the contact number of the donor.
        /// </summary>
        public int ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        /// <summary>
        /// Gets or sets the start date of the donor's participation.
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        /// <summary>
        /// Gets or sets the end date of the donor's participation, if applicable.
        /// </summary>
        public DateTime? EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Donor"/> class.
        /// </summary>
        /// <param name="donorID">The unique ID of the donor.</param>
        /// <param name="name">The name of the donor.</param>
        /// <param name="contactNumber">The contact number of the donor.</param>
        /// <param name="startDate">The start date of the donor's participation.</param>
        /// <param name="endDate">The end date of the donor's participation, if applicable.</param>
        public Donor(int donorID, string name, int contactNumber, DateTime startDate, DateTime? endDate)
        {
            this.DonorID = donorID;
            this.Name = name;
            this.ContactNumber = contactNumber;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Determines if the donor is currently active based on the end date.
        /// </summary>
        /// <returns>True if the donor is active; otherwise, false.</returns>
        public bool IsActive()
        {
            return !EndDate.HasValue || EndDate.Value > DateTime.Now;
        }
        #endregion
    }
}

