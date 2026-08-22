public class RangeSum {

    private readonly long[] pre;
    public RangeSum(int[] arr)
    {
        pre = new long[arr.Length + 1];

        for (int i = 0; i < arr.Length; i++)
        {
            pre[i + 1] = pre[i] + arr[i];
        }
    }
    public long Query (int l ,int r)
    {
        return pre[r + 1] - pre[l];
    }
}

class Program
{
    static void Main()
    {
        {
            int[] arr = new int[] { 2, 3, 5, 7, 9 };
            RangeSum solver = new RangeSum(arr);
            Console.WriteLine(solver.Query(1, 3));
        }
    }
}

