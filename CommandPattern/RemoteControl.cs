namespace DesignPattern
{
    // Class thiết lập đối tượng điều khiển command
    public class RemoteControl
    {
        private Command _command;
        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Phương thức thể hiện hành động
        public void PressOnOff()
        {
            _command.Execute();
        }
    }
}