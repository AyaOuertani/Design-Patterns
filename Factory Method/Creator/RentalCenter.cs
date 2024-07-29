using Factory_Method.Interface;

namespace Factory_Method.Creator
{
    public abstract class RentalCenter
    {
        public abstract IVehicle CreateVehicule(string model, string fuelType, int capacity, double rentalCostPerDay,int day);
    }
}
