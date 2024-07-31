using Builder.Interface;

namespace Builder.Kitchen
{
    public class KitchenType
    {
        public static string KitchenStyle;
        public static void ChooseKitchenType(ref IHouseBuilder builder)
        {
            Console.WriteLine("Choose kitchen style:");
            Console.WriteLine("1. Modern\n2. Classic\n3. Eco\n4. Minimalist");
            int.TryParse(Console.ReadLine(), out int kitchenStyleChoice);
            switch (kitchenStyleChoice)
            {
                case 1:
                    KitchenStyle = "Modern";
                    break;
                case 2:
                    KitchenStyle = "Classic";
                    break;
                case 3:
                    KitchenStyle = "Eco";
                    break;
                case 4:
                    KitchenStyle = "Minimalist";
                    break;
                default:
                    Console.WriteLine("Default kitchen style will be used.");
                    break;
                
            }
            builder.KitchenStyle(KitchenStyle);

        }
    }
}
