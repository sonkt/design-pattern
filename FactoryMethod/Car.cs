namespace FactoryMethod;

public class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine($"Tôi lái chiếc ô tô có tên là {Name}");
    }
}