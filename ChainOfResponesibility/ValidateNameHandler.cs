namespace DesignPattern
{
    public class ValidateNameHandler : Handler
    {
        public override CheckResult HandleRequest(Student student)
        {
            var result = new CheckResult
            {
                IsValid = true,
                Messages = new List<string> { }
            };
            if (string.IsNullOrEmpty(student.FullName))
            {
                result.IsValid = false;
                result.Messages.Add("Họ tên không để trống");
            }
            
            // Kiểm tra xem nếu có Handler kế tiếp thì truyền hành động cho Handler kế tiếp xử lý
            // Sau đó nhận kết quả và gom vào với kết quả của handler hiện tại.
            if (_nextHandler != null)
            {
                var nextResult = _nextHandler.HandleRequest(student);
                result.IsValid = result.IsValid &&  nextResult.IsValid;
                result.Messages.AddRange(nextResult.Messages??new List<string>{});
            }
            return result;
        }
    }
}