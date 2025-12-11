using SmartHome;

namespace TestSmartHome;

[TestClass]
public class TestMarkisensteuerung
{
    [TestMethod]
    public void Markise_wird_ausgefahren_wenn_Bedingungen_erfuellt()
    {
        // Arrange
        var room = new TestRoom("Wohnzimmer");
        var sut = new Markisensteuerung(room);

        var sw = new StringWriter();
        Console.SetOut(sw);

        double externalTemp = 30;
        double roomTemp = 22;
        double windSpeed = 20;
        bool isRaining = false;

        // Act
        sut.Operate(externalTemp, roomTemp, windSpeed, isRaining, false);

        // Assert
        string output = sw.ToString();
        Assert.Contains("Markise wird ausgefahren", output);
    }

    [TestMethod]
    public void Markise_wird_eingefahren_wenn_Wind_zu_stark()
    {
        // Arrange
        var room = new TestRoom("Wohnzimmer");
        var sut = new Markisensteuerung(room);

        var sw = new StringWriter();
        Console.SetOut(sw);

        double externalTemp = 30;
        double roomTemp = 22;
        double windSpeed = 40;
        bool isRaining = false;

        // Act
        sut.Operate(externalTemp, roomTemp, windSpeed, isRaining, false);

        // Assert
        string output = sw.ToString();
        Assert.Contains("Markise wird eingefahren", output);
    }

    [TestMethod]
    public void Markise_wird_eingefahren_wenn_es_regnet()
    {
        // Arrange
        var room = new TestRoom("Wohnzimmer");
        var sut = new Markisensteuerung(room);

        var sw = new StringWriter();
        Console.SetOut(sw);

        double externalTemp = 30;
        double roomTemp = 22;
        double windSpeed = 10;
        bool isRaining = true;

        // Act
        sut.Operate(externalTemp, roomTemp, windSpeed, isRaining, false);

        // Assert
        string output = sw.ToString();
        Assert.Contains("Markise wird eingefahren", output);
    }
}