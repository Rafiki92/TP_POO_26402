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
    public class NeedProductRegs
    {
        private readonly List<NeedProductReg> needProductRegs = new List<NeedProductReg>();

        #region Methods
        public void AddProductRequest(int npid, Need need, Product product, Volunteer volunteer, int quantity)
        {
            if (need == null) throw new ArgumentNullException(nameof(need));
            if (product == null) throw new ArgumentNullException(nameof(product));

            // Check duplicates if needed
            if (needProductRegs.Any(r => r.NPID == npid))
                throw new ArgumentException($"A NeedProductReg with ID {npid} already exists.");

            var request = new NeedProductReg(npid, need, product, volunteer, quantity);
            needProductRegs.Add(request);

            // Update product availability
            if (product.Quantity >= quantity)
            {
                product.Quantity -= quantity;
                Console.WriteLine($"Product {product.Name} (Qty: {quantity}) reserved for Need ID {need.NeedID}. New quantity available: {product.Quantity}");
            }
            else
            {
                Console.WriteLine($"Product {product.Name} cannot fulfill the requested quantity. Available: {product.Quantity}");
            }
        }

        public bool RemoveProductRequestByID(int npid)
        {
            var reg = needProductRegs.FirstOrDefault(r => r.NPID == npid);
            if (reg != null)
            {
                needProductRegs.Remove(reg);
                Console.WriteLine($"NeedProductReg with ID {npid} removed successfully.");
                return true;
            }

            Console.WriteLine($"NeedProductReg with ID {npid} not found.");
            return false;
        }

        public NeedProductReg GetRequestByID(int npid)
        {
            return needProductRegs.FirstOrDefault(r => r.NPID == npid);
        }

        public void DisplayAllRequests()
        {
            Console.WriteLine("\nAll Need Product Requests:");
            if (!needProductRegs.Any())
            {
                Console.WriteLine("No product requests found.");
                return;
            }

            foreach (var reg in needProductRegs)
            {
                Console.WriteLine($"Need ID: {reg.Need.NeedID} - {reg}");
            }
        }
    }

    #endregion
}
