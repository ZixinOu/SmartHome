namespace SmartHome.Tests;

public class DummyOutput : IOutput
{
    public string LastMessage = "";

    public void Write(string message)
    {
        LastMessage = message;
    }
}
