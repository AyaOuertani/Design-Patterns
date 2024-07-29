using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Interface
{
    public interface IVehicle
    {
        
        public double CalculateRentalCost(int days);
        public string VehiculeFullDescription();
        public int Day { get; set; }
    }
}
