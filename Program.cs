using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Actors;
using ThriftShop.Donation;
using ThriftShop.Products;

namespace ThriftShop
{

    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Donor donor1 = new Donor(1, "John Doe", "john@example.com", "American");
            Donor.AddDonor(donor1);

            // Create a category for products
            Category clothingCategory = new Category(1, "Clothing", "Various clothing items donated.");

            // Create products
            Product product1 = new Product(1, "Winter Coat", clothingCategory, 5);
            Product product2 = new Product(2, "T-shirt", clothingCategory, 10);

            // Create a list of donated products
            List<Product> donatedProducts = new List<Product> { product1, product2 };

            // Create a donation
            Donation.AddDonation((Donation)new Donation(1, donor1, donatedProducts, DateTime.Now));

            // Display all donors and donations
            Donor.DisplayDonors();
            Donation.DisplayDonations();


            Console.ReadLine();
        }
    }
}
