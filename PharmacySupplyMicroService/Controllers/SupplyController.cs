using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PharmacySupplyMicroService.Repository;
using PharmacySupplyMicroService.Models;
using Microsoft.AspNetCore.Authorization;
using PharmacySupplyMicroService.Services;

namespace PharmacySupplyMicroService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SupplyController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IDistributeMedicineService _distributeMedicineService;
        private readonly IGetMedicineService _getMedicineService;
        private readonly IValidationService _validationService;
        public SupplyController(IConfiguration config, IGetMedicineService getMedicineService, IDistributeMedicineService distributeMedicineService, IValidationService validationService)
        {
            _config = config;
            _distributeMedicineService = distributeMedicineService;
            _getMedicineService = getMedicineService;
            _validationService = validationService;
        }

        [HttpGet]
        public IActionResult GetResult(string qtyString)
        {
            if (_validationService.ValidateTwo(qtyString, _getMedicineService.GetMedicine(_config)))
            {
                if(_validationService.ValidateOne(qtyString))
                {
                    return Ok(_distributeMedicineService.DistributeStock(_getMedicineService.GetMedicine(_config),qtyString));
                }
                return StatusCode(405); //If all 0 or not atleast one is above 3 in quantity //BadMethod
            }
            return StatusCode(400);  //When Input quantities does not match number of individual medicines or negative value is passed //BadRequest
        }

        [AllowAnonymous]
        [HttpGet("Run")]
        public ActionResult<string> Get()
        {
            return "The Pharmacy Medicine Supply MicroService API is Running";
        }
    }
}
