using Factory_Method.Concreate_Product.Bike;
using Factory_Method.Creator;
using Factory_Method.Interface;

namespace Factory_Method.Concreate_Creator
{
    public class BikeRental : IRentalCenter
    {
        public IVehicle CreateVehicule(string model, string fuelType, int capacity, double rentalCostPerDay, int day)
        {
            return new Bike(model, fuelType, capacity, rentalCostPerDay, day);
        }
    }
}
