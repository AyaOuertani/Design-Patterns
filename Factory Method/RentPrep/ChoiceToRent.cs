using Factory_Method.Concreate_Creator;
using Factory_Method.Creator;
using Factory_Method.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.RentPrep
{
    public static class ChoiceToRent
    {
        public static void Choice (out RentalCenter rentalService)
        {
            Console.WriteLine("Welcome to the Vehicle Rental System");
            Console.WriteLine("Please select a vehicle type: 1. Car, 2. Bike, 3. Truck");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    rentalService = new CarRental();
                    break;
                case 2:
                    rentalService = new BikeRental();
                    break;
                case 3:
                    rentalService = new TruckRental();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    rentalService = null;
                    break;
            }
        }
    }
}
