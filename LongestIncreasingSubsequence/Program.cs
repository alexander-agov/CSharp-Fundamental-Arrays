namespace LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(input, int.Parse);
            List<int> longestSubsequence = FindLongestIncreasingSubsequence(nums);
            foreach (int num in longestSubsequence)
            {
                Console.Write(num + " ");
            }
        }
        static List<int> FindLongestIncreasingSubsequence(int[] nums)
        {
            int n = nums.Length;
            int[] len = new int[n];
            int[] prev = new int[n];
            for (int p = 0; p < n; p++)
            {
                int left = -1;
                int maxLength = 0;
                for (int i = 0; i < p; i++)
                {
                    if (nums[i] < nums[p] && len[i] > maxLength)
                    {
                        maxLength = len[i];
                        left = i;
                    }
                }
                len[p] = 1 + maxLength;
                prev[p] = left;
            }
            int maxLengthIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (len[i] > len[maxLengthIndex])
                {
                    maxLengthIndex = i;
                }
            }
            List<int> longestSubsequence = new List<int>();
            int current = maxLengthIndex;
            while (current != -1)
            {
                longestSubsequence.Insert(0, nums[current]);
                current = prev[current];
            }
            return longestSubsequence;
        }
    }
}

