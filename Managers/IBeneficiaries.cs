using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    public interface IBeneficiaries
    {
        /// <summary>
        /// Adds a new beneficiary.
        /// </summary>
        /// <param name="beneficiary">The beneficiary to add.</param>
        void AddBeneficiary(Beneficiary beneficiary);

        /// <summary>
        /// Updates an existing beneficiary's details.
        /// </summary>
        /// <param name="benID">The ID of the beneficiary to update.</param>
        /// <param name="newName">The new name of the beneficiary.</param>
        /// <param name="newPhoneNumber">The new phone number of the beneficiary.</param>
        /// <param name="newReference">The new reference for the beneficiary.</param>
        /// <param name="newFamilyNumber">The new family number for the beneficiary.</param>
        /// <param name="newHasChildren">Indicates whether the beneficiary has children.</param>
        /// <param name="newNotes">New notes about the beneficiary.</param>
        /// <param name="newNationality">The new nationality of the beneficiary.</param>
        /// <param name="newStartDate">The new start date for the beneficiary.</param>
        /// <param name="newEndDate">The new end date for the beneficiary (if applicable).</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        bool UpdateBeneficiary(int benID, string newName, int newPhoneNumber, string newReference,
                               int newFamilyNumber, bool newHasChildren, string newNotes,
                               string newNationality, DateTime newStartDate, DateTime? newEndDate);

        /// <summary>
        /// Inactivates a beneficiary by setting their end date to the current date.
        /// </summary>
        /// <param name="benID">The ID of the beneficiary to inactivate.</param>
        /// <returns>True if the inactivation was successful; otherwise, false.</returns>
        bool InactivateBeneficiary(int benID);

        /// <summary>
        /// Retrieves all beneficiaries.
        /// </summary>
        /// <returns>A list of all beneficiaries.</returns>
        List<Beneficiary> GetAll();
    }
}

