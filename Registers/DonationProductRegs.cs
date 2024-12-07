using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Processes;
using ThriftShopApp.Products;
using ThriftShopApp.Users;

namespace ThriftShopApp.Registers
{
    /// <summary>
    /// 
    /// </summary>
    public class DonationProductRegs
    {

        private readonly List<DonationProductReg> donationProductRegs = new List<DonationProductReg>();

        #region Methods
        public void AddProductDonation(int dpid, Donation donation, Product product, Volunteer volunteer, int quantity)
        {
            if (donation == null) throw new ArgumentNullException(nameof(donation));
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (volunteer == null) throw new ArgumentNullException(nameof(volunteer));

            if (donationProductRegs.Any(r => r.DPID == dpid))
                throw new ArgumentException($"A DonationProductReg with ID {dpid} already exists.");

            var donationReg = new DonationProductReg(dpid, donation, product, volunteer, quantity);
            donationProductRegs.Add(donationReg);

            // Update product quantity
            product.Quantity += quantity;
            Console.WriteLine($"Product {product.Name} (Qty: {quantity}) added to Donation ID {donation.DonationID}. New quantity available: {product.Quantity}");
        }

        public void DisplayProductDonationsForDonation(Donation donation)
        {
            if (donation == null) throw new ArgumentNullException(nameof(donation));

            Console.WriteLine($"\nProduct Donations for Donation ID {donation.DonationID}:");
            var regs = donationProductRegs.Where(r => r.Donation.DonationID == donation.DonationID).ToList();
            if (!regs.Any())
            {
                Console.WriteLine("No product donations found for this donation.");
                return;
            }

            foreach (var reg in regs)
            {
                Console.WriteLine(reg.ToString());
            }
        }

        public bool RemoveProductDonationByID(int dpid)
        {
            var reg = donationProductRegs.FirstOrDefault(r => r.DPID == dpid);
            if (reg != null)
            {
                donationProductRegs.Remove(reg);
                Console.WriteLine($"DonationProductReg with ID {dpid} removed successfully.");
                return true;
            }

            Console.WriteLine($"DonationProductReg with ID {dpid} not found.");
            return false;
        }

        public void DisplayAllDonationProductRegs()
        {
            Console.WriteLine("\nAll Donation Product Registrations:");
            if (!donationProductRegs.Any())
            {
                Console.WriteLine("No donation product registrations found.");
                return;
            }

            foreach (var reg in donationProductRegs)
            {
                Console.WriteLine($"Donation ID: {reg.Donation.DonationID} - {reg}");
            }
        }
        #endregion
    }
}
