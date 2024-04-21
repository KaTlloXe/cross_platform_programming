using VehicleLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestVehicleLibrary
{
    [TestClass]
    public class AutomobileTests
    {
        [TestMethod]
        public void CreateAutomobile_ShouldReturnAutomobileType()
        {
            var car = new Automobile("Sedan", "Toyota", "Red", 1.8);
            Assert.IsInstanceOfType(car, typeof(Automobile));
        }

        [TestMethod]
        public void ChangeSpeed_ShouldAlterCurrentSpeed()
        {
            var car = new Automobile("Sedan", "Toyota", "Red", 1.8);
            car.ChangeSpeed(20);
            Assert.AreEqual(20, car.CurrentSpeed);
        }

        [TestMethod]
        public void CargoVehicle_ShouldInheritFromAutomobile()
        {
            var truck = new CargoVehicle("Truck", "Volvo", "Blue", 5.0, 10000);
            Assert.IsInstanceOfType(truck, typeof(Automobile));
        }

        [TestMethod]
        public void CargoVehicle_ShouldHaveCargoCapacityProperty()
        {
            var truck = new CargoVehicle("Truck", "Volvo", "Blue", 5.0, 10000);
            Assert.AreEqual(10000, truck.CargoCapacity);
        }

        [TestMethod]
        public void PassengerVehicle_ShouldInheritFromAutomobile()
        {
            var bus = new PassengerVehicle("Bus", "Mercedes", "White", 3.0, 50);
            Assert.IsInstanceOfType(bus, typeof(Automobile));
        }

        [TestMethod]
        public void PassengerVehicle_ShouldHavePassengerCapacityProperty()
        {
            var bus = new PassengerVehicle("Bus", "Mercedes", "White", 3.0, 50);
            Assert.AreEqual(50, bus.CurrentSpeed);
        }
    }
}
