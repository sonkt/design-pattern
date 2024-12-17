namespace Decorator;

/// <summary>
/// Decorate abstract được tạo ra để cung cấp mẫu cho các decorator khác.
/// </summary>
public abstract class NotifyDecorator : INotifier
{
    // Thuộc tính chứa object của lớp cần được mở rộng.
    protected INotifier _notifier;
    protected NotifyDecorator(INotifier notifier)
    {
        _notifier = notifier;
    }
    public abstract void Send(string message);
}