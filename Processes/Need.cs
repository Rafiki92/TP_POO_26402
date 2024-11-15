using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Clients;
using ThriftShopApp.Products;
using ThriftShopApp.Registers;
using ThriftShopApp.Users;

namespace ThriftShopApp.Processes
{
    /// <summary>
    /// Represents a need of the beneficiary.
    /// </summary>
    public class Need
    {
        #region Attributes
        private int needID;
        private string name;
        private string category;
        private string description;
        private DateTime date;
        private NeedStatus status;
        private Beneficiary beneficiary;
        private User registeredBy;
        private List<NeedProductReg> productRequests = new List<NeedProductReg>();
        #endregion

        #region Properties
        public int NeedID
        {
            get { return needID; }
            set { needID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public NeedStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public Beneficiary Beneficiary
        {
            get { return beneficiary; }
            set { beneficiary = value; }
        }

        public User RegisteredBy
        {
            get { return registeredBy; }
            set { registeredBy = value; }
        }

        public enum NeedStatus
        {
            Pending,
            Fulfilled,
            InProgress
        }
        #endregion

        #region Constructors
        public Need(int needID, string name, string category, string description, DateTime date, NeedStatus status = NeedStatus.Pending, Beneficiary beneficiary = null, User registeredBy = null)
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
        public void AddProductRequest(int npid, Product product, int quantity)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            // Create a new NeedProductReg with an ID (npid)
            var request = new NeedProductReg(npid, this, product, registeredBy, quantity);
            productRequests.Add(request);

            // Check and update product availability
            if (product.Quantity >= quantity)
            {
                product.Quantity -= quantity; // Ensure the `set` accessor in `Product` is public
                Console.WriteLine($"Product {product.Name} (Qty: {quantity}) reserved for Need ID {NeedID}. New quantity available: {product.Quantity}");
            }
            else
            {
                Console.WriteLine($"Product {product.Name} cannot fulfill the requested quantity. Available: {product.Quantity}");
            }
        }

        public void DisplayNeedDetails()
        {
            Console.WriteLine($"Need ID: {NeedID}, Description: {Description}, Date: {Date.ToShortDateString()}, Status: {Status}");
            Console.WriteLine($"Beneficiary: {Beneficiary?.Name ?? "N/A"}, Registered By: {RegisteredBy?.GetName() ?? "N/A"}");
            Console.WriteLine("Product Requests:");
            foreach (var reg in productRequests)
            {
                Console.WriteLine(reg);
            }
        }

        public void UpdateStatus(NeedStatus newStatus)
        {
            this.Status = newStatus;
        }
        #endregion
    }
}
