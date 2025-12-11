using SmartHome;

namespace TestSmartHome;

[TestClass]
public class HeatingVentTests
{
    [TestMethod]
    public void HeatingVent_Oeffnet_wenn_Aussentemperatur_zu_tief()
    {
        // Arrange
        var room = new TestRoom("Wohnzimmer") { TargetTemperature = 22 };
        var vent = new HeatingVent(room);

        var output = new StringWriter();
        Console.SetOut(output);

        double externalTemp = 15; 

        // Act
        vent.Operate(externalTemp, room.TargetTemperature, 0, false, false);

        // Assert
        Assert.Contains("Heizungsventil wird geöffnet", output.ToString());
    }

    [TestMethod]
    public void HeatingVent_Schliesst_wenn_Temperatur_ausreichend()
    {
        // Arrange
        var room = new TestRoom("Wohnzimmer") { TargetTemperature = 22 };
        var vent = new HeatingVent(room);

        vent.Operate(15, room.TargetTemperature, 0, false, false);

        var output = new StringWriter();
        Console.SetOut(output);

        // Act 
        vent.Operate(25, room.TargetTemperature, 0, false, false);

        // Assert
        Assert.Contains("Heizungsventil wird geschlossen", output.ToString());
    }
}