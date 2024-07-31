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
        public int Days { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public int Capacity { get; set; }
        public double RentalCostPerDay { get; set; }
    }
}
