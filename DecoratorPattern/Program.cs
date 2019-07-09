using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using DecoratorPattern.Decorator;
using DecoratorPattern.Component;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = new HondaCity();
            VehicleDecorator vehicleDecorator = new SeatCover(car);
            vehicleDecorator = new Spoiler(vehicleDecorator);
            Console.WriteLine("Total Price : " + vehicleDecorator.GetPrice());
            Console.ReadLine();
        }
    }
}
