using Moq;
using SmartHome;

namespace TestSmartHome;

[TestClass]
public class TestRoom
{
    [TestMethod]
    public void Update_TemperatureLowerThanTarget_ActivatesHeating()
    {
        // Arrange
        var bathroom = new Bathroom();
        bathroom.TargetTemperature = 23;
        var weatherData = new WeatherData { Temperature = 20 };

        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        bathroom.Update(weatherData);

        // Assert
        var output = writer.ToString();
        Assert.Contains("[Bad/WC] Heating activated.", output);
    }
}