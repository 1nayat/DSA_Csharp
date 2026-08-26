class Program {

    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4 };
        int [] result = ProductExceptItself(arr);

        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(string.Join(" ", result));


    }

    public static int[] ProductExceptItself(int[] arr)
    {
        int n = arr.Length;
        int[] result = new int[n];

        result[0] = 1;
        for(int i =1;i<n; i++)
        {
            result[i] = result[i - 1] * arr[i - 1];

        }
        int right = 1;
        for (int i =n-1;i>=0;i--)
        {
            result[i] *= right;
            right *= arr[i];

        }
        return result;
    }
}