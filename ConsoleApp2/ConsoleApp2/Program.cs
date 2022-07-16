using ConsoleApp2;

var cars = Car.CreateCars();
var firsCar = cars[0];

Console.WriteLine("First car: " + firsCar.GetHashCode());

cars.ForEach(x =>
{
    Console.WriteLine(firsCar.Equals(x));
    Console.WriteLine(x.GetHashCode());
});