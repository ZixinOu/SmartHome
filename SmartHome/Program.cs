using System.Timers;

namespace SmartHome
{
   
class Program
    {
        static void Main(string[] args)
        {
            HomeSimulation homeSimulation = new HomeSimulation();
            homeSimulation.Run();
        }
    }

    class HomeSimulation
    {
        private System.Timers.Timer simulationTimer;
        private WeatherSimulator weatherSimulator;
        private List<Room> rooms;

        public HomeSimulation()
        {
            weatherSimulator = new WeatherSimulator();
            rooms = new List<Room>
            {
                new Kitchen(),
                new Bathroom(),
                new LivingRoom(),
                new Bedroom(),
                new WinterGarden()
            };
            simulationTimer = new System.Timers.Timer(1000); 
            simulationTimer.Elapsed += OnSimulationTick;
        }

        public void Run()
        {
            Console.WriteLine("Home Automation Simulation started.");
            simulationTimer.Start();
            Console.ReadLine(); 
        }

        private void OnSimulationTick(object sender, ElapsedEventArgs e)
        {
            WeatherData weatherData = weatherSimulator.GenerateWeather();
            Console.WriteLine(weatherData);

            foreach (var room in rooms)
            {
                room.Update(weatherData);
            }
        }
    }

    class WeatherSimulator
    {
        private Random random = new Random();

        public WeatherData GenerateWeather()
        {
            return new WeatherData
            {
                Temperature = random.Next(-10, 36),
                WindSpeed = random.Next(0, 50),
                IsRaining = random.Next(0, 2) == 1
            };
        }
    }
}