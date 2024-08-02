namespace Facade.SubSystem
{
    public class MenuManagement
    {
        private List<Dish> _dishes;

        public MenuManagement()
        {
            _dishes = new List<Dish>
            {
                new Dish ("Pizza",12.99m, "Delicious cheese pizza" ),
                new Dish ( "Burger", 10.99m, "Juicy beef burger" ),
                new Dish ("Pasta", 15.99m, "Pasta with pesto sauce")
            };
        }
        public List<Dish> GetMenu()
        {
            return _dishes;
        }
        public string AddDish(Dish dish)
        {
            _dishes.Add(dish);
            return "Added Successfully";
        }
        public string RemoveDish(Dish dish)
        {
            _dishes.Remove(dish);
            return "Removed Successfully";
        }
        public string UpdateDish(Dish dish)
        {
            Dish? existingDish = _dishes.Find(d => d.Name.ToUpper() == dish.Name.ToUpper());
            if (existingDish == null)
            {
                throw new KeyNotFoundException("Dish Not Found !");
            }
            existingDish.Price = dish.Price;
            existingDish.Description = dish.Description;
            return "Updated Successfully !";

        }
    }
}
