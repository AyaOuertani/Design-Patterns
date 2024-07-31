using Builder.House_Builder;

using Builder.Interface;

namespace Builder.HouseType
{
    public static class HouseTypes
    {
        public static int choice;
        public static IHouseBuilder ChooseHouseType()
        {
            Console.WriteLine("Choose the type of house to build");
            Console.WriteLine("\n1. Luxury House\n2. Eco-Friendly House\n3. Minimalist House");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            }
            IHouseBuilder builder;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nYou chose Luxury House.");
                    builder = new LuxuryHouse();
                    break;
                case 2:
                    Console.WriteLine("\nYou chose Eco-Friendly House.");
                    builder = new EcoFreindlyHouse();
                    break;
                case 3:
                    Console.WriteLine("\nYou chose Minimalist House.");
                    builder = new MinimlistHouse();
                    break;
                default:
                    builder = null;
                    break;
            }
            return builder;
        }
    }
}
