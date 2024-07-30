namespace Builder.PizzaProduct
{
    public class Pizza
    {
        public string Size;
        public string Type;
        public string Cheese;
        public List<string> Toppings;
        public decimal TotalCost;

        public void AddTopping(string topping) => Toppings.Add(topping);
        public void CalculateTotalCost()
        {
            TotalCost = 0;
            switch (Size)
            {
                case "Small":
                    TotalCost += 10;
                    break;
                case "Medium":
                    TotalCost += 15;
                    break;
                case "Large":
                    TotalCost += 20;
                    break;
            }
            switch (Cheese)
            {
                case "Chedar":
                    TotalCost += 2;
                    break;
                case "Mozzarella":
                    TotalCost += 3;
                    break;
            }
            TotalCost += Toppings.Count * 2;
        }
        public string Orderetails()
        {
            return $"Pizza {Type} :\nSize:{Size}\nCheese:{Cheese}\nToppings:{string.Join(',', Toppings)}\nTotal Cost :{TotalCost}";
        }
    }
}
