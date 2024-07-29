using Factory_Method.Interface;

namespace Factory_Method.Concreate_Product.Truck
{
    public partial class Truck : IVehicule
    {
        public Truck(string model, int cpacity, string fuelType, int stock, double rentalCostPerDay)
        {
            Model = model;
            FuelType = fuelType;
            Cpacity = cpacity;
            Stock = stock;
            RentalCostPerDay = rentalCostPerDay;
        }
        public double CalculateRentalCost(int days) => days * RentalCostPerDay;
        public string VehiculeFullDescription()
        {
            return $"Car:\nMoel:{Model} \nFull Type : {FuelType} \nCpacity: {Cpacity} \n Stock : {Stock}\n Rental Cost Per Day :{RentalCostPerDay}";
        }
    }
}

