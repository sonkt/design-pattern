namespace FactoryMethod;

// Lớp trừu tượng Vehicle chứa cấu trúc chung của các đối tượng sẽ được sử dụng.
// Trong ví dụ này có 1 phương thức là Drive, 1 phương thức SetName và 1 thuộc tính là Name
// Có 1 constructor để khởi tạo đối tượng.
public abstract class Vehicle
{
    public virtual Vehicle SetName(string name)
    {
        Name = name;
        return this;
    }
    public virtual string Name { get; protected set; }
    public abstract void Drive();
}