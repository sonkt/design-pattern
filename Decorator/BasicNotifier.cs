namespace Decorator;

/// <summary>
/// Lớp cơ sở ban đầu Implement Interface của nó
/// </summary>
public class BasicNotifier : INotifier
{
    /// <summary>
    /// Chức năng gửi thông báo cơ bản lên màn hình
    /// </summary>
    /// <param name="message"></param>
    public void Send(string message)
    {
        Console.WriteLine($"[x] {this.GetType().Name}: Notify({message})");
    }
}