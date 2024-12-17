namespace ChainOfResponesibility;

public class ValidateMarkHandler : Handler
{
    public override CheckResult HandleRequest(Student student)
    {
        var result = new CheckResult
        {
            IsValid = true,
            Messages = new List<string>()
        };
        if (student == null)
        {
            result.IsValid = false;
            result.Messages.Add("Vui lòng nhập thông tin học viên");
        }
        else if (student.Marks == null)
        {
            result.IsValid = false;
            result.Messages.Add("Vui lòng nhập thông tin điểm của học viên");
        }
        else
        {
            if (student.Marks.Mathematical < 0)
            {
                result.IsValid = false;
                result.Messages.Add("Điểm toán phải >=0");
            }
            if (student.Marks.Literature < 0)
            {
                result.IsValid = false;
                result.Messages.Add("Điểm văn phải >=0");
            }

            if (student.Marks.ForeignLanguage < 0)
            {
                result.IsValid = false;
                result.Messages.Add("Điểm ngoại ngữ phải >=0");
            }
            // Kiểm tra xem nếu có Handler kế tiếp thì truyền hành động cho Handler kế tiếp xử lý
            // Sau đó nhận kết quả và gom vào với kết quả của handler hiện tại.
            if (_nextHandler != null)
            {
                var nextResult = _nextHandler.HandleRequest(student);
                result.IsValid = result.IsValid && nextResult.IsValid;
                result.Messages.AddRange(nextResult.Messages?? new List<string>());
            }
        }
        return result;
    }
}