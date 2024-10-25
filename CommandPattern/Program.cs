namespace DesignPattern
{
    /// <summary>
    /// Mục đích chính của Command pattern là đóng gói một yêu cầu dưới dạng một đối tượng, qua đó cho phép tham số hóa các đối tượng khác với các yêu cầu khác nhau, hàng đợi 
    /// hoặc ghi lại các lệnh và hỗ trợ hủy bỏ các lệnh.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Dòng này là để show tiếng Việt font Unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khai báo đối tượng thực thi
            var light = new Light();
            // Khai báo command để bật đèn
            var onCommand = new LightOnCommand(light);
            // Khai báo command để tắt đèn
            var offCommand = new LightOffCommand(light);

            // Khai báo đối tượng điều khiển
            var remote = new RemoteControl();
            // Thiết lập command là bật đèn
            remote.SetCommand(onCommand);
            // Chạy lệnh bật đèn của Remote

            remote.PressOnOff();

            // Thiết lập command là tắt đèn
            remote.SetCommand(offCommand);
            // Chạy lệnh bật đèn của Remote

            remote.PressOnOff();
        }
    }
}