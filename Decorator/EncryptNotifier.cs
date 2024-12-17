namespace Decorator;

public class EncryptNotifier : NotifyDecorator
{
    public EncryptNotifier(INotifier notifier) : base(notifier)
    {
    }

    private string Encrypt(string plainText)
    {
        // Giả lập mã hóa
        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(plainText));
    }

    // Phương thức mới để giải mã thông điệp
    public string DecryptMessage(string encryptedText)
    {
        // Giả lập giải mã
        byte[] decodedBytes = Convert.FromBase64String(encryptedText);
        return System.Text.Encoding.UTF8.GetString(decodedBytes);
    }

    public override void Send(string message)
    {
        var mess = Encrypt(message);
        _notifier.Send(mess);
        Console.WriteLine($"[x] {this.GetType().Name}: Mã hóa({mess})");
    }
}