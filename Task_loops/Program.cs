using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_loops
{
    internal class Program
    {
        //loop

        //1
        static void Zigizag(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    for (int j = i; j >= 1; j--)
                        Console.Write(j);
                    Console.WriteLine();
                }
                else
                {
                    for(int j=1; j <=i; j++)
                    Console.Write(j);
                    Console.WriteLine();
                }
            }
         
        }
        //2
        static void MirrorNumber(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for(int s=n-i-1; s >1; s--)
                {
                    Console.Write(" ");
                }
                for(int k=i;k>=1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }

        }
        //3
        static void CenteredNumberPyramid(int n) { 
        for(int i = 1; i <= n; i++)
            {
                for(int s1 = n - i; s1 >= 1; s1--)
                {
                    Console.Write(' ');
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                for(int k = i-1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                for (int s1 = n - i; s1 >= 1; s1--)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        //4
        static void SkipEven(int n)
        {
           
            for (int i=1; i <= n; i++)
            {
                int c = 1;
               for (int j = 1; j <= i; j++)
                {
                    Console.Write(c);
                    c += 2;
                }
               Console.WriteLine();
            }
        }

        //5
        static void RowSum(int n) {
            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(Math.Pow(2,i-1));
                }
                Console.WriteLine() ;
            }

        }

        //6
        static void AlternatingDirection(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = i; j >= 1; j--)
                        Console.Write(j);
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write(j);
                    Console.WriteLine();
                }
            }
        }

        //7
        static void HollowPyramidNumbers(int n)
        {

        }      

        //9
        static void IncrementalBlocks(int n)
        {
            int  x = 1;
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(x++);

                }
                Console.WriteLine();
            }
        }

        //10
        static void PatternwithGaps(int n) { 
            for(int i = 1; i <n; i++)
            {
                Console.Write("1");
                for(int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("1");
                
            }
            for(int i = 1; i <= n+1; i++)
            {
                Console.Write("1");
            }
        }
        static void Main(string[] args)
        {
            PatternwithGaps(4);

        }
    }
}
