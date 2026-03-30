namespace Builder_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car car = new CarBuilder()
                    .SetBrand("BMW")
                    .SetModel("X5")
                    .SetYear(2021)
                    .SetColor("Black")
                    .SetNavigation(true)
                    .Build();

                Console.WriteLine($"Car: {car.Brand} {car.Model}, {car.Year}, {car.Color}, Nav: {car.HasNavigation}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
