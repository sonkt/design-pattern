namespace DesignPattern
{
    /// <summary>
    /// Chain Of Responsibility (CoR) là mật Pattern thuộc nhóm Pattern Hành Vi trong Gang Of Four.
    /// CoR cho phép bạn chuyển một yêu cầu dọc theo một chuỗi các handler. Mỗi handler xử lý theo một
    /// logic riêng của chúng sau đó chuyển cho Handler tiếp theo thực thi.
    /// Chuỗi yêu cầu này có thể kết thúc khi xử lý hết các handler hoặc có thể dừng tại một handler nào đó
    /// khi gặp điều kiện phù hợp.
    /// 
    /// Khi nào nên sử dụng CoR
    ///    + Khi bạn có nhiều handler cùng tham gia vào xử lý một logic nào đó. Việc quyết định handler nào xử lý hoặc tất cả
    ///      được quyết định runtime.
    ///    + Khi yêu cầu được thực hiện qua nhiều bước mà mỗi bước là độc lập. Khi một trong các bước có sự thay đổi về code sẽ
    ///      không làm ảnh hưởng đến code của các bước khác.
    /// Ví dụ dưới đây xây dựng 3 Handler để validate thông tin của 1 học viên.
    /// Các thông tin được validate tuần tự và ghi lại kết quả ở từng bước.
    /// Sau khi thực hiện sẽ trả ra kết quả ở từng bước 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Dòng này là để show tiếng Việt font Unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khai báo đối tượng cần check
            var student = new Student
            {
                FullName = "Khiếu Trịnh Gia Bảo",
                Code = "",
                Marks = new Mark
                {
                    Mathematical = 0,
                    Literature = -1,
                    ForeignLanguage = 0
                }
            };
            // Khai báo 3 handler
            var nameHandler = new ValidateNameHandler();
            var codeHandler = new ValidateCodeHandler();
            var markHandler = new ValidateMarkHandler();

            // Thiết lập thứ tự thực hiện các handler
            nameHandler.SetNext(codeHandler);
            codeHandler.SetNext(markHandler);
            // Khởi động chuỗi handler
            var result = nameHandler.HandleRequest(student);

            // Kiểm tra kết quả và show ra màn hình.
            if (result.IsValid)
            {
                Console.WriteLine("Thông tin học viên đã đầy đủ");
            }
            else
            {
                string mess = string.Join("\n  + ", result.Messages ?? new List<string> { });
                Console.WriteLine($"Thông tin học viên chưa đầy đủ. \nVui lòng hoàn thiện những phần sau:\n  + {mess}");
            }
        }
    }
}