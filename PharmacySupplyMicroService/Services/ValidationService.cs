using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmacySupplyMicroService.Models;
using PharmacySupplyMicroService.Repository;

namespace PharmacySupplyMicroService.Services
{
    public class ValidationService:IValidationService
    {
        private readonly IValidationRepository _validationRepository;
        public ValidationService(IValidationRepository validationRepository)
        {
            _validationRepository = validationRepository;
        }
        public bool ValidateOne(string qtyString)
        {
            return _validationRepository.ValidateOne(qtyString);
        }
        public bool ValidateTwo(string qtyString, List<Medicine> medicines)
        {
            return _validationRepository.ValidateTwo(qtyString,medicines);
        }
    }
}
