using Builder.Floor;
using Builder.House_Director;
using Builder.HouseCustomize;
using Builder.HouseProduct;
using Builder.HouseType;
using Builder.Interface;
using Builder.Kitchen;
using Builder.Roof;
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
                HouseCustomizing.CustomizeHouse(ref builder);
                houseDirector.SetBuilder(builder);
                House house;
                if (builder.GetType().Name == "LuxuryHouse")
                {
                    house = houseDirector.ConstructLuxeryHouse(HouseCustomizing.EntryDoor, HouseCustomizing.RoomNumber, FloorType.FlooringType, KitchenType.KitchenStyle, RoofType.RoofTypes, HouseCustomizing.Garden, HouseCustomizing.Pool);
                }
                else if (builder.GetType().Name == "EcoFreindlyHouse")
                {
                    house = houseDirector.ConstructEcoyHouse(HouseCustomizing.EntryDoor, HouseCustomizing.RoomNumber, FloorType.FlooringType, KitchenType.KitchenStyle, RoofType.RoofTypes, HouseCustomizing.Garden, HouseCustomizing.Pool);
                }
                else
                {
                    house = houseDirector.ConstructMinimilistHouse(HouseCustomizing.EntryDoor, HouseCustomizing.RoomNumber, FloorType.FlooringType, KitchenType.KitchenStyle, RoofType.RoofTypes, HouseCustomizing.Garden, HouseCustomizing.Pool);
                }

                Console.WriteLine("Your customized house: " + house.HouseDesign());
                Console.WriteLine("House Type: " + builder.GetType().Name);
            }
        }

    }
}

