using System;
using System.Linq;
using System.Collections.Generic;

namespace EncryptSortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < num; i++)
            {
                string command = Console.ReadLine();
                double sum1 = 0;
                double sum2 = 0;
                double sum3 = 0;
                foreach (char c in command)
                {
                    if (c == 'a' || c == 'o' || c == 'i' || c == 'u' || c == 'e' ||
                        c == 'A' || c == 'O' || c == 'I' || c == 'U' || c == 'E')
                    {
                        sum1 += (int)c * command.Length;
                    }
                    else
                    {
                        sum2 += (int)c / command.Length;
                    }
                }
                sum3 = sum1 + sum2;
                list.Add(sum3);
            }
            list.Sort();
            foreach (double sum in list)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
