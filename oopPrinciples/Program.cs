using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopPrinciples
{
    internal class Program
    {

        //1
       public static class MathUtilities
        {
            public static int Square(int x1)
            {
                return x1*x1;
            }
            public static int SquareRoot(int x1) {
                return Convert.ToInt32(Math.Sqrt(x1));
            }
            public static int Max(int x1, int x2) { 
            return x1 > x2 ? x1 : x2;
            }
        }

        //2
        class VisitorCounter
        {
            public static int Visitors = 0;

            public VisitorCounter()
            {
                Visitors++;
            }
        }

        //3
        class Company
        {
            public static string CompanyName { get; set; }

            public string EmployeeName { get; set; }
        }

        //4
        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }

        //class Animal
        //{
        //    public virtual void Speak()
        //    {
        //        Console.WriteLine("Animal makes a sound");
        //    }
        //}
        //class Person
        //{
        //    private string name;

        //    public string Name
        //    {
        //        get { return name; }
        //        set { name = value; }
        //    }
        //}
        //abstract class Shape
        //{
        //    public abstract double GetArea();
        //}
        //class Rectangle : Shape
        //{
        //    public double Width { get; set; }
        //    public double Height { get; set; }

        //    public Rectangle(double width, double height)
        //    {
        //        Width = width;
        //        Height = height;
        //    }

        //    public override double GetArea()
        //    {
        //        return Width * Height;
        //    }
        //}
        //class Cat : Animal
        //{
        //    public override void Speak()
        //    {
        //        Console.WriteLine("Meow");
        //    }
        //}

        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal Sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        //Task Description: Abstraction
        abstract class Appliance
        {
            public string Brand { get; set; }

            public abstract void TurnOn();

            public abstract void TurnOff();
        }

        class WashingMachine : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine($"{Brand} Washing Machine: Wash cycle started.");
            }

            public override void TurnOff()
            {
                Console.WriteLine($"{Brand} Washing Machine: Wash cycle stopped.");
            }
        }

        class AirConditioner : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine($"{Brand} Air Conditioner: Cooling mode activated.");
            }

            public override void TurnOff()
            {
                Console.WriteLine($"{Brand} Air Conditioner: Air conditioner turned off.");
            }
        }

        //Task Description: Encapsulation
        class BankAccount
        {
            private double balance;
            public double Balance
            {
                get { return balance; }
            }
            public void Deposit(int amount)
            {
                balance += amount;
            }
            public void Withdraw(int amount) {
                if (amount <= 0)
                {
                    Console.WriteLine("Withdrawal amount must be greater than 0.");
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Insufficient balance.");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn: {amount}");
                }
                
            }
            public string ViewBalance()
            {
                return "";
            }
        }

        //Task Description: Abstract Class
        abstract class Employee
        {
            public string Name { get; set; }

            public abstract double CalculateSalary();
        }

        class FullTimeEmployee : Employee
        {
            public double MonthlySalary { get; set; }

            public override double CalculateSalary()
            {
                return MonthlySalary;
            }
        }

        class PartTimeEmployee : Employee
        {
            public double HoursWorked { get; set; }
            public double HourlyRate { get; set; }

            public override double CalculateSalary()
            {
                return HoursWorked * HourlyRate;
            }
        }



        static void Main(string[] args)
        {
            int x=MathUtilities.SquareRoot(25);
            Console.WriteLine(x);

            Company.CompanyName = "Microsoft";

            Company emp1 = new Company();
            emp1.EmployeeName = "Ali";

            Company emp2 = new Company();
            emp2.EmployeeName = "Sara";
        }
    }
}
