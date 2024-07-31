using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Truck
{
    public partial class Truck : IVehicle
    {
        public int Days { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public int Capacity { get; set; }
        public double RentalCostPerDay { get; set; }
    }
}

