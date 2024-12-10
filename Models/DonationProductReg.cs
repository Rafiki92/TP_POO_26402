using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Models
{/// <summary>
 /// Represents the register of a Donation Product, from a Donor.
 /// </summary>
    public class DonationProductReg
    {
        #region Attributes
        protected int dpid;
        protected Donation donation;
        protected Product product;
        protected Volunteer volunteer;
        protected int quantityDonated;
        #endregion

        #region Properties
        public int DPID
        {
            get { return dpid; }
            set { dpid = value; }
        }
        public Donation Donation
        {
            get { return donation; }
            set { donation = value; }
        }

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public Volunteer Volunteer
        {
            get { return volunteer; }
            set { volunteer = value; }
        }

        public int QuantityDonated
        {
            get { return quantityDonated; }
            set { quantityDonated = value; }
        }
        #endregion

        #region Constructors
        public DonationProductReg(int dpid, Donation donation, Product product, Volunteer volunteer, int quantityDonated)
        {
            this.DPID = dpid;
            this.Donation = donation;
            this.Product = product;
            this.Volunteer = volunteer;
            this.QuantityDonated = quantityDonated;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Product: {product.Name}, Quantity Donated: {quantityDonated}";
        }
        #endregion
    }
}
