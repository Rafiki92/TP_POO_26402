using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Processes;
using ThriftShopApp.Products;
using ThriftShopApp.Users;

namespace ThriftShopApp.Registers
{/// <summary>
 /// Represents the register of a Donation Product, from a User.
 /// </summary>
    public class DonationProductReg
    {
        #region Attributes
        protected int dpid;
        protected Donation donation;
        protected Product product;
        protected User user;
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

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public int QuantityDonated
        {
            get { return quantityDonated; }
            set { quantityDonated = value; }
        }
        #endregion

        #region Constructors
        public DonationProductReg(int dpid, Donation donation, Product product, User user, int quantityDonated)
        {
            this.DPID = dpid;
            this.Donation = donation;
            this.Product = product;
            this.user = user;
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
