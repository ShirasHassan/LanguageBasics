using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet
{
    public class Inheritance
    {
        

        public static void Run()
        { 
            Console.WriteLine("-------------------------------------");
         Vehicle vehicle = new Vehicle();
         Console.WriteLine(nameof(vehicle.DisplayStatus));
         vehicle.DisplayStatus();
         Console.WriteLine();
         Console.WriteLine("-------------------------------------");
         Car car = new Car();
         Console.WriteLine(nameof(car.DisplayStatus));
         car.DisplayStatus();
         Console.WriteLine();

         vehicle = car;
         Console.WriteLine($"{nameof(vehicle)} = {nameof(car)}");
         Console.WriteLine(nameof(vehicle.DisplayStatus));
         vehicle.DisplayStatus();
         Console.WriteLine();
         Console.WriteLine("-------------------------------------");
         Bike bike = new Bike();
         Console.WriteLine(nameof(bike.DisplayStatus));
         bike.DisplayStatus();
         Console.WriteLine();
         
         vehicle = bike;
         Console.WriteLine($"{nameof(vehicle)} = {nameof(bike)}");
         Console.WriteLine(nameof(bike.DisplayStatus));
         bike.DisplayStatus();
         Console.WriteLine();
         Console.WriteLine("-------------------------------------");
         MarutiCar marutiCar = new MarutiCar();
         Console.WriteLine(nameof(marutiCar.DisplayStatus));
         marutiCar.DisplayStatus();
         Console.WriteLine();

         car = marutiCar;
         Console.WriteLine($"{nameof(car)} = {nameof(marutiCar)}");
         Console.WriteLine(nameof(car.DisplayStatus));
         car.DisplayStatus();
         Console.WriteLine();
         
         vehicle = car;
         Console.WriteLine($"{nameof(vehicle)} = {nameof(car)}");
         Console.WriteLine(nameof(vehicle.DisplayStatus));
         vehicle.DisplayStatus();
         Console.WriteLine();
         Console.WriteLine("-------------------------------------");
         HondaBike hondaBike = new HondaBike();
         Console.WriteLine(nameof(hondaBike.DisplayStatus));
         hondaBike.DisplayStatus();
         Console.WriteLine();

         bike = hondaBike;
         Console.WriteLine($"{nameof(bike)} = {nameof(hondaBike)}");
         Console.WriteLine(nameof(bike.DisplayStatus));
         bike.DisplayStatus();
         Console.WriteLine();
         
         vehicle = bike;
         Console.WriteLine($"{nameof(vehicle)} = {nameof(bike)}");
         Console.WriteLine(nameof(vehicle.DisplayStatus));
         vehicle.DisplayStatus();
         Console.WriteLine();
         Console.WriteLine("-------------------------------------");
         Ciaz ciaz = new Ciaz();
         Console.WriteLine(nameof(ciaz.DisplayStatus));
         ciaz.DisplayStatus();
         Console.WriteLine();
         
         marutiCar = ciaz;
         Console.WriteLine($"{nameof(marutiCar)} = {nameof(ciaz)}");
         Console.WriteLine(nameof(marutiCar.DisplayStatus));
         marutiCar.DisplayStatus();
         Console.WriteLine();

         car = marutiCar;
         Console.WriteLine($"{nameof(car)} = {nameof(marutiCar)}");
         Console.WriteLine(nameof(car.DisplayStatus));
         car.DisplayStatus();
         Console.WriteLine();
         
         vehicle = car;
         Console.WriteLine($"{nameof(vehicle)} = {nameof(car)}");
         Console.WriteLine(nameof(vehicle.DisplayStatus));
         vehicle.DisplayStatus();
         Console.WriteLine();
         Console.WriteLine("-------------------------------------");
         Cbr350 cbr = new Cbr350();
         Console.WriteLine(nameof(cbr.DisplayStatus));
         cbr.DisplayStatus();
         Console.WriteLine();
         
         vehicle = cbr;
         Console.WriteLine($"{nameof(vehicle)} = {nameof(cbr)}");
         Console.WriteLine(nameof(vehicle.DisplayStatus));
         vehicle.DisplayStatus();
         Console.WriteLine();

         hondaBike = cbr;
         Console.WriteLine($"{nameof(hondaBike)} = {nameof(cbr)}");
         Console.WriteLine(nameof(hondaBike.DisplayStatus));
         hondaBike.DisplayStatus();
         Console.WriteLine();

         bike = hondaBike;
         Console.WriteLine($"{nameof(bike)} = {nameof(hondaBike)}");
         Console.WriteLine(nameof(bike.DisplayStatus));
         bike.DisplayStatus();
         Console.WriteLine();
         
         vehicle = bike;
         Console.WriteLine($"{nameof(vehicle)} = {nameof(bike)}");
         Console.WriteLine(nameof(vehicle.DisplayStatus));
         vehicle.DisplayStatus();
         Console.WriteLine();
         Console.WriteLine("-------------------------------------");
         
         
        }
    }


    public class Vehicle
    {
        public virtual void DisplayStatus()
        {
            Console.WriteLine("Vehicle manufacturing is in progress");
        }
    }
    
    public class Car : Vehicle
    {
        public new void DisplayStatus()
        {
            Console.WriteLine("Car manufacturing is in progress");
        }
    }

    public class MarutiCar : Car
    {
        public virtual void DisplayStatus()
        {
            Console.WriteLine("MarutiCar manufacturing is in progress");
        } 
    }
    

    public class Ciaz : MarutiCar
    {
        public override void DisplayStatus()
        {
            Console.WriteLine("Ciaz manufacturing is in progress");
        } 
    }
    
    public class Bike : Vehicle
    {
        public override void DisplayStatus()
        {
            Console.WriteLine("Bike manufacturing is in progress");
        }
    }
    
    public class HondaBike : Bike
    {
        public override void DisplayStatus()
        {
            Console.WriteLine("HondaBike manufacturing is in progress");
        }
    }
    
    public class Cbr350 : HondaBike
    {
        public override void DisplayStatus()
        {
            Console.WriteLine("CBR350 manufacturing is in progress");
        } 
    }
}