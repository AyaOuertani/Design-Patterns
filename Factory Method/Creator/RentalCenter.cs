using Factory_Method.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Creator
{
    public abstract class RentalCenter
    {
        public abstract IVehicule CreateVehicule(string model, int seatsNumber, string fuelType, int stock, double rentalCostPerDay);
    }
}
