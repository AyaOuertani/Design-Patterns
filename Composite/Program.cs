using Composite.Interface;
using Composite.SingleProduct;
using Composite.Package;
public class Program
{
    public static void Main()
    {

        IProduct book = new SingleProd("C# Programming Guide", 29);
        IProduct laptop = new SingleProd("Laptop Model X", 999);
        IProduct mouse = new SingleProd("Wireless Mouse", 20);


        ProductPackage techPackage = new ProductPackage("Tech Package");
        techPackage.AddProduct(laptop);
        techPackage.AddProduct(mouse);

       
        ProductPackage holidayGift = new ProductPackage("Holiday Gift Package");
        holidayGift.AddProduct(book);
        holidayGift.AddProduct(techPackage);


        Console.WriteLine("Products available:");
        holidayGift.DisplayProductInfo();
        holidayGift.GetDescription();

        Console.WriteLine($"Total Price: ${holidayGift.GetPrice()}");
    }
}
