using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Processes;
using ThriftShopApp.Registers;
using ThriftShopApp.Users;

namespace ThriftShopApp.Clients
{
    /// <summary>
    /// Represents a beneficiary in the thrift shop.
    /// </summary>
    public class Beneficiary
    {
        #region Attributes
        private int benID;
        private string name;
        private int phoneNumber;
        private string reference;
        private int familyNumber;
        private bool hasChildren;
        private string notes;
        private string nationality;
        private DateTime startDate;
        private DateTime? endDate;
        

        // List to hold all beneficiaries
        private static List<Beneficiary> beneficiaries = new List<Beneficiary>();
        #endregion

        #region Properties
        public int BenID
        {
            get { return benID; }
            set { benID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public int FamilyNumber
        {
            get { return familyNumber; }
            set { familyNumber = value; }
        }

        public bool HasChildren
        {
            get { return hasChildren; }
            set { hasChildren = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime? EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }


        #endregion

        #region Constructors
        public Beneficiary(int benID, string name, int phoneNumber, string reference, int familyNumber, bool hasChildren, string notes, string nationality, DateTime startDate, DateTime? endDate)
        {
            this.BenID = benID;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Reference = reference;
            this.FamilyNumber = familyNumber;
            this.HasChildren = hasChildren;
            this.Notes = notes;
            this.Nationality = nationality;
            this.StartDate = startDate;
            this.EndDate = endDate;
            
        }
        #endregion

        #region Methods
        public static void AddBeneficiary(Beneficiary beneficiary)
        {
            beneficiaries.Add(beneficiary);
        }

        public static void DisplayBeneficiaries()
        {
            Console.WriteLine($"Total Number of Beneficiaries: {beneficiaries.Count}");
            foreach (var beneficiary in beneficiaries)
            {
                Console.WriteLine($"ID: {beneficiary.BenID}, Name: {beneficiary.Name}, Contact: {beneficiary.PhoneNumber}, Nationality: {beneficiary.Nationality}");
            }
        }
    }
        #endregion
    }
