using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Models
{
    /// <summary>
    /// Represents a need of the beneficiary.
    /// </summary>
    public class Need
    {
        #region Attributes
        private int needID;
        private string name;
        private string category;
        private string description;
        private DateTime date;
        private NeedStatus status;
        private Beneficiary beneficiary;
        private Volunteer registeredBy;

        #endregion

        #region Properties
        public int NeedID
        {
            get { return needID; }
            set { needID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public NeedStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public Beneficiary Beneficiary
        {
            get { return beneficiary; }
            set { beneficiary = value; }
        }

        public Volunteer RegisteredBy
        {
            get { return registeredBy; }
            set { registeredBy = value; }
        }

        public enum NeedStatus
        {
            Pending,
            Fulfilled,
            InProgress
        }
        #endregion

        #region Constructors
        public Need(int needID, string name, string category, string description, DateTime date, NeedStatus status = NeedStatus.Pending, Beneficiary beneficiary = null, Volunteer registeredBy = null)
        {
            this.NeedID = needID;
            this.Name = name;
            this.Category = category;
            this.Description = description;
            this.Date = date;
            this.Status = status;
            this.Beneficiary = beneficiary;
            this.RegisteredBy = registeredBy;
        }
        #endregion

        #region Methods
        public void UpdateStatus(NeedStatus newStatus)
        {
            this.Status = newStatus;
        }

        public override string ToString()
        {
            return $"Need ID: {NeedID}, Name: {Name}, Category: {Category}, Description: {Description}, Date: {Date.ToShortDateString()}, Status: {Status}, Beneficiary: {Beneficiary?.Name ?? "N/A"}, Registered By: {RegisteredBy?.GetName() ?? "N/A"}";
        }
        #endregion
    }
}
