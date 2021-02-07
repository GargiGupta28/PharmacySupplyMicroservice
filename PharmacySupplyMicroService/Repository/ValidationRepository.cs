using Microsoft.AspNetCore.Mvc;
using PharmacySupplyMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacySupplyMicroService.Repository
{
    public class ValidationRepository:IValidationRepository
    {
        public bool ValidateOne(string qtyString)
        {
            bool isValid = false;
            List<int> quantityList = new List<int>();
            quantityList = qtyString.Split(',').ToList().Select(s => int.Parse(s)).ToList();   // Convert list from string to int
            foreach (int item in quantityList)
                if (item >= 3)
                    isValid = true;
            return isValid;    
        }
        public bool ValidateTwo(string qtyString, List<Medicine> medicines)
        {
            bool isValid = true;
            if (medicines.Count!= qtyString.Split(',').Length)
                isValid = false;
            List<int> quantityList = new List<int>();
            quantityList = qtyString.Split(',').ToList().Select(s => int.Parse(s)).ToList();
            foreach (int item in quantityList)
                if (item < 0)
                    isValid = false;
            return isValid;
        }
    }
}
