using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Truck
{
    public partial class Truck : IVehicle
    {
        public int day { get; set; }
        public Truck(string model, string fuelType, int capacity, double rentalCostPerDay,int day)
        {
            Model = model;
            FuelType = fuelType;
            Capacity = capacity;
            RentalCostPerDay = rentalCostPerDay;
            Day = day;
        }
        public double CalculateRentalCost(int day) => day * RentalCostPerDay;
        public string VehiculeFullDescription()
        {
            return $"Truck:\nMoel:{Model}\nCapacity:{Capacity}Kg\nFull Type:{FuelType}\nRental Cost Per Day:{RentalCostPerDay}DT";
        }
    }
}

