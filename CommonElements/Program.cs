﻿using System.Windows.Markup;
using System.Linq;
namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            for (int j = 0; j < arr2.Length; j++)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.Write($"{arr1[i]} ");
                        break;
                    }
                }
            }
        }
    }
}


