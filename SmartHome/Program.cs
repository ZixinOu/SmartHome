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
        private WeatherSensor weatherSensor;
        private List<Room> rooms;

        public HomeSimulation()
        {
            weatherSensor = new WeatherSensor();
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
            WeatherData weatherData = weatherSensor.GenerateWeather();
            Console.WriteLine(weatherData);
        }
    }
}