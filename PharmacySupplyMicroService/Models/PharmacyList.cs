using System.Collections.Generic;

namespace PharmacySupplyMicroService.Models
{
    public static class PharmacyList
    {
        public static List<Pharmacy> Pharmacies = new List<Pharmacy>()
        {
            new Pharmacy { PharmacyName = "Alderaan" },
            new Pharmacy { PharmacyName = "Bespin" },
            new Pharmacy { PharmacyName = "Cantonica" }
        };
    }
}
