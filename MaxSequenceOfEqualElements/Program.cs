using System.Windows.Markup;
using System.Linq;
namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string str = string.Empty;
            int bestCount = 0;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int count = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (bestCount <= count)
                        {
                            str = numbers[i];
                            bestCount = count;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.Write(string.Join(" ", Enumerable.Repeat(str, bestCount)));
        }
    }
}



