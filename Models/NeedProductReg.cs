using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Models
{/// <summary>
 /// Represents the register of a Need Product, from a Beneficiary.
 /// </summary>
    public class NeedProductReg
        {
            #region Attributes
            protected int npid;
            protected Need need;
            protected Product product;
            protected Volunteer volunteer;
            protected int quantityRequested;
            protected bool isFulfilled;
        #endregion

        #region Properties
        public int NPID
        {
            get { return npid; }
            set { npid = value; }
        }
        public Need Need
        {
            get { return need; }
            set { need = value; }
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

        public int QuantityRequested
        {
            get { return quantityRequested; }
            set { quantityRequested = value; }
        }

        public bool IsFulfilled
        {
            get { return product.Quantity >= quantityRequested; }
            set { isFulfilled = value; }
        }
        #endregion

        #region Constructors
        public NeedProductReg(int npid, Need need, Product product, Volunteer volunteer, int quantityRequested)
            {
                this.NPID = npid;
                this.Need = need;
                this.Product = product;
                this.Volunteer = volunteer;
                this.QuantityRequested = quantityRequested;
            }
            #endregion

            #region Methods
            public override string ToString()
            {
                return $"Product: {product.Name}, Quantity Requested: {quantityRequested}, Fulfilled: {IsFulfilled}";
            }
            #endregion
        }
    }


