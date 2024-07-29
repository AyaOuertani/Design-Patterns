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
        public override IVehicule CreateVehicule(string model, int WheelNumber, string fuelType, int stock, double rentalCostPerDay)
        {
            return new Bike(model, WheelNumber, fuelType, stock, rentalCostPerDay);
        }
    }
}
