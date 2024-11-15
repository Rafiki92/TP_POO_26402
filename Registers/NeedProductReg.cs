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
 /// Represents the register of a Need Product, from a User.
 /// </summary>
    public class NeedProductReg
        {
            #region Attributes
            protected int npid;
            protected Need need;
            protected Product product;
            protected User user;
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

        public User User
        {
            get { return user; }
            set { user = value; }
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
        public NeedProductReg(int npid, Need need, Product product, User user, int quantityRequested)
            {
                this.NPID = npid;
                this.Need = need;
                this.Product = product;
                this.user = user;
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


