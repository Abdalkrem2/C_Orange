using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
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


            for (int row = 1; row <= n; row++)
            {
                // Left spaces
                for (int space = 1; space <= n - row; space++)
                {
                    Console.Write(" ");
                }

                if (row == 1)
                {
                    Console.Write("1");
                }
                else if (row == n)
                {
                    for (int i = 1; i <= 2 * n - 1; i++)
                    {
                        Console.Write("1");
                    }
                }
                else
                {
                    Console.Write("1");

                    // Inner spaces
                    for (int space = 1; space <= 2 * row - 3; space++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("1");
                }

                Console.WriteLine();

            }
        }

        //8
        static void DiagonalCrossPattern(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col || row + col == n - 1)
                    {
                        Console.Write(row + 1);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
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


        //Array
        //1
        static void NonRepeatingSubarray(int[]nums) {//1 2 1 3
            int left = 0;
            int right = 0;
            HashSet<int> dublicate = new HashSet<int>();
            while (right<nums.Length) {

                while (dublicate.Contains(nums[right])){
                  
                    dublicate.Remove(nums[left]);
                    left++;
                }
               
                    dublicate.Add(nums[right]);
                   
                
                if (right - left +1>= 2 )
                {
                    for (int i = left; i <= right; i++)
                    {
                        Console.Write(nums[i]+" ");
                    }
                    return;
                }
                right++;

            }
          
        }

        //2

        static void EqualDistanceElements(int[] nums)//[1,2,1,2,1,2] 0 1 2 3 4 5
        {
            Dictionary<int,List<int>>map= new Dictionary<int,List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = new List<int>();
                }
                map[nums[i]].Add(i) ;
            }
            foreach (int key in map.Keys)
            {
                List<int> positions = map[key];

                int distance = positions[1] - positions[0];

                bool equal = true;

                for (int i = 2; i < positions.Count; i++)
                {
                    if (positions[i] - positions[i - 1] != distance)
                    {
                        equal = false;
                        break;
                    }
                }

                if (equal)
                {
                    Console.Write(key + " ");
                }
            }


        }

        //3
        static void SplitbyValueChange(int[] nums)
        {
            int p1 = 0, p2 = 0;
            while (p1 <nums.Length)
            {
                if (p2<nums.Length&&nums[p2] == nums[p1]) //[1,1,2,2,3,1]
                {
                    p2++;
                }
                else
                {
                    Console.Write("[");

                    for (int i = p1; i < p2; i++)
                    {
                        
                            Console.Write(  nums[i] );
                        if (i != p2 - 1) {  Console.Write(","); }
                        
                    }

                    Console.Write("] ");
                    p1 = p2;
                }
            }
        }

        //4
        static void AlmostSorted(int[] nums)
        {
            int[] sorted = new int[nums.Length];
            Array.Copy(nums, sorted, nums.Length);
            Array.Sort(sorted);
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] - sorted[i] != 0)
                {
                    counter++;
                }

            }
            if (counter == 0 || counter == 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        //5 wrong
        static void LongestStableSegment(int[]nums)
        {

        }
        //6
        static void DuplicateWindow(int[] nums)//[1,2,3,2,4,2,2]
        {
            int p1=0,p2=0;
            int l = 0, r = 0, max = int.MaxValue;
            HashSet<int> set = new HashSet<int>();
            while (p2 < nums.Length)
            {
                if (set.Contains(nums[p2]))
                {
                    
                    if (p2 - p1 < max) { 
                        l = p1 + 1; r = p2; max = p2 - p1;
                }
                    while (set.Contains(nums[p2]))
                    {
                        set.Remove(nums[p1]);
                        p1++;
                    }
                }
                else
                {
                    set.Add(nums[p2]);
                    p2++;
                }

            }
            for (int i = l; i <=r; i++) { 
            Console.Write(nums[i]);
            }
        }

        //7
        static void ProgressiveDifference(int[] arr)
        {
            int[] result = new int[arr.Length];

            result[0] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                result[i] = arr[i] - arr[i - 1];
            }

            for (int i = 0; i < result.Length; i++) {
                Console.Write(result[i]+" ");
            }
        }

        //8
        static void RearrangePosNeg(int[] nums)
        {
            List<int> positive = new List<int>();
            List<int> negative = new List<int>();

            foreach (int num in nums)
            {
                if (num >= 0)
                    positive.Add(num);
                else
                    negative.Add(num);
            }

            int[] result = new int[nums.Length];

            int p = 0; 
            int n = 0; 
            int i = 0;

            
            while (p < positive.Count && n < negative.Count)
            {
                result[i++] = positive[p++];
                result[i++] = negative[n++];
            }

           
            while (p < positive.Count)
            {
                result[i++] = positive[p++];
            }

         
            while (n < negative.Count)
            {
                result[i++] = negative[n++];
            }


            for(int j=0; j< result.Length; j++)
            {
                Console.Write(result[j] + " ");
            }
        }

        //9


        //10
        //حله بعد ما تخلص

        //Strings

        //1
        static void RemoveAdjacentOpposites(string s) { 
        Stack<char>stack= new Stack<char>();

            foreach(char c in s)
            {
               if(stack.Count > 0&&Math.Abs( stack.Peek()-c )== 32)
                {
                    stack.Pop();
                }else
                {
                    stack.Push(c);
                }

            }
            Console.Write(stack.Reverse().ToArray());
        }

        //2
        static void Compress(string s)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();

         
            foreach (char c in s)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }


            StringBuilder result = new StringBuilder();
            HashSet<char> printed = new HashSet<char>();

            foreach (char c in s)
            {
                if (!printed.Contains(c))
                {
                    result.Append(c);
                    result.Append(freq[c]);

                    printed.Add(c);
                }
            }

            Console.WriteLine(result);
        }

        //3
        static void AlternateCaseFix(string s)
        {
            char[]chars= s.ToCharArray();
            for (int i = 1; i < chars.Length; i++) {
                if (char.IsLower(chars[i]) == char.IsLower(chars[i - 1]))
                {
                    if (char.IsLower(chars[i]))
                    {
                        chars[i] = char.ToUpper(chars[i]);
                    }else
                        chars[i]=char.ToLower(chars[i]);
                }
                
            }
            Console.Write(chars);   
        }

        //4
        static void CountValidSubstrings(string s)//مش فاهمه ارجع عيده فكره مهمه
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            map[0] = 1;

            int prefix = 0;
            int answer = 0;

            foreach (char c in s)
            {
                if (c == '0')
                    prefix--;
                else
                    prefix++;

                if (map.ContainsKey(prefix))
                {
                    answer += map[prefix];
                    map[prefix]++;
                }
                else
                {
                    map[prefix] = 1;
                }
            }

           Console.WriteLine(answer);
        }

        //5
        static void ReverseOnlyLetters(string s) { 
        char [] chars = s.ToCharArray();
            int p1=0,p2=s.Length-1;
            while (p1 < p2) {
                if (chars[p1] != '-' && chars[p2] != '-')
                {
                    char temp=chars[p1];
                    chars[p1] = chars[p2];
                    chars[p2]= temp;
                    p2--; p1++;
                } else if (chars[p1] != '-' && chars[p2]=='-') 
                {
                    p2--;
                }
                else
                {
                    p1++;
                }
            }
            Console.Write(chars);
        }

        //6
        static void LongestRepeatingBlock(string s) //"aaabbccccd"
        {
            int p1 = 0, p2 = 0;
            char [] chars = s.ToCharArray();
            int max = 0;
            while (p2 < s.Length)
            {
                if (chars[p2] == chars[p1])
                {
                    p2++;
                }else
                {
                    if (p2 - p1>max)
                    {
                        max = p2 - p1;
                    }

                    p1 = p2;
                }
            }
            if (p2 - p1 > max)
            {
                max = p2 - p1;
            }
            Console.WriteLine(max);
        }

        //7
        static void ShiftCharacters(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'z')
                {
                    chars[i] = 'a';
                }
                else
                chars[i] ++;
            }
            Console.Write(chars);
        }

        //8
        static void RemoveOnetoMakePalindrome(string s)//"aabcaa"
        {
            int p1=0, p2= s.Length-1;
            bool flag= false;
              char [] chars = s.ToCharArray();
            while (p1 < p2 - 1)
            {
                if (chars[p1] != chars[p2])
                {
                    flag = true;
                }
                p1++;
                p2--;
            }
            Console.Write(flag ? "No" : "Yes");

        }

        //9
        static void PatternDistance(string s)
        {
            char [] chars = s.ToCharArray();
            Dictionary<char,int> distance = new Dictionary<char,int>();
            Dictionary<char,int>answers= new Dictionary<char,int>();
            for (int i = 0; i < chars.Length; i++) 
            {
                if (distance.ContainsKey(chars[i]))
                {

                    int diff = i - distance[chars[i]];
                    answers[chars[i]] = diff;
                

                }
                else
                {
                    distance[chars[i]] = i;
                }
            }
            foreach(var key in answers.Keys)
            {
                Console.Write( key+ "->" + answers[key]);
            }
        }

        //10
        static void SplitBalancedString(string s)//"LRLRLLRR"
        {
            char [] chars = s.ToCharArray();
            int counter = 0;
            int res = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i]=='L')
                {
                    counter++;
                }
                else
                {
                    counter--;
                }
                if(counter == 0)
                {
                    res++;
                }
            }
            Console.WriteLine(res);
        }

        static void Main(string[] args)
        {
            //int[] x = { 5, 7, 10 ,-1,-2};
            SplitBalancedString("LRLRLLRRRL");

        }
    }
}
