using Factory_Method.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Concreate_Product
{
    public partial class Car : IVehicule
    {
        public string Model;
        public int SeatsNumber;
        public string FuelType;
        public int Stock;
        public double RentalCostPerDay;
    }
}
