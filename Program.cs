using System;
using System.Globalization;

namespace Homework_for_lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Tesla", "Model_X", 113190, 260);
            Car car2 = new Car("BMW", "i3", 47650, 150);
            Car car3 = new Car("Chevrolet", "Bolt", 37500, 145);

            Car[] garage = {car1, car2, car3};

            foreach (Car car in garage)
            {
                car.ShowMaxSpeed();
                car.ShowPrice();
                string json = System.Text.Json.JsonSerializer.Serialize<Car>(car);
                Console.WriteLine(json);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public double Price { get; }
        public uint MaxSpeed { get; }

        public Car(){}

        public Car(string brand, string model, double price, uint maxSpeed)
        {
            Brand = brand;
            Model = model;
            Price = price;
            MaxSpeed = maxSpeed;
        }

        public void ShowMaxSpeed()
        {
            Console.WriteLine($"{Brand} {Model} can move with max speed - {MaxSpeed}");
        }

        public void ShowPrice()
        {
            string price = Price.ToString("C", CultureInfo.CreateSpecificCulture("us-US"));
            Console.WriteLine($"{Brand} {Model} costs {price}");
        }
    }
}
