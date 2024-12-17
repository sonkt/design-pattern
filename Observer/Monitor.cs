namespace Observer;

public class Monitor : IObserver
{
    private string _name;
    public Monitor(string name)
    {
        _name = name;
    }
    /// <summary>
    /// Action của OPbserver
    /// </summary>
    /// <param name="message"></param>
    public void DisplayMessage(string message)
    {
        Console.WriteLine("[x] Màn hình {0} hiển thị nội dung: {1}", _name, message);
    }
}