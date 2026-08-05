using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oopInterface
{
    interface ICalculator
    {
        int Add(int a, int b);

    }
    class Calculator : ICalculator
    {
        public int Add(int a, int b) { return a + b; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ICalculator calc = new Calculator();
                    
                Console.WriteLine(calc.Add(1, 2));
            }
            catch (Exception e) { 
            Console.WriteLine(e.ToString());
            }
            string filePath = "C:\\Users\\user\\Desktop\\Orange\\C#\\oopInterface\\data";

            File.WriteAllText(filePath, "My name is abd alkrem and my age is 23");
            File.AppendAllText(filePath, "My major is Cs");
            string[] lines = File.ReadAllLines(filePath);

            int totalCharacters = 0;
            int totalWords = 0;

            // Read file line by line
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                    // Count characters without spaces
                    totalCharacters += line.Replace(" ", "").Length;

                    // Count words
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    totalWords += words.Length;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Total Characters (without spaces): {totalCharacters}");
            Console.WriteLine($"Total Words: {totalWords}");


        }

    }
}
