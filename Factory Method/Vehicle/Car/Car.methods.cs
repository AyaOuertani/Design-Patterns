using Factory_Method.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Concreate_Product
{
    public partial class Car : IVehicle
    {
        public Car(string model, string fuelType, int capacity, double rentalCostPerDay,int days)
        {
            Model = model;
            FuelType = fuelType;
            Capacity = capacity;
            RentalCostPerDay = rentalCostPerDay;
            Days = days;
        }
        public double CalculateRentalCost() => Days * RentalCostPerDay;
        public string VehiculeFullDescription()
        {
            return $"Car:\nMoel:{Model}\nCapacity:{Capacity}\nFull Type:{FuelType}\nRental Cost Per Day:{RentalCostPerDay}";
        }
    }
}
