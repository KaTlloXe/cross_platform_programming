using System;

namespace VehicleLibrary
{
    public class Automobile
    {
        public string Type { get; private set; }
        public string Make { get; private set; }
        public string Color { get; private set; }
        public double EngineVolume { get; private set; }
        public double CurrentSpeed { get; private set; }

        public Automobile(string type, string make, string color, double engineVolume)
        {
            Type = type;
            Make = make;
            Color = color;
            EngineVolume = engineVolume;
            CurrentSpeed = 0;
        }

        public void ChangeSpeed(double speedChange)
        {
            CurrentSpeed += speedChange;
        }
    }

    public class CargoVehicle : Automobile
    {
        public double CargoCapacity { get; private set; }

        public CargoVehicle(string type, string make, string color, double engineVolume, double cargoCapacity)
            : base(type, make, color, engineVolume)
        {
            CargoCapacity = cargoCapacity;
        }
    }

    public class PassengerVehicle : Automobile
    {
        public int PassengerCapacity { get; private set; }

        public PassengerVehicle(string type, string make, string color, double engineVolume, int passengerCapacity)
            : base(type, make, color, engineVolume)
        {
            PassengerCapacity = passengerCapacity;
        }
    }
}
