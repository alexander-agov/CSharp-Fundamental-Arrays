using System;
using System.Linq;
namespace TopInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int[] newStr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                newStr[i] = int.Parse(str[i]);
            }
            for (int i = 0; i < newStr.Length; i++)
            {
                bool isTop = true;
                for (int j = i + 1; j < newStr.Length; j++)
                {
                    if (newStr[i] <= newStr[j])
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write($"{newStr[i]} ");
                }
            }
        }
    }
}

