using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static double CalculateAverage(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;

        }

        static void StudentNames()
        {
            List<string> names=new List<string>();
            names.Add("abd");
            names.Add("ahmad");
            names.Add("khaled");
            names.Add("abd");
            names.Add("belal");
            foreach(string name in names) 
            Console.WriteLine(name);

            names.Remove("abd");
            foreach (string name in names)
                Console.WriteLine(name);
        }

        static void Task3()
        {
            Dictionary<int,string>map=new Dictionary<int, string>();
            map[0] = "ahmad";
            map[1] = "ahmad";
            map[2] = "ahmad";
            foreach(var name in map) {  Console.WriteLine(name); }
        }

        //linQ
        static void Greater(int[] nums)
        {
            var res = nums.Where(n => n > 15);
            
           foreach(var n in res)
            {
                Console.WriteLine(n);
            }

        }
        static void Even(int[] nums)
        {
            var res=nums.Where(n => n%2==0);
            foreach(var n in res)
            {
                Console.WriteLine($"{n}");
            }    

        }
        static void FillterName(string[] names)
        {
            var res = names.Where(n => n.StartsWith("A"));
            foreach(var n in res)
                Console.WriteLine(n);
        }
        static void GreaterThan10(int[] nums)
        {
            var res= nums.FirstOrDefault(n=>n>10);
            Console.WriteLine(res);
        }

        //Task5


        // 1. Method without parameters
        static void Welcome()
        {
            Console.WriteLine("Welcome!");
        }

        // 2. Method with parameters
        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        // 3. Method with default parameter
        static void ShowAge(string name, int age = 18)
        {
            Console.WriteLine($"{name} is {age} years old.");
        }

        // 4. Method that returns the sum
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        // 5. Method with an array parameter
        static void PrintArray(int[] numbers)
        {
            Console.WriteLine("Array elements:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }



        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25, 30 };
            string[] names = { "Ahmad", "Ali", "Sara", "Mona", "Omar" };


            GreaterThan10(numbers);
        }
    }
}
