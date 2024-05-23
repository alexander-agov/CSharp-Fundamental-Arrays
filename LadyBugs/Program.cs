﻿using System.Windows.Markup;
using System.Linq;
namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fieldSize = int.Parse(Console.ReadLine());
            int[] InitialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long[] field = new long[fieldSize];
            for (int i = 0; i < InitialIndexes.Length; i++)
            {
                if (InitialIndexes[i] >= 0 && InitialIndexes[i] < field.Length)
                {
                    field[InitialIndexes[i]] = 1;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] position = command.Split();
                int ladybugIndex = int.Parse(position[0]);
                string direction = position[1];
                int flyLength = int.Parse(position[2]);
                if (ladybugIndex < 0 || ladybugIndex > field.Length - 1 || field[ladybugIndex] == 0)
                {
                    continue;
                }
                field[ladybugIndex] = 0;
                if (direction == "right")
                {
                    int landIndex = ladybugIndex + flyLength;
                    if (landIndex > field.Length - 1)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if (landIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex <= field.Length - 1)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landIndex = ladybugIndex - flyLength;
                    if (landIndex < 0)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landIndex >= 0)
                    {
                        field[landIndex] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}

