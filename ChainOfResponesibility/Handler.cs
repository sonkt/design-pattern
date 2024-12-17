namespace ChainOfResponesibility;

/// <summary>
/// Lớp trừu tượng (base) để khai báo các handler.
/// Bên trong bao gồm 
/// + Một thuộc tính _nextHandler để khai báo Handler kế tiếp sẽ xử lý yêu cầu.
/// + Một hàm để gán handler kế tiếp
/// + Một phương thức xử lý Yêu cầu theo logic của từng handler khác nhau.
/// </summary>
public abstract class Handler{
    protected Handler? _nextHandler;
    public void SetNext(Handler handler){
        _nextHandler = handler;
    }
    public abstract CheckResult HandleRequest(Student student);
}