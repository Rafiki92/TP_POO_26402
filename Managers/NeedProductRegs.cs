using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages the registration of products needed for specific needs in the thrift shop application.
    /// Tracks the relationship between needs, products, and volunteers.
    /// </summary>
    public class NeedProductRegs
    {
        // List to store NeedProductReg objects, representing each product request for a need.
        private readonly List<NeedProductReg> needProductRegs = new List<NeedProductReg>();

        #region Methods

        /// <summary>
        /// Adds a new product request to fulfill a specific need.
        /// </summary>
        /// <param name="npid">The unique ID of the need-product registration.</param>
        /// <param name="need">The need associated with the product request.</param>
        /// <param name="product">The product being requested.</param>
        /// <param name="volunteer">The volunteer facilitating the request.</param>
        /// <param name="quantity">The quantity of the product being requested.</param>
        public void AddProductRequest(int npid, Need need, Product product, Volunteer volunteer, int quantity)
        {
            // Ensure required objects are not null.
            if (need == null) throw new ArgumentNullException(nameof(need));
            if (product == null) throw new ArgumentNullException(nameof(product));

            // Check if a record with the same NPID already exists.
            if (needProductRegs.Any(r => r.NPID == npid))
                throw new ArgumentException($"A NeedProductReg with ID {npid} already exists.");

            // Create a new NeedProductReg object and add it to the registry.
            var request = new NeedProductReg(npid, need, product, volunteer, quantity);
            needProductRegs.Add(request);

            // Check if the product has enough quantity to fulfill the need.
            if (product.Quantity >= quantity)
            {
                // Deduct the requested quantity from the product's availability.
                product.Quantity -= quantity;

                // Inform the user that the request was successfully fulfilled.
                Console.WriteLine($"Product {product.Name} (Qty: {quantity}) reserved for Need ID {need.NeedID}. New quantity available: {product.Quantity}");
            }
            else
            {
                // Inform the user if the product cannot fulfill the requested quantity.
                Console.WriteLine($"Product {product.Name} cannot fulfill the requested quantity. Available: {product.Quantity}");
            }
        }

        /// <summary>
        /// Removes a product request by its unique ID.
        /// </summary>
        /// <param name="npid">The unique ID of the need-product registration to remove.</param>
        /// <returns>True if the registration was removed successfully; otherwise, false.</returns>
        public bool RemoveProductRequestByID(int npid)
        {
            // Find the need-product registration by ID.
            var reg = needProductRegs.FirstOrDefault(r => r.NPID == npid);

            if (reg != null)
            {
                // Remove the registration from the list.
                needProductRegs.Remove(reg);

                // Inform the user about the successful removal.
                Console.WriteLine($"NeedProductReg with ID {npid} removed successfully.");
                return true;
            }

            // Inform the user if the registration was not found.
            Console.WriteLine($"NeedProductReg with ID {npid} not found.");
            return false;
        }

        /// <summary>
        /// Retrieves a product request by its unique ID.
        /// </summary>
        /// <param name="npid">The ID of the need-product registration to retrieve.</param>
        /// <returns>The <see cref="NeedProductReg"/> object if found; otherwise, null.</returns>
        public NeedProductReg GetRequestByID(int npid)
        {
            // Find and return the need-product registration with the specified ID.
            return needProductRegs.FirstOrDefault(r => r.NPID == npid);
        }

        /// <summary>
        /// Displays all product requests, including their associated need and product details.
        /// </summary>
        public void DisplayAllRequests()
        {
            Console.WriteLine("\nAll Need Product Requests:");

            // Check if there are any product requests.
            if (!needProductRegs.Any())
            {
                Console.WriteLine("No product requests found.");
                return;
            }

            // Loop through and display each product request's details.
            foreach (var reg in needProductRegs)
            {
                Console.WriteLine($"Need ID: {reg.Need.NeedID} - {reg}");
            }
        }

        #endregion
    }
}

