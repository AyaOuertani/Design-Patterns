using Factory_Method.Concreate_Product;
using Factory_Method.Concreate_Product.Bike;
using Factory_Method.Creator;
using Factory_Method.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Concreate_Creator
{
    public class BikeRental : RentalCenter
    {
        public override IVehicle CreateVehicule(string model, string fuelType, int capacity, double rentalCostPerDay,int day)
        {
            return new Bike(model, fuelType, capacity, rentalCostPerDay,day);
        }
    }
}
