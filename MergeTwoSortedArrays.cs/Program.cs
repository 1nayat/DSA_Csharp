class Program
{

    public static void Main()
    {
        int[] a = { 1, 3, 5, 7 };
        int[] b = { 2, 4, 6, 8 };
        int[] result = MergeSorted(a, b);
        Console.WriteLine(string.Join(" ", result));
    }
    public static int[] MergeSorted(int[] a, int[]b)
    {
        int[] result = new int[a.Length + b.Length];
        int i = 0;
        int j = 0;
        int k = 0;

        while(i<a.Length && j<b.Length)
        
            result[k++] = a[i] <= b[j] ? a[i++] : b[j++];

            while (i < a.Length)
                result[k++] = a[i++];

            while (j < b.Length)
                result[k++] = b[j++];

        return result;
    }
}


//Time: O(n + m)
//Space: O(n + m)