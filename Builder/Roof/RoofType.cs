using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Roof
{
    public class RoofType
    {
        public static void ChooseRoofType(ref IHouseBuilder builder)
        {
            Console.WriteLine("Choose roof type:");
            Console.WriteLine("1. Gable");
            Console.WriteLine("2. Flat");
            Console.WriteLine("3. Green Roof");
            int.TryParse(Console.ReadLine(), out int roofTypeChoice);
            switch (roofTypeChoice)
            {
                case 1:
                    builder.RoofType("Gable");
                    break;
                case 2:
                    builder.RoofType("Flat");
                    break;
                case 3:
                    builder.RoofType("Green Roof");
                    break;
                default:
                    Console.WriteLine("Default roof type will be used.");
                    break;
            }
        }
    }
}
