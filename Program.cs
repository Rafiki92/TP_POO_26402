using System;
using System.Collections.Generic;
using ThriftShop.Actors;
using ThriftShop.Donations;
using ThriftShop.Products;

namespace ThriftShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create some products with valid categories and conditions
            Beneficiary beneficiary1 = new Beneficiary(1, "Alice Johnson", "555-1234", "American", true, 2);
            Beneficiary beneficiary2 = new Beneficiary(2, "John Smith", "555-5678", "British", false, 0);

            Beneficiary.AddBeneficiary(beneficiary1);
            Beneficiary.AddBeneficiary(beneficiary2);

            // Step 2: Create needs and associate with beneficiaries
            Need need1 = new Need(1, "Winter clothes for children", 2, Need.NeedStatus.Pending);
            Need need2 = new Need(2, "School supplies", 1, Need.NeedStatus.Pending);
            Need need3 = new Need(3, "Furniture for new apartment", 3, Need.NeedStatus.Pending);

            // Add needs to beneficiaries
            beneficiary1.Needs.Add(need1);
            beneficiary1.Needs.Add(need2);
            beneficiary2.Needs.Add(need3);

            // Step 3: Display all beneficiaries and their needs
            Console.WriteLine("Displaying beneficiaries and their needs:");
            Beneficiary.DisplayBeneficiaries(showNeeds: true);

            Console.ReadLine(); // Pause the console to view output
        }
    }
}