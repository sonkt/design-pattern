namespace FactoryMethod;

//Factory Method là một design pattern thuộc nhóm creational patterns, cho phép bạn tạo đối tượng mà không cần chỉ định lớp chính xác của đối tượng đó. 
//Thay vào đó, các lớp con sẽ quyết định kiểu đối tượng cụ thể nào sẽ được tạo. Điều này giúp mã linh hoạt và dễ dàng mở rộng khi cần tạo thêm nhiều loại đối tượng mới.
static class Program
{
    static void Main()
    {
        // Dòng này là để show tiếng Việt font Unicode
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Tạo object Factory từ lớp CarFactory
        VehicleFactory factory = new CarFactory();
        // Tạo Object car từ Factory
        var car = factory.CreateVehicle("Mẹc");
        // Đổi object Factory sang Moto (chỗ này có thể tạo factory mới)
        factory = new MotobikeFactory();
        // Tạo moto từ factory bên trên sau khi đổi
        var moto = factory.CreateVehicle("Ngáo");
        // Sử dụng 2 object vừa tạo ra.
        car.Drive();
        moto.Drive();
    }
}