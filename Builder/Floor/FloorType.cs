﻿using Builder.Interface;

namespace Builder.Floor
{
    public class FloorType
    {
        public static string FlooringType;
        public static void ChooseFloorType(ref IHouseBuilder builder)
        {
            Console.WriteLine("Choose flooring type:");
            Console.WriteLine("1. Marble\n2. Hardwood\n3. Bamboo\n4. Polished Concrete");
            int.TryParse(Console.ReadLine(), out int flooringChoice);

            switch (flooringChoice)
            {
                case 1:
                    FlooringType = "Marble";
                    break;
                case 2:
                    FlooringType = "Hardwood";
                    break;
                case 3:
                    FlooringType = "Bamboo";
                    break;
                case 4:
                    FlooringType = "Polished Concrete";
                    break;
                default:
                    Console.WriteLine("Default flooring will be used.");
                    break;
            }
            builder.FlooringType(FlooringType);
        }
    }
}
