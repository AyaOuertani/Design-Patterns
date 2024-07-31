using Builder.Floor;
using Builder.House_Director;
using Builder.HouseProduct;
using Builder.HouseType;
using Builder.Interface;
using Builder.Kitchen;
namespace Builder
{
    public class Program
    {

        public static HouseDirector houseDirector = new();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The House Builder App !");
            IHouseBuilder builder = HouseTypes.ChooseHouseType();
            if (builder != null)
            {
                Console.WriteLine("\nCustomize your house:");
                Console.WriteLine("\nEnter the number of Entry Door: ");
                int.TryParse(Console.ReadLine(), out int entryDoor);
                builder.EntryDoor(entryDoor);

                Console.WriteLine("Enter the number of rooms: ");
                int.TryParse(Console.ReadLine(), out int roomNumber);
                builder.RoomNumber(roomNumber);

                Console.WriteLine("Does the house have a garden? (yes/no): ");
                string hasGarden = Console.ReadLine();
                bool garden = true;
                if (hasGarden.ToUpper() == "Yes")
                {
                    builder.Garden(garden);
                }
                else
                {
                    builder.Garden(!garden);
                }

                Console.WriteLine("Does the house have a swimming pool? (yes/no): ");
                string hasPool = Console.ReadLine();
                bool pool = true;
                if (hasPool.ToUpper() == "Yes")
                {
                    builder.SwimmingPool(pool);
                }
                else
                {
                    builder.SwimmingPool(!pool);
                }
                FloorType.ChooseFloorType(ref builder);
                KitchenType.ChooseKitchenType(ref builder);
                FloorType.ChooseFloorType(ref builder);
                houseDirector.SetBuilder(builder);
                House house = builder.HouseBuilding();
                Console.WriteLine("Your customized house: " + house.HouseDesign());
                Console.WriteLine("House Type: " + builder.GetType().Name);
            }
        }

    }
}

