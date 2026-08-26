class Program
{
    public static void Main()
    {
        int[] arr = new int[] { 2, 4, 6, 7, 4 };
        long[] suf = SuffixSum(arr);
        Console.WriteLine( string.Join(" ", suf));

        int targetIndex = 2;
        Console.WriteLine(suf[targetIndex]);
    }
    
    public static long[] SuffixSum(int[] arr )
    {
        long[] suf = new long[arr.Length + 1];
        for (int i =arr.Length-1;i>=0;i--)
        {
            suf[i] = suf[i + 1] + arr[i];
        }
        return suf;
    }
}
