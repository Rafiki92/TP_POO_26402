using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents the registration of a visit by a beneficiary in the thrift shop application.
    /// Tracks details such as the visit date, associated beneficiary, and the volunteer who registered the visit.
    /// </summary>
    public class VisitReg
    {
        #region Attributes
        // Unique identifier for the visit registration.
        private int visitID;

        // The date of the visit.
        private DateTime date;

        // The beneficiary associated with this visit.
        private Beneficiary beneficiary;

        // The volunteer who registered the visit.
        private Volunteer volunteer;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the visit registration.
        /// </summary>
        public int VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        /// <summary>
        /// Gets or sets the date of the visit.
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Gets or sets the beneficiary associated with this visit.
        /// </summary>
        public Beneficiary Beneficiary
        {
            get { return beneficiary; }
            set { beneficiary = value ?? throw new ArgumentNullException(nameof(beneficiary), "Beneficiary cannot be null."); }
        }

        /// <summary>
        /// Gets or sets the volunteer who registered the visit.
        /// </summary>
        public Volunteer Volunteer
        {
            get { return volunteer; }
            set { volunteer = value ?? throw new ArgumentNullException(nameof(volunteer), "Volunteer cannot be null."); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitReg"/> class.
        /// </summary>
        /// <param name="visitID">The unique ID of the visit registration.</param>
        /// <param name="date">The date of the visit.</param>
        /// <param name="beneficiary">The beneficiary associated with the visit.</param>
        /// <param name="volunteer">The volunteer who registered the visit.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="beneficiary"/> or <paramref name="volunteer"/> is null.
        /// </exception>
        public VisitReg(int visitID, DateTime date, Beneficiary beneficiary, Volunteer volunteer)
        {
            this.VisitID = visitID;
            this.Date = date;
            this.Beneficiary = beneficiary ?? throw new ArgumentNullException(nameof(beneficiary), "Beneficiary cannot be null.");
            this.Volunteer = volunteer ?? throw new ArgumentNullException(nameof(volunteer), "Volunteer cannot be null.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Provides a string representation of the visit registration.
        /// </summary>
        /// <returns>
        /// A string containing the visit details, including the visit ID, date, beneficiary's name, and the registering volunteer's username.
        /// </returns>
        public override string ToString()
        {
            return $"Visit ID: {VisitID}, Date: {Date.ToShortDateString()}, Beneficiary: {Beneficiary.Name}, Registered by: {Volunteer.GetUsername()}";
        }
        #endregion
    }
}
