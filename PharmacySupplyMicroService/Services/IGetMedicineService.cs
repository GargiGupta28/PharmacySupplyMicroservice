using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PharmacySupplyMicroService.Models;
using PharmacySupplyMicroService.Repository;

namespace PharmacySupplyMicroService.Services
{
    public interface IGetMedicineService
    {
        public List<Medicine> GetMedicine(IConfiguration _config);
    }
}
