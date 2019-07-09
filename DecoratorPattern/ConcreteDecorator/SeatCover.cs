using DecoratorPattern.Decorator;
using DecoratorPattern.Component;


namespace DecoratorPattern.ConcreteDecorator
{
    public class SeatCover : VehicleDecorator
    {
        private IVehicle _vehicle;
        public SeatCover(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public override string GetDescription()
        {
            return "SeatCover Added";
        }

        public override double GetPrice()
        {
            return _vehicle.GetPrice() + 6000;
        }

       
    }
}
