using System.Windows.Markup;
using System.Linq;

namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main()
        {
            string[] values = Console.ReadLine().Split(" ");
            for (int i = 0; i < values.Length / 2; i++)
            {
                string firstElement = values[i];
                string lastElement = values[values.Length - 1 - i];
                values[i] = lastElement;
                values[values.Length - 1 - i] = firstElement;
            }

            //Array.Reverse(values);

            //List<string> list = new List<string>();
            //for (int i = values.Length - 1; i > 0 ;i--) 
            //{
            //    list.Add(values[i]);
            //}
            //Console.WriteLine(string.Join(" ", list));

            //for (int i = 0; i < values.Length; i++) { }
            // Console.WriteLine(values[^(i + 1)]); //with ^ return the last element;
                                                                                // always begin from the given number without 0, 0 exception!

            Console.WriteLine(string.Join(" ", values));
        }
    }
}
