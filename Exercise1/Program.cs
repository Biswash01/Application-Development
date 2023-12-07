namespace Exercise1
{

    internal class Program
    {
        public class Car
        {
            private string brand;
            private int year;
            private float price;

            // Constructor
            public Car(string brand, int year, float price)
            {
                this.brand = brand;
                this.year = year;
                this.price = price;
            }

            // Public method to get the car details
            public void PrintCarDetails()
            {
                Console.WriteLine($"Brand: {brand}");
                Console.WriteLine($"Year: {year}");
                Console.WriteLine($"Price: ${price}");
            }
        }

        static void Main()
        {
            // Create an instance of the Car class
            Car myCar = new Car("Toyota", 2022, 25000.50f);

            // Print out the car details
            myCar.PrintCarDetails();
        }
    }

}