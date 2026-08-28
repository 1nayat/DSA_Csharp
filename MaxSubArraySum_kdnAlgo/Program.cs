class Program
{
    public static void Main()
    {
        int[] arr = { -2, -8, 1, 9, -2, 3 };
        int result = MaxSubArray(arr);
        Console.WriteLine(result);
    }
    public static int MaxSubArray(int[] arr)
    {
        int best = arr[0];
        int current = arr[0];

        for (int i =0; i<arr.Length;i++)
        {
            current = Math.Max(arr[i], current + arr[i]);
            best = Math.Max(best, current);
        }
        return best;
    }

}