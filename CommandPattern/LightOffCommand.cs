namespace CommandPattern;

/// <summary>
/// Command tắt đèn
/// </summary>
public class LightOffCommand : Command
{
    private readonly Light _light;
    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}