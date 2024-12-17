namespace Decorator;

/// <summary>
/// Interface chứa mẫu đối tượng và khai báo phương thức của đối tượng.
/// </summary>
public interface INotifier
{
    void Send(string message);
}