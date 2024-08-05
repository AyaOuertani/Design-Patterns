using State.Context;

namespace State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var trafficLight = new TraficLightContext();
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Cicle{i + 1}");
                trafficLight.Request();
            }
        }
    }
}