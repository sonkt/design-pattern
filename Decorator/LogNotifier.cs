namespace DesignPattern
{
    /// <summary>
    /// Lớp mở rộng của message bất kỳ thuộc họ INotifier tích hợp thêm tính năng log
    /// </summary>
    public class LogNotifier : NotifyDecorator
    {
        public LogNotifier(INotifier notifier) : base(notifier)
        {
        }
        public override void Send(string message)
        {
            _notifier.Send(message);
            Console.WriteLine($"[x] Ghi log tại {this.GetType().Name}");
        }
    }
}