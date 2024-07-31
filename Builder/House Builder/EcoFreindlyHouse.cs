using Builder.HouseProduct;
using Builder.Interface;

namespace Builder.House_Builder
{
    public class EcoFreindlyHouse : IHouseBuilder
    {
        private readonly House _house = new();
        public void EntryDoor(int entryDoor) => _house.EntryDoor = entryDoor;
        public void RoomNumber(int roomNumber) => _house.RoomNumber = roomNumber;
        public void FlooringType(string flooringType = "Bamboo") => _house.FlooringType = flooringType;
        public void RoofType(string roofType) => _house.RoofType = roofType;
        public void KitchenStyle(string kitchenStyle = "Eco") => _house.KitchenStyle = kitchenStyle;
        public void Garden(bool garden = false) => _house.Garden = garden;
        public void SwimmingPool(bool swimmingPool = false) => _house.SwimmingPool = swimmingPool;
        public House HouseBuilding() => _house;
    }
}
