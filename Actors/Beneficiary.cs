using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShop.Donations;

namespace ThriftShop.Actors
{
    /// <summary>
    /// 
    /// </summary>
    public class Beneficiary
    {
        #region Attributes
        public int BeneficiaryId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Nationality { get; set; }
        public bool HasChildren { get; set; }
        public int ChildrenCount { get; set; }
        public int VisitCount { get; set; }

        //List of need for this beneficiary
        public List<Need> Needs { get; set; } = new List<Need>();

        //List to hold all beneficiaries
        private static List<Beneficiary> beneficiaries = new List<Beneficiary>();

        #endregion

        #region Constructors
        public Beneficiary(int beneficiaryId, string name, string contactNumber, string nationality, bool hasChildren, int childrenCount)
        {
            this.BeneficiaryId = beneficiaryId;
            this.Name = name;
            this.ContactNumber = contactNumber;
            this.Nationality = nationality;
            this.HasChildren = hasChildren;
            this.ChildrenCount = hasChildren ? childrenCount : 0;  // If HasChildren is false, ChildrenCount is set to 0
            this.VisitCount = 0;  // Initialize the visit count to zero
        }
        #endregion

        #region Methods
        public static void AddBeneficiary(Beneficiary beneficiary)
        {
            beneficiaries.Add(beneficiary);
        }

        public void AddNeed(Need need)
        {
            Needs.Add(need);
        }

        public static void DisplayBeneficiaries(bool showNeeds = false)
        {
            foreach (var beneficiary in beneficiaries)
            {
                Console.WriteLine($"ID: {beneficiary.BeneficiaryId}, Name: {beneficiary.Name}, Contact: {beneficiary.ContactNumber}, Nationality: {beneficiary.Nationality}, Visits: {beneficiary.VisitCount}");

                // Optionally display needs for each beneficiary
                if (showNeeds && beneficiary.Needs.Count > 0)  // Use `beneficiary.Needs`
                {
                    Console.WriteLine("  Needs:");
                    foreach (var need in beneficiary.Needs)  // Use `beneficiary.Needs`
                    {
                        Console.WriteLine($"    Need ID: {need.NeedId}, Description: {need.Description}, Priority: {need.PriorityLevel}, Status: {need.Status}");
                    }
                }
            }
        }


        #endregion
    }
}

