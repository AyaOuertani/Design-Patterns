// Program.cs
using Factory_Method.Concreate_Creator;
using Factory_Method.Creator;
using Factory_Method.Interface;
using Factory_Method.RentPrep;
namespace Factory_Method
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            ChoiceToRent.Choice(out RentalCenter rentalService);
            IVehicle vehicleRented = RentCreation.RentCreationDetails(rentalService);
            Console.WriteLine("Vehicle rented successfully!");
            Console.WriteLine("Details of the rent:");
            Console.WriteLine(vehicleRented.VehiculeFullDescription());
            Console.WriteLine($"Total Rental Cost for {vehicleRented.Day} days: {vehicleRented.CalculateRentalCost(vehicleRented.Day)}");
        }
    }
}
