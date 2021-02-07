using Microsoft.Extensions.Configuration;
using PharmacySupplyMicroService.Models;
using System.Collections.Generic;

namespace PharmacySupplyMicroService.Repository
{
    public interface IGetMedicineRepository
    {
        public List<Medicine> GetMedicine(IConfiguration _config);
    }
}
