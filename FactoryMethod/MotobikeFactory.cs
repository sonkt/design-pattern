namespace FactoryMethod;

public class MotobikeFactory : VehicleFactory
{
    public override Vehicle CreateVehicle(string name)
    {
        return new Motobike().SetName(name);
    }
}