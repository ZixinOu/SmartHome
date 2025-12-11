using SmartHome;

namespace TestSmartHome;

[TestClass]
public class JalousiencontrollerTests
{
    [TestMethod]
    public void Jalousie_faehrt_runter_wenn_heiss_und_keine_Personen()
    {
        // Arrange
        var room = new RoomDummy("Wohnzimmer");
        var ctrl = new Jalousiencontroler(room);

        var output = new StringWriter();
        Console.SetOut(output);

        double externalTemp = 30;
        double roomTemp = 22;
        bool peopleInRoom = false;

        // Act
        ctrl.Operate(externalTemp, roomTemp, 0, false, peopleInRoom);

        // Assert
        Assert.Contains("Jalousie wird runtergefahren", output.ToString());
    }

    [TestMethod]
    public void Jalousie_faehrt_hoch_wenn_Personen_im_Raum()
    {
        // Arrange
        var room = new RoomDummy("Wohnzimmer");
        var ctrl = new Jalousiencontroler(room);

        ctrl.Operate(30, 22, 0, false, false);

        var output = new StringWriter();
        Console.SetOut(output);

        // Act
        ctrl.Operate(30, 22, 0, false, true);

        // Assert
        Assert.Contains("Jalousie wird hochgefahren", output.ToString());
    }
}