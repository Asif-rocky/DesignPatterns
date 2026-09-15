namespace DesignPatterns.src.OopPrinciples.Polymorphism
{
    public class Bike : Vehicle
    {
        public int NumberOfGears { get; set; }
        public override void Start()
        {
            Console.WriteLine($"Starting the bike.");
        }
        public override void Stop()
        {
            Console.WriteLine($"Stopping the bike.");
        }
    }
}
