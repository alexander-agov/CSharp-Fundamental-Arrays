using System.Windows.Markup;
using System.Linq;
namespace EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            int sum = 0;
            foreach (int curr in arr1)
            {
                sum += curr;
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
