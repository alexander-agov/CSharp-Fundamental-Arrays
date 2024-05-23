using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int result = GetFibonacci(n);
            Console.WriteLine($"{result}");

            static int GetFibonacci(int n)
            {
                if (n == 1 || n == 2)
                    return 1;

                return GetFibonacci(n - 1) + GetFibonacci(n - 2); //recursive calls
            }
        }
    }
}
