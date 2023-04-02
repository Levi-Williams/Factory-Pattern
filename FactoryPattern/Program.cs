namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = VehicleFactory.GetVehicle(3);

            vehicle.Drive();

        }
    }
}
