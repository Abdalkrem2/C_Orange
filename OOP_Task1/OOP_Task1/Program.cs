 using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task1
{
    internal class Program
    {

        public class Car
        {
            protected string make;
            protected int year;
            protected string type;
            protected decimal price;
            protected string model;
            protected string palletNo;
            protected string color;

            protected bool isEngineRunning;
            public Car(string make, int year, string type, decimal price,
                    string model, string palletNo, string color)
            {
                this.make = make;
                this.year = year;
                this.type = type;
                this.price = price;
                this.model = model;
                this.palletNo = palletNo;
                this.color = color;
                this.isEngineRunning = false;
            }

            public virtual void StartEngine()
            {
                if (isEngineRunning)
                {
                    Console.Write("Engine is Already running");
                }
                else
                {
                    isEngineRunning = true;
                    Console.WriteLine("Enging is running");
                }
            }
            public virtual void StopEngine()
            {
                if (isEngineRunning)
                {
                    Console.Write("Engine stopped");
                    isEngineRunning = false;
                }
                else
                {
                   
                    Console.WriteLine("Enging is Already stopped");
                }

            }
            public string info()
            {
                return $"Make: {make}\n" +
                    $"Model: {model}\n" +
                    $"Year: {year}\n" +
                    $"Type: {type}\n" +
                    $"Price: {price:N2}\n" +
                    $"Pallet No: {palletNo}\n" +
                    $"Color: {color}\n" +
                    $"Engine Running: {isEngineRunning}\n";
            }
            

            

        }

        public class ElectricCar : Car
        {
            private int batteryRangeKm;

            public ElectricCar(string make, int year, string type, decimal price,
                            string model, string palletNo, string color,
                            int batteryRangeKm)
            : base(make, year, type, price, model, palletNo, color)
            {
                this.batteryRangeKm = batteryRangeKm;
            }

            public override void StartEngine()
            {
                isEngineRunning = true;
                Console.WriteLine($"{make} {model} is now powered on (silent electric start).");
            }

            public override void StopEngine()
            {
                isEngineRunning = false;
                Console.WriteLine($"{make} {model} has been powered off.");
            }

            public virtual string info()
            {
                return $"Make: {make}\n" +
                       $"Model: {model}\n" +
                       $"Year: {year}\n" +
                       $"Type: {type}\n" +
                       $"Price: {price:N2}\n" +
                       $"Pallet No: {palletNo}\n" +
                       $"Color: {color}\n" +
                       $"Engine Running: {isEngineRunning}\n"+
                       $"batteryRangeKm:{ batteryRangeKm}"
                       ;
            }

        }
            static void Main(string[] args)
        {
            Car myCar = new Car(
            make: "Toyota",
            year: 2024,
            type: "SUV",
            price: 32000.00m,
            model: "RAV4",
            palletNo: "PLT-1029",
            color: "Blue"
        );
            ElectricCar ev =new ElectricCar(make: "Toyota",
            year: 2024,
            type: "SUV",
            price: 32000.00m,
            model: "RAV4",
            palletNo: "PLT-1029",
            color: "Blue",
            batteryRangeKm:500
            );

            Console.Write(myCar.info());
       

            Console.WriteLine(ev.info());

        }
    }
}
