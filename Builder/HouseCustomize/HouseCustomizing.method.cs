using Builder.Floor;
using Builder.Interface;
using Builder.Kitchen;
using Builder.Roof;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.HouseCustomize
{
    public partial class HouseCustomizing
    {
        public static void CustomizeHouse(ref IHouseBuilder builder)
        {
            Console.WriteLine("\nCustomize your house:");

            Console.WriteLine("\nEnter the number of Entry Door: ");
            int.TryParse(Console.ReadLine(), out EntryDoor);
            builder.EntryDoor(EntryDoor);

            Console.WriteLine("Enter the number of rooms: ");
            int.TryParse(Console.ReadLine(), out RoomNumber);
            builder.RoomNumber(RoomNumber);

            Console.WriteLine("Does the house have a garden? (yes/no): ");
            string hasGarden = Console.ReadLine();
            if (hasGarden.ToUpper() == "Yes")
            {
                builder.Garden(Garden);
            }
            else
            {
                builder.Garden(!Garden);
            }

            Console.WriteLine("Does the house have a swimming pool? (yes/no): ");
            string hasPool = Console.ReadLine();
            if (hasPool.ToUpper() == "Yes")
            {
                builder.SwimmingPool(Pool);
            }
            else
            {
                builder.SwimmingPool(!Pool);
            }
            FloorType.ChooseFloorType(ref builder);
            KitchenType.ChooseKitchenType(ref builder);
            RoofType.ChooseRoofType(ref builder);

        }
    }
