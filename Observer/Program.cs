namespace Observer;

static class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Tạo đối tượng Subject
        var cpu = new CPU();
        // Tạo các Observer
        var monitor1 = new Monitor("Monitor 1");
        var monitor2 = new Monitor("Monitor 2");
        var printer1 = new Printer("Printer 1");
        var printer2 = new Printer("Printer 2");
        // Đăng ký các observer vào subject
        cpu.Attach(monitor1);
        cpu.Attach(monitor2);
        cpu.Attach(printer1);
        cpu.Attach(printer2);
        // Notify messaage tới các observer từ subject
        cpu.PushMessage("Test thử nội dung");

        cpu.Detach(monitor1);
        cpu.Detach(printer2);
        cpu.PushMessage("Test thử sau khi hủy đăng ký 2 Observer");
    }
}