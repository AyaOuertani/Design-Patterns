using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.HouseProduct
{
    public class House
    {
        public int EntryDoor;
        public int RoomNumber;
        public string FlooringType;
        public string RoofType;
        public string KitchenStyle;
        public bool Garden;
        public bool SwimmingPool;
        public string HouseDesign()
        {
            return $"Home Design : Entry Door : {EntryDoor}\nRoom Number : {RoomNumber}\nFlooring Type : {FlooringType}\nRoof Type :{RoofType}\nKitchenStyle : {KitchenStyle}\nGarden:{Garden}\nSwimming Pool : {SwimmingPool}";
        }
    }
}
