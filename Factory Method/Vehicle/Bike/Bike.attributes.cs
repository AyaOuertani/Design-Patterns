using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Bike
{
    public partial class Bike : IVehicle
    {
        public int Day { get; set; }
        public string Model;
        public string FuelType;
        public int Capacity;
        public double RentalCostPerDay;
    }
}

