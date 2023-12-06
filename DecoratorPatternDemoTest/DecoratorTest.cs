using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using DecoratorPattern.Decorator;
using DecoratorPattern.Component;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorPatternTest
{
    [TestClass]
    public class DecoratorTest
    {
        [TestMethod]
        public void GetPrice_HondaCity_SingleDecorator_Test()
        {
            IVehicle vehicle = new HondaCity();
            VehicleDecorator vehicleDecorator = new SeatCover(vehicle);         
            Assert.AreEqual(vehicleDecorator.GetPrice(), 106000);
        }

        [TestMethod]
        public void GetTotalPrice_HondaCity_MultipleDecorator_Test()
        {
            IVehicle vehicle = new HondaCity();
            VehicleDecorator vehicleDecorator = new SeatCover(vehicle);
            vehicleDecorator = new Spoiler(vehicleDecorator);
            Assert.AreEqual(vehicle.GetDescription(), "Petrol engine is 1497 cc");
            Assert.AreEqual(vehicleDecorator.GetPrice(), 111000);     
        }

        [TestMethod]
        public void GetTotalPrice_Amaze_MultipleDecorator_Test()
        {
            IVehicle vehicle = new Amaze();
            VehicleDecorator vehicleDecorator = new SeatCover(vehicle);
            vehicleDecorator = new Spoiler(vehicleDecorator);
            Assert.AreEqual(vehicle.GetDescription(), "Petrol engine is 1199 cc");
            Assert.AreEqual(vehicleDecorator.GetPrice(), 211000);
        }

        [TestMethod]
        public void GetTotalPrice_Amaze_MultipleDecorator_Test1()
        {
            IVehicle vehicle = new Amaze();
            VehicleDecorator vehicleDecorator = new SeatCover(vehicle);
            vehicleDecorator = new Spoiler(vehicleDecorator);
            Assert.AreEqual(vehicle.GetDescription(), "Petrol engine is 1199 cc");
            Assert.AreEqual(vehicleDecorator.GetPrice(), 211000);
        }
    }
}
