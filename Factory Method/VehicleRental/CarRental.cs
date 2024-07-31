using Factory_Method.Concreate_Product;
using Factory_Method.Creator;
using Factory_Method.Interface;

namespace Factory_Method.Concreate_Creator
{
    public class CarRental : IRentalCenter
    {

        public IVehicle CreateVehicule(string model, string fuelType, int capacity, double rentalCostPerDay, int day)
        {
            return new Car(model, fuelType, capacity, rentalCostPerDay, day);
        }
    }
}
