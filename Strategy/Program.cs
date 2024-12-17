namespace Strategy;

/// <summary>
/// Strategy Pattern là mật Pattern thuộc nhóm Behavioral Pattern trong Gang Of Four.
/// Strategy pattern được sử dụng để định nghĩa một họ các thuật toán, đóng gói và sử dụng thay thế cho nhau khi cần.
/// Từ đó giúp code của bạn linh hoạt trong việc thay đổi các thuật toán xử lý có cùng 1 bài toán runtime mà không cần thay đổi code
/// </summary>
static class Program
{
    static void Main()
    {
        // Dòng này là để show tiếng Việt font Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khai báo đối tượng thực thi
        var executor = new Executor();
        executor.SetData("Haha");
        // Thiết lập thuật toán xử lý
        executor.SetAlgorithm(new FirstAlgorithm());
        // Thực thi method của thuật toán
        executor.Execute();
        // Đổi sang thuật toán khác cho cùng 1 object executor ban đầu
        executor.SetAlgorithm(new SecondAlgorithm());
        // Thực thi method với thuật toán mới
        executor.Execute();
    }
}