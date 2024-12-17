namespace Observer;

// Interface cung cấp mẫu object chuẩn cho các đối tượng lắng nghe (theo dõi).
// Interface này khai báo 1 method là DisplayMessage(string message) hiển thị thông tin khi các observer nhận được notify
public interface IObserver
{
    void DisplayMessage(string message);
}