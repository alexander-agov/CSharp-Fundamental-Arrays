using System.Windows.Markup;
using System.Linq;
namespace CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (num.Length == 1)
            {
                Console.WriteLine($"{num[0]}");
                return;
            }
            while (num.Length > 1)
            {
                int[] condensed = new int[num.Length - 1];
                for (int i = 0; i < num.Length - 1; i++)
                {
                    condensed[i] = num[i] + num[i + 1];
                }
                num = condensed;
            }
            Console.WriteLine(num[0]);
        }
    }
}
