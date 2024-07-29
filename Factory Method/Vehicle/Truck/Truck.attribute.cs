using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Truck
{
    public partial class Truck : IVehicle
    {
        public int Day { get; set; }
        public string Model;
        public string FuelType;
        public int Capacity;
        public double RentalCostPerDay;
    }
}

