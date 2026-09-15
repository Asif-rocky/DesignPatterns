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
