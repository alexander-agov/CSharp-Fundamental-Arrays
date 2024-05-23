using System.Windows.Markup;
using System.Linq;
namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] arr1 = new string[num];
            string[] arr2 = new string[num];
            for (int i = 1; i <= num; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    arr1[i - 1] += numbers[1];
                    arr2[i - 1] += numbers[0];
                }
                else
                {
                    arr1[i - 1] += numbers[0];
                    arr2[i - 1] += numbers[1];
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
