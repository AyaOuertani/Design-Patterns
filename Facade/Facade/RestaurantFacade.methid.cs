using Facade.SubSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facade
{
    public partial class RestaurantFacade
    {
        public RestaurantFacade()
        {
            _MenuManagement = new MenuManagement();
            _OrderProcessing = new OrderProcessing();
            _DeleveryManagement = new DeleveryManagement();
        }
        public List<Dish> GetMenu() => _MenuManagement.GetMenu();
        public Order CreateOrder(List<Dish> dishes)
        {
            return _OrderProcessing.CreateOrder(dishes);
        }
        public void CheckOrder(int orderRef) => _OrderProcessing.ShowOrderDetails(orderRef);
        public string TrackOrder(int orderRef)
        {
            _DeleveryManagement.AsignDriver(orderRef);
            return _DeleveryManagement.TrackDelivery(orderRef);
        }

        public void ConfirmDelivery(int orderRef) => _DeleveryManagement.ConfirmDelivery(orderRef);
    }
}
