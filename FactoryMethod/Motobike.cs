namespace FactoryMethod;

public class Motobike : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine($"Tôi lái chiếc xe máy có tên là {Name}");
    }
}