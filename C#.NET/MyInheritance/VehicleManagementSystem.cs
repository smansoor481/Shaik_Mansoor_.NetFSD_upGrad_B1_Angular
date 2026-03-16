using System;
using System.Collections.Generic;
using System.Text;

namespace MyInheritance
{
    internal class VehicleManagementSystem
    {
        static void Main()
        {

        }
    }
}

public class Vehicle
{
    public int VehicleNumber;
    public string brand;

    public virtual void StartVehicle()
    {
        Console.WriteLine("Vehicle is started");
    }
}

public class Car : Vehicle
{
    public string FuelType;

    public override void StartVehicle()
    {
        Console.WriteLine("Car is started");
    }
}

public sealed class ElectricCar : Car
{
    public override void StartVehicle()
    {
        Console.WriteLine("ElectricCar is started");
    }
}

public class Tesla : ElectricCar
{
    public override void StartVehicle()
    {
        Console.WriteLine("Tesla is started");
    }
}

