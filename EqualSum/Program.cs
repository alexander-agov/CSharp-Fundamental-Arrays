using System;
using System.Linq;
namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += nums[j];
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    rightSum += nums[j];
                }

                if (rightSum == leftSum)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Console.WriteLine($"{index}");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
