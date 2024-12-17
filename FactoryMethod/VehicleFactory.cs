namespace FactoryMethod;

// Lớp trừu tượng để tạo đối tượng Vehicle
// Trong lớp này có 1 phương thức để trả về đối tượng thuộc kiểu Vehicle
public abstract class VehicleFactory
{
    public abstract Vehicle CreateVehicle(string name);
}