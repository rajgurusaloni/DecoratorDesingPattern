using DecoratorPattern.Component;


namespace DecoratorPattern.ConcreteComponent
{
    public class Amaze : IVehicle
    {       
        public string GetDescription()
        {
            return "Petrol engine is 1199 cc";
        }

        public double GetPrice()
        {
            return 200000;
        }
    }
}
