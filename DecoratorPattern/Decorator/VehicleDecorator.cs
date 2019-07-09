using DecoratorPattern.Component;


namespace DecoratorPattern.Decorator
{
    public abstract class VehicleDecorator : IVehicle
    {            
        public abstract double GetPrice();
        public abstract string GetDescription();
      
    }
}
