using Builder.Interface;

namespace Builder.Roof
{
    public class RoofType
    {
        public static string RoofTypes;
        public static void ChooseRoofType(ref IHouseBuilder builder)
        {
            Console.WriteLine("Choose roof type:");
            Console.WriteLine("1. Gable\n2. Flat\n3. Green Roof");
            int.TryParse(Console.ReadLine(), out int roofTypeChoice);
            switch (roofTypeChoice)
            {
                case 1:
                    RoofTypes = "Gable";
                    break;
                case 2:
                    RoofTypes = "Flat";
                    break;
                case 3:
                    RoofTypes = "Green Roof";
                    break;
                default:
                    Console.WriteLine("Default roof type will be used.");
                    break;
            }
            builder.RoofType(RoofTypes);

        }
    }
}
