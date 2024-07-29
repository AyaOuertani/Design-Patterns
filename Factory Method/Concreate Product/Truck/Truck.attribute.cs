using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Truck
{
    public partial class Truck : IVehicule
    {

        public string Model;
        public int Cpacity;
        public string FuelType;
        public int Stock;
        public double RentalCostPerDay;
    }
}

