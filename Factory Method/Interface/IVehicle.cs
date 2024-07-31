namespace Factory_Method.Interface
{
    public interface IVehicle
    {
        public int Days { get; set; }
        public double CalculateRentalCost();
        public string VehiculeFullDescription();
    }
}
