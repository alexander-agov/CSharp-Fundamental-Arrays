using System.Windows.Markup;
using System.Linq;
namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] wagon = new int[num];
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                wagon[i] = passengers;
                sum += wagon[i];
            }
            Console.WriteLine(string.Join(" ", wagon));
            Console.WriteLine(sum);
        }
    }
}

