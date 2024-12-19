using System;
using System.Collections.Generic;
using System.IO;
using ThriftShopApp.Models;

namespace ThriftShopApp.Managers
{
    public class CsvReaderHelper
    {
        public static List<Beneficiary> ReadBeneficiariesFromCsv(string filePath)
        {
            var beneficiaries = new List<Beneficiary>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        // Skip the header row
                        isHeader = false;
                        continue;
                    }

                    var values = line.Split(',');

                    try
                    {
                        // Parse CSV line into Beneficiary object
                        var beneficiary = new Beneficiary(
                            int.Parse(values[0]),   // BenID
                            values[1],              // Name
                            int.Parse(values[2]),   // PhoneNumber
                            values[3],              // Reference
                            int.Parse(values[4]),   // FamilyNumber
                            bool.Parse(values[5]),  // HasChildren
                            values[6],              // Notes
                            values[7],              // Nationality
                            DateTime.Parse(values[8]),   // StartDate
                            string.IsNullOrEmpty(values[9]) ? (DateTime?)null : DateTime.Parse(values[9]) // EndDate
                        );

                        beneficiaries.Add(beneficiary);
                    }
                    catch (Exception ex)
                    {
                        throw new InvalidOperationException($"Error parsing line: {line}. Details: {ex.Message}");
                    }
                }
            }

            return beneficiaries;
        }
    }
}

