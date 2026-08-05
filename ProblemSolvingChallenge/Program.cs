using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingChallenge
{
    internal class Program
    {
        static void MirrorCompression(int[]nums)//1, 2 ,3,4,4
        {
            int p1 = 0, p2 = nums.Length - 1;
            int size = 0;bool flag = true;
            if (nums.Length % 2 == 0)
            {
                size = nums.Length / 2;
            }
            else
            {
                size = (nums.Length / 2)+1;
                flag = false;
            }
            int[] res=new int[size];
            int j = 0;
            while (p1 < p2) {
                res[j++] = nums[p1] + nums[p2];
                p2--;
                p1++;
            }

            if(!flag)
            res[j] = nums[p1];
            for (int i = 0; i < res.Length; i++) {
                Console.Write(res[i] + " ");
            }

        }
        static void FrequencyWithoutCountingTwice(int[]nums)
        {
            int[]freq=new int[nums.Max()+1];
            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }
            for (int i = 0; i < freq.Length; i++)
            { 
                
                    Console.WriteLine($"{i} -->{freq[i]}");
                
            }
        }

        static void LongestMountain(int[]nums)
        {
         
            int count=0;
            int max = 0;
            bool up=false;bool down=false;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] > nums[i + 1])
                {

                    count++;
                }
            }

           
        }


        static void Main(string[] args)
        {
            LongestMountain(new int []{ 1 ,2 ,5 ,9 ,6 ,3 ,4 ,7 });
        }
    }
}
