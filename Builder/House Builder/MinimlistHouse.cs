using Builder.HouseProduct;
using Builder.Interface;

namespace Builder.House_Builder
{
    public class MinimlistHouse : IHouseBuilder
    {
        private House _house = new();
        public void EntryDoor(int entryDoor)
        {
            _house.EntryDoor = entryDoor;
        }
        public void RoomNumber(int roomNumber)
        {
            _house.RoomNumber = roomNumber;
        }
        public void FlooringType(string flooringType )
        {
            _house.FlooringType = flooringType;

        }
        public void RoofType(string roofType )
        {
            _house.RoofType = roofType;
        }
        public void KitchenStyle(string kitchenStyle)
        {
            _house.KitchenStyle = kitchenStyle;
        }
        public void Garden(bool garden)
        {
            _house.Garden = true;
        }
        public void SwimmingPool(bool swimmingPool)
        {
            _house.SwimmingPool = true;
        }
        public House HouseBuilding()
        {
            return _house;
        }
    }
}
