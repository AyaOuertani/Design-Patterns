using Composite.Interface;

namespace Composite.SingleProduct
{
    public class SingleProd : IProduct
    {
        private readonly string _Name;
        private readonly decimal _Price;
        public SingleProd(string name, decimal price)
        {
            _Name = name;
            _Price = price;
        }
        public decimal GetPrice() => _Price;
        public string GetName() => _Name;
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product :\nName:{GetName()}\nPrice:{GetPrice()}");
        }
    }
}
