namespace DesignPattern
{
    /// <summary>
    /// Command bật đèn
    /// </summary>
    public class LightOnCommand : Command
    {
        private readonly Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}