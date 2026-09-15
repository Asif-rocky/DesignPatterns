using DesignPatterns.src.OopPrinciples.Inheritance;

namespace DesignPatterns.src.OopPrinciples.Inheritance
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

//using DesignPatterns.src.OopPrinciples.Inheritance;

//Car car = new Car
//{
//    Model = "Model S",
//    Brand = "Tesla",
//    NumberOfDoors = 4
//};
//Bike bike = new Bike
//{
//    Model = "Ducati",
//    Brand = "Ducati",
//    NumberOfGears = 6
//};

//car.Start();
//car.Stop();

//bike.Start();
//bike.Stop();

