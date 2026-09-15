namespace DesignPatterns.src.OopPrinciples.Polymorphism
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }


        public virtual void Start()
        {
            Console.WriteLine($"Starting the vehicle.");
        }

        public virtual void Stop()
        {
            Console.WriteLine($"Stopping the vehicle.");
        }

    }
}

// Example usage:

//using DesignPatterns.src.OopPrinciples.Polymorphism;

//List<Vehicle> vehicles = new List<Vehicle>
//{
//    new Car { Model = "Model S", Brand = "Tesla", NumberOfDoors = 4 },
//    new Bike { Model = "Ducati", Brand = "Ducati", NumberOfGears = 6 }
//};
//foreach (var vehicle in vehicles)
//{
//    vehicle.Start();
//    vehicle.Stop();
//}
