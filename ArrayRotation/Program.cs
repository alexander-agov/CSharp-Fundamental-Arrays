﻿using System;
using System.Linq;
namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                string firstElement = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];

                }
                arr[arr.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
