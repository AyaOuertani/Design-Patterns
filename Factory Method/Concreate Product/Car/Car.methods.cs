using Factory_Method.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Concreate_Product
{
    public partial class Car : IVehicule
    {
        public Car(string model, int seatsNumber, string fuelType,int stock, double rentalCostPerDay)
        {
            Model = model;
            SeatsNumber = seatsNumber;
            FuelType = fuelType;
            Stock = stock;
            RentalCostPerDay = rentalCostPerDay;
        }
        public double CalculateRentalCost(int days) => days * RentalCostPerDay;
        public string VehiculeFullDescription()
        {
            return $"Car:\nMoel:{Model} \nSeats Number: {SeatsNumber} \nFull Type : {FuelType}\n Stock : {Stock}\n Rental Cost Per Day :{RentalCostPerDay}";
        }
    }
}
