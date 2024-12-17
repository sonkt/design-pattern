namespace Observer;

/// <summary>
/// Interface này khai báo các phương thức để quản lý (thêm, xóa, thông báo) các đối tượng theo dõi
/// </summary>
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}