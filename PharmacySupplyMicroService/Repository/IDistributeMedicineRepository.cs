using PharmacySupplyMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacySupplyMicroService.Repository
{
    public interface IDistributeMedicineRepository
    {
        public List<Pharmacy> DistributeStock(List<Medicine> medicines, string qtyString);
    }
}
