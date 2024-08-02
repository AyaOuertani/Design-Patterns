using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SubSystem
{
    public class Order
    {
        public int OrderReference { get; set; }
        public List<Dish> Dishes { get; set; }
        public DateTime OrderDate { get; set; }
        public Order(int orderReference, List<Dish> dishes, DateTime orderDate)
        {
            OrderReference = orderReference;
            Dishes = dishes;
            OrderDate = orderDate;
        }
    }
}
