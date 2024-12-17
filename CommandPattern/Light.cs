namespace CommandPattern;

// Đối tượng cần điều khiển
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Đã bật đèn");
    }
    public void TurnOff()
    {
        Console.WriteLine("Đã tắt đèn");
    }
}