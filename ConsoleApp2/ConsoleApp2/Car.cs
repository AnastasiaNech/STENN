namespace ConsoleApp2
{
    public class Car
    {
        public Car(string model, string color, string description)
        {
            Model = model;
            Color = color;
            Description = description;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }

        public bool Equals(Car car)
        {
            if (Model == car.Model &&
                Color == car.Color)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Model, Color);
        }

        public static List<Car> CreateCars()
        {
            return new List<Car>()
        {
            new Car("Cadillac Srx", "Red", "New"),
            new Car("Cadillac Srx", "Red", "Old"),
            new Car("Cadillac Srx", "Yellow", "Total"),
            new Car("Cadillac Srx", "Yellow", "Total"),
            new Car("Ford F-150", "Yellow", "Old"),
            new Car("Ford F-150", "Black", "Total"),
            new Car("Cadillac Sts", "Yellow", "Old"),
            new Car("Cadillac Sts", "Yellow", "Old"),
            new Car("Ford Mustang", "White", "Old"),
            new Car("Ford Mustang", "Black", "Total"),
            new Car("Cadillac Escalade", "White", "Total"),
            new Car("Ford Focus", "Black", "New"),
            new Car("Ford F-150", "Black", "Old"),
            new Car("Ford Mustang", "Black", "Total")
        };
        }
    }
}
