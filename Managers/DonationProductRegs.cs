using System;
using System.Collections.Generic;
using System.Linq;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    /// <summary>
    /// Manages the registration of products donated to the thrift shop.
    /// Tracks the relationship between donations, products, and volunteers.
    /// </summary>
    public class DonationProductRegs
    {
        // List to store DonationProductReg objects, representing each product donation record.
        private readonly List<DonationProductReg> donationProductRegs = new List<DonationProductReg>();

        #region Methods

        /// <summary>
        /// Adds a new product donation to the registry.
        /// </summary>
        /// <param name="dpid">The unique ID of the donation-product registration.</param>
        /// <param name="donation">The donation associated with the product.</param>
        /// <param name="product">The product being donated.</param>
        /// <param name="volunteer">The volunteer facilitating the donation.</param>
        /// <param name="quantity">The quantity of the product being donated.</param>
        public void AddProductDonation(int dpid, Donation donation, Product product, Volunteer volunteer, int quantity)
        {
            // Ensure required objects are not null.
            if (donation == null) throw new ArgumentNullException(nameof(donation));
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (volunteer == null) throw new ArgumentNullException(nameof(volunteer));

            // Check if a record with the same DPID already exists.
            if (donationProductRegs.Any(r => r.DPID == dpid))
                throw new ArgumentException($"A DonationProductReg with ID {dpid} already exists.");

            // Create a new DonationProductReg object and add it to the registry.
            var donationReg = new DonationProductReg(dpid, donation, product, volunteer, quantity);
            donationProductRegs.Add(donationReg);

            // Update the product's quantity to reflect the donation.
            product.Quantity += quantity;

            // Inform the user about the successful addition.
            Console.WriteLine($"Product {product.Name} (Qty: {quantity}) added to Donation ID {donation.DonationID}. New quantity available: {product.Quantity}");
        }

        /// <summary>
        /// Displays all product donations associated with a specific donation.
        /// </summary>
        /// <param name="donation">The donation for which to display product donations.</param>
        public void DisplayProductDonationsForDonation(Donation donation)
        {
            // Ensure the donation object is not null.
            if (donation == null) throw new ArgumentNullException(nameof(donation));

            Console.WriteLine($"\nProduct Donations for Donation ID {donation.DonationID}:");

            // Retrieve all DonationProductReg objects linked to the specified donation.
            var regs = donationProductRegs.Where(r => r.Donation.DonationID == donation.DonationID).ToList();

            // Check if there are any associated product donations.
            if (!regs.Any())
            {
                Console.WriteLine("No product donations found for this donation.");
                return;
            }

            // Display each product donation's details.
            foreach (var reg in regs)
            {
                Console.WriteLine(reg.ToString());
            }
        }

        /// <summary>
        /// Removes a product donation registration by its unique ID.
        /// </summary>
        /// <param name="dpid">The unique ID of the donation-product registration to remove.</param>
        /// <returns>True if the registration was removed successfully; otherwise, false.</returns>
        public bool RemoveProductDonationByID(int dpid)
        {
            // Find the donation-product registration by ID.
            var reg = donationProductRegs.FirstOrDefault(r => r.DPID == dpid);

            if (reg != null)
            {
                // Remove the registration from the list.
                donationProductRegs.Remove(reg);

                // Inform the user about the successful removal.
                Console.WriteLine($"DonationProductReg with ID {dpid} removed successfully.");
                return true;
            }

            // Inform the user if the registration was not found.
            Console.WriteLine($"DonationProductReg with ID {dpid} not found.");
            return false;
        }

        /// <summary>
        /// Displays all product donation registrations.
        /// </summary>
        public void DisplayAllDonationProductRegs()
        {
            Console.WriteLine("\nAll Donation Product Registrations:");

            // Check if there are any product donation registrations.
            if (!donationProductRegs.Any())
            {
                Console.WriteLine("No donation product registrations found.");
                return;
            }

            // Display the details of each registration.
            foreach (var reg in donationProductRegs)
            {
                Console.WriteLine($"Donation ID: {reg.Donation.DonationID} - {reg}");
            }
        }

        #endregion
    }
}

