using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmacySupplyMicroService.Models;
using PharmacySupplyMicroService.Repository;

namespace PharmacySupplyMicroService.Services
{
    public class DistributeMedicineService:IDistributeMedicineService
    {
        private readonly IDistributeMedicineRepository _distributeMedicineRepository;
        public DistributeMedicineService(IDistributeMedicineRepository distributeMedicineRepository)
        {
            _distributeMedicineRepository = distributeMedicineRepository;
        }
        public List<Pharmacy> DistributeStock(List<Medicine> medicines, string qtyString)
        {
            return _distributeMedicineRepository.DistributeStock(medicines, qtyString);
        }
    }
}
