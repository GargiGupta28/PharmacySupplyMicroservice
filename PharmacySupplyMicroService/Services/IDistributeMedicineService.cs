using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmacySupplyMicroService.Models;
using PharmacySupplyMicroService.Repository;

namespace PharmacySupplyMicroService.Services
{
    public interface IDistributeMedicineService
    {
        public List<Pharmacy> DistributeStock(List<Medicine> medicines, string qtyString);
    }
}
