using Composite.Interface;
using System.Text;

namespace Composite.Package
{
    public class ProductPackage : IProduct
    {
        private List<IProduct> _Products = new List<IProduct>();
        private string _PackageName;
        public ProductPackage(string packageName)
        {
            _PackageName = packageName;
        }
        public string AddProduct(IProduct product)
        {
            _Products.Add(product);
            return "Added Successfully !";
        }
        public string RemoveProduct(IProduct product)
        {
            _Products.Remove(product);
            return "Deleted Successfully !";
        }
        public decimal GetPrice()
        {
            decimal total = 0;
            foreach (IProduct product in _Products)
            {
                total += product.GetPrice();
            }
            return total;
        }

        public string GetDescription()
        {
            string description = _PackageName + ": ";
            foreach (var product in _Products)
            {
                description += product.GetName() + ", ";
            }
            return description;
        }
        public string GetName() => _PackageName;
        public void DisplayProductInfo()
        {
            Console.WriteLine($"{GetName()}  Total: ${GetPrice()}");
            foreach (var product in _Products)
            {
                product.DisplayProductInfo();
            }
        }
    }
}
