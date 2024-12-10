using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;
using ThriftShopApp.Services;

namespace ThriftShopApp.Controllers
{
    public class BeneficiaryController
    {
        private readonly Beneficiaries beneficiariesService;

        public BeneficiaryController(Beneficiaries beneficiariesService)
        {
            this.beneficiariesService = beneficiariesService;
        }

        // Add a new beneficiary
        public void AddBeneficiary(int id, string name, int phoneNumber, string reference, int familyNumber,
            bool hasChildren, string notes, string nationality, DateTime startDate, DateTime? endDate)
        {
            var newBeneficiary = new Beneficiary(id, name, phoneNumber, reference, familyNumber, hasChildren, notes, nationality, startDate, endDate);
            beneficiariesService.AddBeneficiary(newBeneficiary);
        }

        public bool UpdateBeneficiary(int id, string name, int phoneNumber, string reference, int familyNumber,
            bool hasChildren, string notes, string nationality, DateTime startDate, DateTime? endDate)
        {
            return beneficiariesService.UpdateBeneficiary(id, name, phoneNumber, reference, familyNumber, hasChildren, notes, nationality, startDate, endDate);
        }

        // Inactivate a beneficiary
        public bool InactivateBeneficiary(int id)
        {
            return beneficiariesService.InactivateBeneficiary(id);
        }

        // Get a list of all beneficiaries
        public List<Beneficiary> GetAllBeneficiaries()
        {
            return beneficiariesService.GetAll();
        }

        // Get a specific beneficiary by ID
        public Beneficiary GetBeneficiaryById(int id)
        {
            var beneficiaries = beneficiariesService.GetAll();
            return beneficiaries.Find(b => b.BenID == id);
        }

        // Get all active beneficiaries
        public List<Beneficiary> GetActiveBeneficiaries()
        {
            var beneficiaries = beneficiariesService.GetAll();
            return beneficiaries.FindAll(b => b.IsActive());
        }
    }
}
