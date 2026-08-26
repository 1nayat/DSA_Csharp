class Program
{

    static void Main()
    {
        int n = 6;
        int[][] updates = new int[][]
        {
            new int [] {1,3,6}
        };
        int[] result = ApplyRangeUpdates(n, updates);
        Console.WriteLine(string.Join(" ", result));
    }
    public static int[] ApplyRangeUpdates(int n , int[][] updates)
    {
        int[] diff = new int[n + 1];

        foreach (int[] u in updates)
        {
            int l = u[0];
            int r = u[1];
            int v = u[2];

            diff[l]  += v;
            diff[r + 1] -= v;
        }
        int[] result = new int[n];
        int running = 0;
        for (int i =0;i<n;i++)
        {
            running += diff[i];
            result[i] = running;
        }
        return result;
    }
}