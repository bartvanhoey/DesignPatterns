using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatterns.Creational.Builder.RealWorld
{
    public abstract class VehicleBuilder
    {
        protected Vehicle Vehicle;
        public Vehicle GetVehicle => Vehicle;
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }

    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder() => Vehicle = new Vehicle("MotorCycle");

        public override void BuildFrame() => Vehicle["frame"] = "MotorCycle Frame";

        public override void BuildEngine() => Vehicle["engine"] = "500CC";

        public override void BuildWheels() => Vehicle["wheels"] = "2";

        public override void BuildDoors() => Vehicle["doors"] = "0";
    }
    
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public override void BuildFrame() => Vehicle["frame"] = "Car Frame";

        public override void BuildEngine() => Vehicle["engine"] = "2500CC";

        public override void BuildWheels() => Vehicle["wheels"] = "4";

        public override void BuildDoors() => Vehicle["doors"] = "4";
    }
    
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            Vehicle = new Vehicle("Scooter");
        }

        public override void BuildFrame() => Vehicle["frame"] = "Scooter Frame";

        public override void BuildEngine() => Vehicle["engine"] = "50CC";

        public override void BuildWheels() => Vehicle["wheels"] = "2";

        public override void BuildDoors() => Vehicle["doors"] = "0";
    }

    public class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }

    public class Vehicle
    {
        private readonly string _vehicleType;
        private readonly Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType) => _vehicleType = vehicleType;

        public string this[string key]
        {
            get => _parts[key];
            set => _parts[key] = value;
        }

        public void Show()
        {
            Debug.WriteLine("\n-------------------------");
            Debug.WriteLine($"Vehicle Type: {_vehicleType}");
            Debug.WriteLine($" Frame: {_parts["frame"]}");
            Debug.WriteLine($" Engine: {_parts["engine"]}");
            Debug.WriteLine($" #Wheels: {_parts["wheels"]}");
            Debug.WriteLine($" #Doors: {_parts["doors"]}");
        }
    }
}