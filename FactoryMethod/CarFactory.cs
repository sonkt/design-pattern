namespace DesignPattern
{
    public class CarFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle(string name)
        {
            return new Car().SetName(name);
        }
    }
}