using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Bike
{
    public partial class Bike : IVehicule
    {
        public Bike(string model, int wheelNumber, string fuelType, int stock, double rentalCostPerDay)
        {
            Model = model;
            WheelNumber = wheelNumber;
            FuelType = fuelType;
            Stock = stock;
            RentalCostPerDay = rentalCostPerDay;
        }
        public double CalculateRentalCost(int days) => days * RentalCostPerDay;
        public string VehiculeFullDescription()
        {
            return $"Car:\nMoel:{Model} \nWheel Number: {WheelNumber} \nFull Type : {FuelType}\n Stock : {Stock}\n Rental Cost Per Day :{RentalCostPerDay}";
        }
    }
}

