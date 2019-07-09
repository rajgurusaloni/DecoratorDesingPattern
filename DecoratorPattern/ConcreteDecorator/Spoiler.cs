using DecoratorPattern.Decorator;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Spoiler : VehicleDecorator
    {
        private IVehicle _vehicle;
        public Spoiler(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public override string GetDescription()
        {
            return "Sensor Added";
        }

        public override double GetPrice()
        {
            return _vehicle.GetPrice() + 5000;
        }

        
    }
}
