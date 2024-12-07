using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShopApp.Processes
{
    /// <summary>
    /// 
    /// </summary>
    public class Needs
    {
        private readonly List<Need> needs = new List<Need>();

        #region Methods
        public void AddNeed(Need need)
        {
            if (need == null)
                throw new ArgumentNullException(nameof(need));

            if (needs.Any(n => n.NeedID == need.NeedID))
                throw new ArgumentException($"A need with ID {need.NeedID} already exists.");

            needs.Add(need);
            Console.WriteLine($"Need '{need.Name}' added successfully.");
        }

        public bool RemoveNeedByID(int needID)
        {
            var need = needs.FirstOrDefault(n => n.NeedID == needID);
            if (need != null)
            {
                needs.Remove(need);
                Console.WriteLine($"Need with ID {needID} removed successfully.");
                return true;
            }

            Console.WriteLine($"Need with ID {needID} not found.");
            return false;
        }

        public Need GetNeedByID(int needID)
        {
            return needs.FirstOrDefault(n => n.NeedID == needID);
        }

        public void DisplayAllNeeds()
        {
            Console.WriteLine("\nAll Needs:");
            if (!needs.Any())
            {
                Console.WriteLine("No needs found.");
                return;
            }

            foreach (var need in needs)
            {
                Console.WriteLine(need.ToString());
            }
        }

        #endregion
    }
}
