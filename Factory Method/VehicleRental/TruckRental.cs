using Factory_Method.Concreate_Product;
using Factory_Method.Concreate_Product.Truck;
using Factory_Method.Creator;
using Factory_Method.Interface;

namespace Factory_Method.Concreate_Creator
{
    public class TruckRental : RentalCenter
    {
        public override IVehicle CreateVehicule(string model, string fuelType,int capacity, double rentalCostPerDay,int day)
        {
            return new Truck(model, fuelType, capacity, rentalCostPerDay,day);
        }
    }
}
