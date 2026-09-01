using System.Timers;

class Program
{
    public static void Main()
    {
        int[][] intervals =
            {
        new int[] {1,3},
        new int[] { 2, 6 },
        new int[] { 8, 10 },
        new int[] { 15, 18 }
        };
        int[][] result = MergeIntervals(intervals);
        foreach (int[] interval in result)
        {
            Console.WriteLine(interval[0] + "," + interval[1]);
        }
    }

    public static int[][] MergeIntervals(int[][] intervals)
    {
        if (intervals.Length == 0)
            return intervals;
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
        List<int[]> merged = new List<int[]>();
        int[] current = intervals[0];

        for(int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= current[1])
            {
                current[1] = Math.Max(current[1], intervals[i][1]);

            }
            else
            {
                merged.Add(current);
                current = intervals[i];
            }
        }
        merged.Add(current);
        return merged.ToArray();
    }
}

//Time complexity: O(n log n) because of sorting.

//Space complexity: O(n) for the output list.