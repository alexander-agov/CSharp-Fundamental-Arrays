namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[,] arr = new int[num + 1, num + 1];
            for (int row = 1; row < num + 1; row++)
            {
                for (int col = 1; col < row + 1; col++)
                {
                    if (row == 1 || col == row)
                    {
                        arr[row, col] = 1;
                    }
                    else
                    {
                        arr[row, col] = arr[row - 1, col] + arr[row - 1, col - 1];
                    }
                    Console.Write(arr[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
