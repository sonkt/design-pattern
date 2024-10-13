namespace DesignPattern
{
    /// <summary>
    /// Handler kiểm tra Mã học viên
    /// </summary>
    public class ValidateCodeHandler : Handler
    {
        public override CheckResult HandleRequest(Student student)
        {
            // Khai báo biến chứa kết quả trả về
            var result = new CheckResult
            {
                IsValid = true,
                Messages = new List<string> { }
            };
            // Kiểm tra nếu Mã trống thì gán giá trị kết quả trả về
            if (string.IsNullOrEmpty(student.Code))
            {
                result.IsValid = false;
                result.Messages.Add("Mã không để trống");
            }
            // Kiểm tra xem nếu có Handler kế tiếp thì truyền hành động cho Handler kế tiếp xử lý
            // Sau đó nhận kết quả và gom vào với kết quả của handler hiện tại.
            if (_nextHandler != null)
            {
                var nextResult = _nextHandler.HandleRequest(student);
                result.IsValid = result.IsValid && nextResult.IsValid;
                result.Messages.AddRange(nextResult.Messages?? new List<string>{});
            }
            // Trả và kết quả
            return result;
        }
    }
}