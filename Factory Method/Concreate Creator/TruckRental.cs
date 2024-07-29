using Factory_Method.Concreate_Product;
using Factory_Method.Concreate_Product.Truck;
using Factory_Method.Creator;
using Factory_Method.Interface;

namespace Factory_Method.Concreate_Creator
{
    public class TruckRental : RentalCenter
    {
        public override IVehicule CreateVehicule(string model, int cpacity, string fuelType, int stock, double rentalCostPerDay)
        {
            return new Truck(model, cpacity, fuelType, stock, rentalCostPerDay);
        }
    }
}
