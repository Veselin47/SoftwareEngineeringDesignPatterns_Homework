using domashno_po_shabloni.Creators;
using domashno_po_shabloni.Extensions;
using domashno_po_shabloni.Product;

namespace domashno_po_shabloni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IVehicleCreator[] vehicleCreators = new IVehicleCreator[]
                {
                    new CarCreator(),
                    new TruckCreator(),
                    new MotorcycleCreator()
                };

                List<Vehicle> vehicles = new List<Vehicle>();

                foreach (var creator in vehicleCreators)
                {
                    string vehicleType = creator.GetType().Name.Replace("Creator", "").SplitPascalCaseString();

                    Console.WriteLine($"Registering new {vehicleType}");

                    Console.WriteLine("Enter model: ");
                    string model = Console.ReadLine();

                    Console.WriteLine("Enter engine power (hp): ");
                    int power = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter daily rental price: ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    Vehicle vehicle = creator.CreateVehicle(model, power, price);
                    vehicles.Add(vehicle);
                    Console.WriteLine();
                }
                Console.WriteLine("--- RENTED VIHICLES LIST ---");
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle.ToString());
                }
            }
            catch (Exception exception)
            {
                if (exception is FormatException)
                {
                    Console.WriteLine("Aborting! Found entry with wrong format!");
                }
                else
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
