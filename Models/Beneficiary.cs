using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a beneficiary in the thrift shop application.
    /// Stores information about individuals who receive support from the thrift shop.
    /// </summary>
    public class Beneficiary
    {
        #region Attributes
        // Unique identifier for the beneficiary.
        private int benID;

        // Full name of the beneficiary.
        private string name;

        // Contact phone number of the beneficiary.
        private int phoneNumber;

        // Reference for the beneficiary (e.g., referring person or organization).
        private string reference;

        // Number of family members associated with the beneficiary.
        private int familyNumber;

        // Indicates whether the beneficiary has children.
        private bool hasChildren;

        // Additional notes about the beneficiary.
        private string notes;

        // Nationality of the beneficiary.
        private string nationality;

        // The start date of the beneficiary's support period.
        private DateTime startDate;

        // The end date of the beneficiary's support period (nullable).
        private DateTime? endDate;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the beneficiary.
        /// </summary>
        public int BenID
        {
            get { return benID; }
            set { benID = value; }
        }

        /// <summary>
        /// Gets or sets the full name of the beneficiary.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the contact phone number of the beneficiary.
        /// </summary>
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Gets or sets the reference for the beneficiary.
        /// </summary>
        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        /// <summary>
        /// Gets or sets the number of family members associated with the beneficiary.
        /// </summary>
        public int FamilyNumber
        {
            get { return familyNumber; }
            set { familyNumber = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the beneficiary has children.
        /// </summary>
        public bool HasChildren
        {
            get { return hasChildren; }
            set { hasChildren = value; }
        }

        /// <summary>
        /// Gets or sets additional notes about the beneficiary.
        /// </summary>
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        /// <summary>
        /// Gets or sets the nationality of the beneficiary.
        /// </summary>
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        /// <summary>
        /// Gets or sets the start date of the beneficiary's support period.
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        /// <summary>
        /// Gets or sets the end date of the beneficiary's support period.
        /// </summary>
        public DateTime? EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Beneficiary"/> class.
        /// </summary>
        /// <param name="benID">The unique ID of the beneficiary.</param>
        /// <param name="name">The name of the beneficiary.</param>
        /// <param name="phoneNumber">The phone number of the beneficiary.</param>
        /// <param name="reference">The reference for the beneficiary.</param>
        /// <param name="familyNumber">The number of family members associated with the beneficiary.</param>
        /// <param name="hasChildren">Indicates whether the beneficiary has children.</param>
        /// <param name="notes">Additional notes about the beneficiary.</param>
        /// <param name="nationality">The nationality of the beneficiary.</param>
        /// <param name="startDate">The start date of the beneficiary's support period.</param>
        /// <param name="endDate">The end date of the beneficiary's support period, if applicable.</param>
        public Beneficiary(int benID, string name, int phoneNumber, string reference, int familyNumber, bool hasChildren, string notes, string nationality, DateTime startDate, DateTime? endDate)
        {
            this.BenID = benID;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Reference = reference;
            this.FamilyNumber = familyNumber;
            this.HasChildren = hasChildren;
            this.Notes = notes;
            this.Nationality = nationality;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Determines if the beneficiary is currently active based on the end date.
        /// </summary>
        /// <returns>True if the beneficiary is active; otherwise, false.</returns>
        public bool IsActive()
        {
            return !EndDate.HasValue || (EndDate.HasValue && EndDate.Value > DateTime.Now);
        }
        #endregion
    }
}
