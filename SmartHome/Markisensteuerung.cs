namespace SmartHome;

public class Markisensteuerung : RoomDecorator
{
    public Markisensteuerung(Room room)
        : base(room)
    {
        HasAwnings = true;
    }

    public override void Operate(
        double externalTemperature,
        double roomTemperature,
        double windSpeed,
        bool isRaining,
        bool peopleInRoom)
    {
        
        if (HasAwnings)
        {
            if (externalTemperature > roomTemperature && windSpeed <= 30 && !isRaining)
            {
                Console.WriteLine($"{Name}: Markise wird ausgefahren.");
            }
            else
            {
                Console.WriteLine($"{Name}: Markise wird eingefahren.");
            }
        }

    }

    public override void Update(WeatherData weatherData)
    {

        base.Update(weatherData);


        Operate(
            weatherData.Temperature,
            weatherData.Temperature,
            weatherData.WindSpeed,
            weatherData.IsRaining,
            IsOccupied);
    }
}
