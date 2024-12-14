using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents the registration of a product donated as part of a donation in the thrift shop application.
    /// Tracks details such as the product, quantity donated, associated donation, and volunteer who facilitated the process.
    /// </summary>
    public class DonationProductReg
    {
        #region Attributes
        // Unique identifier for the donation product registration.
        protected int dpid;

        // The donation associated with this product registration.
        protected Donation donation;

        // The product that is being donated.
        protected Product product;

        // The volunteer who facilitated the donation process.
        protected Volunteer volunteer;

        // The quantity of the product that was donated.
        protected int quantityDonated;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the donation product registration.
        /// </summary>
        public int DPID
        {
            get { return dpid; }
            set { dpid = value; }
        }

        /// <summary>
        /// Gets or sets the donation associated with this registration.
        /// </summary>
        public Donation Donation
        {
            get { return donation; }
            set { donation = value; }
        }

        /// <summary>
        /// Gets or sets the product being donated.
        /// </summary>
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        /// <summary>
        /// Gets or sets the volunteer who facilitated this donation process.
        /// </summary>
        public Volunteer Volunteer
        {
            get { return volunteer; }
            set { volunteer = value; }
        }

        /// <summary>
        /// Gets or sets the quantity of the product that was donated.
        /// </summary>
        public int QuantityDonated
        {
            get { return quantityDonated; }
            set { quantityDonated = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="DonationProductReg"/> class.
        /// </summary>
        /// <param name="dpid">The unique ID of the donation product registration.</param>
        /// <param name="donation">The donation associated with this product registration.</param>
        /// <param name="product">The product being donated.</param>
        /// <param name="volunteer">The volunteer who facilitated the donation process.</param>
        /// <param name="quantityDonated">The quantity of the product that was donated.</param>
        public DonationProductReg(int dpid, Donation donation, Product product, Volunteer volunteer, int quantityDonated)
        {
            this.DPID = dpid;
            this.Donation = donation ?? throw new ArgumentNullException(nameof(donation), "Donation cannot be null.");
            this.Product = product ?? throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            this.Volunteer = volunteer ?? throw new ArgumentNullException(nameof(volunteer), "Volunteer cannot be null.");
            this.QuantityDonated = quantityDonated > 0 ? quantityDonated : throw new ArgumentOutOfRangeException(nameof(quantityDonated), "Quantity donated must be greater than zero.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns a string representation of the donation product registration.
        /// </summary>
        /// <returns>A string containing the product name and the quantity donated.</returns>
        public override string ToString()
        {
            return $"Product: {product.Name}, Quantity Donated: {quantityDonated}";
        }
        #endregion
    }
}

