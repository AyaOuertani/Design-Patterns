using Builder.HouseProduct;
using Builder.Interface;

namespace Builder.House_Director
{
    public class HouseDirector
    {
        private IHouseBuilder _builder;
        public void SetBuilder(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public House ConstructLuxeryHouse(int entryDoor, int roomNumber, string flooringType, string kitchenStyle, string roofType, bool garden = true, bool pool = true)
        {
            _builder.EntryDoor(entryDoor);
            _builder.RoomNumber(roomNumber);
            _builder.FlooringType(string.IsNullOrEmpty(flooringType) ? "Marbel" : flooringType);
            _builder.KitchenStyle(string.IsNullOrEmpty(kitchenStyle) ? "Modern" : kitchenStyle);
            _builder.RoofType(string.IsNullOrEmpty(roofType) ? "Gable" : roofType);
            _builder.Garden(garden);
            _builder.SwimmingPool(pool);
            return _builder.HouseBuilding();
        }
        public House ConstructEcoyHouse(int entryDoor, int roomNumber, string flooringType, string kitchenStyle, string roofType, bool garden = true, bool pool = false)
        {
            _builder.EntryDoor(entryDoor);
            _builder.RoomNumber(roomNumber);
            _builder.FlooringType(string.IsNullOrEmpty(flooringType) ? "Bamboo" : flooringType);
            _builder.KitchenStyle(string.IsNullOrEmpty(kitchenStyle) ? "Eco" : kitchenStyle);
            _builder.RoofType(string.IsNullOrEmpty(roofType) ? "Green" : roofType);
            _builder.Garden(garden);
            _builder.SwimmingPool(pool);
            return _builder.HouseBuilding();
        }
        public House ConstructMinimilistHouse(int entryDoor, int roomNumber, string flooringType, string kitchenStyle, string roofType, bool garden = false, bool pool = false)
        {
            _builder.EntryDoor(entryDoor);
            _builder.RoomNumber(roomNumber);
            _builder.FlooringType(string.IsNullOrEmpty(flooringType) ? "Polished Concrete" : flooringType);
            _builder.KitchenStyle(string.IsNullOrEmpty(kitchenStyle) ? "Minimalist" : kitchenStyle);
            _builder.RoofType(string.IsNullOrEmpty(roofType) ? "Flat" : roofType);
            _builder.Garden(garden);
            _builder.SwimmingPool(pool);
            return _builder.HouseBuilding();
        }
    }
}
