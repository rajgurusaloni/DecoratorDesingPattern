using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public class HondaCity : IVehicle
    {        
        public string GetDescription()
        {
            return "Petrol engine is 1497 cc";
        }

        public double GetPrice()
        {
            return 100000;
        }
    }
}
