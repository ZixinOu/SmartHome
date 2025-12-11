using SmartHome;

namespace TestSmartHome;

[TestClass]
public class TestBedroom
{
    [TestMethod]
    public void Update_TemperatureLowerThanTarget_ActivatesHeating()
    {
        // Arrange
        var bathroom = new Bedroom();
        bathroom.TargetTemperature = 23;
        var weatherData = new WeatherData { Temperature = 20 };

        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        bathroom.Update(weatherData);

        // Assert
        var output = writer.ToString();
        Assert.Contains("[Schlafzimmer] Heating activated.", output);
    }
    
    [TestMethod]
    public void Update_LowerBlindsWhenTooHot()
    {
        // Arrange
        var bathroom = new Bedroom();
        bathroom.TargetTemperature = 20;
        var weatherData = new WeatherData { Temperature = 23 };

        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        bathroom.Update(weatherData);

        // Assert
        var output = writer.ToString();
        Assert.Contains("[Schlafzimmer] Blinds lowered.", output);
    }
}