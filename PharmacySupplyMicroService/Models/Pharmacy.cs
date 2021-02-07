using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacySupplyMicroService.Models
{
    public class Pharmacy
    {
        public string PharmacyName { get; set; }
        public List<string> MedicineName { get; set; }
        public List<int> SupplyCount { get; set; }
    }
}
