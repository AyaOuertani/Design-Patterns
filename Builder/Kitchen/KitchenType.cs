using Builder.Interface;

namespace Builder.Kitchen
{
    public class KitchenType
    {
        public static string kitchenStyle;
        public static void ChooseKitchenType(ref IHouseBuilder builder)
        {
            Console.WriteLine("Choose kitchen style:");
            Console.WriteLine("1. Modern");
            Console.WriteLine("2. Classic");
            Console.WriteLine("3. Eco");
            Console.WriteLine("4. Minimalist");
            int.TryParse(Console.ReadLine(), out int kitchenStyleChoice);
            switch (kitchenStyleChoice)
            {
                case 1:
                    kitchenStyle = "Modern";
                    break;
                case 2:
                    kitchenStyle = "Classic";
                    break;
                case 3:
                    kitchenStyle = "Eco";
                    break;
                case 4:
                    kitchenStyle = "Minimalist";
                    break;
                default:
                    Console.WriteLine("Default kitchen style will be used.");
                    break;
                
            }
            builder.KitchenStyle(kitchenStyle);

        }
    }
}
