using System;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents the registration of a product requested as part of a beneficiary's need in the thrift shop application.
    /// Tracks details such as the product, quantity requested, associated need, and volunteer who facilitated the process.
    /// </summary>
    public class NeedProductReg
    {
        #region Attributes
        // Unique identifier for the need product registration.
        protected int npid;

        // The need associated with this product registration.
        protected Need need;

        // The product being requested.
        protected Product product;

        // The volunteer who facilitated the process.
        protected Volunteer volunteer;

        // The quantity of the product being requested.
        protected int quantityRequested;

        // Indicates whether the requested need has been fulfilled.
        protected bool isFulfilled;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the unique ID of the need product registration.
        /// </summary>
        public int NPID
        {
            get { return npid; }
            set { npid = value; }
        }

        /// <summary>
        /// Gets or sets the need associated with this registration.
        /// </summary>
        public Need Need
        {
            get { return need; }
            set { need = value; }
        }

        /// <summary>
        /// Gets or sets the product being requested.
        /// </summary>
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        /// <summary>
        /// Gets or sets the volunteer who facilitated the registration process.
        /// </summary>
        public Volunteer Volunteer
        {
            get { return volunteer; }
            set { volunteer = value; }
        }

        /// <summary>
        /// Gets or sets the quantity of the product being requested.
        /// </summary>
        public int QuantityRequested
        {
            get { return quantityRequested; }
            set { quantityRequested = value; }
        }

        /// <summary>
        /// Gets whether the requested need is fulfilled based on product quantity.
        /// </summary>
        public bool IsFulfilled
        {
            get { return product.Quantity >= quantityRequested; }
            set { isFulfilled = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="NeedProductReg"/> class.
        /// </summary>
        /// <param name="npid">The unique ID of the need product registration.</param>
        /// <param name="need">The need associated with this product registration.</param>
        /// <param name="product">The product being requested.</param>
        /// <param name="volunteer">The volunteer who facilitated the process.</param>
        /// <param name="quantityRequested">The quantity of the product being requested.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="need"/>, <paramref name="product"/>, or <paramref name="volunteer"/> is null.
        /// </exception>
        public NeedProductReg(int npid, Need need, Product product, Volunteer volunteer, int quantityRequested)
        {
            this.NPID = npid;
            this.Need = need ?? throw new ArgumentNullException(nameof(need), "Need cannot be null.");
            this.Product = product ?? throw new ArgumentNullException(nameof(product), "Product cannot be null.");
            this.Volunteer = volunteer ?? throw new ArgumentNullException(nameof(volunteer), "Volunteer cannot be null.");
            this.QuantityRequested = quantityRequested > 0 ? quantityRequested : throw new ArgumentOutOfRangeException(nameof(quantityRequested), "Quantity requested must be greater than zero.");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Provides a string representation of the need product registration.
        /// </summary>
        /// <returns>A string containing the product name, quantity requested, and fulfillment status.</returns>
        public override string ToString()
        {
            return $"Product: {product.Name}, Quantity Requested: {quantityRequested}, Fulfilled: {IsFulfilled}";
        }
        #endregion
    }
}



