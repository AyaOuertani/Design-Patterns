using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Bike
{
    public partial class Bike : IVehicle
    {

        public Bike(string model, string fuelType, int capacity, double rentalCostPerDay, int day)
        {
            Model = model;
            FuelType = fuelType;
            Capacity = capacity;
            RentalCostPerDay = rentalCostPerDay;
            Day = day;
        }
        public double CalculateRentalCost(int days) => days * RentalCostPerDay;
        public string VehiculeFullDescription()
        {
            return $"Bike:\nMoel:{Model}\nCapacity:{Capacity}\nFull Type:{FuelType}\n Rental Cost Per Day:{RentalCostPerDay}";
        }
    }
}

