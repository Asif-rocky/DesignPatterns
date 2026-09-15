
using DesignPatterns.src.OopPrinciples.Inheritance;

Car car = new Car 
{ 
    Model = "Model S", 
    Brand = "Tesla", 
    NumberOfDoors = 4 
};
Bike bike = new Bike 
{
    Model = "Ducati", 
    Brand = "Ducati", 
    NumberOfGears = 6 
};

car.Start();
car.Stop();

bike.Start();
bike.Stop();
