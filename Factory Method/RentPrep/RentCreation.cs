using Factory_Method.Creator;
using Factory_Method.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.RentPrep
{
    public class RentCreation
    {
        public static IVehicle RentCreationDetails(IRentalCenter rentalService)
        {
            Console.WriteLine("Enter vehicle name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter rental cost per day:");
            double rentalCostPerDay = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter capacity per Kg:");
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fuel type :");
            string fuelType = Console.ReadLine();

            Console.WriteLine("Enter number of days to rent:");
            int days = int.Parse(Console.ReadLine());
            return rentalService.CreateVehicule(name, fuelType, capacity, rentalCostPerDay,days);
        }
    }
}
