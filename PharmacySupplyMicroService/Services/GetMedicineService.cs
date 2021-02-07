using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PharmacySupplyMicroService.Models;
using PharmacySupplyMicroService.Repository;

namespace PharmacySupplyMicroService.Services
{
    public class GetMedicineService:IGetMedicineService
    {
        private readonly IGetMedicineRepository _getMedicineRepository;
        public GetMedicineService(IGetMedicineRepository getMedicineRepository)
        {
            _getMedicineRepository = getMedicineRepository;
        }
        public List<Medicine> GetMedicine(IConfiguration _config)
        {
            return _getMedicineRepository.GetMedicine(_config);
        }
    }
}
