using Factory_Method.Interface;

namespace Factory_Method.Creator
{
    public interface IRentalCenter
    {
        public IVehicle CreateVehicule(string model, string fuelType, int capacity, double rentalCostPerDay,int day);
    }
}
