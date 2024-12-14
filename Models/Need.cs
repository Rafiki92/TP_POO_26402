using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a specific need of a beneficiary in the thrift shop application.
    /// Tracks details about the need, including its status, associated beneficiary, and the volunteer who registered it.
    /// </summary>
    public class Need
    {
        #region Attributes
        // Unique identifier for the need.
        private int needID;

        // Name or title of the need.
        private string name;

        // Category of the need (e.g., "Clothing", "Objects").
        private string category;

        // Detailed description of the need.
        private string description;

        // Date the need was registered or identified.
        private DateTime date;

        // Current status of the need (e.g., Pending, Fulfilled).
        private NeedStatus status;

        // The beneficiary associated with the need.
        private Beneficiary beneficiary;

        // The volunteer who registered the need.
        private Volunteer registeredBy;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the need.
        /// </summary>
        public int NeedID
        {
            get { return needID; }
            set { needID = value; }
        }

        /// <summary>
        /// Gets or sets the name or title of the need.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the category of the need.
        /// </summary>
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Gets or sets the description of the need.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Gets or sets the date the need was registered or identified.
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Gets or sets the current status of the need.
        /// </summary>
        public NeedStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        /// <summary>
        /// Gets or sets the beneficiary associated with the need.
        /// </summary>
        public Beneficiary Beneficiary
        {
            get { return beneficiary; }
            set { beneficiary = value; }
        }

        /// <summary>
        /// Gets or sets the volunteer who registered the need.
        /// </summary>
        public Volunteer RegisteredBy
        {
            get { return registeredBy; }
            set { registeredBy = value; }
        }

        /// <summary>
        /// Enum representing the possible statuses of a need.
        /// </summary>
        public enum NeedStatus
        {
            Pending,     // The need is awaiting fulfillment.
            Fulfilled,   // The need has been fulfilled.
            InProgress   // The need is currently being addressed.
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Need"/> class.
        /// </summary>
        /// <param name="needID">The unique ID of the need.</param>
        /// <param name="name">The name or title of the need.</param>
        /// <param name="category">The category of the need.</param>
        /// <param name="description">The description of the need.</param>
        /// <param name="date">The date the need was registered or identified.</param>
        /// <param name="status">The initial status of the need (default is Pending).</param>
        /// <param name="beneficiary">The beneficiary associated with the need (optional).</param>
        /// <param name="registeredBy">The volunteer who registered the need (optional).</param>
        public Need(int needID, string name, string category, string description, DateTime date, NeedStatus status = NeedStatus.Pending, Beneficiary beneficiary = null, Volunteer registeredBy = null)
        {
            this.NeedID = needID;
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Date = date;
            this.Status = status;
            this.Beneficiary = beneficiary;
            this.RegisteredBy = registeredBy;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the status of the need.
        /// </summary>
        /// <param name="newStatus">The new status to set for the need.</param>
        public void UpdateStatus(NeedStatus newStatus)
        {
            this.Status = newStatus;
        }

        /// <summary>
        /// Provides a string representation of the need object.
        /// </summary>
        /// <returns>A string containing the need's details.</returns>
        public override string ToString()
        {
            return $"Need ID: {NeedID}, Name: {Name}, Category: {Category}, Description: {Description}, Date: {Date.ToShortDateString()}, Status: {Status}, Beneficiary: {Beneficiary?.Name ?? "N/A"}, Registered By: {RegisteredBy?.GetName() ?? "N/A"}";
        }
        #endregion
    }
}

