using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        //List
        //1
        static void EvenNumbersFilter(List<int>nums)
        {
            List<int>even = nums.Where(n => n%2==0).ToList();
            foreach (int n in even) {
                Console.Write(n + " ");
            }
        }

        //2
        static void RemoveDuplicates(List<int> nums)
        {
            List<int> res = nums.Distinct().ToList();
            foreach (int n in res) {
                Console.WriteLine(n);
            } 
        }

            //3
            static void FindMaximumNumber(List<int>nums)
            {
            int res = nums.Max();
            Console.WriteLine(res);
            }

        //4
        static void ReverseList(List<int> nums)
        {
            nums.Reverse();
            foreach (int n in nums)
            {
                Console.Write(n + " ");
            }


        }

        //5
        static void CountNumbersGreaterThanX(List<int> nums,int x)
        {
            int res = nums.Count(n => n > x);
            Console.WriteLine(res);

        }

        //Dictionary
        //1
        static void StudentScores()
        {
            Dictionary<string,int>map= new Dictionary<string,int>();
            map["ahmad"] = 90;
            map["khaled"] = 50;
            foreach (var x in map.Keys)
            {
                if(map[x]>80)
                Console.Write($"{x} : {map[x]} ");
            }

        }

        static void Main(string[] args)
        {
            List<int> x = new List<int>() { 1, 2, 4,5,6 ,6,6};
            StudentScores();


        }
    }
}
