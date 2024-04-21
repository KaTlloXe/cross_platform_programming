using VehicleLibrary;
using System;

class Program
{
    static void Main()
    {
        Automobile myCar = new Automobile("Sedan", "Toyota", "Red", 1.8);
        Console.WriteLine($"Type: {myCar.Type}, Make: {myCar.Make}, Color: {myCar.Color}, Engine Volume: {myCar.EngineVolume}, Current Speed: {myCar.CurrentSpeed}");

        myCar.ChangeSpeed(50);
        Console.WriteLine($"New Speed: {myCar.CurrentSpeed}");

        CargoVehicle myTruck = new CargoVehicle("Truck", "Volvo", "Blue", 5.0, 10000);
        Console.WriteLine($"Type: {myTruck.Type}, Make: {myTruck.Make}, Color: {myTruck.Color}, Engine Volume: {myTruck.EngineVolume}, Cargo Capacity: {myTruck.CargoCapacity}");

        PassengerVehicle myBus = new PassengerVehicle("Bus", "Mercedes", "White", 3.0, 50);
        Console.WriteLine($"Type: {myBus.Type}, Make: {myBus.Make}, Color: {myBus.Color}, Engine Volume: {myBus.EngineVolume}, Passenger Capacity: {myBus.PassengerCapacity}");
        Console.ReadLine();
    
    }

}
