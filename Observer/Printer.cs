namespace DesignPattern
{
    public class Printer : IObserver
    {
        private string _name;
        public Printer(string name)
        {
            _name = name;
        }
        /// <summary>
        /// Action của Observer
        /// </summary>
        /// <param name="message"></param>
        public void DisplayMessage(string message)
        {
            Console.WriteLine("[x] Máy in {0} in nội dung: {1} ra giấy", _name, message);
        }
    }
}