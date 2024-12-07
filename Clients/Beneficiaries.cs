using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Clients
{
    /// <summary>
    /// 
    /// </summary>
    public class Beneficiaries
    {
        private readonly List<Beneficiary> beneficiaries = new List<Beneficiary>();

        #region Methods
        public void AddBeneficiary(Beneficiary beneficiary)
        {
            if (beneficiary == null)
                throw new ArgumentNullException(nameof(beneficiary), "Beneficiary cannot be null.");

            // Optionally, check for duplicate BenID
            if (beneficiaries.Any(b => b.BenID == beneficiary.BenID))
                throw new ArgumentException($"A beneficiary with ID {beneficiary.BenID} already exists.");

            beneficiaries.Add(beneficiary);
        }

        public bool UpdateBeneficiary(int benID, string newName, int newPhoneNumber, string newReference, int newFamilyNumber, bool newHasChildren, string newNotes, string newNationality, DateTime newStartDate, DateTime? newEndDate)
        {
            var beneficiary = beneficiaries.FirstOrDefault(b => b.BenID == benID);
            if (beneficiary == null)
            {
                return false;
            }

            beneficiary.Name = newName;
            beneficiary.PhoneNumber = newPhoneNumber;
            beneficiary.Reference = newReference;
            beneficiary.FamilyNumber = newFamilyNumber;
            beneficiary.HasChildren = newHasChildren;
            beneficiary.Notes = newNotes;
            beneficiary.Nationality = newNationality;
            beneficiary.StartDate = newStartDate;
            beneficiary.EndDate = newEndDate;

            return true;
        }

        public bool InactivateBeneficiary(int benID)
        {
            var beneficiary = beneficiaries.FirstOrDefault(b => b.BenID == benID);
            if (beneficiary == null)
                return false; 

            //Defines the End Date as Today
            beneficiary.EndDate = DateTime.Now;
            return true;
        }


        public void DisplayBeneficiaries()
        {
            Console.WriteLine($"Total Number of Beneficiaries: {beneficiaries.Count}");
            foreach (var beneficiary in beneficiaries)
            {
                string activeStatus = beneficiary.IsActive() ? "Active" : "Inactive";
                Console.WriteLine($"ID: {beneficiary.BenID}, Name: {beneficiary.Name}, Contact: {beneficiary.PhoneNumber}, Nationality: {beneficiary.Nationality}, Status: {activeStatus}");
            }
            #endregion
        }
    }
}

