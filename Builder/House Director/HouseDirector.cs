using Builder.HouseProduct;
using Builder.Interface;
using System.Reflection.Emit;

namespace Builder.House_Director
{
    public class HouseDirector
    {
        private IHouseBuilder _builder;
        public void SetBuilder(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public House ConstructLuxeryHouse(int entryDoor, int roomNumber,string flooringType= "Marbel", string kitchenStyle= "Modren", string roofType = "Gable", bool garden=true, bool pool = true)
        {
            _builder.EntryDoor(entryDoor);
            _builder.RoomNumber(roomNumber);
            _builder.FlooringType(flooringType);
            _builder.KitchenStyle(kitchenStyle);
            _builder.RoofType(roofType);
            _builder.Garden(garden);
            _builder.SwimmingPool(pool);
            return _builder.HouseBuilding();
        }
        public House ConstructEcoyHouse(int entryDoor, int roomNumber, string flooringType = "Bamboo", string kitchenStyle = "Eco", string roofType = "Green", bool garden = true, bool pool = false)
        {
            _builder.EntryDoor(entryDoor);
            _builder.RoomNumber(roomNumber);
            _builder.FlooringType(flooringType);
            _builder.KitchenStyle(kitchenStyle);
            _builder.RoofType(roofType);
            _builder.Garden(garden);
            _builder.SwimmingPool(pool);
            return _builder.HouseBuilding();
        }
        public House ConstructMinimilistHouse(int entryDoor, int roomNumber, string flooringType = "Polished Concrete", string kitchenStyle = "Minimalist", string roofType = = "Flat", bool garden = false, bool pool = false)
        {
            _builder.EntryDoor(entryDoor);
            _builder.RoomNumber(roomNumber);
            _builder.FlooringType(flooringType);
            _builder.KitchenStyle(kitchenStyle);
            _builder.RoofType(roofType);
            _builder.Garden(garden);
            _builder.SwimmingPool(pool);
            return _builder.HouseBuilding();
        }
    }
}
