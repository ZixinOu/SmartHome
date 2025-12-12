namespace SmartHome.Tests;

public class FakeOutput : IOutput
{
    public string LastMessage = "";

    public void Write(string message)
    {
        LastMessage = message;
    }
}
