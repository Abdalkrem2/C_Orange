using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        //6
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

        //7
        static void SearchbyKey(string s)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            map["ahmad"] = 90;
            map["khaled"] = 50;
            if (map.ContainsKey(s))
            {
                Console.WriteLine(map[s]);
            }
            else
            {
                Console.WriteLine("Not found");

            }
        }


        //8
        static void SumofValues()
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            map["ahmad"] = 90;
            map["khaled"] = 50;

        }

        //9
        static void RemoveLowScores(List<int> nums)
        {
            List<int> result = nums.Where(score => score >= 50).ToList();

            foreach (int score in result)
            {
                Console.Write(score + " ");
            }
        }

        //10
        static void HighestScore(List<int>nums)
        {
       

            int highest = nums.Max();

            Console.WriteLine(highest);
        }

        //LinkedList
        //11
        static void AddElements()
        {
            LinkedList<string> nav = new LinkedList<string>();

            nav.AddFirst("Home");
            nav.AddLast("About");
            nav.AddLast("Contact");

            foreach (string item in nav)
            {
                Console.Write(item + " ");
            }
        }

        //12
        static void RemoveMiddle()
        {
            LinkedList<string> nav = new LinkedList<string>();

            nav.AddLast("Home");
            nav.AddLast("About");
            nav.AddLast("Services");
            nav.AddLast("Contact");

            LinkedListNode<string> node = nav.Find("Services");

            if (node != null)
            {
                nav.Remove(node);
            }

            foreach (string item in nav)
            {
                Console.Write(item + " ");
            }
        }

        //13
        static void AddBeforeAfter()
        {
            LinkedList<string> nav = new LinkedList<string>();

            nav.AddLast("Home");
            nav.AddLast("Contact");

            LinkedListNode<string> node = nav.Find("Contact");

            nav.AddBefore(node, "About");
            nav.AddAfter(node, "Help");

            foreach (string item in nav)
            {
                Console.Write(item + " ");
            }
        }

        //14
        static void TraverseLinkedList()
        {
            LinkedList<string> nav = new LinkedList<string>();

            nav.AddLast("Home");
            nav.AddLast("Contact");
            LinkedListNode<string> current = nav.First;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
        //15

        static void FirstAndLast()
        {
            LinkedList<string> nav = new LinkedList<string>();

            nav.AddLast("Home");
            nav.AddLast("Contact");

            Console.WriteLine(nav.First.Value);
            Console.WriteLine(nav.Last.Value);
        }


        // Task 16: Extract odd numbers
        static void OddNumbers(List<int> nums)
        {
            var odd = nums.Where(n => n % 2 != 0);

            Console.WriteLine("Odd Numbers:");
            foreach (int n in odd)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }


        // Task 17: Multiply all numbers by 2
        static void MultiplyNumbers(List<int> nums)
        {
            var result = nums.Select(n => n * 2);

            Console.WriteLine("Multiplied Numbers:");
            foreach (int n in result)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }


        // Task 18: Sort numbers from highest to lowest
        static void SortDescending(List<int> nums)
        {
            var sorted = nums.OrderByDescending(n => n);

            Console.WriteLine("Descending Order:");

            foreach (int n in sorted)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }


        // Task 19: Find first number > 100
        static void FirstGreaterThan100(List<int> nums)
        {
            int result = nums.FirstOrDefault(n => n > 100);

            Console.WriteLine("First Number Greater Than 100:");

            Console.WriteLine(result);
        }


        // Task 20: Calculate average
        static void CalculateAverage(List<int> nums)
        {
            double avg = nums.Average();

            Console.WriteLine("Average:");
            Console.WriteLine(avg);
        }

        // Task 21: Find common numbers between two lists
        static void CompareTwoLists(List<int> list1, List<int> list2)
        {
            var common = list1.Intersect(list2);

            Console.WriteLine("Common Numbers:");

            foreach (int n in common)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }


        // Task 22: Merge Two Lists
        static void MergeLists(List<int> list1, List<int> list2)
        {
            var merged = list1.Concat(list2);

            Console.WriteLine("Merged List:");

            foreach (int n in merged)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }


        // Task 23: Keep only unique numbers
        static void UniqueValues(List<int> nums)
        {
            var unique = nums.Distinct();

            Console.WriteLine("Unique Values:");

            foreach (int n in unique)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }


        // Task 24: Extract all values from Dictionary into List
        static void DictionaryToList(Dictionary<string, int> map)
        {
            List<int> values = map.Values.ToList();

            Console.WriteLine("Dictionary Values:");

            foreach (int value in values)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
        }


        // Task 25: Keep dictionary items where value > 100
        static void FilterDictionary(Dictionary<string, int> map)
        {
            var result = map
                .Where(x => x.Value > 100)
                .ToDictionary(x => x.Key, x => x.Value);


            Console.WriteLine("Filtered Dictionary:");

            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        // Task 26: Search for a number without LINQ
        static bool ManualSearch(List<int> nums, int target)
        {
            foreach (int n in nums)
            {
                if (n == target)
                {
                    return true;
                }
            }

            return false;
        }


        // Task 27: Count even numbers without LINQ
        static int CountEven(List<int> nums)
        {
            int count = 0;

            foreach (int n in nums)
            {
                if (n % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }


        // Task 28: Remove elements safely from List
        static void RemoveWhileLooping(List<int> nums)
        {
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] < 50)
                {
                    nums.RemoveAt(i);
                }
            }

            foreach (int n in nums)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();
        }


        // Task 29: Find second largest without sorting
        static int SecondLargest(List<int> nums)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;


            foreach (int n in nums)
            {
                if (n > largest)
                {
                    secondLargest = largest;
                    largest = n;
                }
                else if (n > secondLargest && n != largest)
                {
                    secondLargest = n;
                }
            }

            return secondLargest;
        }

        //Advanced Logic Tasks 
        //1
        static void HiddenPatternFinder(int[]nums)
        {
            int[]freq= new int[nums.Max()+1];
            for(int i=0;i<nums.Length;i++)
            {
                freq[nums[i]]++;            
            }
            int max = 0;
            int res = -1;
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > max)
                {
                    max = freq[i];
                    res = i;
                }
            }
            Console.WriteLine(res);
        }

        //2

        //3
        static void MirrorCheck(int[] nums)
        {
            int p1 = 0, p2 = nums.Length - 1;
            bool flag = false;
            while(p1 < p2)
            {
                if (nums[p1]!= nums[p2])
                    {
                    flag = true;
                    break; }
            }
            Console.WriteLine(flag ? "No" : "Yes");
        }

        //4
        static void MissingNumberDetective(int[] nums)
        {
            int max = nums.Max();
            int sum = (max * (max + 1)) / 2;
            int numSum=nums.Sum();
            Console.WriteLine(sum - numSum);
        }

        //5
        static void SplitListBalanced(int[] nums)
        {
            int bestIndex = -1;
            int minDiff = int.MaxValue;

            for (int split = 1; split < nums.Length; split++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int i = 0; i < split; i++)
                    leftSum += nums[i];

                for (int i = split; i < nums.Length; i++)
                    rightSum += nums[i];

                int diff = Math.Abs(leftSum - rightSum);

                if (diff < minDiff)
                {
                    minDiff = diff;
                    bestIndex = split;
                }
            }

            Console.WriteLine("Best Split Index = " + bestIndex);
        }//راجع

        //6
        static void LongestIncreasingSequence(int[] nums)
        {
            int start = 0;
            int maxStart = 0;
            int maxLength = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    if (i - start + 1 > maxLength)
                    {
                        maxLength = i - start + 1;
                        maxStart = start;
                    }
                }
                else
                {
                    start = i;
                }
            }

            for (int i = maxStart; i < maxStart + maxLength; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }

        //7
        static void DuplicateDistance(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            int minDistance = int.MaxValue;

            foreach (int n in nums)
            {
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    int distance = i - map[nums[i]];

                    if (distance < minDistance)
                        minDistance = distance;
                }

                map[nums[i]] = i;
            }

            Console.WriteLine(minDistance);
        }

        //8
        static void ReorderByRule(int[] nums)
        {
            List<int> result = new List<int>();

            foreach (int n in nums)
            {
                if (n % 2 == 0)
                    result.Add(n);
            }

            foreach (int n in nums)
            {
                if (n % 2 != 0)
                    result.Add(n);
            }

            foreach (int n in result)
            {
                Console.Write(n + " ");
            }
        }

        //9
        static void PeaksFinder(int[] nums)
        {
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i - 1] &&
                    nums[i] > nums[i + 1])
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }

        //10
        static void TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int needed = target - nums[i];

                if (map.ContainsKey(needed))
                {
                    Console.WriteLine(
                        $"Found: {needed} + {nums[i]} = {target}"
                    );
                    return;
                }

                map[nums[i]] = i;
            }

            Console.WriteLine("No pair found");
        }

        //11 ارجع حله سهل بس فيه فكرة


        //12
        static void AlternatingMerge(int[] a, int[] b)
        {
            List<int> result = new List<int>();

            int i = 0;
            int j = 0;

            while (i < a.Length || j < b.Length)
            {
                if (i < a.Length)
                {
                    result.Add(a[i]);
                    i++;
                }

                if (j < b.Length)
                {
                    result.Add(b[j]);
                    j++;
                }
            }


            foreach (int n in result)
            {
                Console.Write(n + " ");
            }
        }

        //13
        static void CountFrequencies(int[] nums)
        {
            int max = nums.Max();

            int[] freq = new int[max + 1];


          
            for (int i = 0; i < nums.Length; i++)
            {
                freq[nums[i]]++;
            }


            
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine(i + " -> " + freq[i]);
                }
            }
        }

        //14
        static void SecondMaximum(int[] nums)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;


            foreach (int n in nums)
            {
                if (n > largest)
                {
                    secondLargest = largest;
                    largest = n;
                }
                else if (n > secondLargest && n != largest)
                {
                    secondLargest = n;
                }
            }


            Console.WriteLine(secondLargest);
        }

        //15
        static void SubarraySum(int[]nums,int target)
        {
            int p1 = 0, p2 = 0;
            int sum = 0;
            while (p1 < nums.Length)
            {
                if (sum > target)
                {
                    sum -= nums[p1];
                    p1++;
                }
                else
                {
                    sum += nums[p2];
                    p2++;
                }
                if (sum == target)
                {
                    for(int i=p1; i<p2; i++)
                    {
                        Console.Write(nums[i]+" ");
                    }
                    break;
                }
                
            }
        }

        //16
        static void ReversePart(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];

                nums[start] = nums[end];

                nums[end] = temp;


                start++;
                end--;
            }


            foreach (int n in nums)
            {
                Console.Write(n + " ");
            }
        }

        //17

        //18


        //20
        static void RemoveNumber(int[] nums, int target)
        {
            int write = 0;

            for (int read = 0; read < nums.Length; read++)
            {
                if (nums[read] != target)
                {
                    nums[write] = nums[read];
                    write++;
                }
            }

           
            for (int i = 0; i < write; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            //List<int> scores = new List<int> { 90, 40, 75, 30, 100, 50 };
            SubarraySum(new int[] { 1, 2,4,5 },9);


        }
    }
}
