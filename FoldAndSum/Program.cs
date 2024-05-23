using System.Linq;
namespace FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            int index = number.Length / 4;
            int lastIndex = number.Length / 4 * 2;
            for (int i = index; i < lastIndex + index; i++)
            {
                list2.Add(number[i]);
            }
            for (int i = 0; i < index; i++)
            {
                list1.Add(number[i]);
            }
            list1.Reverse();
            for (int i = number.Length - 1; i >= lastIndex + index; i--)
            {
                list1.Add(number[i]);
            }

            for (int k = 0; k < lastIndex; k++)
            {
                list3.Add(list1[k] + list2[k]);
                Console.Write(list3[k] + " ");
            }
        }
    }
}
