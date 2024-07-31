using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Bike
{
    public partial class Bike : IVehicle
    {

        public Bike(string model, string fuelType, int capacity, double rentalCostPerDay, int days)
        {
            Model = model;
            FuelType = fuelType;
            Capacity = capacity;
            RentalCostPerDay = rentalCostPerDay;
            Days = days;
        }
        public double CalculateRentalCost() => Days * RentalCostPerDay;
        public string VehiculeFullDescription()
        {
            return $"Bike:\nMoel:{Model}\nCapacity:{Capacity}\nFull Type:{FuelType}\n Rental Cost Per Day:{RentalCostPerDay}";
        }
    }
}

