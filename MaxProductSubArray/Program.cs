class Program
{
    public static void Main()
    {
        int[] arr = { -2, 3, -2, 4 };
        int result = MaxProduct(arr);
        Console.WriteLine(string.Join(" ", result));   
    }
    public static int MaxProduct(int[] arr)
    {
        int best = arr[0];
        int mincur = arr[0];
        int maxcur = arr[0];

        for (int i =1; i<arr.Length;i++)
        {
            int x = arr[i];
            if (x<0)
            {
                (maxcur, mincur) = (mincur, maxcur);

            }
            maxcur = Math.Max(x, maxcur * x);
            mincur = Math.Min(x, mincur * x);
            best = Math.Max(best, maxcur);
        }
        return best;
    }

}