using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Bike
{
    public partial class Bike : IVehicule
    {
        public string Model;
        public int WheelNumber;
        public string FuelType;
        public int Stock;
        public double RentalCostPerDay;
    }
}

