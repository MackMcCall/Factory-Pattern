namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels will your vehicle have?");
            if (!int.TryParse(Console.ReadLine(), out int wheelsInput))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            
            IVehicle userCar = VehicleFactory.GetVehicle(wheelsInput);
            userCar.Drive();
        }
    }
}
