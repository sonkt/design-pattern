namespace Decorator;

/// <summary>
/// Lớp mở rộng của message bất kỳ thuộc họ INotifier tích hợp thêm tính năng gửi SmS
/// </summary>
public class SmsNotifier : NotifyDecorator
{
    public SmsNotifier(INotifier notifier) : base(notifier)
    {
    }
    public override void Send(string message)
    {
        _notifier.Send(message);
        Console.WriteLine($"[x] {this.GetType().Name}: Sms({message})");
    }
}