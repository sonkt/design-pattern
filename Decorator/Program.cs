namespace Decorator;
// Decorator là một design pattern thuộc nhóm Structural Design patterns, cho phép bạn mở rộng hoặc thay đổi chức năng của một đối tượng một cách linh hoạt
// mà không thay đổi mã nguồn của lớp gốc hoặc ảnh hưởng đến các đối tượng khác cùng loại.
// Decorator thường được sử dụng để thêm các hành vi mới cho một đối tượng hiện tại trong runtime mà không cần tạo một lớp kế thừa từ lớp gốc.

// Ví dụ này sẽ minh họa chức năng gửi thông báo sử dụng nhiều hình thức thông báo mở rộng từ một hình thức thông báo ban đầu ra màn hình.
static class Program
{
    static void Main()
    {
        // Dòng này là để show tiếng Việt font Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("[x] From main: Minh họa tổng hợp các chức năng được đính kèm vào đối tượng basic ban đầu");
        // Tạo đối tượng từ lớp cơ sở
        INotifier allNotifier = new BasicNotifier();

        // Mở rộng thêm chức năng gửi Sms đi kèm với in lên màn hình trong lớp basic
        allNotifier = new SmsNotifier(allNotifier);

        // Mở rộng thêm chức năng gửi Email đi kèm với 2 chức năng trước đó
        allNotifier = new EmailNotifier(allNotifier);

        // Bổ sung thêm thức năng ghi log sau khi thông báo
        allNotifier = new LogNotifier(allNotifier);

        // Bổ sung thêm chức năng mã hóa và phương thức mở rộng để giải mã
        allNotifier = new EncryptNotifier(allNotifier);

        allNotifier.Send("OK OK");

        // Giải mã:
        Console.WriteLine(((EncryptNotifier)allNotifier).DecryptMessage("T0sgT0s="));
    }
}