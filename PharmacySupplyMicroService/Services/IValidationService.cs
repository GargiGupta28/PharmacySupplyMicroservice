using PharmacySupplyMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacySupplyMicroService.Services
{
    public interface IValidationService
    {
        public bool ValidateOne(string qtyString);
        public bool ValidateTwo(string qtyString, List<Medicine> medicines);
    }
}
