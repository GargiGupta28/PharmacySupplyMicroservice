using PharmacySupplyMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacySupplyMicroService.Repository
{
    public class DistributeMedicineRepository:IDistributeMedicineRepository
    {
        public List<Pharmacy> DistributeStock(List<Medicine> medicines, string qtyString)
        {
            List<int> listOfQuantities = new List<int>();
            //List<string>  qtyStringList = qtyString.Split(',').ToList();
            //quantityList = qtyStringList.Select(s => int.Parse(s)).ToList();   // Convert list from string to int
            listOfQuantities = qtyString.Split(',').ToList().Select(s => int.Parse(s)).ToList();
            int pharmacyCount = PharmacyList.Pharmacies.Count;
            List<string> tempNameList = new List<string>(); // For transferring names of Medicines
            List<string> tempIntList = new List<string>();  // For temporary storage of medicine quantity as string
            List<int> tempQtyList = new List<int>();        // For transferring quantity

            foreach(Pharmacy pharmacy in PharmacyList.Pharmacies)
            {
                for(int i = 0 ; i < listOfQuantities.Count ; i++)
                {
                    if(listOfQuantities[i] >= medicines[i].NumberOfTabletsInStock)
                    {
                        tempNameList.Add(medicines[i].Name);
                        tempQtyList.Add(medicines[i].NumberOfTabletsInStock / pharmacyCount);
                    }
                    else 
                    {
                        tempNameList.Add(medicines[i].Name);
                        tempQtyList.Add(listOfQuantities[i] / pharmacyCount);
                    }
                }
                //string nameToList = string.Join(',', tempNameList.ToArray()); 
                //pharmacy.MedicineName = nameToList.Split(',').ToList();
                //string qtyToList = string.Join(',', tempQtyList.ToArray());
                //tempIntList = string.Join(',', tempQtyList.ToArray()).Split(',').ToList(); //list of string with number value
                pharmacy.MedicineName = string.Join(',', tempNameList.ToArray()).Split(',').ToList();
                pharmacy.SupplyCount = string.Join(',', tempQtyList.ToArray()).Split(',').ToList().Select(s => int.Parse(s)).ToList();

                //tempIntList.Clear(); Remove above 2 lines when using the commented function
                tempNameList.Clear();
                tempQtyList.Clear();
            }
            return PharmacyList.Pharmacies;
        }
    }
}
