using Factory_Method.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Concreate_Product
{
    public partial class Car : IVehicle
    {
        public int Day { get; set; }
        public string Model;
        public string FuelType;
        public int Capacity;
        public double RentalCostPerDay;
    }
}
