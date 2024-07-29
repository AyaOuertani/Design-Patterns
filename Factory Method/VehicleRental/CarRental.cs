using Factory_Method.Concreate_Product;
using Factory_Method.Creator;
using Factory_Method.Interface;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Concreate_Creator
{
    public class CarRental : RentalCenter
    {

        public override IVehicle CreateVehicule(string model, string fuelType, int capacity, double rentalCostPerDay,int day)
        {
            return new Car(model, fuelType, capacity, rentalCostPerDay,day);
        }
    }
}
