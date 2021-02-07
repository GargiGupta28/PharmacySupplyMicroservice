using PharmacySupplyMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacySupplyMicroService.Repository
{
    public interface IValidationRepository
    {
        public bool ValidateOne(string qtyString);
        public bool ValidateTwo(string qtyString, List<Medicine> medicines);
    }
}
