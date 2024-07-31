using Builder.HouseProduct;

namespace Builder.Interface
{
    public interface IHouseBuilder
    {
        public void EntryDoor(int entryDoor);
        public void RoomNumber(int roomNumber);
        public void FlooringType(string flooringType);
        public void RoofType(string roofType);
        public void KitchenStyle(string kitchenStyle);
        public void Garden(bool garden);
        public void SwimmingPool(bool swimmingPool);
        public House HouseBuilding();
    }
}
