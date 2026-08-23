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

//Why We Created a Class (RangeSum)
// 1 . Precompute Once: The constructor (RangeSum(int[] nums)) runs the $O(n)$ prefix
//sum loop only once when the object is instantiated.
// 2 . Query Many Times: The array's running total is saved inside the instance. Subsequent
// calls to Query(l, r) can be executed thousands of times at $O(1)$ speed without recalculating the prefix sums each time.


//  Why readonly on private readonly long[] pre;
//Immutability (Prevents Accidental Overwriting):
//Clear Design Intent:
//The problem states that the array is immutable (it does not change after creation).
//readonly documents in code that this data structure is write-once, read-many.
